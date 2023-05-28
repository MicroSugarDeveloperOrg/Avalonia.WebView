using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilityElementProtocol_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetAccessibilityFocused(this INSAccessibilityElementProtocol This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isAccessibilityFocused"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetAccessibilityIdentifier(this INSAccessibilityElementProtocol This)
	{
		NSApplication.EnsureUIThread();
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityIdentifier")));
	}
}
