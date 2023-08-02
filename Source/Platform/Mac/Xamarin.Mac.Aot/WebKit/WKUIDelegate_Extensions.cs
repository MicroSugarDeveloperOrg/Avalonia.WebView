using Foundation;
using ObjCRuntime;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Utiles;

namespace WebKit;

public static class WKUIDelegate_Extensions
{
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
        return Runtime.GetNSObjectTx<WKWebView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:"), webView.Handle, configuration.Handle, navigationAction.Handle, windowFeatures.Handle));
    }

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
        blockLiteral.SetupBlock(Trampolines.SDAction.Handler, completionHandler);
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:completionHandler:"), webView.Handle, intPtr, frame.Handle, (IntPtr)ptr);
        NSString.ReleaseNative(intPtr);
        ptr->CleanupBlock();
    }

    public unsafe static void RunJavaScriptConfirmPanel(this IWKUIDelegate This, WKWebView webView, string message, WKFrameInfo frame, [BlockProxy(typeof(Trampolines.NIDActionArity1V2))] Action<bool> completionHandler)
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
        blockLiteral.SetupBlock(Trampolines.SDActionArity1V2.Handler, completionHandler);
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:completionHandler:"), webView.Handle, intPtr, frame.Handle, (IntPtr)ptr);
        NSString.ReleaseNative(intPtr);
        ptr->CleanupBlock();
    }

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
        blockLiteral.SetupBlock(Trampolines.SDActionArity1V44.Handler, completionHandler);
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:completionHandler:"), webView.Handle, intPtr, intPtr2, frame.Handle, (IntPtr)ptr);
        NSString.ReleaseNative(intPtr);
        NSString.ReleaseNative(intPtr2);
        ptr->CleanupBlock();
    }

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
        blockLiteral.SetupBlock(Trampolines.SDActionArity1V95.Handler, completionHandler);
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:runOpenPanelWithParameters:initiatedByFrame:completionHandler:"), webView.Handle, parameters.Handle, frame.Handle, (IntPtr)ptr);
        ptr->CleanupBlock();
    }

    public static void DidClose(this IWKUIDelegate This, WKWebView webView)
    {
        if (webView == null)
        {
            throw new ArgumentNullException("webView");
        }
        Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewDidClose:"), webView.Handle);
    }
}
