using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSScrubberDelegate_Extensions
{
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidSelectItem(this INSScrubberDelegate This, NSScrubber scrubber, nint selectedIndex)
	{
		NSApplication.EnsureUIThread();
		if (scrubber == null)
		{
			throw new ArgumentNullException("scrubber");
		}
		Messaging.void_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("scrubber:didSelectItemAtIndex:"), scrubber.Handle, selectedIndex);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidHighlightItem(this INSScrubberDelegate This, NSScrubber scrubber, nint highlightedIndex)
	{
		NSApplication.EnsureUIThread();
		if (scrubber == null)
		{
			throw new ArgumentNullException("scrubber");
		}
		Messaging.void_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("scrubber:didHighlightItemAtIndex:"), scrubber.Handle, highlightedIndex);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeVisible(this INSScrubberDelegate This, NSScrubber scrubber, NSRange visibleRange)
	{
		NSApplication.EnsureUIThread();
		if (scrubber == null)
		{
			throw new ArgumentNullException("scrubber");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange(This.Handle, Selector.GetHandle("scrubber:didChangeVisibleRange:"), scrubber.Handle, visibleRange);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBeginInteracting(this INSScrubberDelegate This, NSScrubber scrubber)
	{
		NSApplication.EnsureUIThread();
		if (scrubber == null)
		{
			throw new ArgumentNullException("scrubber");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("didBeginInteractingWithScrubber:"), scrubber.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishInteracting(this INSScrubberDelegate This, NSScrubber scrubber)
	{
		NSApplication.EnsureUIThread();
		if (scrubber == null)
		{
			throw new ArgumentNullException("scrubber");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("didFinishInteractingWithScrubber:"), scrubber.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCancelInteracting(this INSScrubberDelegate This, NSScrubber scrubber)
	{
		NSApplication.EnsureUIThread();
		if (scrubber == null)
		{
			throw new ArgumentNullException("scrubber");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("didCancelInteractingWithScrubber:"), scrubber.Handle);
	}
}
