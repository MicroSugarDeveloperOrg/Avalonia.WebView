using System;
using ObjCRuntime;

namespace AppKit;

public static class NSAppearanceCustomization_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppearance GetAppearance(this INSAppearanceCustomization This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("appearance")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAppearance(this INSAppearanceCustomization This, NSAppearance value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setAppearance:"), value?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppearance GetEffectiveAppearance(this INSAppearanceCustomization This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("effectiveAppearance")));
	}
}
