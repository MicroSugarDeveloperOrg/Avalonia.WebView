using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSTextDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool TextShouldBeginEditing(this INSTextDelegate This, NSText textObject)
	{
		NSApplication.EnsureUIThread();
		if (textObject == null)
		{
			throw new ArgumentNullException("textObject");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("textShouldBeginEditing:"), textObject.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool TextShouldEndEditing(this INSTextDelegate This, NSText textObject)
	{
		NSApplication.EnsureUIThread();
		if (textObject == null)
		{
			throw new ArgumentNullException("textObject");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("textShouldEndEditing:"), textObject.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void TextDidBeginEditing(this INSTextDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("textDidBeginEditing:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void TextDidEndEditing(this INSTextDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("textDidEndEditing:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void TextDidChange(this INSTextDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("textDidChange:"), notification.Handle);
	}
}
