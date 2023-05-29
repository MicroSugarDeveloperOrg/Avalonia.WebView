using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebResourceLoadDelegate", true)]
[Model]
public class WebResourceLoadDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebResourceLoadDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WebResourceLoadDelegate(NSCoder coder)
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
	public WebResourceLoadDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebResourceLoadDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("webView:identifierForInitialRequest:fromDataSource:")]
	public virtual NSObject OnIdentifierForInitialRequest(WebView sender, NSUrlRequest request, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:willSendRequest:redirectResponse:fromDataSource:")]
	public virtual NSUrlRequest OnSendRequest(WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:didReceiveAuthenticationChallenge:fromDataSource:")]
	public virtual void OnReceivedAuthenticationChallenge(WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:didCancelAuthenticationChallenge:fromDataSource:")]
	public virtual void OnCancelledAuthenticationChallenge(WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:didReceiveResponse:fromDataSource:")]
	public virtual void OnReceivedResponse(WebView sender, NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:didReceiveContentLength:fromDataSource:")]
	public virtual void OnReceivedContentLength(WebView sender, NSObject identifier, int length, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:didFinishLoadingFromDataSource:")]
	public virtual void OnFinishedLoading(WebView sender, NSObject identifier, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:resource:didFailLoadingWithError:fromDataSource:")]
	public virtual void OnFailedLoading(WebView sender, NSObject identifier, NSError withError, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:plugInFailedWithError:dataSource:")]
	public virtual void OnPlugInFailed(WebView sender, NSError error, WebDataSource dataSource)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
