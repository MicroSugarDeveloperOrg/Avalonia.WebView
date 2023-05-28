using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSResponder_NSTouchBarProvider
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeTouchBar = "makeTouchBar";

	private static readonly IntPtr selMakeTouchBarHandle = Selector.GetHandle("makeTouchBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTouchBar_ = "setTouchBar:";

	private static readonly IntPtr selSetTouchBar_Handle = Selector.GetHandle("setTouchBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchBar = "touchBar";

	private static readonly IntPtr selTouchBarHandle = Selector.GetHandle("touchBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSResponder");

	[Export("touchBar")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTouchBar GetTouchBar(this NSResponder This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSend(This.Handle, selTouchBarHandle));
	}

	[Export("makeTouchBar")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTouchBar MakeTouchBar(this NSResponder This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSend(This.Handle, selMakeTouchBarHandle));
	}

	[Export("setTouchBar:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetTouchBar(this NSResponder This, NSTouchBar? bar)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selSetTouchBar_Handle, bar?.Handle ?? IntPtr.Zero);
	}
}
