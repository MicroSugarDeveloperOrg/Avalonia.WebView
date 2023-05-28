using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilityTable_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSAccessibilityRow[] GetAccessibilitySelectedRows(this INSAccessibilityTable This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilitySelectedRows")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAccessibilitySelectedRows(this INSAccessibilityTable This, INSAccessibilityRow[] value)
	{
		NSApplication.EnsureUIThread();
		NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setAccessibilitySelectedRows:"), nSArray?.Handle ?? IntPtr.Zero);
		nSArray?.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSAccessibilityRow[] GetAccessibilityVisibleRows(this INSAccessibilityTable This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityVisibleRows")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[] GetAccessibilityColumns(this INSAccessibilityTable This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityColumns")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[] GetAccessibilityVisibleColumns(this INSAccessibilityTable This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityVisibleColumns")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[] GetAccessibilitySelectedColumns(this INSAccessibilityTable This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilitySelectedColumns")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetAccessibilityHeaderGroup(this INSAccessibilityTable This)
	{
		NSApplication.EnsureUIThread();
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityHeaderGroup")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[] GetAccessibilitySelectedCells(this INSAccessibilityTable This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilitySelectedCells")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[] GetAccessibilityVisibleCells(this INSAccessibilityTable This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityVisibleCells")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[] GetAccessibilityRowHeaderUIElements(this INSAccessibilityTable This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityRowHeaderUIElements")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[] GetAccessibilityColumnHeaderUIElements(this INSAccessibilityTable This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityColumnHeaderUIElements")));
	}
}
