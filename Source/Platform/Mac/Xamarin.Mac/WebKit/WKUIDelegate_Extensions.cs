using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

public static class WKUIDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static WKWebView CreateWebView(this IWKUIDelegate This, WKWebView webView, WKWebViewConfiguration configuration, WKNavigationAction navigationAction, WKWindowFeatures windowFeatures)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		if (navigationAction == null)
		{
			throw new ArgumentNullException("navigationAction");
		}
		if (windowFeatures == null)
		{
			throw new ArgumentNullException("windowFeatures");
		}
		return Runtime.GetNSObject<WKWebView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:"), webView.Handle, configuration.Handle, navigationAction.Handle, windowFeatures.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RunJavaScriptAlertPanel(this IWKUIDelegate This, WKWebView webView, string message, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (frame == null)
		{
			throw new ArgumentNullException("frame");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr intPtr = NSString.CreateNative(message);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:completionHandler:"), webView.Handle, intPtr, frame.Handle, (IntPtr)ptr);
		NSString.ReleaseNative(intPtr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RunJavaScriptConfirmPanel(this IWKUIDelegate This, WKWebView webView, string message, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> completionHandler)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (frame == null)
		{
			throw new ArgumentNullException("frame");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr intPtr = NSString.CreateNative(message);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:completionHandler:"), webView.Handle, intPtr, frame.Handle, (IntPtr)ptr);
		NSString.ReleaseNative(intPtr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RunJavaScriptTextInputPanel(this IWKUIDelegate This, WKWebView webView, string prompt, string? defaultText, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDActionArity1V44))] Action<string> completionHandler)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (prompt == null)
		{
			throw new ArgumentNullException("prompt");
		}
		if (frame == null)
		{
			throw new ArgumentNullException("frame");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr intPtr = NSString.CreateNative(prompt);
		IntPtr intPtr2 = NSString.CreateNative(defaultText);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V44.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:completionHandler:"), webView.Handle, intPtr, intPtr2, frame.Handle, (IntPtr)ptr);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RunOpenPanel(this IWKUIDelegate This, WKWebView webView, WKOpenPanelParameters parameters, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDActionArity1V95))] Action<NSUrl[]> completionHandler)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		if (frame == null)
		{
			throw new ArgumentNullException("frame");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V95.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runOpenPanelWithParameters:initiatedByFrame:completionHandler:"), webView.Handle, parameters.Handle, frame.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidClose(this IWKUIDelegate This, WKWebView webView)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewDidClose:"), webView.Handle);
	}
}
