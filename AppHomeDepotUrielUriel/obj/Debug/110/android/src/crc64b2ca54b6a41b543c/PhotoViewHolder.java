package crc64b2ca54b6a41b543c;


public class PhotoViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("AppHomeDepotUrielUriel.PhotoViewHolder, AppHomeDepotUrielUriel", PhotoViewHolder.class, __md_methods);
	}


	public PhotoViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == PhotoViewHolder.class)
			mono.android.TypeManager.Activate ("AppHomeDepotUrielUriel.PhotoViewHolder, AppHomeDepotUrielUriel", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
