using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSTextFinderSupport
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformTextFinderAction_ = "performTextFinderAction:";

	private static readonly IntPtr selPerformTextFinderAction_Handle = Selector.GetHandle("performTextFinderAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSResponder");

	[Export("performTextFinderAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PerformTextFinderAction(this NSResponder This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selPerformTextFinderAction_Handle, sender?.Handle ?? IntPtr.Zero);
	}
}
