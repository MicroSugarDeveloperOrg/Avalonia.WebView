using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSStringDrawing_NSAttributedString
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawAtPoint_ = "drawAtPoint:";

	private static readonly IntPtr selDrawAtPoint_Handle = Selector.GetHandle("drawAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInRect_ = "drawInRect:";

	private static readonly IntPtr selDrawInRect_Handle = Selector.GetHandle("drawInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSAttributedString");

	[Export("drawAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawAtPoint(this NSAttributedString This, CGPoint point)
	{
		Messaging.void_objc_msgSend_CGPoint(This.Handle, selDrawAtPoint_Handle, point);
	}

	[Export("drawInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawInRect(this NSAttributedString This, CGRect rect)
	{
		Messaging.void_objc_msgSend_CGRect(This.Handle, selDrawInRect_Handle, rect);
	}

	[Export("size")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize GetSize(this NSAttributedString This)
	{
		return Messaging.CGSize_objc_msgSend(This.Handle, selSizeHandle);
	}
}
