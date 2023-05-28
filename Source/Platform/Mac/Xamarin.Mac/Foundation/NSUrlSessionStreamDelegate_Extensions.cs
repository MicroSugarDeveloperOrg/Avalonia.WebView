using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrlSessionStreamDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReadClosed(this INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (streamTask == null)
		{
			throw new ArgumentNullException("streamTask");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:readClosedForStreamTask:"), session.Handle, streamTask.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WriteClosed(this INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (streamTask == null)
		{
			throw new ArgumentNullException("streamTask");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:writeClosedForStreamTask:"), session.Handle, streamTask.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void BetterRouteDiscovered(this INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (streamTask == null)
		{
			throw new ArgumentNullException("streamTask");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:betterRouteDiscoveredForStreamTask:"), session.Handle, streamTask.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CompletedTaskCaptureStreams(this INSUrlSessionStreamDelegate This, NSUrlSession session, NSUrlSessionStreamTask streamTask, NSInputStream inputStream, NSOutputStream outputStream)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (streamTask == null)
		{
			throw new ArgumentNullException("streamTask");
		}
		if (inputStream == null)
		{
			throw new ArgumentNullException("inputStream");
		}
		if (outputStream == null)
		{
			throw new ArgumentNullException("outputStream");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:streamTask:didBecomeInputStream:outputStream:"), session.Handle, streamTask.Handle, inputStream.Handle, outputStream.Handle);
	}
}
