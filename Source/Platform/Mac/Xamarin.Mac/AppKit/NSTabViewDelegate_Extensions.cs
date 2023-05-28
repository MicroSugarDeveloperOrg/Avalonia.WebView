using System;
using ObjCRuntime;

namespace AppKit;

public static class NSTabViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldSelectTabViewItem(this INSTabViewDelegate This, NSTabView tabView, NSTabViewItem item)
	{
		NSApplication.EnsureUIThread();
		if (tabView == null)
		{
			throw new ArgumentNullException("tabView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tabView:shouldSelectTabViewItem:"), tabView.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillSelect(this INSTabViewDelegate This, NSTabView tabView, NSTabViewItem item)
	{
		NSApplication.EnsureUIThread();
		if (tabView == null)
		{
			throw new ArgumentNullException("tabView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tabView:willSelectTabViewItem:"), tabView.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidSelect(this INSTabViewDelegate This, NSTabView tabView, NSTabViewItem item)
	{
		NSApplication.EnsureUIThread();
		if (tabView == null)
		{
			throw new ArgumentNullException("tabView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tabView:didSelectTabViewItem:"), tabView.Handle, item.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void NumberOfItemsChanged(this INSTabViewDelegate This, NSTabView tabView)
	{
		NSApplication.EnsureUIThread();
		if (tabView == null)
		{
			throw new ArgumentNullException("tabView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("tabViewDidChangeNumberOfTabViewItems:"), tabView.Handle);
	}
}
