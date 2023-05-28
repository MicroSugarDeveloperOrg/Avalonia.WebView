using System;
using ObjCRuntime;

namespace AppKit;

public static class NSDraggingDestination_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDragOperation DraggingEntered(this INSDraggingDestination This, NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("draggingEntered:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDragOperation DraggingUpdated(this INSDraggingDestination This, NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("draggingUpdated:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggingExited(this INSDraggingDestination This, NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("draggingExited:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool PrepareForDragOperation(this INSDraggingDestination This, NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("prepareForDragOperation:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool PerformDragOperation(this INSDraggingDestination This, NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("performDragOperation:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ConcludeDragOperation(this INSDraggingDestination This, NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("concludeDragOperation:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggingEnded(this INSDraggingDestination This, NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("draggingEnded:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetWantsPeriodicDraggingUpdates(this INSDraggingDestination This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("wantsPeriodicDraggingUpdates"));
	}
}
