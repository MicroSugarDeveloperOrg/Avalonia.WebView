using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSExtendedStringDrawing
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingRectWithSize_Options_Attributes_Context_ = "boundingRectWithSize:options:attributes:context:";

	private static readonly IntPtr selBoundingRectWithSize_Options_Attributes_Context_Handle = Selector.GetHandle("boundingRectWithSize:options:attributes:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawWithRect_Options_Attributes_Context_ = "drawWithRect:options:attributes:context:";

	private static readonly IntPtr selDrawWithRect_Options_Attributes_Context_Handle = Selector.GetHandle("drawWithRect:options:attributes:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSString");

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawString(this NSString This, CGRect rect, NSStringDrawingOptions options, NSStringAttributes? attributes, NSStringDrawingContext? context)
	{
		This.WeakDrawString(rect, options, attributes.GetDictionary(), context);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect GetBoundingRect(this NSString This, CGSize size, NSStringDrawingOptions options, NSStringAttributes? attributes, NSStringDrawingContext? context)
	{
		return This.WeakGetBoundingRect(size, options, attributes.GetDictionary(), context);
	}

	[Export("drawWithRect:options:attributes:context:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WeakDrawString(this NSString This, CGRect rect, NSStringDrawingOptions options, NSDictionary? attributes, NSStringDrawingContext? context)
	{
		Messaging.void_objc_msgSend_CGRect_UInt64_IntPtr_IntPtr(This.Handle, selDrawWithRect_Options_Attributes_Context_Handle, rect, (ulong)options, attributes?.Handle ?? IntPtr.Zero, context?.Handle ?? IntPtr.Zero);
	}

	[Export("boundingRectWithSize:options:attributes:context:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect WeakGetBoundingRect(this NSString This, CGSize size, NSStringDrawingOptions options, NSDictionary? attributes, NSStringDrawingContext? context)
	{
		Messaging.CGRect_objc_msgSend_stret_CGSize_UInt64_IntPtr_IntPtr(out var retval, This.Handle, selBoundingRectWithSize_Options_Attributes_Context_Handle, size, (ulong)options, attributes?.Handle ?? IntPtr.Zero, context?.Handle ?? IntPtr.Zero);
		return retval;
	}
}
