using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSAttributedString_NSExtendedStringDrawing
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingRectWithSize_Options_Context_ = "boundingRectWithSize:options:context:";

	private static readonly IntPtr selBoundingRectWithSize_Options_Context_Handle = Selector.GetHandle("boundingRectWithSize:options:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawWithRect_Options_Context_ = "drawWithRect:options:context:";

	private static readonly IntPtr selDrawWithRect_Options_Context_Handle = Selector.GetHandle("drawWithRect:options:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSAttributedString");

	[Export("boundingRectWithSize:options:context:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect BoundingRectWithSize(this NSAttributedString This, CGSize size, NSStringDrawingOptions options, NSStringDrawingContext? context)
	{
		Messaging.CGRect_objc_msgSend_stret_CGSize_UInt64_IntPtr(out var retval, This.Handle, selBoundingRectWithSize_Options_Context_Handle, size, (ulong)options, context?.Handle ?? IntPtr.Zero);
		return retval;
	}

	[Export("drawWithRect:options:context:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawWithRect(this NSAttributedString This, CGRect rect, NSStringDrawingOptions options, NSStringDrawingContext? context)
	{
		Messaging.void_objc_msgSend_CGRect_UInt64_IntPtr(This.Handle, selDrawWithRect_Options_Context_Handle, rect, (ulong)options, context?.Handle ?? IntPtr.Zero);
	}
}
