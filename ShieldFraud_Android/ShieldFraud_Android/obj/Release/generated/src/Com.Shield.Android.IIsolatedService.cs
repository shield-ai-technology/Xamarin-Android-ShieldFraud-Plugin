using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Shield.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Default']"
	[global::Android.Runtime.Register ("com/shield/android/IIsolatedService$Default", DoNotGenerateAcw=true)]
	public partial class IsolatedServiceDefault : global::Java.Lang.Object, global::Com.Shield.Android.IIsolatedService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/shield/android/IIsolatedService$Default", typeof (IsolatedServiceDefault));

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

		protected IsolatedServiceDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Default']/constructor[@name='IIsolatedService.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IsolatedServiceDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_isMagiskPresent;
#pragma warning disable 0169
		static Delegate GetIsMagiskPresentHandler ()
		{
			if (cb_isMagiskPresent == null)
				cb_isMagiskPresent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsMagiskPresent));
			return cb_isMagiskPresent;
		}

		static bool n_IsMagiskPresent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Shield.Android.IsolatedServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMagiskPresent;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMagiskPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Default']/method[@name='isMagiskPresent' and count(parameter)=0]"
			[Register ("isMagiskPresent", "()Z", "GetIsMagiskPresentHandler")]
			get {
				const string __id = "isMagiskPresent.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_AsBinder));
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Shield.Android.IsolatedServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Default']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Stub']"
	[global::Android.Runtime.Register ("com/shield/android/IIsolatedService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class IsolatedServiceStub : global::Android.OS.Binder, global::Com.Shield.Android.IIsolatedService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/shield/android/IIsolatedService$Stub", typeof (IsolatedServiceStub));

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

		protected IsolatedServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Stub']/constructor[@name='IIsolatedService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IsolatedServiceStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe global::Com.Shield.Android.IIsolatedService DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/shield/android/IIsolatedService;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/shield/android/IIsolatedService;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Shield.Android.IIsolatedService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_AsBinder));
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Shield.Android.IsolatedServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/shield/android/IIsolatedService;", "")]
		public static unsafe global::Com.Shield.Android.IIsolatedService AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/shield/android/IIsolatedService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Shield.Android.IIsolatedService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLI_Z (n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I));
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Shield.Android.IsolatedServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [2] = new JniArgumentValue ((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reply).Handle);
				__args [3] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (reply);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.shield.android.IIsolatedService']]"
		[Register ("setDefaultImpl", "(Lcom/shield/android/IIsolatedService;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Shield.Android.IIsolatedService impl)
		{
			const string __id = "setDefaultImpl.(Lcom/shield/android/IIsolatedService;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_isMagiskPresent;
#pragma warning disable 0169
		static Delegate GetIsMagiskPresentHandler ()
		{
			if (cb_isMagiskPresent == null)
				cb_isMagiskPresent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsMagiskPresent));
			return cb_isMagiskPresent;
		}

		static bool n_IsMagiskPresent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Shield.Android.IsolatedServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMagiskPresent;
		}
#pragma warning restore 0169

		public abstract bool IsMagiskPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Stub']/method[@name='isMagiskPresent' and count(parameter)=0]"
			[Register ("isMagiskPresent", "()Z", "GetIsMagiskPresentHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/shield/android/IIsolatedService$Stub", DoNotGenerateAcw=true)]
	internal partial class IsolatedServiceStubInvoker : IsolatedServiceStub {
		public IsolatedServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/shield/android/IIsolatedService$Stub", typeof (IsolatedServiceStubInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsMagiskPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/class[@name='IIsolatedService.Stub']/method[@name='isMagiskPresent' and count(parameter)=0]"
			[Register ("isMagiskPresent", "()Z", "GetIsMagiskPresentHandler")]
			get {
				const string __id = "isMagiskPresent.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.shield.android']/interface[@name='IIsolatedService']"
	[Register ("com/shield/android/IIsolatedService", "", "Com.Shield.Android.IIsolatedServiceInvoker")]
	public partial interface IIsolatedService : global::Android.OS.IInterface {
		bool IsMagiskPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.shield.android']/interface[@name='IIsolatedService']/method[@name='isMagiskPresent' and count(parameter)=0]"
			[Register ("isMagiskPresent", "()Z", "GetIsMagiskPresentHandler:Com.Shield.Android.IIsolatedServiceInvoker, ShieldFraud_Android")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/shield/android/IIsolatedService", DoNotGenerateAcw=true)]
	internal partial class IIsolatedServiceInvoker : global::Java.Lang.Object, IIsolatedService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/shield/android/IIsolatedService", typeof (IIsolatedServiceInvoker));

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

		public static IIsolatedService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIsolatedService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.shield.android.IIsolatedService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIsolatedServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isMagiskPresent;
#pragma warning disable 0169
		static Delegate GetIsMagiskPresentHandler ()
		{
			if (cb_isMagiskPresent == null)
				cb_isMagiskPresent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsMagiskPresent));
			return cb_isMagiskPresent;
		}

		static bool n_IsMagiskPresent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Shield.Android.IIsolatedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMagiskPresent;
		}
#pragma warning restore 0169

		IntPtr id_isMagiskPresent;
		public unsafe bool IsMagiskPresent {
			get {
				if (id_isMagiskPresent == IntPtr.Zero)
					id_isMagiskPresent = JNIEnv.GetMethodID (class_ref, "isMagiskPresent", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMagiskPresent);
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_AsBinder));
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Shield.Android.IIsolatedService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}
}
