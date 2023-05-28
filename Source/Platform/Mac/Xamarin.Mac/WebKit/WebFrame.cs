using System;
using System.ComponentModel;
using Foundation;
using JavaScriptCore;
using ObjCRuntime;

namespace WebKit;

[Register("WebFrame", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebFrame : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDOMDocument = "DOMDocument";

	private static readonly IntPtr selDOMDocumentHandle = Selector.GetHandle("DOMDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildFrames = "childFrames";

	private static readonly IntPtr selChildFramesHandle = Selector.GetHandle("childFrames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindFrameNamed_ = "findFrameNamed:";

	private static readonly IntPtr selFindFrameNamed_Handle = Selector.GetHandle("findFrameNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameElement = "frameElement";

	private static readonly IntPtr selFrameElementHandle = Selector.GetHandle("frameElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameView = "frameView";

	private static readonly IntPtr selFrameViewHandle = Selector.GetHandle("frameView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlobalContext = "globalContext";

	private static readonly IntPtr selGlobalContextHandle = Selector.GetHandle("globalContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_WebFrameView_WebView_ = "initWithName:webFrameView:webView:";

	private static readonly IntPtr selInitWithName_WebFrameView_WebView_Handle = Selector.GetHandle("initWithName:webFrameView:webView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJavaScriptContext = "javaScriptContext";

	private static readonly IntPtr selJavaScriptContextHandle = Selector.GetHandle("javaScriptContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadAlternateHTMLString_BaseURL_ForUnreachableURL_ = "loadAlternateHTMLString:baseURL:forUnreachableURL:";

	private static readonly IntPtr selLoadAlternateHTMLString_BaseURL_ForUnreachableURL_Handle = Selector.GetHandle("loadAlternateHTMLString:baseURL:forUnreachableURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadArchive_ = "loadArchive:";

	private static readonly IntPtr selLoadArchive_Handle = Selector.GetHandle("loadArchive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadData_MIMEType_TextEncodingName_BaseURL_ = "loadData:MIMEType:textEncodingName:baseURL:";

	private static readonly IntPtr selLoadData_MIMEType_TextEncodingName_BaseURL_Handle = Selector.GetHandle("loadData:MIMEType:textEncodingName:baseURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadHTMLString_BaseURL_ = "loadHTMLString:baseURL:";

	private static readonly IntPtr selLoadHTMLString_BaseURL_Handle = Selector.GetHandle("loadHTMLString:baseURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadRequest_ = "loadRequest:";

	private static readonly IntPtr selLoadRequest_Handle = Selector.GetHandle("loadRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentFrame = "parentFrame";

	private static readonly IntPtr selParentFrameHandle = Selector.GetHandle("parentFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProvisionalDataSource = "provisionalDataSource";

	private static readonly IntPtr selProvisionalDataSourceHandle = Selector.GetHandle("provisionalDataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReload = "reload";

	private static readonly IntPtr selReloadHandle = Selector.GetHandle("reload");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadFromOrigin = "reloadFromOrigin";

	private static readonly IntPtr selReloadFromOriginHandle = Selector.GetHandle("reloadFromOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopLoading = "stopLoading";

	private static readonly IntPtr selStopLoadingHandle = Selector.GetHandle("stopLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWebView = "webView";

	private static readonly IntPtr selWebViewHandle = Selector.GetHandle("webView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowObject = "windowObject";

	private static readonly IntPtr selWindowObjectHandle = Selector.GetHandle("windowObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WebFrame");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebFrame[] ChildFrames
	{
		[Export("childFrames")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<WebFrame>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildFramesHandle));
			}
			return NSArray.ArrayFromHandle<WebFrame>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildFramesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebDataSource DataSource
	{
		[Export("dataSource")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle));
			}
			return Runtime.GetNSObject<WebDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomDocument DomDocument
	{
		[Export("DOMDocument")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomDocument>(Messaging.IntPtr_objc_msgSend(base.Handle, selDOMDocumentHandle));
			}
			return Runtime.GetNSObject<DomDocument>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDOMDocumentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomHtmlElement FrameElement
	{
		[Export("frameElement")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomHtmlElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selFrameElementHandle));
			}
			return Runtime.GetNSObject<DomHtmlElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrameElementHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebFrameView FrameView
	{
		[Export("frameView")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebFrameView>(Messaging.IntPtr_objc_msgSend(base.Handle, selFrameViewHandle));
			}
			return Runtime.GetNSObject<WebFrameView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrameViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr GlobalContext
	{
		[Export("globalContext")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selGlobalContextHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGlobalContextHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual JSContext JavaScriptContext
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("javaScriptContext", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<JSContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selJavaScriptContextHandle));
			}
			return Runtime.GetNSObject<JSContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJavaScriptContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebFrame ParentFrame
	{
		[Export("parentFrame")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentFrameHandle));
			}
			return Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentFrameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebDataSource ProvisionalDataSource
	{
		[Export("provisionalDataSource")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selProvisionalDataSourceHandle));
			}
			return Runtime.GetNSObject<WebDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProvisionalDataSourceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebView WebView
	{
		[Export("webView")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebView>(Messaging.IntPtr_objc_msgSend(base.Handle, selWebViewHandle));
			}
			return Runtime.GetNSObject<WebView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWebViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebScriptObject WindowObject
	{
		[Export("windowObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WebScriptObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowObjectHandle));
			}
			return Runtime.GetNSObject<WebScriptObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowObjectHandle));
		}
	}

	public void LoadHtmlString(string htmlString, NSUrl baseUrl)
	{
		LoadHtmlString((NSString)htmlString, baseUrl);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WebFrame(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebFrame(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:webFrameView:webView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithName_WebFrameView_WebView_Handle, arg, view.Handle, webView.Handle), "initWithName:webFrameView:webView:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithName_WebFrameView_WebView_Handle, arg, view.Handle, webView.Handle), "initWithName:webFrameView:webView:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("findFrameNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WebFrame FindFrameNamed(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		WebFrame result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFindFrameNamed_Handle, arg)) : Runtime.GetNSObject<WebFrame>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFindFrameNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("loadAlternateHTMLString:baseURL:forUnreachableURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selLoadAlternateHTMLString_BaseURL_ForUnreachableURL_Handle, arg, baseURL.Handle, forUnreachableURL.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selLoadAlternateHTMLString_BaseURL_ForUnreachableURL_Handle, arg, baseURL.Handle, forUnreachableURL.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("loadArchive:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoadArchive(WebArchive archive)
	{
		if (archive == null)
		{
			throw new ArgumentNullException("archive");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadArchive_Handle, archive.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadArchive_Handle, archive.Handle);
		}
	}

	[Export("loadData:MIMEType:textEncodingName:baseURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selLoadData_MIMEType_TextEncodingName_BaseURL_Handle, data.Handle, arg, arg2, baseUrl.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selLoadData_MIMEType_TextEncodingName_BaseURL_Handle, data.Handle, arg, arg2, baseUrl.Handle);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("loadHTMLString:baseURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoadHtmlString(NSString htmlString, NSUrl? baseUrl)
	{
		if (htmlString == null)
		{
			throw new ArgumentNullException("htmlString");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadHTMLString_BaseURL_Handle, htmlString.Handle, (baseUrl == null) ? IntPtr.Zero : baseUrl.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadHTMLString_BaseURL_Handle, htmlString.Handle, (baseUrl == null) ? IntPtr.Zero : baseUrl.Handle);
		}
	}

	[Export("loadRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoadRequest(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadRequest_Handle, request.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadRequest_Handle, request.Handle);
		}
	}

	[Export("reload")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reload()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadHandle);
		}
	}

	[Export("reloadFromOrigin")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadFromOrigin()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadFromOriginHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadFromOriginHandle);
		}
	}

	[Export("stopLoading")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopLoading()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopLoadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopLoadingHandle);
		}
	}
}
