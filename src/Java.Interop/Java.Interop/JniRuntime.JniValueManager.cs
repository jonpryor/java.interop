#nullable enable

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

using Java.Interop.Expressions;

namespace Java.Interop
{
	public class JniSurfacedPeerInfo {

		public  int                             JniIdentityHashCode     {get; private set;}
		public  WeakReference<IJavaPeerable>    SurfacedPeer            {get; private set;}

		public JniSurfacedPeerInfo (int jniIdentityHashCode, WeakReference<IJavaPeerable> surfacedPeer)
		{
			JniIdentityHashCode     = jniIdentityHashCode;
			SurfacedPeer            = surfacedPeer;
		}
	}

	partial class JniRuntime
	{
		partial class CreationOptions {
			public  JniValueManager?        ValueManager                {get; set;}
		}

		internal    JniValueManager?                    valueManager;
		public  JniValueManager             ValueManager                {
			get => valueManager ?? throw new NotSupportedException ();
		}

		partial void SetValueManager (CreationOptions options)
		{
			var manager     = options.ValueManager;
			if (manager == null)
				throw new ArgumentException (
						"No JniValueManager specified in JniRuntime.CreationOptions.ValueManager.",
						nameof (options));
			valueManager    = SetRuntime (manager);
		}

		/// <include file="../Documentation/Java.Interop/JniRuntime.JniValueManager.xml" path="/docs/member[@name='T:JniValueManager']/*" />
		public abstract partial class JniValueManager : ISetRuntime, IDisposable {

			readonly    ConditionalWeakTable<object, JavaProxyObject>   cachedValues    = new ConditionalWeakTable<object, JavaProxyObject> ();

			JniRuntime?             runtime;
			bool                    disposed;

			public      JniRuntime  Runtime {
				get => runtime ?? throw new NotSupportedException ();
			}

			public virtual void OnSetRuntime (JniRuntime runtime)
			{
				if (disposed)
					throw new ObjectDisposedException (GetType ().Name);

				this.runtime = runtime;
			}

			public void Dispose ()
			{
				Dispose (true);
				GC.SuppressFinalize (this);
			}

			protected virtual void Dispose (bool disposing)
			{
				disposed = true;
			}

			/// <include file="../Documentation/Java.Interop/JniRuntime.JniValueManager.xml" path="/docs/member[@name='M:WaitForGCBridgeProcessing']/*" />
			public abstract void WaitForGCBridgeProcessing ();

			/// <include file="../Documentation/Java.Interop/JniRuntime.JniValueManager.xml" path="/docs/member[@name='P:CanCollectPeers']/*" />
			public abstract bool CanCollectPeers { get; }

			/// <include file="../Documentation/Java.Interop/JniRuntime.JniValueManager.xml" path="/docs/member[@name='M:CollectPeers']/*" />
			public void CollectPeers ()
			{
				if (disposed) {
					throw new ObjectDisposedException (this.GetType ().ToString ());
				}
				if (!CanCollectPeers) {
					throw new NotSupportedException ("CollectPeers() is not supported.");
				}
				CollectPeersCore ();
			}

			/// <include file="../Documentation/Java.Interop/JniRuntime.JniValueManager.xml" path="/docs/member[@name='M:CollectPeersCore']/*" />
			protected abstract void CollectPeersCore ();

			/// <include file="../Documentation/Java.Interop/JniRuntime.JniValueManager.xml" path="/docs/member[@name='M:DisposePeers']/*" />
			public void DisposePeers ()
			{
				if (disposed) {
					throw new ObjectDisposedException (this.GetType ().ToString ());
				}
				DisposePeersCore ();
			}

			/// <include file="../Documentation/Java.Interop/JniRuntime.JniValueManager.xml" path="/docs/member[@name='M:DisposePeersCore']/*" />
			protected abstract void DisposePeersCore ();

			/// <include file="../Documentation/Java.Interop/JniRuntime.JniValueManager.xml" path="/docs/member[@name='M:ReleasePeers']/*" />
			public void ReleasePeers ()
			{
				if (disposed) {
					throw new ObjectDisposedException (this.GetType ().ToString ());
				}
				ReleasePeersCore ();
			}

			/// <include file="../Documentation/Java.Interop/JniRuntime.JniValueManager.xml" path="/docs/member[@name='M:ReleasePeersCore']/*" />
			protected abstract void ReleasePeersCore ();

			/// <include file="../Documentation/Java.Interop/JniRuntime.JniValueManager.xml" path="/docs/member[@name='M:AddPeer']/*" />
			public void AddPeer (IJavaPeerable value)
			{
				if (disposed) {
					throw new ObjectDisposedException (this.GetType ().ToString ());
				}
				if (value == null) {
					throw new ArgumentNullException (nameof (value));
				}

				var r = value.PeerReference;
				if (!r.IsValid) {
					throw new ObjectDisposedException (value.GetType ().FullName);
				}

				var o = PeekPeer (value.PeerReference);
				if (o != null)
					return;

				if (r.Type != JniObjectReferenceType.Global) {
					value.SetPeerReference (r.NewGlobalRef ());
					JniObjectReference.Dispose (ref r, JniObjectReferenceOptions.CopyAndDispose);
				}

				var scope = JniEnvironment.CurrentInfo.CurrentScope;

				if (scope != null) {
					scope.Add (value);
				} else {
					AddPeerCore (value);
				}
			}

			protected abstract void AddPeerCore (IJavaPeerable value);

			public void RemovePeer (IJavaPeerable value)
			{
				if (disposed) {
					throw new ObjectDisposedException (this.GetType ().ToString ());
				}
				if (value == null) {
					throw new ArgumentNullException (nameof (value));
				}

				var scope   = JniEnvironment.CurrentInfo.CurrentScope;
				if (scope != null && scope.Cleanup != JavaScopeCleanup.RegisterWithManager) {
					scope.Remove (value);
				} else {
					RemovePeerCore (value);
				}
			}

			protected abstract void RemovePeerCore (IJavaPeerable value);

			public void FinalizePeer (IJavaPeerable value)
			{
				if (disposed) {
					throw new ObjectDisposedException (this.GetType ().ToString ());
				}
				if (value == null) {
					throw new ArgumentNullException (nameof (value));
				}

				if (!ShouldFinalizePeer (value)) {
					GC.ReRegisterForFinalize (value);
					return;
				}
				var h = value.PeerReference;
				var o = Runtime.ObjectReferenceManager;
				if (o.LogGlobalReferenceMessages) {
					o.WriteGlobalReferenceLine ("Finalizing PeerReference={0} IdentityHashCode=0x{1} Instance=0x{2} Instance.Type={3}",
							h.ToString (),
							value.JniIdentityHashCode.ToString ("x"),
							RuntimeHelpers.GetHashCode (value).ToString ("x"),
							value.GetType ().ToString ());
				}
				RemovePeer (value);
				value.SetPeerReference (new JniObjectReference ());
				value.Finalized ();

				// MUST NOT use SafeHandle.ReferenceType: local refs are tied to a JniEnvironment
				// and the JniEnvironment's corresponding thread; it's a thread-local value.
				// Accessing SafeHandle.ReferenceType won't kill anything (so far...), but
				// instead it always returns JniReferenceType.Invalid.
				if (h.IsValid || h.Type != JniObjectReferenceType.Local) {
					JniObjectReference.Dispose (ref h);
				}
			}

			protected abstract bool ShouldFinalizePeer (IJavaPeerable value);
			// AndroidRuntime: ShouldFinalizePeer(IJavaPeerable value) => !value.PeerReference.IsValid;

			[Flags]
			public enum PeerLocations {
				ValueManager    = 1 << 0,
				CurrentThread   = 1 << 1,
				AllThreads      = 1 << 2,
				Everywhere      = ValueManager | CurrentThread | AllThreads,
			}
			public List<JniSurfacedPeerInfo> GetSurfacedPeers (PeerLocations locations = PeerLocations.Everywhere)
			{
				if (disposed) {
					throw new ObjectDisposedException (this.GetType ().ToString ());
				}

				var peers = new List<JniSurfacedPeerInfo> ();

				if (locations.HasFlag (PeerLocations.ValueManager))
					AddSurfacedPeers (peers);
				if (locations.HasFlag (PeerLocations.AllThreads)) {
					foreach (var info in JniEnvironment.Info.Values) {
						AddScopes (info.Scopes);
					}
				}
				if (locations.HasFlag (PeerLocations.CurrentThread) && !locations.HasFlag (PeerLocations.AllThreads)) {
					AddScopes (JniEnvironment.CurrentInfo.Scopes);
				}

				return peers;

				void AddScopes (List<PeerableCollection>? scopes) {
					if (scopes == null) {
						return;
					}
					foreach (var scope in scopes) {
						if (scope == null) {
							continue;
						}
						foreach (var peer in scope) {
							peers.Add (new JniSurfacedPeerInfo (peer.JniIdentityHashCode, CreateRef (peer)));
						}
					}
				}

				WeakReference<IJavaPeerable> CreateRef (IJavaPeerable value) {
					return new WeakReference<IJavaPeerable> (value, trackResurrection: false);
				}
			}

			protected abstract void AddSurfacedPeers (ICollection<JniSurfacedPeerInfo> collection);

			public void ActivatePeer (JniObjectReference reference, ConstructorInfo constructor, object? []? argumentValues)
			{
				if (disposed) {
					throw new ObjectDisposedException (this.GetType ().ToString ());
				}
				if (!reference.IsValid) {
					throw new ArgumentException ("reference is not valid", nameof (reference));
				}
				if (constructor == null) {
					throw new ArgumentNullException (nameof (constructor));
				}
				ActivatePeerCore (reference, constructor, argumentValues);
			}

			protected abstract void ActivatePeerCore (JniObjectReference reference, ConstructorInfo constructor, object?[]? argumentValues);

			public void ConstructPeer (IJavaPeerable peer, ref JniObjectReference reference, JniObjectReferenceOptions options)
			{
				if (disposed) {
					throw new ObjectDisposedException (this.GetType ().ToString ());
				}

				if (peer == null)
					throw new ArgumentNullException (nameof (peer));

				var newRef  = peer.PeerReference;
				if (newRef.IsValid) {
					// Activation! See ManagedPeer.RunConstructor
					peer.SetJniManagedPeerState (peer.JniManagedPeerState | JniManagedPeerStates.Activatable);
					JniObjectReference.Dispose (ref reference, options);
					newRef   = newRef.NewGlobalRef ();
				} else if (options == JniObjectReferenceOptions.None) {
					// `reference` is likely *InvalidJniObjectReference, and can't be touched
					return;
				} else if (!reference.IsValid) {
					throw new ArgumentException ("JNI Object Reference is invalid.", nameof (reference));
				} else {
					newRef  = reference;

					if ((options & JniObjectReferenceOptions.Copy) == JniObjectReferenceOptions.Copy) {
						newRef  = reference.NewGlobalRef ();
					}

					JniObjectReference.Dispose (ref reference, options);
				}

				peer.SetPeerReference (newRef);
				peer.SetJniIdentityHashCode (JniSystem.IdentityHashCode (newRef));

				var o = Runtime.ObjectReferenceManager;
				if (o.LogGlobalReferenceMessages) {
					o.WriteGlobalReferenceLine ("Created PeerReference={0} IdentityHashCode=0x{1} Instance=0x{2} Instance.Type={3}, Java.Type={4}",
							newRef.ToString (),
							peer.JniIdentityHashCode.ToString ("x"),
							RuntimeHelpers.GetHashCode (peer).ToString ("x"),
							peer.GetType ().FullName,
							JniEnvironment.Types.GetJniTypeNameFromInstance (newRef));
				}

				if ((options & DoNotRegisterTarget) != DoNotRegisterTarget) {
					AddPeer (peer);
				}
			}

			public int GetJniIdentityHashCode (JniObjectReference reference)
			{
				return JniSystem.IdentityHashCode (reference);
			}

			public void DisposePeer (IJavaPeerable value)
			{
				if (disposed)
					throw new ObjectDisposedException (GetType ().Name);

				if (value == null)
					throw new ArgumentNullException (nameof (value));

				if (!value.PeerReference.IsValid)
					return;

				value.Disposed ();
				RemovePeer (value);

				var h = value.PeerReference;
				if (!h.IsValid)
					return;

				DisposePeer (h, value);
			}

			void DisposePeer (JniObjectReference h, IJavaPeerable value)
			{
				var o = Runtime.ObjectReferenceManager;
				if (o.LogGlobalReferenceMessages) {
					o.WriteGlobalReferenceLine ("Disposing PeerReference={0} IdentityHashCode=0x{1} Instance=0x{2} Instance.Type={3} Java.Type={4}",
							h.ToString (),
							value.JniIdentityHashCode.ToString ("x"),
							RuntimeHelpers.GetHashCode (value).ToString ("x"),
							value.GetType ().ToString (),
							JniEnvironment.Types.GetJniTypeNameFromInstance (h));
				}
#if FEATURE_JNIOBJECTREFERENCE_SAFEHANDLES
				var lref = value.PeerReference.SafeHandle as JniLocalReference;
				if (lref != null && !JniEnvironment.IsHandleValid (lref)) {
					// `lref` was created on another thread, and CANNOT be disposed on this thread.
					// Just invalidate the reference and move on.
					lref.SetHandleAsInvalid ();
				}
#endif  // FEATURE_JNIOBJECTREFERENCE_SAFEHANDLES

				JniObjectReference.Dispose (ref h);
				value.SetPeerReference (new JniObjectReference ());
				GC.SuppressFinalize (value);
			}

			public void DisposePeerUnlessReferenced (IJavaPeerable value)
			{
				if (disposed)
					throw new ObjectDisposedException (GetType ().Name);

				if (value == null)
					throw new ArgumentNullException (nameof (value));

				var h = value.PeerReference;
				if (!h.IsValid)
					return;

				var o = PeekPeer (h);
				if (o != null && object.ReferenceEquals (o, value))
					return;

				DisposePeer (h, value);
			}

			public IJavaPeerable? PeekPeer (JniObjectReference reference)
			{
				if (disposed) {
					throw new ObjectDisposedException (this.GetType ().ToString ());
				}

				if (!reference.IsValid)
					return null;

				var scope   = JniEnvironment.CurrentInfo.CurrentScope;
				if (scope != null && scope.Cleanup != JavaScopeCleanup.RegisterWithManager) {
					var peer    = scope.GetPeerableForObjectReference (reference);
					if (peer != null) {
						return peer;
					}
				}
				return PeekPeerCore (reference);
			}

			protected abstract IJavaPeerable? PeekPeerCore (JniObjectReference reference);

			public object? PeekValue (JniObjectReference reference)
			{
				if (disposed)
					throw new ObjectDisposedException (GetType ().Name);

				if (!reference.IsValid)
					return null;

				var t   = PeekPeer (reference);
				if (t == null)
					return t;

				object? r;
				return TryUnboxPeerObject (t, out r)
					? r
					: t;
			}

			protected virtual bool TryUnboxPeerObject (IJavaPeerable value, [NotNullWhen (true)] out object? result)
			{
				result  = null;
				var p   = value as JavaProxyObject;
				if (p != null) {
					result  = p.Value;
					return true;
				}
				var x   = value as JavaProxyThrowable;
				if (x != null) {
					result  = x.Exception;
					return true;
				}
				return false;
			}

			object? PeekBoxedObject (JniObjectReference reference)
			{
				var t   = PeekPeer (reference);
				if (t == null)
					return null;
				object? r;
				return TryUnboxPeerObject (t, out r)
					? r
					: null;
			}

			static  readonly    KeyValuePair<Type, Type>[]      PeerTypeMappings = new []{
				new KeyValuePair<Type, Type>(typeof (object),           typeof (JavaObject)),
				new KeyValuePair<Type, Type>(typeof (IJavaPeerable),    typeof (JavaObject)),
				new KeyValuePair<Type, Type>(typeof (Exception),        typeof (JavaException)),
			};

			static Type GetPeerType (Type type)
			{
				foreach (var m in PeerTypeMappings) {
					if (m.Key == type)
						return m.Value;
				}
				return type;
			}

			public IJavaPeerable? CreatePeer (ref JniObjectReference reference, JniObjectReferenceOptions transfer, Type? targetType)
			{
				if (disposed)
					throw new ObjectDisposedException (GetType ().Name);

				targetType  = targetType ?? typeof (JavaObject);
				targetType  = GetPeerType (targetType);

				if (!typeof (IJavaPeerable).IsAssignableFrom (targetType))
					throw new ArgumentException ($"targetType `{targetType.AssemblyQualifiedName}` must implement IJavaPeerable!", nameof (targetType));

				if (transfer == JniObjectReferenceOptions.None || !reference.IsValid) {
					return null;
				}

				var peer    = CreatePeerCore (ref reference, transfer, targetType, out var ctorSigs);
				if (peer != null) {
					return peer;
				}
				// Could be that:
				//  1. we're within a JniPeerRegistrationScope stack, and
				//  2. current scope entry didn't register this type, and
				//  3. `reference` refers to an *already created* instance which is in a *parent* or "global" scope
				// PeekPeer() won't find it because of (1) + (2); look in *all* scopes.
				peer    = TryGetPeerFromScopes (reference);
				if (peer != null) {
					if (targetType.IsAssignableFrom (peer.GetType ())) {
						return peer;
					}
					throw new NotSupportedException ($"Found peer `{peer.GetType()}` for reference=`{reference}`, which is not convertible to type `{targetType}`.");
				}
				var error = new StringBuilder ();
				error.Append ("Could not find an appropriate constructor wrapper for Java type ")
					.Append (JniEnvironment.Types.GetJniTypeNameFromInstance (reference))
					.Append ("`.  Looked for constructor signatures: ");
				foreach (var ctorSig in (ctorSigs ?? new Type[][]{})) {
					error.Append (targetType.FullName).Append ("(");
					bool first = true;
					foreach (var t in ctorSig) {
						if (!first) {
							error.Append (", ");
						}
						first = false;
						error.Append (t);
					}
					error.Append (")");
				}
				throw new NotSupportedException (error.ToString ());
			}

			protected virtual IJavaPeerable? CreatePeerCore (ref JniObjectReference reference, JniObjectReferenceOptions transfer, Type targetType, out IEnumerable<Type>[]? attemptedConstructorSignatures)
			{
				attemptedConstructorSignatures  = null;

				var ctor = GetPeerConstructor (reference, targetType);
				if (ctor == null) {
					attemptedConstructorSignatures = new[]{
						new[]{ByRefJniObjectReference, typeof (JniObjectReferenceOptions)},
					};
					return null;
				}

				var acts = new object[] {
					reference,
					transfer,
				};
				try {
					var peer    = (IJavaPeerable) ctor.Invoke (acts);
					peer.SetJniManagedPeerState (peer.JniManagedPeerState | JniManagedPeerStates.Replaceable);
					return peer;
				} finally {
					reference   = (JniObjectReference) acts [0];
				}
			}

			IJavaPeerable? TryGetPeerFromScopes (JniObjectReference reference)
			{
				var scopes  = JniEnvironment.CurrentInfo.Scopes;
				if (scopes == null) {
					return null;
				}

				int count   = (scopes.Count - 1);
				for (int i = count; i >= 0; --i) {
					var scope   = scopes [i];
					if (scope.Cleanup == JavaScopeCleanup.RegisterWithManager) {
						continue;
					}
					var peer    = scope.GetPeerableForObjectReference (reference);
					if (peer != null) {
						return peer;
					}
				}
				return PeekPeerCore (reference);
			}

			static  readonly    Type    ByRefJniObjectReference = typeof (JniObjectReference).MakeByRefType ();

			ConstructorInfo? GetPeerConstructor (JniObjectReference instance, Type fallbackType)
			{
				var klass       = JniEnvironment.Types.GetObjectClass (instance);
				var jniTypeName = JniEnvironment.Types.GetJniTypeNameFromClass (klass);

				Type? type = null;
				while (jniTypeName != null) {
					JniTypeSignature sig;
					if (!JniTypeSignature.TryParse (jniTypeName, out sig))
						return null;

					type    = Runtime.TypeManager.GetType (sig);

					if (type != null) {
						var ctor = GetActivationConstructor (type);

						if (ctor != null) {
							JniObjectReference.Dispose (ref klass);
							return ctor;
						}
					}

					var super   = JniEnvironment.Types.GetSuperclass (klass);
					jniTypeName = super.IsValid
						? JniEnvironment.Types.GetJniTypeNameFromClass (super)
						: null;

					JniObjectReference.Dispose (ref klass, JniObjectReferenceOptions.CopyAndDispose);
					klass      = super;
				}
				JniObjectReference.Dispose (ref klass, JniObjectReferenceOptions.CopyAndDispose);

				return GetActivationConstructor (fallbackType);
			}

			static ConstructorInfo GetActivationConstructor (Type type)
			{
				return
					(from c in type.GetConstructors (BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
					 let p = c.GetParameters ()
					 where p.Length == 2 && p [0].ParameterType == ByRefJniObjectReference && p [1].ParameterType == typeof (JniObjectReferenceOptions)
					 select c)
				.FirstOrDefault ();
			}


			public object? CreateValue (ref JniObjectReference reference, JniObjectReferenceOptions options, Type? targetType = null)
			{
				if (disposed)
					throw new ObjectDisposedException (GetType ().Name);

				if (!reference.IsValid)
					return null;

				if (targetType != null && typeof (IJavaPeerable).IsAssignableFrom (targetType)) {
					return JavaPeerableValueMarshaler.Instance.CreateGenericValue (ref reference, options, targetType);
				}

				var boxed   = PeekBoxedObject (reference);
				if (boxed != null) {
					JniObjectReference.Dispose (ref reference, options);
					if (targetType != null)
						return Convert.ChangeType (boxed, targetType);
					return boxed;
				}

				targetType = targetType ?? GetRuntimeType (reference);
				if (targetType == null) {
					// Let's hope this is an IJavaPeerable!
					return JavaPeerableValueMarshaler.Instance.CreateGenericValue (ref reference, options, targetType);
				}
				var marshaler   = GetValueMarshaler (targetType);
				return marshaler.CreateValue (ref reference, options, targetType);
			}

			[return: MaybeNull]
			public T CreateValue<T> (ref JniObjectReference reference, JniObjectReferenceOptions options, Type? targetType = null)
			{
				if (disposed)
					throw new ObjectDisposedException (GetType ().Name);

				if (!reference.IsValid) {
#pragma warning disable 8653
					return default (T);
#pragma warning restore 8653
				}

				if (targetType != null && !typeof (T).IsAssignableFrom (targetType))
					throw new ArgumentException (
							string.Format ("Requested runtime '{0}' value of '{1}' is not compatible with requested compile-time type T of '{2}'.",
								nameof (targetType),
								targetType,
								typeof (T)),
							nameof (targetType));

				var boxed   = PeekBoxedObject (reference);
				if (boxed != null) {
					JniObjectReference.Dispose (ref reference, options);
					return (T) Convert.ChangeType (boxed, targetType ?? typeof (T));
				}

				targetType  = targetType ?? typeof (T);

				if (typeof (IJavaPeerable).IsAssignableFrom (targetType)) {
#pragma warning disable CS8601 // Possible null reference assignment.
					return (T) JavaPeerableValueMarshaler.Instance.CreateGenericValue (ref reference, options, targetType);
#pragma warning restore CS8601 // Possible null reference assignment.
				}

				var marshaler   = GetValueMarshaler<T> ();
				return marshaler.CreateGenericValue (ref reference, options, targetType);
			}

			internal Type? GetRuntimeType (JniObjectReference reference)
			{
				if (!reference.IsValid)
					return null;
				JniTypeSignature signature;
				if (!JniTypeSignature.TryParse (JniEnvironment.Types.GetJniTypeNameFromInstance (reference)!, out signature))
					return null;
				return Runtime.TypeManager.GetType (signature);
			}

			public object? GetValue (ref JniObjectReference reference, JniObjectReferenceOptions options, Type? targetType = null)
			{
				if (disposed)
					throw new ObjectDisposedException (GetType ().Name);

				if (!reference.IsValid)
					return null;

				var existing = PeekValue (reference);
				if (existing != null && (targetType == null || targetType.IsAssignableFrom (existing.GetType ()))) {
					JniObjectReference.Dispose (ref reference, options);
					return existing;
				}

				if (targetType != null && typeof (IJavaPeerable).IsAssignableFrom (targetType)) {
					return JavaPeerableValueMarshaler.Instance.CreateGenericValue (ref reference, options, targetType);
				}

				targetType = targetType ?? GetRuntimeType (reference);
				if (targetType == null) {
					// Let's hope this is an IJavaPeerable!
					return JavaPeerableValueMarshaler.Instance.CreateGenericValue (ref reference, options, targetType);
				}
				var marshaler   = GetValueMarshaler (targetType);
				return marshaler.CreateValue (ref reference, options, targetType);
			}

			[return: MaybeNull]
			public T GetValue<T> (IntPtr handle)
			{
				var r   = new JniObjectReference (handle);
				return GetValue<T> (ref r, JniObjectReferenceOptions.Copy);
			}

			[return: MaybeNull]
			public T GetValue<T> (ref JniObjectReference reference, JniObjectReferenceOptions options, Type? targetType = null)
			{
				if (!reference.IsValid) {
#pragma warning disable 8653
					return default (T);
#pragma warning restore 8653
				}

				if (targetType != null && !typeof (T).IsAssignableFrom (targetType))
					throw new ArgumentException (
							string.Format ("Requested runtime '{0}' value of '{1}' is not compatible with requested compile-time type T of '{2}'.",
								nameof (targetType),
								targetType,
								typeof (T)),
							nameof (targetType));

				targetType  = targetType ?? typeof (T);

				var existing = PeekValue (reference);
				if (existing != null && (targetType == null || targetType.IsAssignableFrom (existing.GetType ()))) {
					JniObjectReference.Dispose (ref reference, options);
					return (T) existing;
				}

				if (typeof (IJavaPeerable).IsAssignableFrom (targetType)) {
#pragma warning disable CS8601 // Possible null reference assignment.
					return (T) JavaPeerableValueMarshaler.Instance.CreateGenericValue (ref reference, options, targetType);
#pragma warning restore CS8601 // Possible null reference assignment.
				}

				var marshaler   = GetValueMarshaler<T> ();
				return marshaler.CreateGenericValue (ref reference, options, targetType);
			}

			Dictionary<Type, JniValueMarshaler> Marshalers = new Dictionary<Type, JniValueMarshaler> ();

			public JniValueMarshaler<T> GetValueMarshaler<T>()
			{
				if (disposed)
					throw new ObjectDisposedException (GetType ().Name);

				var m   = GetValueMarshaler (typeof (T));
				var r   = m as JniValueMarshaler<T>;
				if (r != null)
					return r;
				lock (Marshalers) {
					if (!Marshalers.TryGetValue (typeof (T), out var d))
						Marshalers.Add (typeof (T), d = new DelegatingValueMarshaler<T> (m));
					return (JniValueMarshaler<T>) d;
				}
			}

			public JniValueMarshaler GetValueMarshaler (Type type)
			{
				if (disposed)
					throw new ObjectDisposedException (GetType ().Name);

				if (type == null)
					throw new ArgumentNullException (nameof (type));
				if (type.ContainsGenericParameters)
					throw new ArgumentException ("Generic type definitions are not supported.", nameof (type));

				var marshalerAttr   = type.GetCustomAttribute<JniValueMarshalerAttribute> ();
				if (marshalerAttr != null)
					return (JniValueMarshaler) Activator.CreateInstance (marshalerAttr.MarshalerType)!;

				if (typeof (IJavaPeerable) == type)
					return JavaPeerableValueMarshaler.Instance;

				if (typeof (void) == type)
					return VoidValueMarshaler.Instance;

				foreach (var marshaler in JniBuiltinMarshalers.Value) {
					if (marshaler.Key == type)
						return marshaler.Value;
				}

				var listIface   = typeof (IList<>);
				var listType    =
					(from iface in type.GetInterfaces ().Concat (new[]{type})
					 where (listIface).IsAssignableFrom (iface.IsGenericType ? iface.GetGenericTypeDefinition () : iface)
					 select iface)
					.FirstOrDefault ();
				if (listType != null) {
					var elementType = listType.GenericTypeArguments [0];
					if (elementType.IsValueType) {
						foreach (var marshaler in JniPrimitiveArrayMarshalers.Value) {
							if (type.IsAssignableFrom (marshaler.Key))
								return marshaler.Value;
						}
					}

					return GetObjectArrayMarshaler (elementType);
				}

				if (typeof (IJavaPeerable).IsAssignableFrom (type)) {
					return JavaPeerableValueMarshaler.Instance;
				}

				JniValueMarshalerAttribute? ifaceAttribute = null;
				foreach (var iface in type.GetInterfaces ()) {
					marshalerAttr = iface.GetCustomAttribute<JniValueMarshalerAttribute> ();
					if (marshalerAttr != null) {
						if (ifaceAttribute != null)
							throw new NotSupportedException ($"There is more than one interface with custom marshaler for type {type}.");

						ifaceAttribute = marshalerAttr;
					}
				}
				if (ifaceAttribute != null)
					return (JniValueMarshaler) Activator.CreateInstance (ifaceAttribute.MarshalerType)!;

				return GetValueMarshalerCore (type);
			}

			static JniValueMarshaler GetObjectArrayMarshaler (Type elementType)
			{
				Func<JniValueMarshaler> indirect = GetObjectArrayMarshalerHelper<object>;
				var reifiedMethodInfo = indirect.Method.GetGenericMethodDefinition ()
					.MakeGenericMethod (elementType);
				Func<JniValueMarshaler> direct = (Func<JniValueMarshaler>) Delegate.CreateDelegate (typeof (Func<JniValueMarshaler>), reifiedMethodInfo);
				return direct ();
			}

			static JniValueMarshaler GetObjectArrayMarshalerHelper<T> ()
			{
				return JavaObjectArray<T>.Instance;
			}

			protected virtual JniValueMarshaler GetValueMarshalerCore (Type type)
			{
				return ProxyValueMarshaler.Instance;
			}

			[return: NotNullIfNotNull ("object")]
			internal JavaProxyObject?  GetProxy (object value)
			{
				if (value == null)
					return null;

				lock (cachedValues) {
					if (cachedValues.TryGetValue (value, out var proxy))
						return proxy;
					proxy = new JavaProxyObject (value);
					cachedValues.Add (value, proxy);
					return proxy;
				}
			}
		}
	}

	sealed class VoidValueMarshaler : JniValueMarshaler {

		internal    static  VoidValueMarshaler              Instance    = new VoidValueMarshaler ();

		public override Type MarshalType {
			get {return typeof (void);}
		}

		public override object? CreateValue (ref JniObjectReference reference, JniObjectReferenceOptions options, Type? targetType)
		{
			throw new NotSupportedException ();
		}

		public override JniValueMarshalerState CreateObjectReferenceArgumentState (object? value, ParameterAttributes synchronize)
		{
			throw new NotSupportedException ();
		}

		public override void DestroyArgumentState (object? value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			throw new NotSupportedException ();
		}
	}

	sealed class JavaPeerableValueMarshaler : JniValueMarshaler<IJavaPeerable?> {

		internal    static  JavaPeerableValueMarshaler      Instance    = new JavaPeerableValueMarshaler ();

		[return: MaybeNull]
		public override IJavaPeerable? CreateGenericValue (ref JniObjectReference reference, JniObjectReferenceOptions options, Type? targetType)
		{
			var jvm         = JniEnvironment.Runtime;
			var marshaler   = jvm.ValueManager.GetValueMarshaler (targetType ?? typeof(IJavaPeerable));
			if (marshaler != Instance)
				return (IJavaPeerable) marshaler.CreateValue (ref reference, options, targetType)!;
			return jvm.ValueManager.CreatePeer (ref reference, options, targetType);
		}

		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState ([MaybeNull]IJavaPeerable? value, ParameterAttributes synchronize)
		{
			if (value == null || !value.PeerReference.IsValid)
				return new JniValueMarshalerState ();
			var r   = value.PeerReference.NewLocalRef ();
			return new JniValueMarshalerState (r);
		}

		public override void DestroyGenericArgumentState ([MaybeNull]IJavaPeerable? value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			var r   = state.ReferenceValue;
			JniObjectReference.Dispose (ref r);
			state   = new JniValueMarshalerState ();
		}

		public override Expression CreateParameterFromManagedExpression (JniValueMarshalerContext context, ParameterExpression sourceValue, ParameterAttributes synchronize)
		{
			var r = CreateIntermediaryExpressionFromManagedExpression (context, sourceValue);
			var h = Expression.Variable (typeof (IntPtr), sourceValue.Name + "_handle");
			context.LocalVariables.Add (h);
			context.CreationStatements.Add (Expression.Assign (h, Expression.Property (r, "Handle")));

			return h;
		}

		Expression CreateIntermediaryExpressionFromManagedExpression (JniValueMarshalerContext context, ParameterExpression sourceValue)
		{
			var r   = Expression.Variable (typeof (JniObjectReference), sourceValue.Name + "_ref");
			context.LocalVariables.Add (r);
			context.CreationStatements.Add (
					Expression.IfThenElse (
						test:       Expression.Equal (Expression.Constant (null), sourceValue),
						ifTrue:     Expression.Assign (r, Expression.New (typeof (JniObjectReference))),
						ifFalse:    Expression.Assign (r, Expression.Property (Expression.Convert (sourceValue, typeof (IJavaPeerable)), "PeerReference"))));

			return r;
		}

		public override Expression CreateReturnValueFromManagedExpression (JniValueMarshalerContext context, ParameterExpression sourceValue)
		{
			return ReturnObjectReferenceToJni (context, sourceValue.Name, CreateIntermediaryExpressionFromManagedExpression (context, sourceValue));
		}

		public override Expression CreateParameterToManagedExpression (JniValueMarshalerContext context, ParameterExpression sourceValue, ParameterAttributes synchronize, Type? targetType)
		{
			var r   = Expression.Variable (targetType, sourceValue.Name + "_val");
			context.LocalVariables.Add (r);
			context.CreationStatements.Add (
					Expression.Assign (r,
						Expression.Call (
							context.ValueManager ?? Expression.Property (context.Runtime, "ValueManager"),
							"GetValue",
							new[]{targetType},
							sourceValue)));
			return r;
		}
	}

	sealed class DelegatingValueMarshaler<T> : JniValueMarshaler<T> {

		JniValueMarshaler   ValueMarshaler;

		public DelegatingValueMarshaler (JniValueMarshaler valueMarshaler)
		{
			ValueMarshaler  = valueMarshaler;
		}

		[return: MaybeNull]
		public override T CreateGenericValue (ref JniObjectReference reference, JniObjectReferenceOptions options, Type? targetType)
		{
			return (T) ValueMarshaler.CreateValue (ref reference, options, targetType ?? typeof (T))!;
		}

		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState ([MaybeNull]T value, ParameterAttributes synchronize)
		{
			return ValueMarshaler.CreateObjectReferenceArgumentState (value, synchronize);
		}

		public override void DestroyGenericArgumentState ([AllowNull]T value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			ValueMarshaler.DestroyArgumentState (value, ref state, synchronize);
		}

		public override Expression CreateParameterFromManagedExpression (JniValueMarshalerContext context, ParameterExpression sourceValue, ParameterAttributes synchronize)
		{
			return ValueMarshaler.CreateParameterFromManagedExpression (context, sourceValue, synchronize);
		}

		public override Expression CreateParameterToManagedExpression (JniValueMarshalerContext context, ParameterExpression sourceValue, ParameterAttributes synchronize, Type? targetType)
		{
			return ValueMarshaler.CreateParameterToManagedExpression (context, sourceValue, synchronize, targetType);
		}

		public override Expression CreateReturnValueFromManagedExpression (JniValueMarshalerContext context, ParameterExpression sourceValue)
		{
			return ValueMarshaler.CreateReturnValueFromManagedExpression (context, sourceValue);
		}
	}

	sealed class ProxyValueMarshaler : JniValueMarshaler<object?> {

		internal    static  ProxyValueMarshaler     Instance    = new ProxyValueMarshaler ();

		[return: MaybeNull]
		public override object? CreateGenericValue (ref JniObjectReference reference, JniObjectReferenceOptions options, Type? targetType)
		{
			var jvm     = JniEnvironment.Runtime;

			if (targetType == null || targetType == typeof (object)) {
				targetType      = jvm.ValueManager.GetRuntimeType (reference);
			}
			if (targetType != null) {
				var vm  = jvm.ValueManager.GetValueMarshaler (targetType);
				if (vm != Instance) {
					return vm.CreateValue (ref reference, options, targetType)!;
				}
			}

			var target  = jvm.ValueManager.PeekValue (reference);
			if (target != null) {
				JniObjectReference.Dispose (ref reference, options);
				return target;
			}
			// Punt! Hope it's a java.lang.Object
			return jvm.ValueManager.CreatePeer (ref reference, options, targetType);
		}

		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState ([MaybeNull]object? value, ParameterAttributes synchronize)
		{
			if (value == null)
				return new JniValueMarshalerState ();

			var jvm     = JniEnvironment.Runtime;

			var vm      = jvm.ValueManager.GetValueMarshaler (value.GetType ());
			if (vm != Instance) {
				var s   = vm.CreateObjectReferenceArgumentState (value, synchronize);
				return new JniValueMarshalerState (s, vm);
			}

			var p   = jvm.ValueManager.GetProxy (value);
			return new JniValueMarshalerState (p!.PeerReference.NewLocalRef ());
		}

		public override void DestroyGenericArgumentState (object? value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			var vm  = state.Extra as JniValueMarshaler;
			if (vm != null) {
				vm.DestroyArgumentState (value, ref state, synchronize);
				return;
			}
			var r   = state.ReferenceValue;
			JniObjectReference.Dispose (ref r);
			state = new JniValueMarshalerState ();
		}
	}
}

