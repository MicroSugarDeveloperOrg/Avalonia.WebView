using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSMenuDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void NeedsUpdate(this INSMenuDelegate This, NSMenu menu)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("menuNeedsUpdate:"), menu.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint MenuItemCount(this INSMenuDelegate This, NSMenu menu)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		return Messaging.nint_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("numberOfItemsInMenu:"), menu.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UpdateItem(this INSMenuDelegate This, NSMenu menu, NSMenuItem item, nint atIndex, bool shouldCancel)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint_bool(This.Handle, Selector.GetHandle("menu:updateItem:atIndex:shouldCancel:"), menu.Handle, item.Handle, atIndex, shouldCancel);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool HasKeyEquivalentForEvent(this INSMenuDelegate This, NSMenu menu, NSEvent theEvent, NSObject target, Selector action)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("menuHasKeyEquivalent:forEvent:target:action:"), menu.Handle, theEvent.Handle, target.Handle, action.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MenuWillOpen(this INSMenuDelegate This, NSMenu menu)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("menuWillOpen:"), menu.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MenuDidClose(this INSMenuDelegate This, NSMenu menu)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("menuDidClose:"), menu.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect ConfinementRectForMenu(this INSMenuDelegate This, NSMenu menu, NSScreen screen)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (screen == null)
		{
			throw new ArgumentNullException("screen");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr_IntPtr(out var retval, This.Handle, Selector.GetHandle("confinementRectForMenu:onScreen:"), menu.Handle, screen.Handle);
		return retval;
	}
}
