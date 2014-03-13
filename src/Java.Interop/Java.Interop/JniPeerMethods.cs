﻿
namespace Java.Interop {

	partial class JniPeerInstanceMethods {


		public void CallVoidMethod (
			string encodedMember,
			IJavaObject self
		)
		{
			JniPeerMembers.AssertSelf (self);


			var args = new JValue[]{
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
			}
		}

		public void CallVoidMethod<T> (
			string encodedMember,
			IJavaObject self,
			T value
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T> arg = new JniArgumentMarshalInfo<T>(value);

			var args = new JValue[]{
				arg.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg.Cleanup (value);
			}
		}

		public void CallVoidMethod<T1, T2> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
			}
		}

		public void CallVoidMethod<T1, T2, T3> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4, T5> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4, T5, T6> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4, T5, T6, T7> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4, T5, T6, T7, T8> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
			}
		}

		public void CallVoidMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);
			JniArgumentMarshalInfo<T15> arg15 = new JniArgumentMarshalInfo<T15>(value15);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
				arg15.JValue,
			};

			var m = GetMethodID (encodedMember);
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    m.CallVirtualVoidMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					m.CallNonvirtualVoidMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
				arg15.Cleanup (value15);
			}
		}

		public bool CallBooleanMethod (
			string encodedMember,
			IJavaObject self
		)
		{
			JniPeerMembers.AssertSelf (self);


			var args = new JValue[]{
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
			}
		}

		public bool CallBooleanMethod<T> (
			string encodedMember,
			IJavaObject self,
			T value
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T> arg = new JniArgumentMarshalInfo<T>(value);

			var args = new JValue[]{
				arg.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg.Cleanup (value);
			}
		}

		public bool CallBooleanMethod<T1, T2> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4, T5> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4, T5, T6> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4, T5, T6, T7> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4, T5, T6, T7, T8> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
			}
		}

		public bool CallBooleanMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);
			JniArgumentMarshalInfo<T15> arg15 = new JniArgumentMarshalInfo<T15>(value15);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
				arg15.JValue,
			};

			var m = GetMethodID (encodedMember);
			bool r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualBooleanMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualBooleanMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
				arg15.Cleanup (value15);
			}
		}

		public sbyte CallByteMethod (
			string encodedMember,
			IJavaObject self
		)
		{
			JniPeerMembers.AssertSelf (self);


			var args = new JValue[]{
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
			}
		}

		public sbyte CallByteMethod<T> (
			string encodedMember,
			IJavaObject self,
			T value
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T> arg = new JniArgumentMarshalInfo<T>(value);

			var args = new JValue[]{
				arg.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg.Cleanup (value);
			}
		}

		public sbyte CallByteMethod<T1, T2> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4, T5> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4, T5, T6> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4, T5, T6, T7> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4, T5, T6, T7, T8> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
			}
		}

		public sbyte CallByteMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);
			JniArgumentMarshalInfo<T15> arg15 = new JniArgumentMarshalInfo<T15>(value15);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
				arg15.JValue,
			};

			var m = GetMethodID (encodedMember);
			sbyte r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualByteMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualByteMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
				arg15.Cleanup (value15);
			}
		}

		public char CallCharMethod (
			string encodedMember,
			IJavaObject self
		)
		{
			JniPeerMembers.AssertSelf (self);


			var args = new JValue[]{
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
			}
		}

		public char CallCharMethod<T> (
			string encodedMember,
			IJavaObject self,
			T value
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T> arg = new JniArgumentMarshalInfo<T>(value);

			var args = new JValue[]{
				arg.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg.Cleanup (value);
			}
		}

		public char CallCharMethod<T1, T2> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
			}
		}

		public char CallCharMethod<T1, T2, T3> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4, T5> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4, T5, T6> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4, T5, T6, T7> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4, T5, T6, T7, T8> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
			}
		}

		public char CallCharMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);
			JniArgumentMarshalInfo<T15> arg15 = new JniArgumentMarshalInfo<T15>(value15);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
				arg15.JValue,
			};

			var m = GetMethodID (encodedMember);
			char r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualCharMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualCharMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
				arg15.Cleanup (value15);
			}
		}

		public short CallInt16Method (
			string encodedMember,
			IJavaObject self
		)
		{
			JniPeerMembers.AssertSelf (self);


			var args = new JValue[]{
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
			}
		}

		public short CallInt16Method<T> (
			string encodedMember,
			IJavaObject self,
			T value
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T> arg = new JniArgumentMarshalInfo<T>(value);

			var args = new JValue[]{
				arg.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg.Cleanup (value);
			}
		}

		public short CallInt16Method<T1, T2> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
			}
		}

		public short CallInt16Method<T1, T2, T3> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4, T5> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4, T5, T6> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4, T5, T6, T7> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4, T5, T6, T7, T8> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4, T5, T6, T7, T8, T9> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
			}
		}

		public short CallInt16Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);
			JniArgumentMarshalInfo<T15> arg15 = new JniArgumentMarshalInfo<T15>(value15);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
				arg15.JValue,
			};

			var m = GetMethodID (encodedMember);
			short r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt16Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt16Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
				arg15.Cleanup (value15);
			}
		}

		public int CallInt32Method (
			string encodedMember,
			IJavaObject self
		)
		{
			JniPeerMembers.AssertSelf (self);


			var args = new JValue[]{
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
			}
		}

		public int CallInt32Method<T> (
			string encodedMember,
			IJavaObject self,
			T value
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T> arg = new JniArgumentMarshalInfo<T>(value);

			var args = new JValue[]{
				arg.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg.Cleanup (value);
			}
		}

		public int CallInt32Method<T1, T2> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
			}
		}

		public int CallInt32Method<T1, T2, T3> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4, T5> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4, T5, T6> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4, T5, T6, T7> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4, T5, T6, T7, T8> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4, T5, T6, T7, T8, T9> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
			}
		}

		public int CallInt32Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);
			JniArgumentMarshalInfo<T15> arg15 = new JniArgumentMarshalInfo<T15>(value15);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
				arg15.JValue,
			};

			var m = GetMethodID (encodedMember);
			int r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt32Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt32Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
				arg15.Cleanup (value15);
			}
		}

		public long CallInt64Method (
			string encodedMember,
			IJavaObject self
		)
		{
			JniPeerMembers.AssertSelf (self);


			var args = new JValue[]{
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
			}
		}

		public long CallInt64Method<T> (
			string encodedMember,
			IJavaObject self,
			T value
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T> arg = new JniArgumentMarshalInfo<T>(value);

			var args = new JValue[]{
				arg.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg.Cleanup (value);
			}
		}

		public long CallInt64Method<T1, T2> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
			}
		}

		public long CallInt64Method<T1, T2, T3> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4, T5> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4, T5, T6> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4, T5, T6, T7> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4, T5, T6, T7, T8> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4, T5, T6, T7, T8, T9> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
			}
		}

		public long CallInt64Method<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);
			JniArgumentMarshalInfo<T15> arg15 = new JniArgumentMarshalInfo<T15>(value15);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
				arg15.JValue,
			};

			var m = GetMethodID (encodedMember);
			long r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualInt64Method (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualInt64Method (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
				arg15.Cleanup (value15);
			}
		}

		public float CallSingleMethod (
			string encodedMember,
			IJavaObject self
		)
		{
			JniPeerMembers.AssertSelf (self);


			var args = new JValue[]{
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
			}
		}

		public float CallSingleMethod<T> (
			string encodedMember,
			IJavaObject self,
			T value
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T> arg = new JniArgumentMarshalInfo<T>(value);

			var args = new JValue[]{
				arg.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg.Cleanup (value);
			}
		}

		public float CallSingleMethod<T1, T2> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
			}
		}

		public float CallSingleMethod<T1, T2, T3> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4, T5> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4, T5, T6> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4, T5, T6, T7> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4, T5, T6, T7, T8> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
			}
		}

		public float CallSingleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);
			JniArgumentMarshalInfo<T15> arg15 = new JniArgumentMarshalInfo<T15>(value15);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
				arg15.JValue,
			};

			var m = GetMethodID (encodedMember);
			float r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualSingleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualSingleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
				arg15.Cleanup (value15);
			}
		}

		public double CallDoubleMethod (
			string encodedMember,
			IJavaObject self
		)
		{
			JniPeerMembers.AssertSelf (self);


			var args = new JValue[]{
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
			}
		}

		public double CallDoubleMethod<T> (
			string encodedMember,
			IJavaObject self,
			T value
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T> arg = new JniArgumentMarshalInfo<T>(value);

			var args = new JValue[]{
				arg.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg.Cleanup (value);
			}
		}

		public double CallDoubleMethod<T1, T2> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
			}
		}

		public double CallDoubleMethod<T1, T2, T3> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4, T5> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4, T5, T6> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4, T5, T6, T7> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4, T5, T6, T7, T8> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
			}
		}

		public double CallDoubleMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);
			JniArgumentMarshalInfo<T15> arg15 = new JniArgumentMarshalInfo<T15>(value15);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
				arg15.JValue,
			};

			var m = GetMethodID (encodedMember);
			double r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualDoubleMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualDoubleMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
				arg15.Cleanup (value15);
			}
		}

		public JniLocalReference CallObjectMethod (
			string encodedMember,
			IJavaObject self
		)
		{
			JniPeerMembers.AssertSelf (self);


			var args = new JValue[]{
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
			}
		}

		public JniLocalReference CallObjectMethod<T> (
			string encodedMember,
			IJavaObject self,
			T value
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T> arg = new JniArgumentMarshalInfo<T>(value);

			var args = new JValue[]{
				arg.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg.Cleanup (value);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4, T5> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4, T5, T6> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4, T5, T6, T7> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4, T5, T6, T7, T8> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
			}
		}

		public JniLocalReference CallObjectMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> (
			string encodedMember,
			IJavaObject self,
			T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15
		)
		{
			JniPeerMembers.AssertSelf (self);

			JniArgumentMarshalInfo<T1> arg1 = new JniArgumentMarshalInfo<T1>(value1);
			JniArgumentMarshalInfo<T2> arg2 = new JniArgumentMarshalInfo<T2>(value2);
			JniArgumentMarshalInfo<T3> arg3 = new JniArgumentMarshalInfo<T3>(value3);
			JniArgumentMarshalInfo<T4> arg4 = new JniArgumentMarshalInfo<T4>(value4);
			JniArgumentMarshalInfo<T5> arg5 = new JniArgumentMarshalInfo<T5>(value5);
			JniArgumentMarshalInfo<T6> arg6 = new JniArgumentMarshalInfo<T6>(value6);
			JniArgumentMarshalInfo<T7> arg7 = new JniArgumentMarshalInfo<T7>(value7);
			JniArgumentMarshalInfo<T8> arg8 = new JniArgumentMarshalInfo<T8>(value8);
			JniArgumentMarshalInfo<T9> arg9 = new JniArgumentMarshalInfo<T9>(value9);
			JniArgumentMarshalInfo<T10> arg10 = new JniArgumentMarshalInfo<T10>(value10);
			JniArgumentMarshalInfo<T11> arg11 = new JniArgumentMarshalInfo<T11>(value11);
			JniArgumentMarshalInfo<T12> arg12 = new JniArgumentMarshalInfo<T12>(value12);
			JniArgumentMarshalInfo<T13> arg13 = new JniArgumentMarshalInfo<T13>(value13);
			JniArgumentMarshalInfo<T14> arg14 = new JniArgumentMarshalInfo<T14>(value14);
			JniArgumentMarshalInfo<T15> arg15 = new JniArgumentMarshalInfo<T15>(value15);

			var args = new JValue[]{
				arg1.JValue,
				arg2.JValue,
				arg3.JValue,
				arg4.JValue,
				arg5.JValue,
				arg6.JValue,
				arg7.JValue,
				arg8.JValue,
				arg9.JValue,
				arg10.JValue,
				arg11.JValue,
				arg12.JValue,
				arg13.JValue,
				arg14.JValue,
				arg15.JValue,
			};

			var m = GetMethodID (encodedMember);
			JniLocalReference r;
			try {
				if (self.GetType () == Members.ManagedPeerType) {
				    r = m.CallVirtualObjectMethod (self.SafeHandle, args);
				} else {
					var j = self.JniPeerMembers;
					m = j.InstanceMethods.GetMethodID (encodedMember);
					r = m.CallNonvirtualObjectMethod (self.SafeHandle, j.JniPeerType.SafeHandle, args);
				}
				return r;
			} finally {
				arg1.Cleanup (value1);
				arg2.Cleanup (value2);
				arg3.Cleanup (value3);
				arg4.Cleanup (value4);
				arg5.Cleanup (value5);
				arg6.Cleanup (value6);
				arg7.Cleanup (value7);
				arg8.Cleanup (value8);
				arg9.Cleanup (value9);
				arg10.Cleanup (value10);
				arg11.Cleanup (value11);
				arg12.Cleanup (value12);
				arg13.Cleanup (value13);
				arg14.Cleanup (value14);
				arg15.Cleanup (value15);
			}
		}
	}
}