using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Java.Interop {

	class ManagedValueManager : JniRuntime.JniValueManager {

		Dictionary<int, List<IJavaPeerable>>?   RegisteredInstances = new Dictionary<int, List<IJavaPeerable>>();

		public override void WaitForGCBridgeProcessing ()
		{
		}

		public override bool CanCollectPeers => false;

		protected override void CollectPeersCore ()
		{
			throw new NotSupportedException ();
		}

		protected override void DisposePeersCore ()
		{
			var peers = new List<IJavaPeerable> ();

			lock (RegisteredInstances!) {
				foreach (var ps in RegisteredInstances.Values) {
					foreach (var p in ps) {
						peers.Add (p);
					}
				}
				RegisteredInstances.Clear ();
			}
			List<Exception>? exceptions = null;
			foreach (var peer in peers) {
				try {
					peer.Dispose ();
				}
				catch (Exception e) {
					exceptions = exceptions ?? new List<Exception> ();
					exceptions.Add (e);
				}
			}
			if (exceptions != null)
				throw new AggregateException ("Exceptions while collecting peers.", exceptions);
		}

		protected override void ReleasePeersCore ()
		{
			lock (RegisteredInstances!) {
				RegisteredInstances.Clear ();
			}
		}

		protected override void AddPeerCore (IJavaPeerable value)
		{
			if (RegisteredInstances == null)
				throw new ObjectDisposedException (nameof (MonoRuntimeValueManager));

			int key = value.JniIdentityHashCode;
			lock (RegisteredInstances) {
				List<IJavaPeerable> peers;
				if (!RegisteredInstances.TryGetValue (key, out peers)) {
					peers = new List<IJavaPeerable> () {
						value,
					};
					RegisteredInstances.Add (key, peers);
					return;
				}

				for (int i = peers.Count - 1; i >= 0; i--) {
					var p   = peers [i];
					if (!JniEnvironment.Types.IsSameObject (p.PeerReference, value.PeerReference))
						continue;
					if (Replaceable (p)) {
						peers [i] = value;
					} else {
						WarnNotReplacing (key, value, p);
					}
					return;
				}
				peers.Add (value);
			}
		}

		static bool Replaceable (IJavaPeerable peer)
		{
			if (peer == null)
				return true;
			return (peer.JniManagedPeerState & JniManagedPeerStates.Replaceable) == JniManagedPeerStates.Replaceable;
		}

		void WarnNotReplacing (int key, IJavaPeerable ignoreValue, IJavaPeerable keepValue)
		{
			Runtime.ObjectReferenceManager.WriteGlobalReferenceLine (
					"Warning: Not registering PeerReference={0} IdentityHashCode=0x{1} Instance={2} Instance.Type={3} Java.Type={4}; " +
					"keeping previously registered PeerReference={5} Instance={6} Instance.Type={7} Java.Type={8}.",
					ignoreValue.PeerReference.ToString (),
					key.ToString ("x"),
					RuntimeHelpers.GetHashCode (ignoreValue).ToString ("x"),
					ignoreValue.GetType ().FullName,
					JniEnvironment.Types.GetJniTypeNameFromInstance (ignoreValue.PeerReference),
					keepValue.PeerReference.ToString (),
					RuntimeHelpers.GetHashCode (keepValue).ToString ("x"),
					keepValue.GetType ().FullName,
					JniEnvironment.Types.GetJniTypeNameFromInstance (keepValue.PeerReference));
		}

		protected override IJavaPeerable? PeekPeerCore (JniObjectReference reference)
		{
			if (RegisteredInstances == null)
				throw new ObjectDisposedException (nameof (MonoRuntimeValueManager));

			if (!reference.IsValid)
				return null;

			int key = GetJniIdentityHashCode (reference);

			lock (RegisteredInstances) {
				List<IJavaPeerable> peers;
				if (!RegisteredInstances.TryGetValue (key, out peers))
					return null;

				for (int i = peers.Count - 1; i >= 0; i--) {
					var p = peers [i];
					if (JniEnvironment.Types.IsSameObject (reference, p.PeerReference))
						return p;
				}
				if (peers.Count == 0)
					RegisteredInstances.Remove (key);
			}
			return null;
		}

		protected override void RemovePeerCore (IJavaPeerable value)
		{
			if (RegisteredInstances == null)
				throw new ObjectDisposedException (nameof (MonoRuntimeValueManager));

			int key = value.JniIdentityHashCode;
			lock (RegisteredInstances) {
				List<IJavaPeerable> peers;
				if (!RegisteredInstances.TryGetValue (key, out peers))
					return;

				for (int i = peers.Count - 1; i >= 0; i--) {
					var p   = peers [i];
					if (object.ReferenceEquals (value, p)) {
						peers.RemoveAt (i);
					}
				}
				if (peers.Count == 0)
					RegisteredInstances.Remove (key);
			}
		}

		protected override bool ShouldFinalizePeer (IJavaPeerable value) => true;

		protected override void ActivatePeerCore (JniObjectReference reference, ConstructorInfo constructor, object?[]? argumentValues)
		{
			var runtime = JniEnvironment.Runtime;

			try {
				var f = runtime.MarshalMemberBuilder.CreateConstructActivationPeerFunc (constructor);
				f (constructor, reference, argumentValues);
			} catch (Exception e) {
				var m = string.Format ("Could not activate {{ PeerReference={0} IdentityHashCode=0x{1} Java.Type={2} }} for managed type '{3}'.",
						reference,
						runtime.ValueManager.GetJniIdentityHashCode (reference).ToString ("x"),
						JniEnvironment.Types.GetJniTypeNameFromInstance (reference),
						constructor.DeclaringType.FullName);
				Debug.WriteLine (m);

				throw new NotSupportedException (m, e);
			}
		}

		protected override void AddSurfacedPeers (ICollection<JniSurfacedPeerInfo> peers)
		{
			lock (RegisteredInstances!) {
				foreach (var e in RegisteredInstances) {
					foreach (var p in e.Value) {
						peers.Add (new JniSurfacedPeerInfo (e.Key, new WeakReference<IJavaPeerable> (p)));
					}
				}
			}
		}
	}
}
