using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebDataSource", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebDataSource : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSubresource_ = "addSubresource:";

	private static readonly IntPtr selAddSubresource_Handle = Selector.GetHandle("addSubresource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRequest_ = "initWithRequest:";

	private static readonly IntPtr selInitWithRequest_Handle = Selector.GetHandle("initWithRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitialRequest = "initialRequest";

	private static readonly IntPtr selInitialRequestHandle = Selector.GetHandle("initialRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLoading = "isLoading";

	private static readonly IntPtr selIsLoadingHandle = Selector.GetHandle("isLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainResource = "mainResource";

	private static readonly IntPtr selMainResourceHandle = Selector.GetHandle("mainResource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageTitle = "pageTitle";

	private static readonly IntPtr selPageTitleHandle = Selector.GetHandle("pageTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentation = "representation";

	private static readonly IntPtr selRepresentationHandle = Selector.GetHandle("representation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequest = "request";

	private static readonly IntPtr selRequestHandle = Selector.GetHandle("request");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResponse = "response";

	private static readonly IntPtr selResponseHandle = Selector.GetHandle("response");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubresourceForURL_ = "subresourceForURL:";

	private static readonly IntPtr selSubresourceForURL_Handle = Selector.GetHandle("subresourceForURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubresources = "subresources";

	private static readonly IntPtr selSubresourcesHandle = Selector.GetHandle("subresources");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextEncodingName = "textEncodingName";

	private static readonly IntPtr selTextEncodingNameHandle = Selector.GetHandle("textEncodingName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnreachableURL = "unreachableURL";

	private static readonly IntPtr selUnreachableURLHandle = Selector.GetHandle("unreachableURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWebArchive = "webArchive";

	private static readonly IntPtr selWebArchiveHandle = Selector.GetHandle("webArchive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWebFrame = "webFrame";

	private static readonly IntPtr selWebFrameHandle = Selector.GetHandle("webFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WebDataSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlRequest InitialRequest
	{
		[Export("initialRequest")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selInitialRequestHandle));
			}
			return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitialRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLoading
	{
		[Export("isLoading")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebResource MainResource
	{
		[Export("mainResource")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebResource>(Messaging.IntPtr_objc_msgSend(base.Handle, selMainResourceHandle));
			}
			return Runtime.GetNSObject<WebResource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainResourceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PageTitle
	{
		[Export("pageTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPageTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IWebDocumentRepresentation Representation
	{
		[Export("representation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IWebDocumentRepresentation>(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentationHandle), owns: false);
			}
			return Runtime.GetINativeObject<IWebDocumentRepresentation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentationHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableUrlRequest Request
	{
		[Export("request")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableUrlRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestHandle));
			}
			return Runtime.GetNSObject<NSMutableUrlRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlResponse Response
	{
		[Export("response")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlResponse>(Messaging.IntPtr_objc_msgSend(base.Handle, selResponseHandle));
			}
			return Runtime.GetNSObject<NSUrlResponse>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResponseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebResource[] Subresources
	{
		[Export("subresources")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<WebResource>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubresourcesHandle));
			}
			return NSArray.ArrayFromHandle<WebResource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubresourcesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string TextEncodingName
	{
		[Export("textEncodingName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTextEncodingNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextEncodingNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl UnreachableURL
	{
		[Export("unreachableURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selUnreachableURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUnreachableURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebArchive WebArchive
	{
		[Export("webArchive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebArchive>(Messaging.IntPtr_objc_msgSend(base.Handle, selWebArchiveHandle));
			}
			return Runtime.GetNSObject<WebArchive>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWebArchiveHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebFrame WebFrame
	{
		[Export("webFrame")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSend(base.Handle, selWebFrameHandle));
			}
			return Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWebFrameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebDataSource()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WebDataSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebDataSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public WebDataSource(NSUrlRequest request)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithRequest_Handle, request.Handle), "initWithRequest:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithRequest_Handle, request.Handle), "initWithRequest:");
		}
	}

	[Export("addSubresource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSubresource(WebResource subresource)
	{
		if (subresource == null)
		{
			throw new ArgumentNullException("subresource");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSubresource_Handle, subresource.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSubresource_Handle, subresource.Handle);
		}
	}

	[Export("subresourceForURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebResource SubresourceForUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WebResource>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSubresourceForURL_Handle, url.Handle));
		}
		return Runtime.GetNSObject<WebResource>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSubresourceForURL_Handle, url.Handle));
	}
}
