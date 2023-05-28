using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Protocol]
[Register("WebPolicyDelegate", false)]
[Model]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebPolicyDelegate : NSObject, IWebPolicyDelegate, INativeObject, IDisposable
{
	private static IntPtr selUse = Selector.GetHandle("use");

	private static IntPtr selDownload = Selector.GetHandle("download");

	private static IntPtr selIgnore = Selector.GetHandle("ignore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WebActionButtonKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WebActionElementKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WebActionModifierFlagsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WebActionNavigationTypeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WebActionOriginalUrlKey;

	[Field("WebActionButtonKey", "WebKit")]
	public static NSString WebActionButtonKey
	{
		get
		{
			if (_WebActionButtonKey == null)
			{
				_WebActionButtonKey = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WebActionButtonKey");
			}
			return _WebActionButtonKey;
		}
	}

	[Field("WebActionElementKey", "WebKit")]
	public static NSString WebActionElementKey
	{
		get
		{
			if (_WebActionElementKey == null)
			{
				_WebActionElementKey = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WebActionElementKey");
			}
			return _WebActionElementKey;
		}
	}

	[Field("WebActionModifierFlagsKey", "WebKit")]
	public static NSString WebActionModifierFlagsKey
	{
		get
		{
			if (_WebActionModifierFlagsKey == null)
			{
				_WebActionModifierFlagsKey = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WebActionModifierFlagsKey");
			}
			return _WebActionModifierFlagsKey;
		}
	}

	[Field("WebActionNavigationTypeKey", "WebKit")]
	public static NSString WebActionNavigationTypeKey
	{
		get
		{
			if (_WebActionNavigationTypeKey == null)
			{
				_WebActionNavigationTypeKey = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WebActionNavigationTypeKey");
			}
			return _WebActionNavigationTypeKey;
		}
	}

	[Field("WebActionOriginalURLKey", "WebKit")]
	public static NSString WebActionOriginalUrlKey
	{
		get
		{
			if (_WebActionOriginalUrlKey == null)
			{
				_WebActionOriginalUrlKey = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WebActionOriginalURLKey");
			}
			return _WebActionOriginalUrlKey;
		}
	}

	public static void DecideUse(NSObject decisionToken)
	{
		if (decisionToken == null)
		{
			throw new ArgumentNullException("token");
		}
		Messaging.void_objc_msgSend(decisionToken.Handle, selUse);
	}

	public static void DecideDownload(NSObject decisionToken)
	{
		if (decisionToken == null)
		{
			throw new ArgumentNullException("decisionToken");
		}
		Messaging.void_objc_msgSend(decisionToken.Handle, selDownload);
	}

	public static void DecideIgnore(NSObject decisionToken)
	{
		if (decisionToken == null)
		{
			throw new ArgumentNullException("decisionToken");
		}
		Messaging.void_objc_msgSend(decisionToken.Handle, selIgnore);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebPolicyDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WebPolicyDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebPolicyDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("webView:decidePolicyForMIMEType:request:frame:decisionListener:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DecidePolicyForMimeType(WebView webView, string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:decidePolicyForNavigationAction:request:frame:decisionListener:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DecidePolicyForNavigation(WebView webView, NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:decidePolicyForNewWindowAction:request:newFrameName:decisionListener:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DecidePolicyForNewWindow(WebView webView, NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:unableToImplementPolicyWithError:frame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnableToImplementPolicy(WebView webView, NSError error, WebFrame frame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
