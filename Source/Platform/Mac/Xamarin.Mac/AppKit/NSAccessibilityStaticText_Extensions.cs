using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilityStaticText_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAttributedString? GetAccessibilityAttributedString(this INSAccessibilityStaticText This, NSRange range)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange(This.Handle, Selector.GetHandle("accessibilityAttributedStringForRange:"), range));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSRange GetAccessibilityVisibleCharacterRange(this INSAccessibilityStaticText This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend(This.Handle, Selector.GetHandle("accessibilityVisibleCharacterRange"));
	}
}
