using CoreGraphics;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilityLayoutItem_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAccessibilityFrame(this INSAccessibilityLayoutItem This, CGRect frame)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_CGRect(This.Handle, Selector.GetHandle("setAccessibilityFrame:"), frame);
	}
}
