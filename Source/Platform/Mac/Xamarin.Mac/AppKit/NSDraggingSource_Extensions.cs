using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSDraggingSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDragOperation DraggingSourceOperationMaskForLocal(this INSDraggingSource This, bool flag)
	{
		NSApplication.EnsureUIThread();
		return (NSDragOperation)Messaging.UInt64_objc_msgSend_bool(This.Handle, Selector.GetHandle("draggingSourceOperationMaskForLocal:"), flag);
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use NSFilePromiseProvider objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] NamesOfPromisedFilesDroppedAtDestination(this INSDraggingSource This, NSUrl dropDestination)
	{
		NSApplication.EnsureUIThread();
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("namesOfPromisedFilesDroppedAtDestination:"), dropDestination.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggedImageBeganAt(this INSDraggingSource This, NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		Messaging.void_objc_msgSend_IntPtr_CGPoint(This.Handle, Selector.GetHandle("draggedImage:beganAt:"), image.Handle, screenPoint);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggedImageEndedAtOperation(this INSDraggingSource This, NSImage image, CGPoint screenPoint, NSDragOperation operation)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		Messaging.void_objc_msgSend_IntPtr_CGPoint_UInt64(This.Handle, Selector.GetHandle("draggedImage:endedAt:operation:"), image.Handle, screenPoint, (ulong)operation);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggedImageMovedTo(this INSDraggingSource This, NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		Messaging.void_objc_msgSend_IntPtr_CGPoint(This.Handle, Selector.GetHandle("draggedImage:movedTo:"), image.Handle, screenPoint);
	}

	[Deprecated(PlatformName.MacOSX, 10, 1, PlatformArchitecture.All, "Use DraggedImageEndedAtOperation instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggedImageEndedAtDeposited(this INSDraggingSource This, NSImage image, CGPoint screenPoint, bool deposited)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		Messaging.void_objc_msgSend_IntPtr_CGPoint_bool(This.Handle, Selector.GetHandle("draggedImage:endedAt:deposited:"), image.Handle, screenPoint, deposited);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetIgnoreModifierKeysWhileDragging(this INSDraggingSource This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("ignoreModifierKeysWhileDragging"));
	}
}
