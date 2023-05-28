using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace WebKit;

[Protocol]
[Register("WebResourceLoadDelegate", false)]
[Model]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class WebResourceLoadDelegate : NSObject, IWebResourceLoadDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebResourceLoadDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WebResourceLoadDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WebResourceLoadDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("webView:resource:didCancelAuthenticationChallenge:fromDataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OnCancelledAuthenticationChallenge(WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:didFailLoadingWithError:fromDataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OnFailedLoading(WebView sender, NSObject identifier, NSError withError, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:didFinishLoadingFromDataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OnFinishedLoading(WebView sender, NSObject identifier, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:identifierForInitialRequest:fromDataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject OnIdentifierForInitialRequest(WebView sender, NSUrlRequest request, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:plugInFailedWithError:dataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OnPlugInFailed(WebView sender, NSError error, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:didReceiveAuthenticationChallenge:fromDataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OnReceivedAuthenticationChallenge(WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:didReceiveContentLength:fromDataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OnReceivedContentLength(WebView sender, NSObject identifier, nint length, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:didReceiveResponse:fromDataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OnReceivedResponse(WebView sender, NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:willSendRequest:redirectResponse:fromDataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlRequest OnSendRequest(WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
