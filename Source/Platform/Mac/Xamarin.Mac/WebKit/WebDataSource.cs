using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebDataSource", true)]
public class WebDataSource : NSObject
{
	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	private static readonly IntPtr selRepresentationHandle = Selector.GetHandle("representation");

	private static readonly IntPtr selWebFrameHandle = Selector.GetHandle("webFrame");

	private static readonly IntPtr selInitialRequestHandle = Selector.GetHandle("initialRequest");

	private static readonly IntPtr selRequestHandle = Selector.GetHandle("request");

	private static readonly IntPtr selResponseHandle = Selector.GetHandle("response");

	private static readonly IntPtr selTextEncodingNameHandle = Selector.GetHandle("textEncodingName");

	private static readonly IntPtr selIsLoadingHandle = Selector.GetHandle("isLoading");

	private static readonly IntPtr selPageTitleHandle = Selector.GetHandle("pageTitle");

	private static readonly IntPtr selUnreachableURLHandle = Selector.GetHandle("unreachableURL");

	private static readonly IntPtr selWebArchiveHandle = Selector.GetHandle("webArchive");

	private static readonly IntPtr selMainResourceHandle = Selector.GetHandle("mainResource");

	private static readonly IntPtr selSubresourcesHandle = Selector.GetHandle("subresources");

	private static readonly IntPtr selInitWithRequest_Handle = Selector.GetHandle("initWithRequest:");

	private static readonly IntPtr selSubresourceForURL_Handle = Selector.GetHandle("subresourceForURL:");

	private static readonly IntPtr selAddSubresource_Handle = Selector.GetHandle("addSubresource:");

	private static readonly IntPtr class_ptr = Class.GetHandle("WebDataSource");

	private object __mt_Data_var;

	private object __mt_Representation_var;

	private object __mt_WebFrame_var;

	private object __mt_InitialRequest_var;

	private object __mt_Request_var;

	private object __mt_Response_var;

	private object __mt_UnreachableURL_var;

	private object __mt_WebArchive_var;

	private object __mt_MainResource_var;

	private object __mt_Subresources_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			return (NSData)(__mt_Data_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle)))));
		}
	}

	public virtual WebDocumentRepresentation Representation
	{
		[Export("representation")]
		get
		{
			return (WebDocumentRepresentation)(__mt_Representation_var = ((!IsDirectBinding) ? ((WebDocumentRepresentation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentationHandle))) : ((WebDocumentRepresentation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentationHandle)))));
		}
	}

	public virtual WebFrame WebFrame
	{
		[Export("webFrame")]
		get
		{
			return (WebFrame)(__mt_WebFrame_var = ((!IsDirectBinding) ? ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWebFrameHandle))) : ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWebFrameHandle)))));
		}
	}

	public virtual NSUrlRequest InitialRequest
	{
		[Export("initialRequest")]
		get
		{
			return (NSUrlRequest)(__mt_InitialRequest_var = ((!IsDirectBinding) ? ((NSUrlRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitialRequestHandle))) : ((NSUrlRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInitialRequestHandle)))));
		}
	}

	public virtual NSMutableUrlRequest Request
	{
		[Export("request")]
		get
		{
			return (NSMutableUrlRequest)(__mt_Request_var = ((!IsDirectBinding) ? ((NSMutableUrlRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestHandle))) : ((NSMutableUrlRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestHandle)))));
		}
	}

	public virtual NSUrlResponse Response
	{
		[Export("response")]
		get
		{
			return (NSUrlResponse)(__mt_Response_var = ((!IsDirectBinding) ? ((NSUrlResponse)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResponseHandle))) : ((NSUrlResponse)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selResponseHandle)))));
		}
	}

	public virtual string TextEncodingName
	{
		[Export("textEncodingName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTextEncodingNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextEncodingNameHandle));
		}
	}

	public virtual bool IsLoading
	{
		[Export("isLoading")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadingHandle);
		}
	}

	public virtual string PageTitle
	{
		[Export("pageTitle")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPageTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageTitleHandle));
		}
	}

	public virtual NSUrl UnreachableURL
	{
		[Export("unreachableURL")]
		get
		{
			return (NSUrl)(__mt_UnreachableURL_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUnreachableURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUnreachableURLHandle)))));
		}
	}

	public virtual WebArchive WebArchive
	{
		[Export("webArchive")]
		get
		{
			return (WebArchive)(__mt_WebArchive_var = ((!IsDirectBinding) ? ((WebArchive)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWebArchiveHandle))) : ((WebArchive)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWebArchiveHandle)))));
		}
	}

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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebDataSource()
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
	public WebDataSource(NSCoder coder)
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
	public WebDataSource(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebDataSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRequest:")]
	public WebDataSource(NSUrlRequest request)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithRequest_Handle, request.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithRequest_Handle, request.Handle);
		}
	}

	[Export("subresourceForURL:")]
	public virtual WebResource SubresourceForUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return (WebResource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSubresourceForURL_Handle, url.Handle));
		}
		return (WebResource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSubresourceForURL_Handle, url.Handle));
	}

	[Export("addSubresource:")]
	public virtual void AddSubresource(WebResource subresource)
	{
		if (subresource == null)
		{
			throw new ArgumentNullException("subresource");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSubresource_Handle, subresource.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSubresource_Handle, subresource.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Data_var = null;
			__mt_Representation_var = null;
			__mt_WebFrame_var = null;
			__mt_InitialRequest_var = null;
			__mt_Request_var = null;
			__mt_Response_var = null;
			__mt_UnreachableURL_var = null;
			__mt_WebArchive_var = null;
			__mt_MainResource_var = null;
			__mt_Subresources_var = null;
		}
	}
}
