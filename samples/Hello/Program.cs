using System;
using System.Threading;

using Java.Interop;

namespace Hello
{
	class MainClass
	{
		public static unsafe void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			try {
				var ignore = JniRuntime.CurrentRuntime;
			} catch (InvalidOperationException e) {
				Console.WriteLine (e);
			}
			foreach (var h in JniRuntime.GetAvailableInvocationPointers ()) {
				Console.WriteLine ("PRE: GetCreatedJavaVMHandles: {0}", h);
			}
			Console.WriteLine ("Part 2!");
			using (var vm = new JreRuntimeOptions ().CreateJreVM ()) {
				Console.WriteLine ("# JniEnvironment.EnvironmentPointer={0}", JniEnvironment.EnvironmentPointer);
				Console.WriteLine ("vm.SafeHandle={0}", vm.InvocationPointer);
				var t = new JniType ("java/lang/Object");
				var c = t.GetConstructor ("()V");
				var o = t.NewObject (c, null);
				var m = t.GetInstanceMethod ("hashCode", "()I");
				int i = JniEnvironment.InstanceMethods.CallIntMethod (o, m);
				Console.WriteLine ("java.lang.Object={0}", o);
				Console.WriteLine ("hashcode={0}", i);
				JniObjectReference.Dispose (ref o);
				t.Dispose ();
				// var o = JniTypes.FindClass ("java/lang/Object");
				/*
				var waitForCreation = new CountdownEvent (1);
				var exitThread = new CountdownEvent (1);
				var t = new Thread (() => {
					var vm2 = new JavaVMBuilder ().CreateJavaVM ();
					waitForCreation.Signal ();
					exitThread.Wait ();
				});
				t.Start ();
				waitForCreation.Wait ();
				*/
				foreach (var h in JniRuntime.GetAvailableInvocationPointers ()) {
					Console.WriteLine ("WITHIN: GetCreatedJavaVMs: {0}", h);
				}
				// exitThread.Signal ();
			}
			foreach (var h in JniRuntime.GetAvailableInvocationPointers ()) {
				Console.WriteLine ("POST: GetCreatedJavaVMs: {0}", h);
			}
		}
	}
}
