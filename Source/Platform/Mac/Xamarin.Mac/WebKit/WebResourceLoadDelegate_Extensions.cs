using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace WebKit;

public static class WebResourceLoadDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject OnIdentifierForInitialRequest(this IWebResourceLoadDelegate This, WebView sender, NSUrlRequest request, WebDataSource dataSource)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:identifierForInitialRequest:fromDataSource:"), sender.Handle, request.Handle, dataSource.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlRequest OnSendRequest(this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebDataSource dataSource)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (redirectResponse == null)
		{
			throw new ArgumentNullException("redirectResponse");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:resource:willSendRequest:redirectResponse:fromDataSource:"), sender.Handle, identifier.Handle, request.Handle, redirectResponse.Handle, dataSource.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OnReceivedAuthenticationChallenge(this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:resource:didReceiveAuthenticationChallenge:fromDataSource:"), sender.Handle, identifier.Handle, challenge.Handle, dataSource.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OnCancelledAuthenticationChallenge(this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:resource:didCancelAuthenticationChallenge:fromDataSource:"), sender.Handle, identifier.Handle, challenge.Handle, dataSource.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OnReceivedResponse(this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (responseReceived == null)
		{
			throw new ArgumentNullException("responseReceived");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:resource:didReceiveResponse:fromDataSource:"), sender.Handle, identifier.Handle, responseReceived.Handle, dataSource.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OnReceivedContentLength(this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, nint length, WebDataSource dataSource)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_nint_IntPtr(This.Handle, Selector.GetHandle("webView:resource:didReceiveContentLength:fromDataSource:"), sender.Handle, identifier.Handle, length, dataSource.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OnFinishedLoading(this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, WebDataSource dataSource)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:resource:didFinishLoadingFromDataSource:"), sender.Handle, identifier.Handle, dataSource.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OnFailedLoading(this IWebResourceLoadDelegate This, WebView sender, NSObject identifier, NSError withError, WebDataSource dataSource)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (withError == null)
		{
			throw new ArgumentNullException("withError");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:resource:didFailLoadingWithError:fromDataSource:"), sender.Handle, identifier.Handle, withError.Handle, dataSource.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OnPlugInFailed(this IWebResourceLoadDelegate This, WebView sender, NSError error, WebDataSource dataSource)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:plugInFailedWithError:dataSource:"), sender.Handle, error.Handle, dataSource.Handle);
	}
}
