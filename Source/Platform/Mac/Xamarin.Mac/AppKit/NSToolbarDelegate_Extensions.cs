using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSToolbarDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSToolbarItem WillInsertItem(this INSToolbarDelegate This, NSToolbar toolbar, string itemIdentifier, bool willBeInserted)
	{
		NSApplication.EnsureUIThread();
		if (toolbar == null)
		{
			throw new ArgumentNullException("toolbar");
		}
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		IntPtr intPtr = NSString.CreateNative(itemIdentifier);
		NSToolbarItem nSObject = Runtime.GetNSObject<NSToolbarItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(This.Handle, Selector.GetHandle("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:"), toolbar.Handle, intPtr, willBeInserted));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] DefaultItemIdentifiers(this INSToolbarDelegate This, NSToolbar toolbar)
	{
		NSApplication.EnsureUIThread();
		if (toolbar == null)
		{
			throw new ArgumentNullException("toolbar");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("toolbarDefaultItemIdentifiers:"), toolbar.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] AllowedItemIdentifiers(this INSToolbarDelegate This, NSToolbar toolbar)
	{
		NSApplication.EnsureUIThread();
		if (toolbar == null)
		{
			throw new ArgumentNullException("toolbar");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("toolbarAllowedItemIdentifiers:"), toolbar.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] SelectableItemIdentifiers(this INSToolbarDelegate This, NSToolbar toolbar)
	{
		NSApplication.EnsureUIThread();
		if (toolbar == null)
		{
			throw new ArgumentNullException("toolbar");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("toolbarSelectableItemIdentifiers:"), toolbar.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillAddItem(this INSToolbarDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("toolbarWillAddItem:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidRemoveItem(this INSToolbarDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("toolbarDidRemoveItem:"), notification.Handle);
	}
}
