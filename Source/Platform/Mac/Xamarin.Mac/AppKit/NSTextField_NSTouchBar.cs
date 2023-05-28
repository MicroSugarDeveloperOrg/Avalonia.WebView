using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 12, 1, PlatformArchitecture.All, null)]
public static class NSTextField_NSTouchBar
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsCharacterPickerTouchBarItem = "allowsCharacterPickerTouchBarItem";

	private static readonly IntPtr selAllowsCharacterPickerTouchBarItemHandle = Selector.GetHandle("allowsCharacterPickerTouchBarItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticTextCompletionEnabled_ = "automaticTextCompletionEnabled:";

	private static readonly IntPtr selAutomaticTextCompletionEnabled_Handle = Selector.GetHandle("automaticTextCompletionEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticTextCompletionEnabled = "isAutomaticTextCompletionEnabled";

	private static readonly IntPtr selIsAutomaticTextCompletionEnabledHandle = Selector.GetHandle("isAutomaticTextCompletionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsCharacterPickerTouchBarItem_ = "setAllowsCharacterPickerTouchBarItem:";

	private static readonly IntPtr selSetAllowsCharacterPickerTouchBarItem_Handle = Selector.GetHandle("setAllowsCharacterPickerTouchBarItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextField");

	[Export("allowsCharacterPickerTouchBarItem")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetAllowsCharacterPickerTouchBarItem(this NSTextField This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(This.Handle, selAllowsCharacterPickerTouchBarItemHandle);
	}

	[Export("isAutomaticTextCompletionEnabled")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetAutomaticTextCompletionEnabled(this NSTextField This)
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(This.Handle, selIsAutomaticTextCompletionEnabledHandle);
	}

	[Export("setAllowsCharacterPickerTouchBarItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAllowsCharacterPickerTouchBarItem(this NSTextField This, bool allows)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_bool(This.Handle, selSetAllowsCharacterPickerTouchBarItem_Handle, allows);
	}

	[Export("automaticTextCompletionEnabled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAutomaticTextCompletionEnabled(this NSTextField This, bool enabled)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_bool(This.Handle, selAutomaticTextCompletionEnabled_Handle, enabled);
	}
}
