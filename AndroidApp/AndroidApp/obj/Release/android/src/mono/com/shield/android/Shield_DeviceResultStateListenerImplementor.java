package mono.com.shield.android;


public class Shield_DeviceResultStateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.shield.android.Shield.DeviceResultStateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_isReady:()V:GetIsReadyHandler:Com.Shield.Android.Shield/IDeviceResultStateListenerInvoker, ShieldFraud_Android\n" +
			"";
		mono.android.Runtime.register ("Com.Shield.Android.Shield+IDeviceResultStateListenerImplementor, ShieldFraud_Android", Shield_DeviceResultStateListenerImplementor.class, __md_methods);
	}


	public Shield_DeviceResultStateListenerImplementor ()
	{
		super ();
		if (getClass () == Shield_DeviceResultStateListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Shield.Android.Shield+IDeviceResultStateListenerImplementor, ShieldFraud_Android", "", this, new java.lang.Object[] {  });
		}
	}


	public void isReady ()
	{
		n_isReady ();
	}

	private native void n_isReady ();

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
