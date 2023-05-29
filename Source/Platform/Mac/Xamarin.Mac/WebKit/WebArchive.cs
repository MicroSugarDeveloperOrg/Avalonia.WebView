using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebArchive", true)]
public class WebArchive : NSObject
{
	private static readonly IntPtr selMainResourceHandle = Selector.GetHandle("mainResource");

	private static readonly IntPtr selSubresourcesHandle = Selector.GetHandle("subresources");

	private static readonly IntPtr selSubframeArchivesHandle = Selector.GetHandle("subframeArchives");

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	private static readonly IntPtr selInitWithMainResourceSubresourcesSubframeArchives_Handle = Selector.GetHandle("initWithMainResource:subresources:subframeArchives:");

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	private static readonly IntPtr class_ptr = Class.GetHandle("WebArchive");

	private object __mt_MainResource_var;

	private object __mt_Subresources_var;

	private object __mt_SubframeArchives_var;

	private object __mt_Data_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual WebResource MainResource
	{
		[Export("mainResource")]
		get
		{
			return (WebResource)(__mt_MainResource_var = ((!IsDirectBinding) ? ((WebResource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainResourceHandle))) : ((WebResource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMainResourceHandle)))));
		}
	}

	public virtual WebResource[] Subresources
	{
		[Export("subresources")]
		get
		{
			return (WebResource[])(__mt_Subresources_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<WebResource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubresourcesHandle)) : NSArray.ArrayFromHandle<WebResource>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubresourcesHandle))));
		}
	}

	public virtual WebArchive[] SubframeArchives
	{
		[Export("subframeArchives")]
		get
		{
			return (WebArchive[])(__mt_SubframeArchives_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<WebArchive>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubframeArchivesHandle)) : NSArray.ArrayFromHandle<WebArchive>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubframeArchivesHandle))));
		}
	}

	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			return (NSData)(__mt_Data_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebArchive()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WebArchive(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebArchive(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebArchive(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMainResource:subresources:subframeArchives:")]
	public WebArchive(WebResource mainResource, NSArray subresources, NSArray subframeArchives)
		: base(NSObjectFlag.Empty)
	{
		if (mainResource == null)
		{
			throw new ArgumentNullException("mainResource");
		}
		if (subresources == null)
		{
			throw new ArgumentNullException("subresources");
		}
		if (subframeArchives == null)
		{
			throw new ArgumentNullException("subframeArchives");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithMainResourceSubresourcesSubframeArchives_Handle, mainResource.Handle, subresources.Handle, subframeArchives.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithMainResourceSubresourcesSubframeArchives_Handle, mainResource.Handle, subresources.Handle, subframeArchives.Handle);
		}
	}

	[Export("initWithData:")]
	public WebArchive(NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_MainResource_var = null;
			__mt_Subresources_var = null;
			__mt_SubframeArchives_var = null;
			__mt_Data_var = null;
		}
	}
}
