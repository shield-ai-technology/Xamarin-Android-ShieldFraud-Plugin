//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Shield.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.shield.android']/class[@name='CaptchaType']"
	[global::Android.Runtime.Register ("com/shield/android/CaptchaType", DoNotGenerateAcw=true)]
	public sealed partial class CaptchaType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.shield.android']/class[@name='CaptchaType']/field[@name='MATH_CHALLENGE']"
		[Register ("MATH_CHALLENGE")]
		public static global::Com.Shield.Android.CaptchaType MathChallenge {
			get {
				const string __id = "MATH_CHALLENGE.Lcom/shield/android/CaptchaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Shield.Android.CaptchaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.shield.android']/class[@name='CaptchaType']/field[@name='TEXT_CAPTCHA']"
		[Register ("TEXT_CAPTCHA")]
		public static global::Com.Shield.Android.CaptchaType TextCaptcha {
			get {
				const string __id = "TEXT_CAPTCHA.Lcom/shield/android/CaptchaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Shield.Android.CaptchaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/shield/android/CaptchaType", typeof (CaptchaType));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal CaptchaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/class[@name='CaptchaType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/shield/android/CaptchaType;", "")]
		public static unsafe global::Com.Shield.Android.CaptchaType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/shield/android/CaptchaType;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Shield.Android.CaptchaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/class[@name='CaptchaType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/shield/android/CaptchaType;", "")]
		public static unsafe global::Com.Shield.Android.CaptchaType[] Values ()
		{
			const string __id = "values.()[Lcom/shield/android/CaptchaType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Shield.Android.CaptchaType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Shield.Android.CaptchaType));
			} finally {
			}
		}

	}
}
