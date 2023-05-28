using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
public static class NSTouch_NSTouchBar
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocationInView_ = "locationInView:";

	private static readonly IntPtr selLocationInView_Handle = Selector.GetHandle("locationInView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousLocationInView_ = "previousLocationInView:";

	private static readonly IntPtr selPreviousLocationInView_Handle = Selector.GetHandle("previousLocationInView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSTouch");

	[Export("locationInView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGPoint GetLocation(this NSTouch This, NSView? view)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGPoint_objc_msgSend_IntPtr(This.Handle, selLocationInView_Handle, view?.Handle ?? IntPtr.Zero);
	}

	[Export("previousLocationInView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGPoint GetPreviousLocation(this NSTouch This, NSView? view)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGPoint_objc_msgSend_IntPtr(This.Handle, selPreviousLocationInView_Handle, view?.Handle ?? IntPtr.Zero);
	}

	[Export("type")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTouchType GetTouchType(this NSTouch This)
	{
		NSApplication.EnsureUIThread();
		return (NSTouchType)Messaging.Int64_objc_msgSend(This.Handle, selTypeHandle);
	}
}
