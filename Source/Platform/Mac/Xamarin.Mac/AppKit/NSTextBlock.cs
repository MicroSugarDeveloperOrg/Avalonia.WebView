using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextBlock", true)]
public class NSTextBlock : NSObject
{
	private static readonly IntPtr selContentWidthHandle = Selector.GetHandle("contentWidth");

	private static readonly IntPtr selContentWidthValueTypeHandle = Selector.GetHandle("contentWidthValueType");

	private static readonly IntPtr selVerticalAlignmentHandle = Selector.GetHandle("verticalAlignment");

	private static readonly IntPtr selSetVerticalAlignment_Handle = Selector.GetHandle("setVerticalAlignment:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selSetValueTypeForDimension_Handle = Selector.GetHandle("setValue:type:forDimension:");

	private static readonly IntPtr selValueForDimension_Handle = Selector.GetHandle("valueForDimension:");

	private static readonly IntPtr selValueTypeForDimension_Handle = Selector.GetHandle("valueTypeForDimension:");

	private static readonly IntPtr selSetContentWidthType_Handle = Selector.GetHandle("setContentWidth:type:");

	private static readonly IntPtr selSetWidthTypeForLayerEdge_Handle = Selector.GetHandle("setWidth:type:forLayer:edge:");

	private static readonly IntPtr selSetWidthTypeForLayer_Handle = Selector.GetHandle("setWidth:type:forLayer:");

	private static readonly IntPtr selWidthForLayerEdge_Handle = Selector.GetHandle("widthForLayer:edge:");

	private static readonly IntPtr selWidthValueTypeForLayerEdge_Handle = Selector.GetHandle("widthValueTypeForLayer:edge:");

	private static readonly IntPtr selSetBorderColorForEdge_Handle = Selector.GetHandle("setBorderColor:forEdge:");

	private static readonly IntPtr selSetBorderColor_Handle = Selector.GetHandle("setBorderColor:");

	private static readonly IntPtr selBorderColorForEdge_Handle = Selector.GetHandle("borderColorForEdge:");

	private static readonly IntPtr selRectForLayoutAtPointInRectTextContainerCharacterRange_Handle = Selector.GetHandle("rectForLayoutAtPoint:inRect:textContainer:characterRange:");

	private static readonly IntPtr selBoundsRectForContentRectInRectTextContainerCharacterRange_Handle = Selector.GetHandle("boundsRectForContentRect:inRect:textContainer:characterRange:");

	private static readonly IntPtr selDrawBackgroundWithFrameInViewCharacterRangeLayoutManager_Handle = Selector.GetHandle("drawBackgroundWithFrame:inView:characterRange:layoutManager:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextBlock");

	private object __mt_BackgroundColor_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual double ContentWidth
	{
		[Export("contentWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selContentWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selContentWidthHandle);
		}
	}

	public virtual NSTextBlockValueType ContentWidthValueType
	{
		[Export("contentWidthValueType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextBlockValueType)Messaging.UInt64_objc_msgSend(base.Handle, selContentWidthValueTypeHandle);
			}
			return (NSTextBlockValueType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selContentWidthValueTypeHandle);
		}
	}

	public virtual NSTextBlockVerticalAlignment VerticalAlignment
	{
		[Export("verticalAlignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextBlockVerticalAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selVerticalAlignmentHandle);
			}
			return (NSTextBlockVerticalAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selVerticalAlignmentHandle);
		}
		[Export("setVerticalAlignment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetVerticalAlignment_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetVerticalAlignment_Handle, (ulong)value);
			}
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			__mt_BackgroundColor_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextBlock()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTextBlock(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextBlock(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextBlock(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setValue:type:forDimension:")]
	public virtual void SetValue(double val, NSTextBlockValueType type, NSTextBlockDimension dimension)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_UInt64_UInt64(base.Handle, selSetValueTypeForDimension_Handle, val, (ulong)type, (ulong)dimension);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_UInt64_UInt64(base.SuperHandle, selSetValueTypeForDimension_Handle, val, (ulong)type, (ulong)dimension);
		}
	}

	[Export("valueForDimension:")]
	public virtual double GetValue(NSTextBlockDimension dimension)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_UInt64(base.Handle, selValueForDimension_Handle, (ulong)dimension);
		}
		return Messaging.Double_objc_msgSendSuper_UInt64(base.SuperHandle, selValueForDimension_Handle, (ulong)dimension);
	}

	[Export("valueTypeForDimension:")]
	public virtual NSTextBlockValueType GetValueType(NSTextBlockDimension dimension)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSTextBlockValueType)Messaging.UInt64_objc_msgSend_UInt64(base.Handle, selValueTypeForDimension_Handle, (ulong)dimension);
		}
		return (NSTextBlockValueType)Messaging.UInt64_objc_msgSendSuper_UInt64(base.SuperHandle, selValueTypeForDimension_Handle, (ulong)dimension);
	}

	[Export("setContentWidth:type:")]
	public virtual void SetContentWidth(double val, NSTextBlockValueType type)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_UInt64(base.Handle, selSetContentWidthType_Handle, val, (ulong)type);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_UInt64(base.SuperHandle, selSetContentWidthType_Handle, val, (ulong)type);
		}
	}

	[Export("setWidth:type:forLayer:edge:")]
	public virtual void SetWidth(double val, NSTextBlockValueType type, NSTextBlockLayer layer, NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_UInt64_Int64_int(base.Handle, selSetWidthTypeForLayerEdge_Handle, val, (ulong)type, (long)layer, (int)edge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_UInt64_Int64_int(base.SuperHandle, selSetWidthTypeForLayerEdge_Handle, val, (ulong)type, (long)layer, (int)edge);
		}
	}

	[Export("setWidth:type:forLayer:")]
	public virtual void SetWidth(double val, NSTextBlockValueType type, NSTextBlockLayer layer)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_UInt64_Int64(base.Handle, selSetWidthTypeForLayer_Handle, val, (ulong)type, (long)layer);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_UInt64_Int64(base.SuperHandle, selSetWidthTypeForLayer_Handle, val, (ulong)type, (long)layer);
		}
	}

	[Export("widthForLayer:edge:")]
	public virtual double GetWidth(NSTextBlockLayer layer, NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Int64_int(base.Handle, selWidthForLayerEdge_Handle, (long)layer, (int)edge);
		}
		return Messaging.Double_objc_msgSendSuper_Int64_int(base.SuperHandle, selWidthForLayerEdge_Handle, (long)layer, (int)edge);
	}

	[Export("widthValueTypeForLayer:edge:")]
	public virtual NSTextBlockValueType WidthValueTypeForLayer(NSTextBlockLayer layer, NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSTextBlockValueType)Messaging.UInt64_objc_msgSend_Int64_int(base.Handle, selWidthValueTypeForLayerEdge_Handle, (long)layer, (int)edge);
		}
		return (NSTextBlockValueType)Messaging.UInt64_objc_msgSendSuper_Int64_int(base.SuperHandle, selWidthValueTypeForLayerEdge_Handle, (long)layer, (int)edge);
	}

	[Export("setBorderColor:forEdge:")]
	public virtual void SetBorderColor(NSColor color, NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selSetBorderColorForEdge_Handle, color.Handle, (int)edge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selSetBorderColorForEdge_Handle, color.Handle, (int)edge);
		}
	}

	[Export("setBorderColor:")]
	public virtual void SetBorderColor(NSColor color)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBorderColor_Handle, color.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBorderColor_Handle, color.Handle);
		}
	}

	[Export("borderColorForEdge:")]
	public virtual NSColor GetBorderColor(NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selBorderColorForEdge_Handle, (int)edge));
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selBorderColorForEdge_Handle, (int)edge));
	}

	[Export("rectForLayoutAtPoint:inRect:textContainer:characterRange:")]
	public virtual CGRect GetRectForLayout(CGPoint startingPoint, CGRect rect, NSTextContainer textContainer, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGPoint_CGRect_IntPtr_NSRange(out retval, base.Handle, selRectForLayoutAtPointInRectTextContainerCharacterRange_Handle, startingPoint, rect, textContainer.Handle, charRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGPoint_CGRect_IntPtr_NSRange(out retval, base.SuperHandle, selRectForLayoutAtPointInRectTextContainerCharacterRange_Handle, startingPoint, rect, textContainer.Handle, charRange);
		}
		return retval;
	}

	[Export("boundsRectForContentRect:inRect:textContainer:characterRange:")]
	public virtual CGRect GetBoundsRect(CGRect contentRect, CGRect rect, NSTextContainer textContainer, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_CGRect_IntPtr_NSRange(out retval, base.Handle, selBoundsRectForContentRectInRectTextContainerCharacterRange_Handle, contentRect, rect, textContainer.Handle, charRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_CGRect_IntPtr_NSRange(out retval, base.SuperHandle, selBoundsRectForContentRectInRectTextContainerCharacterRange_Handle, contentRect, rect, textContainer.Handle, charRange);
		}
		return retval;
	}

	[Export("drawBackgroundWithFrame:inView:characterRange:layoutManager:")]
	public virtual void DrawBackground(CGRect frameRect, NSView controlView, NSRange charRange, NSLayoutManager layoutManager)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_NSRange_IntPtr(base.Handle, selDrawBackgroundWithFrameInViewCharacterRangeLayoutManager_Handle, frameRect, controlView.Handle, charRange, layoutManager.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_NSRange_IntPtr(base.SuperHandle, selDrawBackgroundWithFrameInViewCharacterRangeLayoutManager_Handle, frameRect, controlView.Handle, charRange, layoutManager.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_BackgroundColor_var = null;
		}
	}
}
