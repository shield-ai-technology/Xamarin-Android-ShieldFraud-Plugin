using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Shield.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.shield.android']/interface[@name='ShieldCallback']"
	[Register ("com/shield/android/ShieldCallback", "", "Com.Shield.Android.IShieldCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IShieldCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/interface[@name='ShieldCallback']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.shield.android.ShieldException']]"
		[Register ("onFailure", "(Lcom/shield/android/ShieldException;)V", "GetOnFailure_Lcom_shield_android_ShieldException_Handler:Com.Shield.Android.IShieldCallbackInvoker, ShieldFraud_Android")]
		void OnFailure (global::Com.Shield.Android.ShieldException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/interface[@name='ShieldCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler:Com.Shield.Android.IShieldCallbackInvoker, ShieldFraud_Android")]
		void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/shield/android/ShieldCallback", DoNotGenerateAcw=true)]
	internal partial class IShieldCallbackInvoker : global::Java.Lang.Object, IShieldCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/shield/android/ShieldCallback", typeof (IShieldCallbackInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IShieldCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShieldCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.shield.android.ShieldCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShieldCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Lcom_shield_android_ShieldException_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lcom_shield_android_ShieldException_Handler ()
		{
			if (cb_onFailure_Lcom_shield_android_ShieldException_ == null)
				cb_onFailure_Lcom_shield_android_ShieldException_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnFailure_Lcom_shield_android_ShieldException_));
			return cb_onFailure_Lcom_shield_android_ShieldException_;
		}

		static void n_OnFailure_Lcom_shield_android_ShieldException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Shield.Android.IShieldCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Shield.Android.ShieldException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Lcom_shield_android_ShieldException_;
		public unsafe void OnFailure (global::Com.Shield.Android.ShieldException p0)
		{
			if (id_onFailure_Lcom_shield_android_ShieldException_ == IntPtr.Zero)
				id_onFailure_Lcom_shield_android_ShieldException_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/shield/android/ShieldException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_shield_android_ShieldException_, __args);
		}

		static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_ == null)
				cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnSuccess_Ljava_lang_Object_));
			return cb_onSuccess_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Shield.Android.IShieldCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_Object_;
		public unsafe void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
