using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrlSessionDataDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DidReceiveResponse(this INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlResponse response, [BlockProxy(typeof(Trampolines.NIDActionArity1V39))] Action<NSUrlSessionResponseDisposition> completionHandler)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (dataTask == null)
		{
			throw new ArgumentNullException("dataTask");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V39.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:dataTask:didReceiveResponse:completionHandler:"), session.Handle, dataTask.Handle, response.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBecomeDownloadTask(this INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionDownloadTask downloadTask)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (dataTask == null)
		{
			throw new ArgumentNullException("dataTask");
		}
		if (downloadTask == null)
		{
			throw new ArgumentNullException("downloadTask");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:dataTask:didBecomeDownloadTask:"), session.Handle, dataTask.Handle, downloadTask.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidReceiveData(this INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSData data)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (dataTask == null)
		{
			throw new ArgumentNullException("dataTask");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:dataTask:didReceiveData:"), session.Handle, dataTask.Handle, data.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void WillCacheResponse(this INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSCachedUrlResponse proposedResponse, [BlockProxy(typeof(Trampolines.NIDActionArity1V36))] Action<NSCachedUrlResponse> completionHandler)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (dataTask == null)
		{
			throw new ArgumentNullException("dataTask");
		}
		if (proposedResponse == null)
		{
			throw new ArgumentNullException("proposedResponse");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V36.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:dataTask:willCacheResponse:completionHandler:"), session.Handle, dataTask.Handle, proposedResponse.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBecomeStreamTask(this INSUrlSessionDataDelegate This, NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionStreamTask streamTask)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (dataTask == null)
		{
			throw new ArgumentNullException("dataTask");
		}
		if (streamTask == null)
		{
			throw new ArgumentNullException("streamTask");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:dataTask:didBecomeStreamTask:"), session.Handle, dataTask.Handle, streamTask.Handle);
	}
}
