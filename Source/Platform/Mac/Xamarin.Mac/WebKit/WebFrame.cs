using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebFrame", true)]
public class WebFrame : NSObject
{
	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selWebViewHandle = Selector.GetHandle("webView");

	private static readonly IntPtr selFrameViewHandle = Selector.GetHandle("frameView");

	private static readonly IntPtr selDOMDocumentHandle = Selector.GetHandle("DOMDocument");

	private static readonly IntPtr selFrameElementHandle = Selector.GetHandle("frameElement");

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	private static readonly IntPtr selProvisionalDataSourceHandle = Selector.GetHandle("provisionalDataSource");

	private static readonly IntPtr selParentFrameHandle = Selector.GetHandle("parentFrame");

	private static readonly IntPtr selChildFramesHandle = Selector.GetHandle("childFrames");

	private static readonly IntPtr selWindowObjectHandle = Selector.GetHandle("windowObject");

	private static readonly IntPtr selGlobalContextHandle = Selector.GetHandle("globalContext");

	private static readonly IntPtr selInitWithNameWebFrameViewWebView_Handle = Selector.GetHandle("initWithName:webFrameView:webView:");

	private static readonly IntPtr selLoadRequest_Handle = Selector.GetHandle("loadRequest:");

	private static readonly IntPtr selLoadDataMIMETypeTextEncodingNameBaseURL_Handle = Selector.GetHandle("loadData:MIMEType:textEncodingName:baseURL:");

	private static readonly IntPtr selLoadHTMLStringBaseURL_Handle = Selector.GetHandle("loadHTMLString:baseURL:");

	private static readonly IntPtr selLoadAlternateHTMLStringBaseURLForUnreachableURL_Handle = Selector.GetHandle("loadAlternateHTMLString:baseURL:forUnreachableURL:");

	private static readonly IntPtr selLoadArchive_Handle = Selector.GetHandle("loadArchive:");

	private static readonly IntPtr selStopLoadingHandle = Selector.GetHandle("stopLoading");

	private static readonly IntPtr selReloadHandle = Selector.GetHandle("reload");

	private static readonly IntPtr selReloadFromOriginHandle = Selector.GetHandle("reloadFromOrigin");

	private static readonly IntPtr selFindFrameNamed_Handle = Selector.GetHandle("findFrameNamed:");

	private static readonly IntPtr class_ptr = Class.GetHandle("WebFrame");

	private object __mt_WebView_var;

	private object __mt_FrameView_var;

	private object __mt_DomDocument_var;

	private object __mt_FrameElement_var;

	private object __mt_DataSource_var;

	private object __mt_ProvisionalDataSource_var;

	private object __mt_ParentFrame_var;

	private object __mt_ChildFrames_var;

	private object __mt_WindowObject_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual WebView WebView
	{
		[Export("webView")]
		get
		{
			return (WebView)(__mt_WebView_var = ((!IsDirectBinding) ? ((WebView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWebViewHandle))) : ((WebView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWebViewHandle)))));
		}
	}

	public virtual WebFrameView FrameView
	{
		[Export("frameView")]
		get
		{
			return (WebFrameView)(__mt_FrameView_var = ((!IsDirectBinding) ? ((WebFrameView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrameViewHandle))) : ((WebFrameView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFrameViewHandle)))));
		}
	}

	public virtual DomDocument DomDocument
	{
		[Export("DOMDocument")]
		get
		{
			return (DomDocument)(__mt_DomDocument_var = ((!IsDirectBinding) ? ((DomDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDOMDocumentHandle))) : ((DomDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDOMDocumentHandle)))));
		}
	}

	public virtual DomHtmlElement FrameElement
	{
		[Export("frameElement")]
		get
		{
			return (DomHtmlElement)(__mt_FrameElement_var = ((!IsDirectBinding) ? ((DomHtmlElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrameElementHandle))) : ((DomHtmlElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFrameElementHandle)))));
		}
	}

	public virtual WebDataSource DataSource
	{
		[Export("dataSource")]
		get
		{
			return (WebDataSource)(__mt_DataSource_var = ((!IsDirectBinding) ? ((WebDataSource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle))) : ((WebDataSource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle)))));
		}
	}

	public virtual WebDataSource ProvisionalDataSource
	{
		[Export("provisionalDataSource")]
		get
		{
			return (WebDataSource)(__mt_ProvisionalDataSource_var = ((!IsDirectBinding) ? ((WebDataSource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProvisionalDataSourceHandle))) : ((WebDataSource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selProvisionalDataSourceHandle)))));
		}
	}

	public virtual WebFrame ParentFrame
	{
		[Export("parentFrame")]
		get
		{
			return (WebFrame)(__mt_ParentFrame_var = ((!IsDirectBinding) ? ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentFrameHandle))) : ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentFrameHandle)))));
		}
	}

	public virtual WebFrame[] ChildFrames
	{
		[Export("childFrames")]
		get
		{
			return (WebFrame[])(__mt_ChildFrames_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<WebFrame>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildFramesHandle)) : NSArray.ArrayFromHandle<WebFrame>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildFramesHandle))));
		}
	}

	public virtual WebScriptObject WindowObject
	{
		[Export("windowObject")]
		get
		{
			return (WebScriptObject)(__mt_WindowObject_var = ((!IsDirectBinding) ? ((WebScriptObject)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowObjectHandle))) : ((WebScriptObject)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowObjectHandle)))));
		}
	}

	public virtual IntPtr GlobalContext
	{
		[Export("globalContext")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selGlobalContextHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGlobalContextHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WebFrame(NSCoder coder)
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
	public WebFrame(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebFrame(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:webFrameView:webView:")]
	public WebFrame(string name, WebFrameView view, WebView webView)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithNameWebFrameViewWebView_Handle, arg, view.Handle, webView.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithNameWebFrameViewWebView_Handle, arg, view.Handle, webView.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("loadRequest:")]
	public virtual void LoadRequest(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadRequest_Handle, request.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadRequest_Handle, request.Handle);
		}
	}

	[Export("loadData:MIMEType:textEncodingName:baseURL:")]
	public virtual void LoadData(NSData data, string mimeType, string textDncodingName, NSUrl baseUrl)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (mimeType == null)
		{
			throw new ArgumentNullException("mimeType");
		}
		if (textDncodingName == null)
		{
			throw new ArgumentNullException("textDncodingName");
		}
		if (baseUrl == null)
		{
			throw new ArgumentNullException("baseUrl");
		}
		IntPtr arg = NSString.CreateNative(mimeType);
		IntPtr arg2 = NSString.CreateNative(textDncodingName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selLoadDataMIMETypeTextEncodingNameBaseURL_Handle, data.Handle, arg, arg2, baseUrl.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selLoadDataMIMETypeTextEncodingNameBaseURL_Handle, data.Handle, arg, arg2, baseUrl.Handle);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("loadHTMLString:baseURL:")]
	public virtual void LoadHtmlString(NSString htmlString, NSUrl? baseUrl)
	{
		if (htmlString == null)
		{
			throw new ArgumentNullException("htmlString");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadHTMLStringBaseURL_Handle, htmlString.Handle, baseUrl?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadHTMLStringBaseURL_Handle, htmlString.Handle, baseUrl?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("loadAlternateHTMLString:baseURL:forUnreachableURL:")]
	public virtual void LoadAlternateHtmlString(string htmlString, NSUrl baseURL, NSUrl forUnreachableURL)
	{
		if (htmlString == null)
		{
			throw new ArgumentNullException("htmlString");
		}
		if (baseURL == null)
		{
			throw new ArgumentNullException("baseURL");
		}
		if (forUnreachableURL == null)
		{
			throw new ArgumentNullException("forUnreachableURL");
		}
		IntPtr arg = NSString.CreateNative(htmlString);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selLoadAlternateHTMLStringBaseURLForUnreachableURL_Handle, arg, baseURL.Handle, forUnreachableURL.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selLoadAlternateHTMLStringBaseURLForUnreachableURL_Handle, arg, baseURL.Handle, forUnreachableURL.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("loadArchive:")]
	public virtual void LoadArchive(WebArchive archive)
	{
		if (archive == null)
		{
			throw new ArgumentNullException("archive");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadArchive_Handle, archive.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadArchive_Handle, archive.Handle);
		}
	}

	[Export("stopLoading")]
	public virtual void StopLoading()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopLoadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopLoadingHandle);
		}
	}

	[Export("reload")]
	public virtual void Reload()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadHandle);
		}
	}

	[Export("reloadFromOrigin")]
	public virtual void ReloadFromOrigin()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadFromOriginHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadFromOriginHandle);
		}
	}

	[Export("findFrameNamed:")]
	public virtual WebFrame FindFrameNamed(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		WebFrame result = ((!IsDirectBinding) ? ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFindFrameNamed_Handle, arg))) : ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFindFrameNamed_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WebView_var = null;
			__mt_FrameView_var = null;
			__mt_DomDocument_var = null;
			__mt_FrameElement_var = null;
			__mt_DataSource_var = null;
			__mt_ProvisionalDataSource_var = null;
			__mt_ParentFrame_var = null;
			__mt_ChildFrames_var = null;
			__mt_WindowObject_var = null;
		}
	}

	public void LoadHtmlString(string htmlString, NSUrl? baseUrl)
	{
		LoadHtmlString((NSString)htmlString, baseUrl);
	}
}
