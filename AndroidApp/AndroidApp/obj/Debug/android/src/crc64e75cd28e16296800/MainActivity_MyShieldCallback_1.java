package crc64e75cd28e16296800;


public class MainActivity_MyShieldCallback_1
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.shield.android.ShieldCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailure:(Lcom/shield/android/ShieldException;)V:GetOnFailure_Lcom_shield_android_ShieldException_Handler:Com.Shield.Android.IShieldCallbackInvoker, ShieldFraud_Android\n" +
			"n_onSuccess:(Ljava/lang/Object;)V:GetOnSuccess_Ljava_lang_Object_Handler:Com.Shield.Android.IShieldCallbackInvoker, ShieldFraud_Android\n" +
			"";
		mono.android.Runtime.register ("AndroidApp.MainActivity+MyShieldCallback`1, AndroidApp", MainActivity_MyShieldCallback_1.class, __md_methods);
	}


	public MainActivity_MyShieldCallback_1 ()
	{
		super ();
		if (getClass () == MainActivity_MyShieldCallback_1.class) {
			mono.android.TypeManager.Activate ("AndroidApp.MainActivity+MyShieldCallback`1, AndroidApp", "", this, new java.lang.Object[] {  });
		}
	}


	public void onFailure (com.shield.android.ShieldException p0)
	{
		n_onFailure (p0);
	}

	private native void n_onFailure (com.shield.android.ShieldException p0);


	public void onSuccess (java.lang.Object p0)
	{
		n_onSuccess (p0);
	}

	private native void n_onSuccess (java.lang.Object p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
