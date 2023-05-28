using System;
using ObjCRuntime;

namespace AppKit;

public static class NSPathCellDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillDisplayOpenPanel(this INSPathCellDelegate This, NSPathCell pathCell, NSOpenPanel openPanel)
	{
		NSApplication.EnsureUIThread();
		if (pathCell == null)
		{
			throw new ArgumentNullException("pathCell");
		}
		if (openPanel == null)
		{
			throw new ArgumentNullException("openPanel");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pathCell:willDisplayOpenPanel:"), pathCell.Handle, openPanel.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillPopupMenu(this INSPathCellDelegate This, NSPathCell pathCell, NSMenu menu)
	{
		NSApplication.EnsureUIThread();
		if (pathCell == null)
		{
			throw new ArgumentNullException("pathCell");
		}
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pathCell:willPopUpMenu:"), pathCell.Handle, menu.Handle);
	}
}
