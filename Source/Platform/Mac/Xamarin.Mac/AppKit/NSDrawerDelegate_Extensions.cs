using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSDrawerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawerDidClose(this INSDrawerDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("drawerDidClose:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawerDidOpen(this INSDrawerDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("drawerDidOpen:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool DrawerShouldClose(this INSDrawerDelegate This, NSDrawer sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("drawerShouldClose:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool DrawerShouldOpen(this INSDrawerDelegate This, NSDrawer sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("drawerShouldOpen:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawerWillClose(this INSDrawerDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("drawerWillClose:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawerWillOpen(this INSDrawerDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("drawerWillOpen:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize DrawerWillResizeContents(this INSDrawerDelegate This, NSDrawer sender, CGSize toSize)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.CGSize_objc_msgSend_IntPtr_CGSize(This.Handle, Selector.GetHandle("drawerWillResizeContents:toSize:"), sender.Handle, toSize);
	}
}
