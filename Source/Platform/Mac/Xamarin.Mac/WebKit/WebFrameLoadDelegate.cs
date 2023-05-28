using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using JavaScriptCore;
using ObjCRuntime;

namespace WebKit;

[Protocol]
[Register("WebFrameLoadDelegate", false)]
[Model]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebFrameLoadDelegate : NSObject, IWebFrameLoadDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebFrameLoadDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WebFrameLoadDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebFrameLoadDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("webView:didCancelClientRedirectForFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CanceledClientRedirect(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didChangeLocationWithinPageForFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangedLocationWithinPage(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didClearWindowObject:forFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClearedWindowObject(WebView webView, WebScriptObject windowObject, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didCommitLoadForFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CommitedLoad(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didCreateJavaScriptContext:forFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCreateJavaScriptContext(WebView webView, JSContext context, WebFrame frame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didFailLoadWithError:forFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FailedLoadWithError(WebView sender, NSError error, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didFailProvisionalLoadWithError:forFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FailedProvisionalLoad(WebView sender, NSError error, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didFinishLoadForFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishedLoad(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didReceiveIcon:forFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedIcon(WebView sender, NSImage image, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didReceiveServerRedirectForProvisionalLoadForFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedServerRedirectForProvisionalLoad(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didReceiveTitle:forFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedTitle(WebView sender, string title, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didStartProvisionalLoadForFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartedProvisionalLoad(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:willCloseFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillCloseFrame(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:willPerformClientRedirectToURL:delay:fireDate:forFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillPerformClientRedirect(WebView sender, NSUrl toUrl, double secondsDelay, NSDate fireDate, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:windowScriptObjectAvailable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WindowScriptObjectAvailable(WebView webView, WebScriptObject windowScriptObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
