using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUrlProtocolClientWrapper : BaseWrapper, INSUrlProtocolClient, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSUrlProtocolClientWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("URLProtocol:wasRedirectedToRequest:redirectResponse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Redirected(NSUrlProtocol protocol, NSUrlRequest redirectedToEequest, NSUrlResponse redirectResponse)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (redirectedToEequest == null)
		{
			throw new ArgumentNullException("redirectedToEequest");
		}
		if (redirectResponse == null)
		{
			throw new ArgumentNullException("redirectResponse");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:wasRedirectedToRequest:redirectResponse:"), protocol.Handle, redirectedToEequest.Handle, redirectResponse.Handle);
	}

	[Export("URLProtocol:cachedResponseIsValid:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CachedResponseIsValid(NSUrlProtocol protocol, NSCachedUrlResponse cachedResponse)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (cachedResponse == null)
		{
			throw new ArgumentNullException("cachedResponse");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:cachedResponseIsValid:"), protocol.Handle, cachedResponse.Handle);
	}

	[Export("URLProtocol:didReceiveResponse:cacheStoragePolicy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ReceivedResponse(NSUrlProtocol protocol, NSUrlResponse response, NSUrlCacheStoragePolicy policy)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, Selector.GetHandle("URLProtocol:didReceiveResponse:cacheStoragePolicy:"), protocol.Handle, response.Handle, (ulong)policy);
	}

	[Export("URLProtocol:didLoadData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DataLoaded(NSUrlProtocol protocol, NSData data)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:didLoadData:"), protocol.Handle, data.Handle);
	}

	[Export("URLProtocolDidFinishLoading:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FinishedLoading(NSUrlProtocol protocol)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("URLProtocolDidFinishLoading:"), protocol.Handle);
	}

	[Export("URLProtocol:didFailWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FailedWithError(NSUrlProtocol protocol, NSError error)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:didFailWithError:"), protocol.Handle, error.Handle);
	}

	[Export("URLProtocol:didReceiveAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ReceivedAuthenticationChallenge(NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:didReceiveAuthenticationChallenge:"), protocol.Handle, challenge.Handle);
	}

	[Export("URLProtocol:didCancelAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CancelledAuthenticationChallenge(NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLProtocol:didCancelAuthenticationChallenge:"), protocol.Handle, challenge.Handle);
	}
}
