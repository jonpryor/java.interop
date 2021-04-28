using System;

using Java.Interop;

namespace Java.InteropTests
{
	[JniTypeSignature (JavaSingleton.JniTypeName)]
	public sealed class JavaSingleton : JavaObject
	{
		internal const string JniTypeName = "com/xamarin/interop/Singleton";

		readonly static JniPeerMembers _members = new JniPeerMembers (JniTypeName, typeof (JavaSingleton));

		public override JniPeerMembers JniPeerMembers {
			get {return _members;}
		}

		public  bool    disposed;

		internal JavaSingleton (ref JniObjectReference reference, JniObjectReferenceOptions options)
			: base (ref reference, options)
		{
		}

		protected override void Dispose (bool disposing)
		{
			disposed    = disposed || disposing;
			base.Dispose (disposing);
		}

		public static unsafe JavaSingleton Singleton {
			get {
				var o   = _members.StaticMethods.InvokeObjectMethod ("getSingleton.()Lcom/xamarin/interop/Singleton;", null);
				return JniEnvironment.Runtime.ValueManager.GetValue<JavaSingleton> (ref o, JniObjectReferenceOptions.CopyAndDispose);
			}
		}
	}
}

