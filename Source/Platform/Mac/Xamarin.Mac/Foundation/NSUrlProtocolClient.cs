using System;
using ObjCRuntime;

namespace Foundation;

public sealed class NSUrlProtocolClient : NSObject
{
	private const string selUrlProtocolWasRedirectedToRequestRedirectResponse_ = "URLProtocol:wasRedirectedToRequest:redirectResponse:";

	private const string selUrlProtocolCachedResponseIsValid_ = "URLProtocol:cachedResponseIsValid:";

	private const string selUrlProtocolDidReceiveResponseCacheStoragePolicy_ = "URLProtocol:didReceiveResponse:cacheStoragePolicy:";

	private const string selUrlProtocolDidLoadData_ = "URLProtocol:didLoadData:";

	private const string selUrlProtocolDidFinishLoading_ = "URLProtocolDidFinishLoading:";

	private const string selUrlProtocolDidFailWithError_ = "URLProtocol:didFailWithError:";

	private const string selUrlProtocolDidReceiveAuthenticationChallenge_ = "URLProtocol:didReceiveAuthenticationChallenge:";

	private const string selUrlProtocolDidCancelAuthenticationChallenge_ = "URLProtocol:didCancelAuthenticationChallenge:";

	public NSUrlProtocolClient(IntPtr handle)
		: base(handle)
	{
	}

	public void Redirected(NSUrlProtocol protocol, NSUrlRequest redirectedToEequest, NSUrlResponse redirectResponse)
	{
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:wasRedirectedToRequest:redirectResponse:"), protocol.Handle, redirectedToEequest.Handle, redirectResponse.Handle);
	}

	public void CachedResponseIsValid(NSUrlProtocol protocol, NSCachedUrlResponse cachedResponse)
	{
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:cachedResponseIsValid:"), protocol.Handle, cachedResponse.Handle);
	}

	public void ReceivedResponse(NSUrlProtocol protocol, NSUrlResponse response, NSUrlCacheStoragePolicy policy)
	{
		Messaging.void_objc_msgSend_intptr_intptr_nuint(base.Handle, Selector.GetHandle("URLProtocol:didReceiveResponse:cacheStoragePolicy:"), protocol.Handle, response.Handle, (ulong)policy);
	}

	public void DataLoaded(NSUrlProtocol protocol, NSData data)
	{
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:didLoadData:"), protocol.Handle, data.Handle);
	}

	public void FinishedLoading(NSUrlProtocol protocol)
	{
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("URLProtocolDidFinishLoading:"), protocol.Handle);
	}

	public void FailedWithError(NSUrlProtocol protocol, NSError error)
	{
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:didFailWithError:"), protocol.Handle, error.Handle);
	}

	public void ReceivedAuthenticationChallenge(NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge)
	{
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:didReceiveAuthenticationChallenge:"), protocol.Handle, challenge.Handle);
	}

	public void CancelledAuthenticationChallenge(NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge)
	{
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:didCancelAuthenticationChallenge:"), protocol.Handle, challenge.Handle);
	}
}
