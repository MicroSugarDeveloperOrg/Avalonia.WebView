using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSAccessibilityRow_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetAccessibilityDisclosureLevel(this INSAccessibilityRow This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nint_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityDisclosureLevel"));
	}
}
