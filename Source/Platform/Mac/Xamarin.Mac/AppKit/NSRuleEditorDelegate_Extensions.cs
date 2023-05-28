using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSRuleEditorDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EditingEnded(this INSRuleEditorDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("controlTextDidEndEditing:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Changed(this INSRuleEditorDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("controlTextDidChange:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EditingBegan(this INSRuleEditorDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("controlTextDidBeginEditing:"), notification.Handle);
	}
}
