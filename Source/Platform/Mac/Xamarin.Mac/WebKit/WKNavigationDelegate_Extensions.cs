using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

public static class WKNavigationDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DecidePolicy(this IWKNavigationDelegate This, WKWebView webView, WKNavigationAction navigationAction, [BlockProxy(typeof(Trampolines.NIDActionArity1V93))] Action<WKNavigationActionPolicy> decisionHandler)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (navigationAction == null)
		{
			throw new ArgumentNullException("navigationAction");
		}
		if (decisionHandler == null)
		{
			throw new ArgumentNullException("decisionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V93.Handler, decisionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:decidePolicyForNavigationAction:decisionHandler:"), webView.Handle, navigationAction.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DecidePolicy(this IWKNavigationDelegate This, WKWebView webView, WKNavigationResponse navigationResponse, [BlockProxy(typeof(Trampolines.NIDActionArity1V94))] Action<WKNavigationResponsePolicy> decisionHandler)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (navigationResponse == null)
		{
			throw new ArgumentNullException("navigationResponse");
		}
		if (decisionHandler == null)
		{
			throw new ArgumentNullException("decisionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V94.Handler, decisionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:decidePolicyForNavigationResponse:decisionHandler:"), webView.Handle, navigationResponse.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DecidePolicy(this IWKNavigationDelegate This, WKWebView webView, WKNavigationAction navigationAction, WKWebpagePreferences preferences, [BlockProxy(typeof(Trampolines.NIDActionArity2V85))] Action<WKNavigationActionPolicy, WKWebpagePreferences> decisionHandler)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (navigationAction == null)
		{
			throw new ArgumentNullException("navigationAction");
		}
		if (preferences == null)
		{
			throw new ArgumentNullException("preferences");
		}
		if (decisionHandler == null)
		{
			throw new ArgumentNullException("decisionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V85.Handler, decisionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:decidePolicyForNavigationAction:preferences:decisionHandler:"), webView.Handle, navigationAction.Handle, preferences.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidStartProvisionalNavigation(this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (navigation == null)
		{
			throw new ArgumentNullException("navigation");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didStartProvisionalNavigation:"), webView.Handle, navigation.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidReceiveServerRedirectForProvisionalNavigation(this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (navigation == null)
		{
			throw new ArgumentNullException("navigation");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didReceiveServerRedirectForProvisionalNavigation:"), webView.Handle, navigation.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFailProvisionalNavigation(this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation, NSError error)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (navigation == null)
		{
			throw new ArgumentNullException("navigation");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didFailProvisionalNavigation:withError:"), webView.Handle, navigation.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCommitNavigation(this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (navigation == null)
		{
			throw new ArgumentNullException("navigation");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didCommitNavigation:"), webView.Handle, navigation.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishNavigation(this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (navigation == null)
		{
			throw new ArgumentNullException("navigation");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didFinishNavigation:"), webView.Handle, navigation.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFailNavigation(this IWKNavigationDelegate This, WKWebView webView, WKNavigation navigation, NSError error)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (navigation == null)
		{
			throw new ArgumentNullException("navigation");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didFailNavigation:withError:"), webView.Handle, navigation.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DidReceiveAuthenticationChallenge(this IWKNavigationDelegate This, WKWebView webView, NSUrlAuthenticationChallenge challenge, [BlockProxy(typeof(Trampolines.NIDActionArity2V44))] Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V44.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didReceiveAuthenticationChallenge:completionHandler:"), webView.Handle, challenge.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ContentProcessDidTerminate(this IWKNavigationDelegate This, WKWebView webView)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("webViewWebContentProcessDidTerminate:"), webView.Handle);
	}
}
