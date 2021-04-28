using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Java.Interop {

	public enum JavaScopeCleanup {
		RegisterWithManager,
		Dispose,
		Release,
	}

	public ref struct JavaScope {

		JavaScopeCleanup?       cleanup;
		PeerableCollection?     scope;

		public JavaScope (JavaScopeCleanup cleanup)
		{
			this.cleanup    = cleanup;
			scope           = JniEnvironment.CurrentInfo.BeginScope (cleanup);
		}

		public void Dispose ()
		{
			if (cleanup == null || scope == null) {
				return;
			}
			List<Exception>?    exceptions  = null;
			switch (cleanup) {
			case JavaScopeCleanup.Dispose:
				// Need to iterate over a copy of `scope`, as `p.Dispose()` will modify `scope`
				var copy = new IJavaPeerable [scope.Count];
				scope.CopyTo (copy, 0);
				foreach (var p in copy) {
					try {
						p.Dispose ();
					}
					catch (Exception e) {
						exceptions  = exceptions ?? new List<Exception>();
						exceptions.Add (e);
						Trace.WriteLine (e);
					}
				}
				break;
			}
			JniEnvironment.CurrentInfo.EndScope (scope);
			scope.Clear ();
			scope = null;
			if (exceptions != null) {
				throw new AggregateException (exceptions);
			}
		}
	}
}
