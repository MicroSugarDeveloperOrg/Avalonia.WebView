using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Protocol]
[Register("WKNavigationDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class WKNavigationDelegate : NSObject, IWKNavigationDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WKNavigationDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WKNavigationDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WKNavigationDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("webViewWebContentProcessDidTerminate:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ContentProcessDidTerminate(WKWebView webView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:decidePolicyForNavigationAction:decisionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DecidePolicy(WKWebView webView, WKNavigationAction navigationAction, [BlockProxy(typeof(Trampolines.NIDActionArity1V93))] Action<WKNavigationActionPolicy> decisionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:decidePolicyForNavigationResponse:decisionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DecidePolicy(WKWebView webView, WKNavigationResponse navigationResponse, [BlockProxy(typeof(Trampolines.NIDActionArity1V94))] Action<WKNavigationResponsePolicy> decisionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:decidePolicyForNavigationAction:preferences:decisionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DecidePolicy(WKWebView webView, WKNavigationAction navigationAction, WKWebpagePreferences preferences, [BlockProxy(typeof(Trampolines.NIDActionArity2V85))] Action<WKNavigationActionPolicy, WKWebpagePreferences> decisionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didCommitNavigation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCommitNavigation(WKWebView webView, WKNavigation navigation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didFailNavigation:withError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFailNavigation(WKWebView webView, WKNavigation navigation, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didFailProvisionalNavigation:withError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFailProvisionalNavigation(WKWebView webView, WKNavigation navigation, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didFinishNavigation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishNavigation(WKWebView webView, WKNavigation navigation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didReceiveAuthenticationChallenge:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveAuthenticationChallenge(WKWebView webView, NSUrlAuthenticationChallenge challenge, [BlockProxy(typeof(Trampolines.NIDActionArity2V44))] Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didReceiveServerRedirectForProvisionalNavigation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveServerRedirectForProvisionalNavigation(WKWebView webView, WKNavigation navigation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didStartProvisionalNavigation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidStartProvisionalNavigation(WKWebView webView, WKNavigation navigation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
