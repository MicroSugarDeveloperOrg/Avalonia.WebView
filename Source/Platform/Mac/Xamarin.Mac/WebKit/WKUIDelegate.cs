using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Protocol]
[Register("WKUIDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class WKUIDelegate : NSObject, IWKUIDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WKUIDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WKUIDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WKUIDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKWebView CreateWebView(WKWebView webView, WKWebViewConfiguration configuration, WKNavigationAction navigationAction, WKWindowFeatures windowFeatures)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webViewDidClose:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidClose(WKWebView webView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunJavaScriptAlertPanel(WKWebView webView, string message, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunJavaScriptConfirmPanel(WKWebView webView, string message, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunJavaScriptTextInputPanel(WKWebView webView, string prompt, string? defaultText, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDActionArity1V44))] Action<string> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:runOpenPanelWithParameters:initiatedByFrame:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunOpenPanel(WKWebView webView, WKOpenPanelParameters parameters, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDActionArity1V95))] Action<NSUrl[]> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
