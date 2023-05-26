using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrlSessionTaskDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void WillPerformHttpRedirection(this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response, NSUrlRequest newRequest, [BlockProxy(typeof(Trampolines.NIDActionArity1V40))] Action<NSUrlRequest> completionHandler)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (newRequest == null)
		{
			throw new ArgumentNullException("newRequest");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V40.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:task:willPerformHTTPRedirection:newRequest:completionHandler:"), session.Handle, task.Handle, response.Handle, newRequest.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DidReceiveChallenge(this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSUrlAuthenticationChallenge challenge, [BlockProxy(typeof(Trampolines.NIDActionArity2V44))] Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:task:didReceiveChallenge:completionHandler:"), session.Handle, task.Handle, challenge.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void NeedNewBodyStream(this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, [BlockProxy(typeof(Trampolines.NIDActionArity1V41))] Action<NSInputStream> completionHandler)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V41.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:task:needNewBodyStream:"), session.Handle, task.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidSendBodyData(this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, long bytesSent, long totalBytesSent, long totalBytesExpectedToSend)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64_Int64_Int64(This.Handle, Selector.GetHandle("URLSession:task:didSendBodyData:totalBytesSent:totalBytesExpectedToSend:"), session.Handle, task.Handle, bytesSent, totalBytesSent, totalBytesExpectedToSend);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCompleteWithError(this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSError error)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:task:didCompleteWithError:"), session.Handle, task.Handle, error.Handle);
	}

	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishCollectingMetrics(this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSUrlSessionTaskMetrics metrics)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		if (metrics == null)
		{
			throw new ArgumentNullException("metrics");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:task:didFinishCollectingMetrics:"), session.Handle, task.Handle, metrics.Handle);
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void WillBeginDelayedRequest(this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task, NSUrlRequest request, [BlockProxy(typeof(Trampolines.NIDActionArity2V45))] Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest> completionHandler)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V45.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:task:willBeginDelayedRequest:completionHandler:"), session.Handle, task.Handle, request.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void TaskIsWaitingForConnectivity(this INSUrlSessionTaskDelegate This, NSUrlSession session, NSUrlSessionTask task)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:taskIsWaitingForConnectivity:"), session.Handle, task.Handle);
	}
}
