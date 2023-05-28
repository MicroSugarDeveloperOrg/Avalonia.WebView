using System;
using ObjCRuntime;

namespace AppKit;

public static class NSSpringLoadingDestination_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSpringLoadingOptions Entered(this INSSpringLoadingDestination This, NSDraggingInfo draggingInfo)
	{
		NSApplication.EnsureUIThread();
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		return (NSSpringLoadingOptions)Messaging.UInt64_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("springLoadingEntered:"), draggingInfo.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSpringLoadingOptions Updated(this INSSpringLoadingDestination This, NSDraggingInfo draggingInfo)
	{
		NSApplication.EnsureUIThread();
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		return (NSSpringLoadingOptions)Messaging.UInt64_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("springLoadingUpdated:"), draggingInfo.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Exited(this INSSpringLoadingDestination This, NSDraggingInfo draggingInfo)
	{
		NSApplication.EnsureUIThread();
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("springLoadingExited:"), draggingInfo.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggingEnded(this INSSpringLoadingDestination This, NSDraggingInfo draggingInfo)
	{
		NSApplication.EnsureUIThread();
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("draggingEnded:"), draggingInfo.Handle);
	}
}
