using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSDraggingInfo_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SlideDraggedImageTo(this INSDraggingInfo This, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_CGPoint(This.Handle, Selector.GetHandle("slideDraggedImageTo:"), screenPoint);
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use NSFilePromiseProvider objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] PromisedFilesDroppedAtDestination(this INSDraggingInfo This, NSUrl dropDestination)
	{
		NSApplication.EnsureUIThread();
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("namesOfPromisedFilesDroppedAtDestination:"), dropDestination.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void EnumerateDraggingItems(this INSDraggingInfo This, NSDraggingItemEnumerationOptions enumOpts, NSView view, IntPtr classArray, NSDictionary searchOptions, [BlockProxy(typeof(Trampolines.NIDNSDraggingEnumerator))] NSDraggingEnumerator enumerator)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (searchOptions == null)
		{
			throw new ArgumentNullException("searchOptions");
		}
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDraggingEnumerator.Handler, enumerator);
		Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:"), (ulong)enumOpts, view.Handle, classArray, searchOptions.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ResetSpringLoading(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("resetSpringLoading"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSWindow GetDraggingDestinationWindow(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("draggingDestinationWindow")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDragOperation GetDraggingSourceOperationMask(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return (NSDragOperation)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("draggingSourceOperationMask"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGPoint GetDraggingLocation(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGPoint_objc_msgSend(This.Handle, Selector.GetHandle("draggingLocation"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGPoint GetDraggedImageLocation(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGPoint_objc_msgSend(This.Handle, Selector.GetHandle("draggedImageLocation"));
	}

	[Advice("Use 'NSDraggingItem' objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImage GetDraggedImage(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("draggedImage")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPasteboard GetDraggingPasteboard(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSPasteboard>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("draggingPasteboard")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject GetDraggingSource(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("draggingSource")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetDraggingSequenceNumber(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nint_objc_msgSend(This.Handle, Selector.GetHandle("draggingSequenceNumber"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetAnimatesToDestination(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("animatesToDestination"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAnimatesToDestination(this INSDraggingInfo This, bool value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_bool(This.Handle, Selector.GetHandle("setAnimatesToDestination:"), value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetNumberOfValidItemsForDrop(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nint_objc_msgSend(This.Handle, Selector.GetHandle("numberOfValidItemsForDrop"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetNumberOfValidItemsForDrop(this INSDraggingInfo This, nint value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_nint(This.Handle, Selector.GetHandle("setNumberOfValidItemsForDrop:"), value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDraggingFormation GetDraggingFormation(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return (NSDraggingFormation)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("draggingFormation"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetDraggingFormation(this INSDraggingInfo This, NSDraggingFormation value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setDraggingFormation:"), (long)value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSpringLoadingHighlight GetSpringLoadingHighlight(this INSDraggingInfo This)
	{
		NSApplication.EnsureUIThread();
		return (NSSpringLoadingHighlight)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("springLoadingHighlight"));
	}
}
