package mono.com.getkeepsafe.relinker;


public class ReLinker_LoadListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.getkeepsafe.relinker.ReLinker.LoadListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_failure:(Ljava/lang/Throwable;)V:GetFailure_Ljava_lang_Throwable_Handler:Com.Getkeepsafe.Relinker.ReLinker/ILoadListenerInvoker, Com.Getkeepsafe.Relinker\n" +
			"n_success:()V:GetSuccessHandler:Com.Getkeepsafe.Relinker.ReLinker/ILoadListenerInvoker, Com.Getkeepsafe.Relinker\n" +
			"";
		mono.android.Runtime.register ("Com.Getkeepsafe.Relinker.ReLinker+ILoadListenerImplementor, Com.Getkeepsafe.Relinker", ReLinker_LoadListenerImplementor.class, __md_methods);
	}


	public ReLinker_LoadListenerImplementor ()
	{
		super ();
		if (getClass () == ReLinker_LoadListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Getkeepsafe.Relinker.ReLinker+ILoadListenerImplementor, Com.Getkeepsafe.Relinker", "", this, new java.lang.Object[] {  });
		}
	}


	public void failure (java.lang.Throwable p0)
	{
		n_failure (p0);
	}

	private native void n_failure (java.lang.Throwable p0);


	public void success ()
	{
		n_success ();
	}

	private native void n_success ();

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
