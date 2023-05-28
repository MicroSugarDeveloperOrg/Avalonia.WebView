using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrlConnectionDataDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlRequest WillSendRequest(this INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSUrlRequest request, NSUrlResponse response)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:willSendRequest:redirectResponse:"), connection.Handle, request.Handle, response.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedResponse(this INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSUrlResponse response)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:didReceiveResponse:"), connection.Handle, response.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedData(this INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSData data)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:didReceiveData:"), connection.Handle, data.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSInputStream NeedNewBodyStream(this INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSUrlRequest request)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return Runtime.GetNSObject<NSInputStream>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:needNewBodyStream:"), connection.Handle, request.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SentBodyData(this INSUrlConnectionDataDelegate This, NSUrlConnection connection, nint bytesWritten, nint totalBytesWritten, nint totalBytesExpectedToWrite)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		Messaging.void_objc_msgSend_IntPtr_nint_nint_nint(This.Handle, Selector.GetHandle("connection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:"), connection.Handle, bytesWritten, totalBytesWritten, totalBytesExpectedToWrite);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCachedUrlResponse WillCacheResponse(this INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSCachedUrlResponse cachedResponse)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (cachedResponse == null)
		{
			throw new ArgumentNullException("cachedResponse");
		}
		return Runtime.GetNSObject<NSCachedUrlResponse>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:willCacheResponse:"), connection.Handle, cachedResponse.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FinishedLoading(this INSUrlConnectionDataDelegate This, NSUrlConnection connection)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("connectionDidFinishLoading:"), connection.Handle);
	}
}
