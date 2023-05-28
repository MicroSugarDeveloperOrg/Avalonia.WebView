using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilitySwitch_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AccessibilityPerformIncrement(this INSAccessibilitySwitch This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityPerformIncrement"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AccessibilityPerformDecrement(this INSAccessibilitySwitch This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityPerformDecrement"));
	}
}
