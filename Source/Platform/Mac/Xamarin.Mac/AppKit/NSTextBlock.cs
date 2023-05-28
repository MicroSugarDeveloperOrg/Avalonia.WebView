using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextBlock", true)]
public class NSTextBlock : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBorderColorForEdge_ = "borderColorForEdge:";

	private static readonly IntPtr selBorderColorForEdge_Handle = Selector.GetHandle("borderColorForEdge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundsRectForContentRect_InRect_TextContainer_CharacterRange_ = "boundsRectForContentRect:inRect:textContainer:characterRange:";

	private static readonly IntPtr selBoundsRectForContentRect_InRect_TextContainer_CharacterRange_Handle = Selector.GetHandle("boundsRectForContentRect:inRect:textContainer:characterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentWidth = "contentWidth";

	private static readonly IntPtr selContentWidthHandle = Selector.GetHandle("contentWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentWidthValueType = "contentWidthValueType";

	private static readonly IntPtr selContentWidthValueTypeHandle = Selector.GetHandle("contentWidthValueType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawBackgroundWithFrame_InView_CharacterRange_LayoutManager_ = "drawBackgroundWithFrame:inView:characterRange:layoutManager:";

	private static readonly IntPtr selDrawBackgroundWithFrame_InView_CharacterRange_LayoutManager_Handle = Selector.GetHandle("drawBackgroundWithFrame:inView:characterRange:layoutManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectForLayoutAtPoint_InRect_TextContainer_CharacterRange_ = "rectForLayoutAtPoint:inRect:textContainer:characterRange:";

	private static readonly IntPtr selRectForLayoutAtPoint_InRect_TextContainer_CharacterRange_Handle = Selector.GetHandle("rectForLayoutAtPoint:inRect:textContainer:characterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBorderColor_ = "setBorderColor:";

	private static readonly IntPtr selSetBorderColor_Handle = Selector.GetHandle("setBorderColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBorderColor_ForEdge_ = "setBorderColor:forEdge:";

	private static readonly IntPtr selSetBorderColor_ForEdge_Handle = Selector.GetHandle("setBorderColor:forEdge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentWidth_Type_ = "setContentWidth:type:";

	private static readonly IntPtr selSetContentWidth_Type_Handle = Selector.GetHandle("setContentWidth:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_Type_ForDimension_ = "setValue:type:forDimension:";

	private static readonly IntPtr selSetValue_Type_ForDimension_Handle = Selector.GetHandle("setValue:type:forDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerticalAlignment_ = "setVerticalAlignment:";

	private static readonly IntPtr selSetVerticalAlignment_Handle = Selector.GetHandle("setVerticalAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWidth_Type_ForLayer_ = "setWidth:type:forLayer:";

	private static readonly IntPtr selSetWidth_Type_ForLayer_Handle = Selector.GetHandle("setWidth:type:forLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWidth_Type_ForLayer_Edge_ = "setWidth:type:forLayer:edge:";

	private static readonly IntPtr selSetWidth_Type_ForLayer_Edge_Handle = Selector.GetHandle("setWidth:type:forLayer:edge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForDimension_ = "valueForDimension:";

	private static readonly IntPtr selValueForDimension_Handle = Selector.GetHandle("valueForDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueTypeForDimension_ = "valueTypeForDimension:";

	private static readonly IntPtr selValueTypeForDimension_Handle = Selector.GetHandle("valueTypeForDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalAlignment = "verticalAlignment";

	private static readonly IntPtr selVerticalAlignmentHandle = Selector.GetHandle("verticalAlignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidthForLayer_Edge_ = "widthForLayer:edge:";

	private static readonly IntPtr selWidthForLayer_Edge_Handle = Selector.GetHandle("widthForLayer:edge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidthValueTypeForLayer_Edge_ = "widthValueTypeForLayer:edge:";

	private static readonly IntPtr selWidthValueTypeForLayer_Edge_Handle = Selector.GetHandle("widthValueTypeForLayer:edge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextBlock");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ContentWidth
	{
		[Export("contentWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selContentWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selContentWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextBlockValueType ContentWidthValueType
	{
		[Export("contentWidthValueType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTextBlockValueType)Messaging.UInt64_objc_msgSend(base.Handle, selContentWidthValueTypeHandle);
			}
			return (NSTextBlockValueType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selContentWidthValueTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextBlockVerticalAlignment VerticalAlignment
	{
		[Export("verticalAlignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTextBlockVerticalAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selVerticalAlignmentHandle);
			}
			return (NSTextBlockVerticalAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selVerticalAlignmentHandle);
		}
		[Export("setVerticalAlignment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetVerticalAlignment_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetVerticalAlignment_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextBlock()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTextBlock(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTextBlock(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextBlock(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("drawBackgroundWithFrame:inView:characterRange:layoutManager:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_NSRange_IntPtr(base.Handle, selDrawBackgroundWithFrame_InView_CharacterRange_LayoutManager_Handle, frameRect, controlView.Handle, charRange, layoutManager.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_NSRange_IntPtr(base.SuperHandle, selDrawBackgroundWithFrame_InView_CharacterRange_LayoutManager_Handle, frameRect, controlView.Handle, charRange, layoutManager.Handle);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("borderColorForEdge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor GetBorderColor(NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selBorderColorForEdge_Handle, (ulong)edge));
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selBorderColorForEdge_Handle, (ulong)edge));
	}

	[Export("boundsRectForContentRect:inRect:textContainer:characterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetBoundsRect(CGRect contentRect, CGRect rect, NSTextContainer textContainer, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_CGRect_IntPtr_NSRange(out retval, base.Handle, selBoundsRectForContentRect_InRect_TextContainer_CharacterRange_Handle, contentRect, rect, textContainer.Handle, charRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_CGRect_IntPtr_NSRange(out retval, base.SuperHandle, selBoundsRectForContentRect_InRect_TextContainer_CharacterRange_Handle, contentRect, rect, textContainer.Handle, charRange);
		}
		return retval;
	}

	[Export("rectForLayoutAtPoint:inRect:textContainer:characterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetRectForLayout(CGPoint startingPoint, CGRect rect, NSTextContainer textContainer, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGPoint_CGRect_IntPtr_NSRange(out retval, base.Handle, selRectForLayoutAtPoint_InRect_TextContainer_CharacterRange_Handle, startingPoint, rect, textContainer.Handle, charRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGPoint_CGRect_IntPtr_NSRange(out retval, base.SuperHandle, selRectForLayoutAtPoint_InRect_TextContainer_CharacterRange_Handle, startingPoint, rect, textContainer.Handle, charRange);
		}
		return retval;
	}

	[Export("valueForDimension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetValue(NSTextBlockDimension dimension)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_UInt64(base.Handle, selValueForDimension_Handle, (ulong)dimension);
		}
		return Messaging.nfloat_objc_msgSendSuper_UInt64(base.SuperHandle, selValueForDimension_Handle, (ulong)dimension);
	}

	[Export("valueTypeForDimension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextBlockValueType GetValueType(NSTextBlockDimension dimension)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSTextBlockValueType)Messaging.UInt64_objc_msgSend_UInt64(base.Handle, selValueTypeForDimension_Handle, (ulong)dimension);
		}
		return (NSTextBlockValueType)Messaging.UInt64_objc_msgSendSuper_UInt64(base.SuperHandle, selValueTypeForDimension_Handle, (ulong)dimension);
	}

	[Export("widthForLayer:edge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetWidth(NSTextBlockLayer layer, NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_Int64_UInt64(base.Handle, selWidthForLayer_Edge_Handle, (long)layer, (ulong)edge);
		}
		return Messaging.nfloat_objc_msgSendSuper_Int64_UInt64(base.SuperHandle, selWidthForLayer_Edge_Handle, (long)layer, (ulong)edge);
	}

	[Export("setBorderColor:forEdge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBorderColor(NSColor color, NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selSetBorderColor_ForEdge_Handle, color.Handle, (ulong)edge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selSetBorderColor_ForEdge_Handle, color.Handle, (ulong)edge);
		}
	}

	[Export("setBorderColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBorderColor(NSColor color)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBorderColor_Handle, color.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBorderColor_Handle, color.Handle);
		}
	}

	[Export("setContentWidth:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetContentWidth(nfloat val, NSTextBlockValueType type)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_UInt64(base.Handle, selSetContentWidth_Type_Handle, val, (ulong)type);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_UInt64(base.SuperHandle, selSetContentWidth_Type_Handle, val, (ulong)type);
		}
	}

	[Export("setValue:type:forDimension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(nfloat val, NSTextBlockValueType type, NSTextBlockDimension dimension)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_UInt64_UInt64(base.Handle, selSetValue_Type_ForDimension_Handle, val, (ulong)type, (ulong)dimension);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_UInt64_UInt64(base.SuperHandle, selSetValue_Type_ForDimension_Handle, val, (ulong)type, (ulong)dimension);
		}
	}

	[Export("setWidth:type:forLayer:edge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWidth(nfloat val, NSTextBlockValueType type, NSTextBlockLayer layer, NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_UInt64_Int64_UInt64(base.Handle, selSetWidth_Type_ForLayer_Edge_Handle, val, (ulong)type, (long)layer, (ulong)edge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_UInt64_Int64_UInt64(base.SuperHandle, selSetWidth_Type_ForLayer_Edge_Handle, val, (ulong)type, (long)layer, (ulong)edge);
		}
	}

	[Export("setWidth:type:forLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWidth(nfloat val, NSTextBlockValueType type, NSTextBlockLayer layer)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_UInt64_Int64(base.Handle, selSetWidth_Type_ForLayer_Handle, val, (ulong)type, (long)layer);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_UInt64_Int64(base.SuperHandle, selSetWidth_Type_ForLayer_Handle, val, (ulong)type, (long)layer);
		}
	}

	[Export("widthValueTypeForLayer:edge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextBlockValueType WidthValueTypeForLayer(NSTextBlockLayer layer, NSRectEdge edge)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSTextBlockValueType)Messaging.UInt64_objc_msgSend_Int64_UInt64(base.Handle, selWidthValueTypeForLayer_Edge_Handle, (long)layer, (ulong)edge);
		}
		return (NSTextBlockValueType)Messaging.UInt64_objc_msgSendSuper_Int64_UInt64(base.SuperHandle, selWidthValueTypeForLayer_Edge_Handle, (long)layer, (ulong)edge);
	}
}
