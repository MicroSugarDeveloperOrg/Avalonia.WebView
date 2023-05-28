using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
public static class NSApplication_NSTouchBarCustomization
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticCustomizeTouchBarMenuItemEnabled = "isAutomaticCustomizeTouchBarMenuItemEnabled";

	private static readonly IntPtr selIsAutomaticCustomizeTouchBarMenuItemEnabledHandle = Selector.GetHandle("isAutomaticCustomizeTouchBarMenuItemEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticCustomizeTouchBarMenuItemEnabled_ = "setAutomaticCustomizeTouchBarMenuItemEnabled:";

	private static readonly IntPtr selSetAutomaticCustomizeTouchBarMenuItemEnabled_Handle = Selector.GetHandle("setAutomaticCustomizeTouchBarMenuItemEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleTouchBarCustomizationPalette_ = "toggleTouchBarCustomizationPalette:";

	private static readonly IntPtr selToggleTouchBarCustomizationPalette_Handle = Selector.GetHandle("toggleTouchBarCustomizationPalette:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSApplication");

	[Export("isAutomaticCustomizeTouchBarMenuItemEnabled")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetAutomaticCustomizeTouchBarMenuItemEnabled(this NSApplication This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(This.Handle, selIsAutomaticCustomizeTouchBarMenuItemEnabledHandle);
	}

	[Export("setAutomaticCustomizeTouchBarMenuItemEnabled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAutomaticCustomizeTouchBarMenuItemEnabled(this NSApplication This, bool enabled)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_bool(This.Handle, selSetAutomaticCustomizeTouchBarMenuItemEnabled_Handle, enabled);
	}

	[Export("toggleTouchBarCustomizationPalette:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ToggleTouchBarCustomizationPalette(this NSApplication This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selToggleTouchBarCustomizationPalette_Handle, sender?.Handle ?? IntPtr.Zero);
	}
}
