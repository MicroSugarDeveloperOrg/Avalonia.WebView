using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAccessibilityElementLoading_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSRange GetAccessibilityRangeInTargetElement(this INSAccessibilityElementLoading This, INSSecureCoding token)
	{
		NSApplication.EnsureUIThread();
		if (token == null)
		{
			throw new ArgumentNullException("token");
		}
		return Messaging.NSRange_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("accessibilityRangeInTargetElementWithToken:"), token.Handle);
	}
}
