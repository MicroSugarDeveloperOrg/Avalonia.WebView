using System;
using ObjCRuntime;

namespace AppKit;

public static class NSPathControlDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldDragPathComponentCell(this INSPathControlDelegate This, NSPathControl pathControl, NSPathComponentCell pathComponentCell, NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pathControl == null)
		{
			throw new ArgumentNullException("pathControl");
		}
		if (pathComponentCell == null)
		{
			throw new ArgumentNullException("pathComponentCell");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pathControl:shouldDragPathComponentCell:withPasteboard:"), pathControl.Handle, pathComponentCell.Handle, pasteboard.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDragOperation ValidateDrop(this INSPathControlDelegate This, NSPathControl pathControl, NSDraggingInfo info)
	{
		NSApplication.EnsureUIThread();
		if (pathControl == null)
		{
			throw new ArgumentNullException("pathControl");
		}
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pathControl:validateDrop:"), pathControl.Handle, info.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AcceptDrop(this INSPathControlDelegate This, NSPathControl pathControl, NSDraggingInfo info)
	{
		NSApplication.EnsureUIThread();
		if (pathControl == null)
		{
			throw new ArgumentNullException("pathControl");
		}
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pathControl:acceptDrop:"), pathControl.Handle, info.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillDisplayOpenPanel(this INSPathControlDelegate This, NSPathControl pathControl, NSOpenPanel openPanel)
	{
		NSApplication.EnsureUIThread();
		if (pathControl == null)
		{
			throw new ArgumentNullException("pathControl");
		}
		if (openPanel == null)
		{
			throw new ArgumentNullException("openPanel");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pathControl:willDisplayOpenPanel:"), pathControl.Handle, openPanel.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillPopUpMenu(this INSPathControlDelegate This, NSPathControl pathControl, NSMenu menu)
	{
		NSApplication.EnsureUIThread();
		if (pathControl == null)
		{
			throw new ArgumentNullException("pathControl");
		}
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pathControl:willPopUpMenu:"), pathControl.Handle, menu.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldDragItem(this INSPathControlDelegate This, NSPathControl pathControl, NSPathControlItem pathItem, NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pathControl == null)
		{
			throw new ArgumentNullException("pathControl");
		}
		if (pathItem == null)
		{
			throw new ArgumentNullException("pathItem");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pathControl:shouldDragItem:withPasteboard:"), pathControl.Handle, pathItem.Handle, pasteboard.Handle);
	}
}
