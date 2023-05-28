using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSBezierPath", true)]
public class NSBezierPath : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddClip = "addClip";

	private static readonly IntPtr selAddClipHandle = Selector.GetHandle("addClip");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPath_ = "appendBezierPath:";

	private static readonly IntPtr selAppendBezierPath_Handle = Selector.GetHandle("appendBezierPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithArcFromPoint_ToPoint_Radius_ = "appendBezierPathWithArcFromPoint:toPoint:radius:";

	private static readonly IntPtr selAppendBezierPathWithArcFromPoint_ToPoint_Radius_Handle = Selector.GetHandle("appendBezierPathWithArcFromPoint:toPoint:radius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_ = "appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:";

	private static readonly IntPtr selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_Handle = Selector.GetHandle("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_Clockwise_ = "appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:clockwise:";

	private static readonly IntPtr selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_Clockwise_Handle = Selector.GetHandle("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:clockwise:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithCGGlyph_InFont_ = "appendBezierPathWithCGGlyph:inFont:";

	private static readonly IntPtr selAppendBezierPathWithCGGlyph_InFont_Handle = Selector.GetHandle("appendBezierPathWithCGGlyph:inFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithCGGlyphs_Count_InFont_ = "appendBezierPathWithCGGlyphs:count:inFont:";

	private static readonly IntPtr selAppendBezierPathWithCGGlyphs_Count_InFont_Handle = Selector.GetHandle("appendBezierPathWithCGGlyphs:count:inFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithGlyph_InFont_ = "appendBezierPathWithGlyph:inFont:";

	private static readonly IntPtr selAppendBezierPathWithGlyph_InFont_Handle = Selector.GetHandle("appendBezierPathWithGlyph:inFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithGlyphs_Count_InFont_ = "appendBezierPathWithGlyphs:count:inFont:";

	private static readonly IntPtr selAppendBezierPathWithGlyphs_Count_InFont_Handle = Selector.GetHandle("appendBezierPathWithGlyphs:count:inFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithOvalInRect_ = "appendBezierPathWithOvalInRect:";

	private static readonly IntPtr selAppendBezierPathWithOvalInRect_Handle = Selector.GetHandle("appendBezierPathWithOvalInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithPackedGlyphs_ = "appendBezierPathWithPackedGlyphs:";

	private static readonly IntPtr selAppendBezierPathWithPackedGlyphs_Handle = Selector.GetHandle("appendBezierPathWithPackedGlyphs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithPoints_Count_ = "appendBezierPathWithPoints:count:";

	private static readonly IntPtr selAppendBezierPathWithPoints_Count_Handle = Selector.GetHandle("appendBezierPathWithPoints:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithRect_ = "appendBezierPathWithRect:";

	private static readonly IntPtr selAppendBezierPathWithRect_Handle = Selector.GetHandle("appendBezierPathWithRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBezierPathWithRoundedRect_XRadius_YRadius_ = "appendBezierPathWithRoundedRect:xRadius:yRadius:";

	private static readonly IntPtr selAppendBezierPathWithRoundedRect_XRadius_YRadius_Handle = Selector.GetHandle("appendBezierPathWithRoundedRect:xRadius:yRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBezierPathByFlatteningPath = "bezierPathByFlatteningPath";

	private static readonly IntPtr selBezierPathByFlatteningPathHandle = Selector.GetHandle("bezierPathByFlatteningPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBezierPathByReversingPath = "bezierPathByReversingPath";

	private static readonly IntPtr selBezierPathByReversingPathHandle = Selector.GetHandle("bezierPathByReversingPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBezierPathWithOvalInRect_ = "bezierPathWithOvalInRect:";

	private static readonly IntPtr selBezierPathWithOvalInRect_Handle = Selector.GetHandle("bezierPathWithOvalInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBezierPathWithRect_ = "bezierPathWithRect:";

	private static readonly IntPtr selBezierPathWithRect_Handle = Selector.GetHandle("bezierPathWithRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBezierPathWithRoundedRect_XRadius_YRadius_ = "bezierPathWithRoundedRect:xRadius:yRadius:";

	private static readonly IntPtr selBezierPathWithRoundedRect_XRadius_YRadius_Handle = Selector.GetHandle("bezierPathWithRoundedRect:xRadius:yRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBounds = "bounds";

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClipRect_ = "clipRect:";

	private static readonly IntPtr selClipRect_Handle = Selector.GetHandle("clipRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClosePath = "closePath";

	private static readonly IntPtr selClosePathHandle = Selector.GetHandle("closePath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsPoint_ = "containsPoint:";

	private static readonly IntPtr selContainsPoint_Handle = Selector.GetHandle("containsPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlPointBounds = "controlPointBounds";

	private static readonly IntPtr selControlPointBoundsHandle = Selector.GetHandle("controlPointBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPoint = "currentPoint";

	private static readonly IntPtr selCurrentPointHandle = Selector.GetHandle("currentPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurveToPoint_ControlPoint1_ControlPoint2_ = "curveToPoint:controlPoint1:controlPoint2:";

	private static readonly IntPtr selCurveToPoint_ControlPoint1_ControlPoint2_Handle = Selector.GetHandle("curveToPoint:controlPoint1:controlPoint2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultFlatness = "defaultFlatness";

	private static readonly IntPtr selDefaultFlatnessHandle = Selector.GetHandle("defaultFlatness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultLineCapStyle = "defaultLineCapStyle";

	private static readonly IntPtr selDefaultLineCapStyleHandle = Selector.GetHandle("defaultLineCapStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultLineJoinStyle = "defaultLineJoinStyle";

	private static readonly IntPtr selDefaultLineJoinStyleHandle = Selector.GetHandle("defaultLineJoinStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultLineWidth = "defaultLineWidth";

	private static readonly IntPtr selDefaultLineWidthHandle = Selector.GetHandle("defaultLineWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultMiterLimit = "defaultMiterLimit";

	private static readonly IntPtr selDefaultMiterLimitHandle = Selector.GetHandle("defaultMiterLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultWindingRule = "defaultWindingRule";

	private static readonly IntPtr selDefaultWindingRuleHandle = Selector.GetHandle("defaultWindingRule");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawPackedGlyphs_AtPoint_ = "drawPackedGlyphs:atPoint:";

	private static readonly IntPtr selDrawPackedGlyphs_AtPoint_Handle = Selector.GetHandle("drawPackedGlyphs:atPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementAtIndex_ = "elementAtIndex:";

	private static readonly IntPtr selElementAtIndex_Handle = Selector.GetHandle("elementAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementAtIndex_AssociatedPoints_ = "elementAtIndex:associatedPoints:";

	private static readonly IntPtr selElementAtIndex_AssociatedPoints_Handle = Selector.GetHandle("elementAtIndex:associatedPoints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementCount = "elementCount";

	private static readonly IntPtr selElementCountHandle = Selector.GetHandle("elementCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFill = "fill";

	private static readonly IntPtr selFillHandle = Selector.GetHandle("fill");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillRect_ = "fillRect:";

	private static readonly IntPtr selFillRect_Handle = Selector.GetHandle("fillRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlatness = "flatness";

	private static readonly IntPtr selFlatnessHandle = Selector.GetHandle("flatness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetLineDash_Count_Phase_ = "getLineDash:count:phase:";

	private static readonly IntPtr selGetLineDash_Count_Phase_Handle = Selector.GetHandle("getLineDash:count:phase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEmpty = "isEmpty";

	private static readonly IntPtr selIsEmptyHandle = Selector.GetHandle("isEmpty");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineCapStyle = "lineCapStyle";

	private static readonly IntPtr selLineCapStyleHandle = Selector.GetHandle("lineCapStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineJoinStyle = "lineJoinStyle";

	private static readonly IntPtr selLineJoinStyleHandle = Selector.GetHandle("lineJoinStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineToPoint_ = "lineToPoint:";

	private static readonly IntPtr selLineToPoint_Handle = Selector.GetHandle("lineToPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineWidth = "lineWidth";

	private static readonly IntPtr selLineWidthHandle = Selector.GetHandle("lineWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMiterLimit = "miterLimit";

	private static readonly IntPtr selMiterLimitHandle = Selector.GetHandle("miterLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveToPoint_ = "moveToPoint:";

	private static readonly IntPtr selMoveToPoint_Handle = Selector.GetHandle("moveToPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelativeCurveToPoint_ControlPoint1_ControlPoint2_ = "relativeCurveToPoint:controlPoint1:controlPoint2:";

	private static readonly IntPtr selRelativeCurveToPoint_ControlPoint1_ControlPoint2_Handle = Selector.GetHandle("relativeCurveToPoint:controlPoint1:controlPoint2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelativeLineToPoint_ = "relativeLineToPoint:";

	private static readonly IntPtr selRelativeLineToPoint_Handle = Selector.GetHandle("relativeLineToPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelativeMoveToPoint_ = "relativeMoveToPoint:";

	private static readonly IntPtr selRelativeMoveToPoint_Handle = Selector.GetHandle("relativeMoveToPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllPoints = "removeAllPoints";

	private static readonly IntPtr selRemoveAllPointsHandle = Selector.GetHandle("removeAllPoints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAssociatedPoints_AtIndex_ = "setAssociatedPoints:atIndex:";

	private static readonly IntPtr selSetAssociatedPoints_AtIndex_Handle = Selector.GetHandle("setAssociatedPoints:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClip = "setClip";

	private static readonly IntPtr selSetClipHandle = Selector.GetHandle("setClip");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultFlatness_ = "setDefaultFlatness:";

	private static readonly IntPtr selSetDefaultFlatness_Handle = Selector.GetHandle("setDefaultFlatness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultLineCapStyle_ = "setDefaultLineCapStyle:";

	private static readonly IntPtr selSetDefaultLineCapStyle_Handle = Selector.GetHandle("setDefaultLineCapStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultLineJoinStyle_ = "setDefaultLineJoinStyle:";

	private static readonly IntPtr selSetDefaultLineJoinStyle_Handle = Selector.GetHandle("setDefaultLineJoinStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultLineWidth_ = "setDefaultLineWidth:";

	private static readonly IntPtr selSetDefaultLineWidth_Handle = Selector.GetHandle("setDefaultLineWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultMiterLimit_ = "setDefaultMiterLimit:";

	private static readonly IntPtr selSetDefaultMiterLimit_Handle = Selector.GetHandle("setDefaultMiterLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultWindingRule_ = "setDefaultWindingRule:";

	private static readonly IntPtr selSetDefaultWindingRule_Handle = Selector.GetHandle("setDefaultWindingRule:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFlatness_ = "setFlatness:";

	private static readonly IntPtr selSetFlatness_Handle = Selector.GetHandle("setFlatness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineCapStyle_ = "setLineCapStyle:";

	private static readonly IntPtr selSetLineCapStyle_Handle = Selector.GetHandle("setLineCapStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineDash_Count_Phase_ = "setLineDash:count:phase:";

	private static readonly IntPtr selSetLineDash_Count_Phase_Handle = Selector.GetHandle("setLineDash:count:phase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineJoinStyle_ = "setLineJoinStyle:";

	private static readonly IntPtr selSetLineJoinStyle_Handle = Selector.GetHandle("setLineJoinStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineWidth_ = "setLineWidth:";

	private static readonly IntPtr selSetLineWidth_Handle = Selector.GetHandle("setLineWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMiterLimit_ = "setMiterLimit:";

	private static readonly IntPtr selSetMiterLimit_Handle = Selector.GetHandle("setMiterLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWindingRule_ = "setWindingRule:";

	private static readonly IntPtr selSetWindingRule_Handle = Selector.GetHandle("setWindingRule:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStroke = "stroke";

	private static readonly IntPtr selStrokeHandle = Selector.GetHandle("stroke");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrokeLineFromPoint_ToPoint_ = "strokeLineFromPoint:toPoint:";

	private static readonly IntPtr selStrokeLineFromPoint_ToPoint_Handle = Selector.GetHandle("strokeLineFromPoint:toPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrokeRect_ = "strokeRect:";

	private static readonly IntPtr selStrokeRect_Handle = Selector.GetHandle("strokeRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformUsingAffineTransform_ = "transformUsingAffineTransform:";

	private static readonly IntPtr selTransformUsingAffineTransform_Handle = Selector.GetHandle("transformUsingAffineTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindingRule = "windingRule";

	private static readonly IntPtr selWindingRuleHandle = Selector.GetHandle("windingRule");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSBezierPath");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Bounds
	{
		[Export("bounds")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ControlPointBounds
	{
		[Export("controlPointBounds")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selControlPointBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selControlPointBoundsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint CurrentPoint
	{
		[Export("currentPoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selCurrentPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selCurrentPointHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat DefaultFlatness
	{
		[Export("defaultFlatness")]
		get
		{
			return Messaging.nfloat_objc_msgSend(class_ptr, selDefaultFlatnessHandle);
		}
		[Export("setDefaultFlatness:")]
		set
		{
			Messaging.void_objc_msgSend_nfloat(class_ptr, selSetDefaultFlatness_Handle, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSLineCapStyle DefaultLineCapStyle
	{
		[Export("defaultLineCapStyle")]
		get
		{
			return (NSLineCapStyle)Messaging.UInt64_objc_msgSend(class_ptr, selDefaultLineCapStyleHandle);
		}
		[Export("setDefaultLineCapStyle:")]
		set
		{
			Messaging.void_objc_msgSend_UInt64(class_ptr, selSetDefaultLineCapStyle_Handle, (ulong)value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSLineJoinStyle DefaultLineJoinStyle
	{
		[Export("defaultLineJoinStyle")]
		get
		{
			return (NSLineJoinStyle)Messaging.UInt64_objc_msgSend(class_ptr, selDefaultLineJoinStyleHandle);
		}
		[Export("setDefaultLineJoinStyle:")]
		set
		{
			Messaging.void_objc_msgSend_UInt64(class_ptr, selSetDefaultLineJoinStyle_Handle, (ulong)value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat DefaultLineWidth
	{
		[Export("defaultLineWidth")]
		get
		{
			return Messaging.nfloat_objc_msgSend(class_ptr, selDefaultLineWidthHandle);
		}
		[Export("setDefaultLineWidth:")]
		set
		{
			Messaging.void_objc_msgSend_nfloat(class_ptr, selSetDefaultLineWidth_Handle, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat DefaultMiterLimit
	{
		[Export("defaultMiterLimit")]
		get
		{
			return Messaging.nfloat_objc_msgSend(class_ptr, selDefaultMiterLimitHandle);
		}
		[Export("setDefaultMiterLimit:")]
		set
		{
			Messaging.void_objc_msgSend_nfloat(class_ptr, selSetDefaultMiterLimit_Handle, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSWindingRule DefaultWindingRule
	{
		[Export("defaultWindingRule")]
		get
		{
			return (NSWindingRule)Messaging.UInt64_objc_msgSend(class_ptr, selDefaultWindingRuleHandle);
		}
		[Export("setDefaultWindingRule:")]
		set
		{
			Messaging.void_objc_msgSend_UInt64(class_ptr, selSetDefaultWindingRule_Handle, (ulong)value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ElementCount
	{
		[Export("elementCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selElementCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selElementCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Flatness
	{
		[Export("flatness")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFlatnessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFlatnessHandle);
		}
		[Export("setFlatness:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFlatness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFlatness_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEmpty
	{
		[Export("isEmpty")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEmptyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEmptyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLineCapStyle LineCapStyle
	{
		[Export("lineCapStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSLineCapStyle)Messaging.UInt64_objc_msgSend(base.Handle, selLineCapStyleHandle);
			}
			return (NSLineCapStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLineCapStyleHandle);
		}
		[Export("setLineCapStyle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLineCapStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLineCapStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLineJoinStyle LineJoinStyle
	{
		[Export("lineJoinStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSLineJoinStyle)Messaging.UInt64_objc_msgSend(base.Handle, selLineJoinStyleHandle);
			}
			return (NSLineJoinStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLineJoinStyleHandle);
		}
		[Export("setLineJoinStyle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLineJoinStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLineJoinStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LineWidth
	{
		[Export("lineWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLineWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLineWidthHandle);
		}
		[Export("setLineWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLineWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLineWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MiterLimit
	{
		[Export("miterLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMiterLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMiterLimitHandle);
		}
		[Export("setMiterLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMiterLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMiterLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindingRule WindingRule
	{
		[Export("windingRule")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSWindingRule)Messaging.UInt64_objc_msgSend(base.Handle, selWindingRuleHandle);
			}
			return (NSWindingRule)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selWindingRuleHandle);
		}
		[Export("setWindingRule:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetWindingRule_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetWindingRule_Handle, (ulong)value);
			}
		}
	}

	public unsafe void GetLineDash(out nfloat[] pattern, out nfloat phase)
	{
		_GetLineDash(IntPtr.Zero, out var count, out phase);
		pattern = new nfloat[(long)count];
		fixed (nfloat* ptr = &pattern[0])
		{
			_GetLineDash((IntPtr)ptr, out count, out phase);
		}
	}

	public unsafe void SetLineDash(nfloat[] pattern, nfloat phase)
	{
		if (pattern == null)
		{
			throw new ArgumentNullException("pattern");
		}
		fixed (nfloat* ptr = &pattern[0])
		{
			_SetLineDash((IntPtr)ptr, pattern.Length, phase);
		}
	}

	public unsafe NSBezierPathElement ElementAt(nint index, out CGPoint[] points)
	{
		points = new CGPoint[3];
		NSBezierPathElement nSBezierPathElement;
		fixed (CGPoint* ptr = &points[0])
		{
			nSBezierPathElement = _ElementAt(index, (IntPtr)ptr);
		}
		if (nSBezierPathElement != NSBezierPathElement.CurveTo)
		{
			Array.Resize(ref points, 1);
		}
		return nSBezierPathElement;
	}

	public unsafe void SetAssociatedPointsAtIndex(CGPoint[] points, nint index)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		if (points.Length < 1)
		{
			throw new ArgumentException("points array is empty");
		}
		fixed (CGPoint* ptr = &points[0])
		{
			_SetAssociatedPointsAtIndex((IntPtr)ptr, index);
		}
	}

	public unsafe void Append(CGPoint[] points)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		if (points.Length < 1)
		{
			throw new ArgumentException("points array is empty");
		}
		fixed (CGPoint* ptr = &points[0])
		{
			_AppendPathWithPoints((IntPtr)ptr, points.Length);
		}
	}

	[Obsolete("Use 'Append (CGPoint[])' instead.")]
	public void AppendPathWithPoints(CGPoint[] points)
	{
		Append(points);
	}

	[Obsolete("Use 'Append (uint[], NSFont)' instead.")]
	public unsafe void AppendPathWithGlyphs(uint[] glyphs, NSFont font)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		if (glyphs.Length < 1)
		{
			throw new ArgumentException("glyphs array is empty");
		}
		fixed (uint* ptr = &glyphs[0])
		{
			_AppendPathWithGlyphs((IntPtr)ptr, glyphs.Length, font);
		}
	}

	[Mac(10, 13)]
	public unsafe void Append(uint[] glyphs, NSFont font)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		if (glyphs.Length < 1)
		{
			throw new ArgumentException("glyphs array is empty");
		}
		fixed (uint* ptr = &glyphs[0])
		{
			_AppendBezierPathWithCGGlyphs((IntPtr)ptr, glyphs.Length, font);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBezierPath()
		: base(NSObjectFlag.Empty)
	{
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
	public NSBezierPath(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected NSBezierPath(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSBezierPath(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addClip")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddClip()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAddClipHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAddClipHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Append(NSBezierPath path)
	{
		AppendPath(path);
	}

	[Export("appendBezierPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendPath(NSBezierPath path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendBezierPath_Handle, path.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendBezierPath_Handle, path.Handle);
		}
	}

	[Export("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:clockwise:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendPathWithArc(CGPoint center, nfloat radius, nfloat startAngle, nfloat endAngle, bool clockwise)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_nfloat_nfloat_nfloat_bool(base.Handle, selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_Clockwise_Handle, center, radius, startAngle, endAngle, clockwise);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_nfloat_nfloat_nfloat_bool(base.SuperHandle, selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_Clockwise_Handle, center, radius, startAngle, endAngle, clockwise);
		}
	}

	[Export("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendPathWithArc(CGPoint center, nfloat radius, nfloat startAngle, nfloat endAngle)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_nfloat_nfloat_nfloat(base.Handle, selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_Handle, center, radius, startAngle, endAngle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_nfloat_nfloat_nfloat(base.SuperHandle, selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_Handle, center, radius, startAngle, endAngle);
		}
	}

	[Export("appendBezierPathWithArcFromPoint:toPoint:radius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendPathWithArc(CGPoint point1, CGPoint point2, nfloat radius)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGPoint_nfloat(base.Handle, selAppendBezierPathWithArcFromPoint_ToPoint_Radius_Handle, point1, point2, radius);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_nfloat(base.SuperHandle, selAppendBezierPathWithArcFromPoint_ToPoint_Radius_Handle, point1, point2, radius);
		}
	}

	[Export("appendBezierPathWithCGGlyph:inFont:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendPathWithCGGlyph(ushort glyph, NSFont font)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt16_IntPtr(base.Handle, selAppendBezierPathWithCGGlyph_InFont_Handle, glyph, font.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt16_IntPtr(base.SuperHandle, selAppendBezierPathWithCGGlyph_InFont_Handle, glyph, font.Handle);
		}
	}

	[Export("appendBezierPathWithGlyph:inFont:")]
	[Obsoleted(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'AppendPathWithCGGlyph (CGGlyph, NSFont)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendPathWithGlyph(uint glyph, NSFont font)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_IntPtr(base.Handle, selAppendBezierPathWithGlyph_InFont_Handle, glyph, font.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_IntPtr(base.SuperHandle, selAppendBezierPathWithGlyph_InFont_Handle, glyph, font.Handle);
		}
	}

	[Export("appendBezierPathWithOvalInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendPathWithOvalInRect(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selAppendBezierPathWithOvalInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selAppendBezierPathWithOvalInRect_Handle, rect);
		}
	}

	[Export("appendBezierPathWithPackedGlyphs:")]
	[Obsoleted(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'Append (uint[], NSFont)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendPathWithPackedGlyphs(IntPtr packedGlyphs)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendBezierPathWithPackedGlyphs_Handle, packedGlyphs);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendBezierPathWithPackedGlyphs_Handle, packedGlyphs);
		}
	}

	[Export("appendBezierPathWithRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendPathWithRect(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selAppendBezierPathWithRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selAppendBezierPathWithRect_Handle, rect);
		}
	}

	[Export("appendBezierPathWithRoundedRect:xRadius:yRadius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendPathWithRoundedRect(CGRect rect, nfloat xRadius, nfloat yRadius)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_nfloat_nfloat(base.Handle, selAppendBezierPathWithRoundedRect_XRadius_YRadius_Handle, rect, xRadius, yRadius);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_nfloat_nfloat(base.SuperHandle, selAppendBezierPathWithRoundedRect_XRadius_YRadius_Handle, rect, xRadius, yRadius);
		}
	}

	[Export("bezierPathByFlatteningPath")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBezierPath BezierPathByFlatteningPath()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selBezierPathByFlatteningPathHandle));
		}
		return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBezierPathByFlatteningPathHandle));
	}

	[Export("bezierPathByReversingPath")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBezierPath BezierPathByReversingPath()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selBezierPathByReversingPathHandle));
		}
		return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBezierPathByReversingPathHandle));
	}

	[Export("clipRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ClipRect(CGRect rect)
	{
		Messaging.void_objc_msgSend_CGRect(class_ptr, selClipRect_Handle, rect);
	}

	[Export("closePath")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClosePath()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClosePathHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClosePathHandle);
		}
	}

	[Export("containsPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint(base.Handle, selContainsPoint_Handle, point);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint(base.SuperHandle, selContainsPoint_Handle, point);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("curveToPoint:controlPoint1:controlPoint2:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CurveTo(CGPoint endPoint, CGPoint controlPoint1, CGPoint controlPoint2)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGPoint_CGPoint(base.Handle, selCurveToPoint_ControlPoint1_ControlPoint2_Handle, endPoint, controlPoint1, controlPoint2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_CGPoint(base.SuperHandle, selCurveToPoint_ControlPoint1_ControlPoint2_Handle, endPoint, controlPoint1, controlPoint2);
		}
	}

	[Export("drawPackedGlyphs:atPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawPackedGlyphsAtPoint(IntPtr packedGlyphs, CGPoint point)
	{
		Messaging.void_objc_msgSend_IntPtr_CGPoint(class_ptr, selDrawPackedGlyphs_AtPoint_Handle, packedGlyphs, point);
	}

	[Export("elementAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBezierPathElement ElementAt(nint index)
	{
		if (base.IsDirectBinding)
		{
			return (NSBezierPathElement)Messaging.UInt64_objc_msgSend_nint(base.Handle, selElementAtIndex_Handle, index);
		}
		return (NSBezierPathElement)Messaging.UInt64_objc_msgSendSuper_nint(base.SuperHandle, selElementAtIndex_Handle, index);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
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

	[Export("fill")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Fill()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFillHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFillHandle);
		}
	}

	[Export("fillRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FillRect(CGRect rect)
	{
		Messaging.void_objc_msgSend_CGRect(class_ptr, selFillRect_Handle, rect);
	}

	[Export("bezierPathWithOvalInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBezierPath FromOvalInRect(CGRect rect)
	{
		return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selBezierPathWithOvalInRect_Handle, rect));
	}

	[Export("bezierPathWithRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBezierPath FromRect(CGRect rect)
	{
		return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selBezierPathWithRect_Handle, rect));
	}

	[Export("bezierPathWithRoundedRect:xRadius:yRadius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBezierPath FromRoundedRect(CGRect rect, nfloat xRadius, nfloat yRadius)
	{
		return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSend_CGRect_nfloat_nfloat(class_ptr, selBezierPathWithRoundedRect_XRadius_YRadius_Handle, rect, xRadius, yRadius));
	}

	[Export("lineToPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LineTo(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selLineToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selLineToPoint_Handle, point);
		}
	}

	[Export("moveToPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveTo(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selMoveToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selMoveToPoint_Handle, point);
		}
	}

	[Export("relativeCurveToPoint:controlPoint1:controlPoint2:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RelativeCurveTo(CGPoint endPoint, CGPoint controlPoint1, CGPoint controlPoint2)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGPoint_CGPoint(base.Handle, selRelativeCurveToPoint_ControlPoint1_ControlPoint2_Handle, endPoint, controlPoint1, controlPoint2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_CGPoint(base.SuperHandle, selRelativeCurveToPoint_ControlPoint1_ControlPoint2_Handle, endPoint, controlPoint1, controlPoint2);
		}
	}

	[Export("relativeLineToPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RelativeLineTo(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selRelativeLineToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selRelativeLineToPoint_Handle, point);
		}
	}

	[Export("relativeMoveToPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RelativeMoveTo(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selRelativeMoveToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selRelativeMoveToPoint_Handle, point);
		}
	}

	[Export("removeAllPoints")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllPoints()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllPointsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllPointsHandle);
		}
	}

	[Export("setClip")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetClip()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetClipHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetClipHandle);
		}
	}

	[Export("stroke")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Stroke()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStrokeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStrokeHandle);
		}
	}

	[Export("strokeLineFromPoint:toPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void StrokeLine(CGPoint point1, CGPoint point2)
	{
		Messaging.void_objc_msgSend_CGPoint_CGPoint(class_ptr, selStrokeLineFromPoint_ToPoint_Handle, point1, point2);
	}

	[Export("strokeRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void StrokeRect(CGRect rect)
	{
		Messaging.void_objc_msgSend_CGRect(class_ptr, selStrokeRect_Handle, rect);
	}

	[Export("transformUsingAffineTransform:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TransformUsingAffineTransform(NSAffineTransform transform)
	{
		if (transform == null)
		{
			throw new ArgumentNullException("transform");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTransformUsingAffineTransform_Handle, transform.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTransformUsingAffineTransform_Handle, transform.Handle);
		}
	}

	[Export("appendBezierPathWithCGGlyphs:count:inFont:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _AppendBezierPathWithCGGlyphs(IntPtr glyphs, nint count, NSFont font)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint_IntPtr(base.Handle, selAppendBezierPathWithCGGlyphs_Count_InFont_Handle, glyphs, count, font.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint_IntPtr(base.SuperHandle, selAppendBezierPathWithCGGlyphs_Count_InFont_Handle, glyphs, count, font.Handle);
		}
	}

	[Export("appendBezierPathWithGlyphs:count:inFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _AppendPathWithGlyphs(IntPtr glyphs, nint count, NSFont font)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint_IntPtr(base.Handle, selAppendBezierPathWithGlyphs_Count_InFont_Handle, glyphs, count, font.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint_IntPtr(base.SuperHandle, selAppendBezierPathWithGlyphs_Count_InFont_Handle, glyphs, count, font.Handle);
		}
	}

	[Export("appendBezierPathWithPoints:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _AppendPathWithPoints(IntPtr points, nint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selAppendBezierPathWithPoints_Count_Handle, points, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selAppendBezierPathWithPoints_Count_Handle, points, count);
		}
	}

	[Export("elementAtIndex:associatedPoints:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSBezierPathElement _ElementAt(nint index, IntPtr points)
	{
		if (base.IsDirectBinding)
		{
			return (NSBezierPathElement)Messaging.UInt64_objc_msgSend_nint_IntPtr(base.Handle, selElementAtIndex_AssociatedPoints_Handle, index, points);
		}
		return (NSBezierPathElement)Messaging.UInt64_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selElementAtIndex_AssociatedPoints_Handle, index, points);
	}

	[Export("getLineDash:count:phase:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _GetLineDash(IntPtr pattern, out nint count, out nfloat phase)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_out_nint_out_nfloat(base.Handle, selGetLineDash_Count_Phase_Handle, pattern, out count, out phase);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_out_nint_out_nfloat(base.SuperHandle, selGetLineDash_Count_Phase_Handle, pattern, out count, out phase);
		}
	}

	[Export("setAssociatedPoints:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetAssociatedPointsAtIndex(IntPtr points, nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetAssociatedPoints_AtIndex_Handle, points, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetAssociatedPoints_AtIndex_Handle, points, index);
		}
	}

	[Export("setLineDash:count:phase:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetLineDash(IntPtr pattern, nint count, nfloat phase)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint_nfloat(base.Handle, selSetLineDash_Count_Phase_Handle, pattern, count, phase);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint_nfloat(base.SuperHandle, selSetLineDash_Count_Phase_Handle, pattern, count, phase);
		}
	}
}
