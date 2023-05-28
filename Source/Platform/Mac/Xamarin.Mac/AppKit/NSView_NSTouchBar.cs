using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSView_NSTouchBar
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedTouchTypes = "allowedTouchTypes";

	private static readonly IntPtr selAllowedTouchTypesHandle = Selector.GetHandle("allowedTouchTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowedTouchTypes_ = "setAllowedTouchTypes:";

	private static readonly IntPtr selSetAllowedTouchTypes_Handle = Selector.GetHandle("setAllowedTouchTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSView");

	[Export("allowedTouchTypes")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTouchTypeMask GetAllowedTouchTypes(this NSView This)
	{
		NSApplication.EnsureUIThread();
		return (NSTouchTypeMask)Messaging.UInt64_objc_msgSend(This.Handle, selAllowedTouchTypesHandle);
	}

	[Export("setAllowedTouchTypes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAllowedTouchTypes(this NSView This, NSTouchTypeMask touchTypes)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_UInt64(This.Handle, selSetAllowedTouchTypes_Handle, (ulong)touchTypes);
	}
}
