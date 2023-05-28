using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibility_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetAccessibilityRequired(this INSAccessibility This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityRequired"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAccessibilityRequired(this INSAccessibility This, bool value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_bool(This.Handle, Selector.GetHandle("setAccessibilityRequired:"), value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAccessibilityElement[] GetAccessibilityChildrenInNavigationOrder(this INSAccessibility This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSAccessibilityElement>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityChildrenInNavigationOrder")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAccessibilityChildrenInNavigationOrder(this INSAccessibility This, NSAccessibilityElement[] value)
	{
		NSApplication.EnsureUIThread();
		NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setAccessibilityChildrenInNavigationOrder:"), nSArray?.Handle ?? IntPtr.Zero);
		nSArray?.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAccessibilityCustomRotor[] GetAccessibilityCustomRotors(this INSAccessibility This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSAccessibilityCustomRotor>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityCustomRotors")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAccessibilityCustomRotors(this INSAccessibility This, NSAccessibilityCustomRotor[] value)
	{
		NSApplication.EnsureUIThread();
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		NSArray nSArray = NSArray.FromNSObjects(value);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setAccessibilityCustomRotors:"), nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAccessibilityCustomAction[] GetAccessibilityCustomActions(this INSAccessibility This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSAccessibilityCustomAction>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityCustomActions")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAccessibilityCustomActions(this INSAccessibility This, NSAccessibilityCustomAction[] value)
	{
		NSApplication.EnsureUIThread();
		NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setAccessibilityCustomActions:"), nSArray?.Handle ?? IntPtr.Zero);
		nSArray?.Dispose();
	}
}
