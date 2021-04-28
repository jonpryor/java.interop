#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Java.Interop;

using NUnit.Framework;

namespace Java.InteropTests {

	// Modifies JniRuntime.valueManager instance field; can't be done in parallel
	[NonParallelizable]
	public abstract class JniRuntimeJniValueManagerContract : JavaVMFixture {

		protected abstract Type ValueManagerType {
			get;
		}

		protected virtual JniRuntime.JniValueManager CreateValueManager ()
		{
			var manager = Activator.CreateInstance (ValueManagerType) as JniRuntime.JniValueManager;
			return manager ?? throw new InvalidOperationException ($"Could not create instance of `{ValueManagerType}`!");
		}

#pragma warning disable CS8618
		JniRuntime.JniValueManager  systemManager;
		JniRuntime.JniValueManager  valueManager;
#pragma warning restore CS8618

		[SetUp]
		public void CreateVM ()
		{
			systemManager   = JniRuntime.CurrentRuntime.valueManager!;
			valueManager    = CreateValueManager ();
			valueManager.OnSetRuntime (JniRuntime.CurrentRuntime);
			JniRuntime.CurrentRuntime.valueManager  = valueManager;
		}

		[TearDown]
		public void DestroyVM ()
		{
			JniRuntime.CurrentRuntime.valueManager  = systemManager;
			systemManager   = null!;
			valueManager?.Dispose ();
			valueManager    = null!;
		}

		[Test]
		public void AddPeer ()
		{
			Assert.Throws<ArgumentNullException>(() => valueManager.AddPeer (null!));
		}

		[Test]
		public void AddPeer_NoDuplicates ()
		{
			int startPeerCount  = valueManager.GetSurfacedPeers ().Count;
			using (var v = new MyDisposableObject ()) {
				// MyDisposableObject ctor implicitly calls AddPeer();
				Assert.AreEqual (startPeerCount + 1, valueManager.GetSurfacedPeers ().Count);
				valueManager.AddPeer (v);
				Assert.AreEqual (startPeerCount + 1, valueManager.GetSurfacedPeers ().Count);
			}
		}

		[Test]
		public void ConstructPeer_ImplicitViaBindingConstructor_PeerIsInSurfacedPeers ()
		{
			int startPeerCount  = valueManager.GetSurfacedPeers ().Count;

			var g               = new GetThis ();
			var surfaced        = valueManager.GetSurfacedPeers ();
			Assert.AreEqual (startPeerCount + 1, surfaced.Count);

			var found           = false;
			foreach (var pr in surfaced) {
				if (!pr.SurfacedPeer.TryGetTarget (out var p))
					continue;
				if (object.ReferenceEquals (g, p)) {
					found = true;
				}
			}
			Assert.IsTrue (found);

			var localRef        = g.PeerReference.NewLocalRef ();
			g.Dispose ();
			Assert.AreEqual (startPeerCount, valueManager.GetSurfacedPeers ().Count);
			Assert.IsNull (valueManager.PeekPeer (localRef));
			JniObjectReference.Dispose (ref localRef);
		}

		[Test]
		public void ConstructPeer_ImplicitViaBindingMethod_PeerIsInSurfacedPeers ()
		{
			int startPeerCount  = valueManager.GetSurfacedPeers ().Count;

			var g               = new GetThis ();
			var surfaced        = valueManager.GetSurfacedPeers ();
			Assert.AreEqual (startPeerCount + 1, surfaced.Count);

			var found           = false;
			foreach (var pr in surfaced) {
				if (!pr.SurfacedPeer.TryGetTarget (out var p))
					continue;
				if (object.ReferenceEquals (g, p)) {
					found = true;
				}
			}
			Assert.IsTrue (found);

			var localRef        = g.PeerReference.NewLocalRef ();
			g.Dispose ();
			Assert.AreEqual (startPeerCount, valueManager.GetSurfacedPeers ().Count);
			Assert.IsNull (valueManager.PeekPeer (localRef));
			JniObjectReference.Dispose (ref localRef);
		}


		[Test]
		public void CollectPeers ()
		{
			// TODO
		}

		[Test]
		public void CreateValue ()
		{
			using (var o = new JavaObject ()) {
				var r = o.PeerReference;
				var x = (IJavaPeerable) valueManager.CreateValue (ref r, JniObjectReferenceOptions.Copy)!;
				Assert.AreNotSame (o, x);
				x.Dispose ();

				x = valueManager.CreateValue<IJavaPeerable> (ref r, JniObjectReferenceOptions.Copy);
				Assert.AreNotSame (o, x);
				x!.Dispose ();
			}
		}

		[Test]
		public void GetValue_ReturnsAlias ()
		{
			var local   = new JavaObject ();
			local.UnregisterFromRuntime ();
			Assert.IsNull (valueManager.PeekValue (local.PeerReference));
			// GetObject must always return a value (unless handle is null, etc.).
			// However, since we called local.UnregisterFromRuntime(),
			// JniRuntime.PeekObject() is null (asserted above), but GetObject() must
			// **still** return _something_.
			// In this case, it returns an _alias_.
			// TODO: "most derived type" alias generation. (Not relevant here, but...)
			var p       = local.PeerReference;
			var alias   = JniRuntime.CurrentRuntime.ValueManager.GetValue<IJavaPeerable> (ref p, JniObjectReferenceOptions.Copy);
			Assert.AreNotSame (local, alias);
			alias!.Dispose ();
			local.Dispose ();
		}

		[Test]
		public void GetValue_ReturnsNullWithNullHandle ()
		{
			var r = new JniObjectReference ();
			var o = valueManager.GetValue (ref r, JniObjectReferenceOptions.Copy);
			Assert.IsNull (o);
		}

		[Test]
		public void GetValue_ReturnsNullWithInvalidSafeHandle ()
		{
			var invalid = new JniObjectReference ();
			Assert.IsNull (valueManager.GetValue (ref invalid, JniObjectReferenceOptions.CopyAndDispose));
		}

		[Test]
		public unsafe void GetValue_FindBestMatchType ()
		{
#if !NO_MARSHAL_MEMBER_BUILDER_SUPPORT
			using (var t = new JniType (TestType.JniTypeName)) {
				var c = t.GetConstructor ("()V");
				var o = t.NewObject (c, null);
				using (var w = valueManager.GetValue<IJavaPeerable> (ref o, JniObjectReferenceOptions.CopyAndDispose)) {
					Assert.AreEqual (typeof (TestType), w!.GetType ());
					Assert.IsTrue (((TestType) w).ExecutedActivationConstructor);
				}
			}
#endif  // !NO_MARSHAL_MEMBER_BUILDER_SUPPORT
		}

		[Test]
		public void PeekPeer ()
		{
			Assert.IsNull (valueManager.PeekPeer (new JniObjectReference ()));

			using (var v = new MyDisposableObject ()) {
				Assert.IsNotNull (valueManager.PeekPeer (v.PeerReference));
				Assert.AreSame (v, valueManager.PeekPeer (v.PeerReference));
			}
		}

		[Test]
		public void PeekValue ()
		{
			JniObjectReference lref;
			using (var o = new JavaObject ()) {
				lref = o.PeerReference.NewLocalRef ();
				Assert.AreSame (o, valueManager.PeekValue (lref));
			}
			// At this point, the Java-side object is kept alive by `lref`,
			// but the wrapper instance has been disposed, and thus should
			// be unregistered, and thus unfindable.
			Assert.IsNull (valueManager.PeekValue (lref));
			JniObjectReference.Dispose (ref lref);
		}

		[Test]
		public void PeekValue_BoxedObjects ()
		{
			var marshaler   = valueManager.GetValueMarshaler<object> ();
			var ad          = AppDomain.CurrentDomain;

			var proxy       = marshaler.CreateGenericArgumentState (ad);
			Assert.AreSame (ad, valueManager.PeekValue (proxy.ReferenceValue));
			marshaler.DestroyGenericArgumentState (ad, ref proxy);

			var ex  = new InvalidOperationException ("boo!");
			proxy   = marshaler.CreateGenericArgumentState (ex);
			Assert.AreSame (ex, valueManager.PeekValue (proxy.ReferenceValue));
			marshaler.DestroyGenericArgumentState (ex, ref proxy);
		}

		void AllNestedRegistrationScopeTests ()
		{
			AddPeer ();
			AddPeer_NoDuplicates ();
			ConstructPeer_ImplicitViaBindingConstructor_PeerIsInSurfacedPeers ();
			CreateValue ();
			GetValue_FindBestMatchType ();
			GetValue_ReturnsAlias ();
			GetValue_ReturnsNullWithInvalidSafeHandle ();
			GetValue_ReturnsNullWithNullHandle ();
			PeekPeer ();
			PeekValue ();
			PeekValue_BoxedObjects ();
		}

		[Test]
		public void WithRegistrationScope_Dispose ()
		{
			Assert.AreEqual (0, valueManager.GetSurfacedPeers ().Count);
			MyDisposableObject v;
			using (new JavaScope (JavaScopeCleanup.Dispose)) {
				v = new MyDisposableObject ();
				Assert.IsFalse (v._isDisposed);
				Assert.AreEqual (1, valueManager.GetSurfacedPeers ().Count);
			}
			Assert.AreEqual (0, valueManager.GetSurfacedPeers ().Count);
			Assert.IsTrue (v._isDisposed);
		}

		[Test]
		public void WithRegistrationScope_Dispose_All ()
		{
			using (new JavaScope (JavaScopeCleanup.Dispose)) {
				AllNestedRegistrationScopeTests ();
			}
		}

		[Test]
		public void WithRegistrationScope_Dispose_Nested ()
		{
			Assert.AreEqual (0, valueManager.GetSurfacedPeers ().Count);
			var u1      = (MyDisposableObject?) null;
			using (var c1 = new JavaScope (JavaScopeCleanup.Dispose)) {
				var b1      = JavaSingleton.Singleton;
				var b2      = (JavaSingleton?) null;
				var array   = new JavaObjectArray<MyDisposableObject> (1);
				u1          = new MyDisposableObject ();
				array [0]   = u1;
				Assert.AreEqual (3, valueManager.GetSurfacedPeers ().Count);
				using (var c2 = new JavaScope (JavaScopeCleanup.Dispose)) {
					// Creating a new scope means that previously created "bound" instances won't be
					// returned by JniValueManager.GetValue<T>().
					b2      = JavaSingleton.Singleton;
					Assert.AreNotSame (b1, b2);
					Assert.AreEqual (4, valueManager.GetSurfacedPeers ().Count);

					// Creating a new scope means that previously created "unbound" instances MUST be
					// returned by JniValueManager.GetValue<T>(), as they don't have an activation ctor
					var u2  = array [0];
					Assert.AreSame (u1, u2);
					Assert.AreEqual (4, valueManager.GetSurfacedPeers ().Count, DumpPeers (valueManager.GetSurfacedPeers ()));
				}
				Assert.IsFalse (b1.disposed);
				Assert.IsTrue (b2.disposed);
				Assert.AreEqual (3, valueManager.GetSurfacedPeers ().Count, DumpPeers (valueManager.GetSurfacedPeers ()));
			}
			Assert.AreEqual (0, valueManager.GetSurfacedPeers ().Count);
			Assert.IsTrue (u1._isDisposed);
		}

		static string DumpPeers (IEnumerable<JniSurfacedPeerInfo> peers)
		{
			return DumpPeers (peers.Select (p => {
					if (p.SurfacedPeer.TryGetTarget (out var q))
						return q;
					return null;
			}));
		}

		static string DumpPeers (IEnumerable<IJavaPeerable?>? peers)
		{
			if (peers == null)
				return "";
			return string.Join (", ", peers.Where (p => p != null)
				.Select (p => $"{p!.GetType ().FullName}(\"{p!.ToString ()}\", PeerReference={p.PeerReference})"));
		}

		[Test]
		public void WithRegistrationScope_Release ()
		{
			Assert.AreEqual (0, valueManager.GetSurfacedPeers ().Count);
			MyDisposableObject v;
			using (new JavaScope (JavaScopeCleanup.Release)) {
				v = new MyDisposableObject ();
				Assert.IsFalse (v._isDisposed);
				Assert.AreEqual (1, valueManager.GetSurfacedPeers ().Count);
			}
			Assert.AreEqual (0, valueManager.GetSurfacedPeers ().Count);
			Assert.IsFalse (v._isDisposed);
		}

		[Test]
		public void WithRegistrationScope_Release_All ()
		{
			using (new JavaScope (JavaScopeCleanup.Release)) {
				AllNestedRegistrationScopeTests ();
			}
		}

		[Test]
		public void WithRegistrationScope_RegisterWithRuntime ()
		{
			Assert.AreEqual (0, valueManager.GetSurfacedPeers ().Count);
			MyDisposableObject v;
			using (new JavaScope (JavaScopeCleanup.Release)) {
				v = new MyDisposableObject ();
				Assert.IsFalse (v._isDisposed);
				Assert.AreEqual (1, valueManager.GetSurfacedPeers ().Count);
			}
			Assert.AreEqual (0, valueManager.GetSurfacedPeers ().Count);
			Assert.IsFalse (v._isDisposed);
		}

		[Test]
		public void WithRegistrationScope_RegisterWithRuntime_All ()
		{
			using (new JavaScope (JavaScopeCleanup.Release)) {
				AllNestedRegistrationScopeTests ();
			}
		}

		// also test:
		// Singleton scenario
		// Types w/o "activation" constructors -- need to support checking parent scopes
		// nesting of scopes
		// Adding an instance already added in a previous scope?
	}

	public abstract class JniRuntimeJniValueManagerContract<T> : JniRuntimeJniValueManagerContract {

		protected override Type ValueManagerType => typeof (T);
	}

#if !NETCOREAPP
	[TestFixture]
	public class JniRuntimeJniValueManagerContract_Mono : JniRuntimeJniValueManagerContract {
		static Type MonoRuntimeValueManagerType = Type.GetType ("Java.Interop.MonoRuntimeValueManager, Java.Runtime.Environment", throwOnError:true)!;

		protected override Type ValueManagerType => MonoRuntimeValueManagerType;
	}
#endif	// !NETCOREAPP

	[TestFixture]
	public class JniRuntimeJniValueManagerContract_NoGCIntegration : JniRuntimeJniValueManagerContract {
		static Type ManagedValueManagerType = Type.GetType ("Java.Interop.ManagedValueManager, Java.Runtime.Environment", throwOnError:true)!;

		protected override Type ValueManagerType => ManagedValueManagerType;
	}
}
