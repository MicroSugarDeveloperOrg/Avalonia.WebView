using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSUserInterfaceItemIdentification_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetIdentifier(this INSUserInterfaceItemIdentification This)
	{
		NSApplication.EnsureUIThread();
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("identifier")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetIdentifier(this INSUserInterfaceItemIdentification This, string value)
	{
		NSApplication.EnsureUIThread();
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr intPtr = NSString.CreateNative(value);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setIdentifier:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}
}
