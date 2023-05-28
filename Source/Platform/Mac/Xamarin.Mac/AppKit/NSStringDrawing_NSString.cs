using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSStringDrawing_NSString
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawAtPoint_WithAttributes_ = "drawAtPoint:withAttributes:";

	private static readonly IntPtr selDrawAtPoint_WithAttributes_Handle = Selector.GetHandle("drawAtPoint:withAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInRect_WithAttributes_ = "drawInRect:withAttributes:";

	private static readonly IntPtr selDrawInRect_WithAttributes_Handle = Selector.GetHandle("drawInRect:withAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeWithAttributes_ = "sizeWithAttributes:";

	private static readonly IntPtr selSizeWithAttributes_Handle = Selector.GetHandle("sizeWithAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSString");

	[Export("drawAtPoint:withAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawAtPoint(this NSString This, CGPoint point, NSDictionary attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		Messaging.void_objc_msgSend_CGPoint_IntPtr(This.Handle, selDrawAtPoint_WithAttributes_Handle, point, attributes.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawAtPoint(this NSString This, CGPoint point, NSStringAttributes attributes)
	{
		This.DrawAtPoint(point, attributes.GetDictionary());
	}

	[Export("drawInRect:withAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawInRect(this NSString This, CGRect rect, NSDictionary attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		Messaging.void_objc_msgSend_CGRect_IntPtr(This.Handle, selDrawInRect_WithAttributes_Handle, rect, attributes.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawInRect(this NSString This, CGRect rect, NSStringAttributes attributes)
	{
		This.DrawInRect(rect, attributes.GetDictionary());
	}

	[Export("sizeWithAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize StringSize(this NSString This, NSDictionary attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		return Messaging.CGSize_objc_msgSend_IntPtr(This.Handle, selSizeWithAttributes_Handle, attributes.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize StringSize(this NSString This, NSStringAttributes attributes)
	{
		return This.StringSize(attributes.GetDictionary());
	}
}
