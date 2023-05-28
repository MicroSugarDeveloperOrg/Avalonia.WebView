using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSGestureRecognizer_NSTouchBar
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedTouchTypes = "allowedTouchTypes";

	private static readonly IntPtr selAllowedTouchTypesHandle = Selector.GetHandle("allowedTouchTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowedTouchTypes_ = "setAllowedTouchTypes:";

	private static readonly IntPtr selSetAllowedTouchTypes_Handle = Selector.GetHandle("setAllowedTouchTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSGestureRecognizer");

	[Export("allowedTouchTypes")]
	[Introduced(PlatformName.MacOSX, 10, 12, 1, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTouchTypeMask GetAllowedTouchTypes(this NSGestureRecognizer This)
	{
		NSApplication.EnsureUIThread();
		return (NSTouchTypeMask)Messaging.UInt64_objc_msgSend(This.Handle, selAllowedTouchTypesHandle);
	}

	[Export("setAllowedTouchTypes:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 1, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAllowedTouchTypes(this NSGestureRecognizer This, NSTouchTypeMask types)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_UInt64(This.Handle, selSetAllowedTouchTypes_Handle, (ulong)types);
	}
}
