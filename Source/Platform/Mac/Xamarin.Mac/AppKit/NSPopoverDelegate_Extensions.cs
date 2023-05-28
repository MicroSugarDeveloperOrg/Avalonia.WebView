using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSPopoverDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldClose(this INSPopoverDelegate This, NSPopover popover)
	{
		NSApplication.EnsureUIThread();
		if (popover == null)
		{
			throw new ArgumentNullException("popover");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("popoverShouldClose:"), popover.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSWindow GetDetachableWindowForPopover(this INSPopoverDelegate This, NSPopover popover)
	{
		NSApplication.EnsureUIThread();
		if (popover == null)
		{
			throw new ArgumentNullException("popover");
		}
		return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("detachableWindowForPopover:"), popover.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillShow(this INSPopoverDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("popoverWillShow:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidShow(this INSPopoverDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("popoverDidShow:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillClose(this INSPopoverDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("popoverWillClose:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidClose(this INSPopoverDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("popoverDidClose:"), notification.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDetach(this INSPopoverDelegate This, NSPopover popover)
	{
		NSApplication.EnsureUIThread();
		if (popover == null)
		{
			throw new ArgumentNullException("popover");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("popoverDidDetach:"), popover.Handle);
	}
}
