using System;
using System.Reflection;
using System.Collections.Generic;
using System.Threading;

using Java.Interop;

using NUnit.Framework;

namespace Java.InteropTests
{
	[TestFixture]
	public class JniRuntimeTest : JavaVMFixture
	{
		[Test]
		public void CreateJavaVM ()
		{
			Assert.AreSame (JniRuntime.CurrentRuntime, JniRuntime.CurrentRuntime);
			Assert.IsTrue (JniRuntime.CurrentRuntime.InvocationPointer != IntPtr.Zero);
			Assert.IsTrue (JniEnvironment.EnvironmentPointer != IntPtr.Zero);
		}

#if !__ANDROID__
		[Test]
		public void JDK_OnlySupportsOneVM ()
		{
			try {
				var second = new JreRuntimeOptions ().CreateJreVM ();
				// If we reach here, we're in a JVM that supports > 1 VM
				second.Dispose ();
				Assert.Ignore ();
			} catch (NotSupportedException) {
			} catch (Exception e){
				Assert.Fail ("Expected NotSupportedException; got: {0}", e);
			}
		}
#endif  // !__ANDROID__

		[Test]
		public void CreateJavaVMWithNullBuilder ()
		{
			Assert.Throws<ArgumentNullException> (() => new JavaVMWithNullBuilder ());
		}

		class JavaVMWithNullBuilder : JniRuntime {
			public JavaVMWithNullBuilder ()
				: base ((JniRuntime.CreationOptions) null)
			{
			}
		}

		[Test]
		public void Dispose_ClearsJniEnvironment ()
		{
			var c   = JniRuntime.CurrentRuntime;
			JniRuntime r    = null;
			var t   = new Thread (() => {
				r   = new JniProxyRuntime (c);
				JniRuntime.SetCurrent (r);
				Assert.AreEqual (r, JniEnvironment.Runtime);
				r.Dispose ();
				Assert.Throws<NotSupportedException>(() => {
					var env = JniEnvironment.Runtime;
				});
			});
			t.Start ();
			t.Join ();
			Assert.IsNotNull (r);
			JniRuntime.SetCurrent (c);
		}


		[Test]
		public void GetRegisteredJavaVM_ExistingInstance ()
		{
			Assert.AreEqual (JniRuntime.CurrentRuntime, JniRuntime.GetRegisteredRuntime (JniRuntime.CurrentRuntime.InvocationPointer));
		}
	}

	class JniProxyRuntime : JniRuntime
	{
		JniRuntime          Proxy;

		public JniProxyRuntime (JniRuntime proxy)
			: base (CreateOptions (proxy))
		{
			Proxy   = proxy;
		}

		static JniRuntime.CreationOptions CreateOptions (JniRuntime proxy)
		{
			return new JniRuntime.CreationOptions {
				DestroyRuntimeOnDispose     = false,
				InvocationPointer           = proxy.InvocationPointer,
				MarshalMemberBuilder        = new ProxyMarshalMemberBuilder (),
				ObjectReferenceManager      = new ProxyObjectReferenceManager (),
				ValueManager                = new ProxyValueManager (),
				TypeManager                 = new ProxyTypeManager (),
			};
		}

		class ProxyMarshalMemberBuilder : JniMarshalMemberBuilder {

			public override System.Linq.Expressions.LambdaExpression CreateMarshalToManagedExpression (System.Reflection.MethodInfo method)
			{
				throw new NotImplementedException ();
			}

			public override System.Collections.Generic.IEnumerable<JniNativeMethodRegistration> GetExportedMemberRegistrations (Type declaringType)
			{
				throw new NotImplementedException ();
			}

			public override System.Linq.Expressions.Expression<Func<System.Reflection.ConstructorInfo, JniObjectReference, object[], object>> CreateConstructActivationPeerExpression (System.Reflection.ConstructorInfo constructor)
			{
				throw new NotImplementedException ();
			}
		}

		class ProxyObjectReferenceManager : JniObjectReferenceManager {

			public override int GlobalReferenceCount {
				get {return 1;}
			}

			public override int WeakGlobalReferenceCount {
				get {return 0;}
			}
		}

		class ProxyValueManager : JniValueManager {

			protected override void AddPeerCore (IJavaPeerable peer)
			{
			}

			public override bool CanCollectPeers => false;

			protected override void CollectPeersCore ()
			{
			}

			protected override void DisposePeersCore ()
			{
			}

			protected override void ReleasePeersCore ()
			{
			}

			protected override bool ShouldFinalizePeer (IJavaPeerable peer) => true;

			protected override void AddSurfacedPeers (ICollection<JniSurfacedPeerInfo> peers)
			{
			}

			protected override IJavaPeerable PeekPeerCore (JniObjectReference reference)
			{
				return null;
			}

			protected override void ActivatePeerCore (JniObjectReference reference, ConstructorInfo constructor, object [] argumentValues)
			{
				throw new NotImplementedException ();
			}

			protected override void RemovePeerCore (IJavaPeerable peer)
			{
			}

			public override void WaitForGCBridgeProcessing ()
			{
			}
		}

		class ProxyTypeManager : JniTypeManager {
		}
	}
}

