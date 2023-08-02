using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSBezierPath", true)]
public class NSBezierPath : NSObject
{
	private static readonly IntPtr selIsEmptyHandle = Selector.GetHandle("isEmpty");

	private static readonly IntPtr selCurrentPointHandle = Selector.GetHandle("currentPoint");

	private static readonly IntPtr selControlPointBoundsHandle = Selector.GetHandle("controlPointBounds");

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	private static readonly IntPtr selElementCountHandle = Selector.GetHandle("elementCount");

	private static readonly IntPtr selDefaultMiterLimitHandle = Selector.GetHandle("defaultMiterLimit");

	private static readonly IntPtr selSetDefaultMiterLimit_Handle = Selector.GetHandle("setDefaultMiterLimit:");

	private static readonly IntPtr selDefaultFlatnessHandle = Selector.GetHandle("defaultFlatness");

	private static readonly IntPtr selSetDefaultFlatness_Handle = Selector.GetHandle("setDefaultFlatness:");

	private static readonly IntPtr selDefaultWindingRuleHandle = Selector.GetHandle("defaultWindingRule");

	private static readonly IntPtr selSetDefaultWindingRule_Handle = Selector.GetHandle("setDefaultWindingRule:");

	private static readonly IntPtr selDefaultLineCapStyleHandle = Selector.GetHandle("defaultLineCapStyle");

	private static readonly IntPtr selSetDefaultLineCapStyle_Handle = Selector.GetHandle("setDefaultLineCapStyle:");

	private static readonly IntPtr selDefaultLineJoinStyleHandle = Selector.GetHandle("defaultLineJoinStyle");

	private static readonly IntPtr selSetDefaultLineJoinStyle_Handle = Selector.GetHandle("setDefaultLineJoinStyle:");

	private static readonly IntPtr selDefaultLineWidthHandle = Selector.GetHandle("defaultLineWidth");

	private static readonly IntPtr selSetDefaultLineWidth_Handle = Selector.GetHandle("setDefaultLineWidth:");

	private static readonly IntPtr selLineWidthHandle = Selector.GetHandle("lineWidth");

	private static readonly IntPtr selSetLineWidth_Handle = Selector.GetHandle("setLineWidth:");

	private static readonly IntPtr selLineCapStyleHandle = Selector.GetHandle("lineCapStyle");

	private static readonly IntPtr selSetLineCapStyle_Handle = Selector.GetHandle("setLineCapStyle:");

	private static readonly IntPtr selLineJoinStyleHandle = Selector.GetHandle("lineJoinStyle");

	private static readonly IntPtr selSetLineJoinStyle_Handle = Selector.GetHandle("setLineJoinStyle:");

	private static readonly IntPtr selWindingRuleHandle = Selector.GetHandle("windingRule");

	private static readonly IntPtr selSetWindingRule_Handle = Selector.GetHandle("setWindingRule:");

	private static readonly IntPtr selMiterLimitHandle = Selector.GetHandle("miterLimit");

	private static readonly IntPtr selSetMiterLimit_Handle = Selector.GetHandle("setMiterLimit:");

	private static readonly IntPtr selFlatnessHandle = Selector.GetHandle("flatness");

	private static readonly IntPtr selSetFlatness_Handle = Selector.GetHandle("setFlatness:");

	private static readonly IntPtr selBezierPathWithRect_Handle = Selector.GetHandle("bezierPathWithRect:");

	private static readonly IntPtr selBezierPathWithOvalInRect_Handle = Selector.GetHandle("bezierPathWithOvalInRect:");

	private static readonly IntPtr selBezierPathWithRoundedRectXRadiusYRadius_Handle = Selector.GetHandle("bezierPathWithRoundedRect:xRadius:yRadius:");

	private static readonly IntPtr selFillRect_Handle = Selector.GetHandle("fillRect:");

	private static readonly IntPtr selStrokeRect_Handle = Selector.GetHandle("strokeRect:");

	private static readonly IntPtr selClipRect_Handle = Selector.GetHandle("clipRect:");

	private static readonly IntPtr selStrokeLineFromPointToPoint_Handle = Selector.GetHandle("strokeLineFromPoint:toPoint:");

	private static readonly IntPtr selDrawPackedGlyphsAtPoint_Handle = Selector.GetHandle("drawPackedGlyphs:atPoint:");

	private static readonly IntPtr selMoveToPoint_Handle = Selector.GetHandle("moveToPoint:");

	private static readonly IntPtr selLineToPoint_Handle = Selector.GetHandle("lineToPoint:");

	private static readonly IntPtr selCurveToPointControlPoint1ControlPoint2_Handle = Selector.GetHandle("curveToPoint:controlPoint1:controlPoint2:");

	private static readonly IntPtr selClosePathHandle = Selector.GetHandle("closePath");

	private static readonly IntPtr selRemoveAllPointsHandle = Selector.GetHandle("removeAllPoints");

	private static readonly IntPtr selRelativeMoveToPoint_Handle = Selector.GetHandle("relativeMoveToPoint:");

	private static readonly IntPtr selRelativeLineToPoint_Handle = Selector.GetHandle("relativeLineToPoint:");

	private static readonly IntPtr selRelativeCurveToPointControlPoint1ControlPoint2_Handle = Selector.GetHandle("relativeCurveToPoint:controlPoint1:controlPoint2:");

	private static readonly IntPtr selGetLineDashCountPhase_Handle = Selector.GetHandle("getLineDash:count:phase:");

	private static readonly IntPtr selSetLineDashCountPhase_Handle = Selector.GetHandle("setLineDash:count:phase:");

	private static readonly IntPtr selStrokeHandle = Selector.GetHandle("stroke");

	private static readonly IntPtr selFillHandle = Selector.GetHandle("fill");

	private static readonly IntPtr selAddClipHandle = Selector.GetHandle("addClip");

	private static readonly IntPtr selSetClipHandle = Selector.GetHandle("setClip");

	private static readonly IntPtr selBezierPathByFlatteningPathHandle = Selector.GetHandle("bezierPathByFlatteningPath");

	private static readonly IntPtr selBezierPathByReversingPathHandle = Selector.GetHandle("bezierPathByReversingPath");

	private static readonly IntPtr selTransformUsingAffineTransform_Handle = Selector.GetHandle("transformUsingAffineTransform:");

	private static readonly IntPtr selElementAtIndexAssociatedPoints_Handle = Selector.GetHandle("elementAtIndex:associatedPoints:");

	private static readonly IntPtr selElementAtIndex_Handle = Selector.GetHandle("elementAtIndex:");

	private static readonly IntPtr selSetAssociatedPointsAtIndex_Handle = Selector.GetHandle("setAssociatedPoints:atIndex:");

	private static readonly IntPtr selAppendBezierPath_Handle = Selector.GetHandle("appendBezierPath:");

	private static readonly IntPtr selAppendBezierPathWithRect_Handle = Selector.GetHandle("appendBezierPathWithRect:");

	private static readonly IntPtr selAppendBezierPathWithPointsCount_Handle = Selector.GetHandle("appendBezierPathWithPoints:count:");

	private static readonly IntPtr selAppendBezierPathWithOvalInRect_Handle = Selector.GetHandle("appendBezierPathWithOvalInRect:");

	private static readonly IntPtr selAppendBezierPathWithArcWithCenterRadiusStartAngleEndAngleClockwise_Handle = Selector.GetHandle("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:clockwise:");

	private static readonly IntPtr selAppendBezierPathWithArcWithCenterRadiusStartAngleEndAngle_Handle = Selector.GetHandle("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:");

	private static readonly IntPtr selAppendBezierPathWithArcFromPointToPointRadius_Handle = Selector.GetHandle("appendBezierPathWithArcFromPoint:toPoint:radius:");

	private static readonly IntPtr selAppendBezierPathWithGlyphInFont_Handle = Selector.GetHandle("appendBezierPathWithGlyph:inFont:");

	private static readonly IntPtr selAppendBezierPathWithGlyphsCountInFont_Handle = Selector.GetHandle("appendBezierPathWithGlyphs:count:inFont:");

	private static readonly IntPtr selAppendBezierPathWithPackedGlyphs_Handle = Selector.GetHandle("appendBezierPathWithPackedGlyphs:");

	private static readonly IntPtr selAppendBezierPathWithRoundedRectXRadiusYRadius_Handle = Selector.GetHandle("appendBezierPathWithRoundedRect:xRadius:yRadius:");

	private static readonly IntPtr selContainsPoint_Handle = Selector.GetHandle("containsPoint:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSBezierPath");

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool IsEmpty
	{
		[Export("isEmpty")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEmptyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEmptyHandle);
		}
	}

	public virtual CGPoint CurrentPoint
	{
		[Export("currentPoint")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selCurrentPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selCurrentPointHandle);
		}
	}

	public virtual CGRect ControlPointBounds
	{
		[Export("controlPointBounds")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual CGRect Bounds
	{
		[Export("bounds")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual long ElementCount
	{
		[Export("elementCount")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selElementCountHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selElementCountHandle);
		}
	}

	public static double DefaultMiterLimit
	{
		[Export("defaultMiterLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selDefaultMiterLimitHandle);
		}
		[Export("setDefaultMiterLimit:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_Double(class_ptr, selSetDefaultMiterLimit_Handle, value);
		}
	}

	public static double DefaultFlatness
	{
		[Export("defaultFlatness")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selDefaultFlatnessHandle);
		}
		[Export("setDefaultFlatness:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_Double(class_ptr, selSetDefaultFlatness_Handle, value);
		}
	}

	public static NSWindingRule DefaultWindingRule
	{
		[Export("defaultWindingRule")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindingRule)Messaging.int_objc_msgSend(class_ptr, selDefaultWindingRuleHandle);
		}
		[Export("setDefaultWindingRule:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_int(class_ptr, selSetDefaultWindingRule_Handle, (int)value);
		}
	}

	public static NSLineCapStyle DefaultLineCapStyle
	{
		[Export("defaultLineCapStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSLineCapStyle)Messaging.int_objc_msgSend(class_ptr, selDefaultLineCapStyleHandle);
		}
		[Export("setDefaultLineCapStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_int(class_ptr, selSetDefaultLineCapStyle_Handle, (int)value);
		}
	}

	public static NSLineJoinStyle DefaultLineJoinStyle
	{
		[Export("defaultLineJoinStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSLineJoinStyle)Messaging.int_objc_msgSend(class_ptr, selDefaultLineJoinStyleHandle);
		}
		[Export("setDefaultLineJoinStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_int(class_ptr, selSetDefaultLineJoinStyle_Handle, (int)value);
		}
	}

	public static double DefaultLineWidth
	{
		[Export("defaultLineWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selDefaultLineWidthHandle);
		}
		[Export("setDefaultLineWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_Double(class_ptr, selSetDefaultLineWidth_Handle, value);
		}
	}

	public virtual double LineWidth
	{
		[Export("lineWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLineWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLineWidthHandle);
		}
		[Export("setLineWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetLineWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetLineWidth_Handle, value);
			}
		}
	}

	public virtual NSLineCapStyle LineCapStyle
	{
		[Export("lineCapStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSLineCapStyle)Messaging.int_objc_msgSend(base.Handle, selLineCapStyleHandle);
			}
			return (NSLineCapStyle)Messaging.int_objc_msgSendSuper(base.SuperHandle, selLineCapStyleHandle);
		}
		[Export("setLineCapStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetLineCapStyle_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetLineCapStyle_Handle, (int)value);
			}
		}
	}

	public virtual NSLineJoinStyle LineJoinStyle
	{
		[Export("lineJoinStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSLineJoinStyle)Messaging.int_objc_msgSend(base.Handle, selLineJoinStyleHandle);
			}
			return (NSLineJoinStyle)Messaging.int_objc_msgSendSuper(base.SuperHandle, selLineJoinStyleHandle);
		}
		[Export("setLineJoinStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetLineJoinStyle_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetLineJoinStyle_Handle, (int)value);
			}
		}
	}

	public virtual NSWindingRule WindingRule
	{
		[Export("windingRule")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWindingRule)Messaging.int_objc_msgSend(base.Handle, selWindingRuleHandle);
			}
			return (NSWindingRule)Messaging.int_objc_msgSendSuper(base.SuperHandle, selWindingRuleHandle);
		}
		[Export("setWindingRule:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetWindingRule_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetWindingRule_Handle, (int)value);
			}
		}
	}

	public virtual double MiterLimit
	{
		[Export("miterLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMiterLimitHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMiterLimitHandle);
		}
		[Export("setMiterLimit:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMiterLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMiterLimit_Handle, value);
			}
		}
	}

	public virtual double Flatness
	{
		[Export("flatness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selFlatnessHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selFlatnessHandle);
		}
		[Export("setFlatness:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetFlatness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetFlatness_Handle, value);
			}
		}
	}

	public unsafe void GetLineDash(out double[] pattern, out double phase)
	{
		_GetLineDash((IntPtr)(void*)null, out var count, out phase);
		int num = (int)count;
		double[] array = new double[num];
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(array[0]) * num);
		_GetLineDash(intPtr, out count, out phase);
		num = (int)count;
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		pattern = array;
	}

	public void SetLineDash(double[] pattern, double phase)
	{
		if (pattern == null)
		{
			throw new ArgumentNullException("pattern");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(pattern[0]) * pattern.Length);
		Marshal.Copy(pattern, 0, intPtr, pattern.Length);
		_SetLineDash(intPtr, pattern.Length, phase);
		Marshal.FreeHGlobal(intPtr);
	}

	public NSBezierPathElement ElementAt(long index, out CGPoint[] points)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(CGPoint)) * 3);
		NSBezierPathElement nSBezierPathElement = _ElementAt(index, intPtr);
		int num = 1;
		if (nSBezierPathElement == NSBezierPathElement.CurveTo)
		{
			num = 3;
		}
		points = new CGPoint[num];
		IntPtr intPtr2 = intPtr;
		for (int i = 0; i < num; i++)
		{
			points[i] = (CGPoint)Marshal.PtrToStructure(intPtr2, typeof(CGPoint));
			intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf(points[i]));
		}
		Marshal.FreeHGlobal(intPtr);
		return nSBezierPathElement;
	}

	public void SetAssociatedPointsAtIndex(CGPoint[] points, long index)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		if (points.Length < 1)
		{
			throw new ArgumentException("points array is empty");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(points[0]) * points.Length);
		IntPtr intPtr2 = intPtr;
		for (int i = 0; i < points.Length; i++)
		{
			Marshal.StructureToPtr(points[i], intPtr2, fDeleteOld: false);
			intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf(points[i]));
		}
		_SetAssociatedPointsAtIndex(intPtr, index);
		Marshal.FreeHGlobal(intPtr);
	}

	public void AppendPathWithPoints(CGPoint[] points)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		if (points.Length < 1)
		{
			throw new ArgumentException("points array is empty");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(points[0]) * points.Length);
		IntPtr intPtr2 = intPtr;
		for (int i = 0; i < points.Length; i++)
		{
			Marshal.StructureToPtr(points[i], intPtr2, fDeleteOld: false);
			intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf(points[i]));
		}
		_AppendPathWithPoints(intPtr, points.Length);
		Marshal.FreeHGlobal(intPtr);
	}

	public void AppendPathWithGlyphs(uint[] glyphs, NSFont font)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		if (glyphs.Length < 1)
		{
			throw new ArgumentException("glyphs array is empty");
		}
		int num = Marshal.SizeOf(glyphs[0]);
		IntPtr intPtr = Marshal.AllocHGlobal(num * glyphs.Length);
		IntPtr intPtr2 = intPtr;
		for (int i = 0; i < glyphs.Length; i++)
		{
			Marshal.WriteIntPtr(intPtr2, (IntPtr)glyphs[i]);
			intPtr2 = (IntPtr)((long)intPtr2 + num);
		}
		_AppendPathWithGlyphs(intPtr, glyphs.Length, font);
		Marshal.FreeHGlobal(intPtr);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBezierPath()
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
	public NSBezierPath(NSCoder coder)
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
	public NSBezierPath(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSBezierPath(IntPtr handle)
		: base(handle)
	{
	}

	[Export("bezierPathWithRect:")]
	public static NSBezierPath FromRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		return (NSBezierPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selBezierPathWithRect_Handle, rect));
	}

	[Export("bezierPathWithOvalInRect:")]
	public static NSBezierPath FromOvalInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		return (NSBezierPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selBezierPathWithOvalInRect_Handle, rect));
	}

	[Export("bezierPathWithRoundedRect:xRadius:yRadius:")]
	public static NSBezierPath FromRoundedRect(CGRect rect, double xRadius, double yRadius)
	{
		NSApplication.EnsureUIThread();
		return (NSBezierPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect_Double_Double(class_ptr, selBezierPathWithRoundedRectXRadiusYRadius_Handle, rect, xRadius, yRadius));
	}

	[Export("fillRect:")]
	public static void FillRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_CGRect(class_ptr, selFillRect_Handle, rect);
	}

	[Export("strokeRect:")]
	public static void StrokeRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_CGRect(class_ptr, selStrokeRect_Handle, rect);
	}

	[Export("clipRect:")]
	public static void ClipRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_CGRect(class_ptr, selClipRect_Handle, rect);
	}

	[Export("strokeLineFromPoint:toPoint:")]
	public static void StrokeLine(CGPoint point1, CGPoint point2)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_CGPoint_CGPoint(class_ptr, selStrokeLineFromPointToPoint_Handle, point1, point2);
	}

	[Export("drawPackedGlyphs:atPoint:")]
	public static void DrawPackedGlyphsAtPoint(IntPtr packedGlyphs, CGPoint point)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr_CGPoint(class_ptr, selDrawPackedGlyphsAtPoint_Handle, packedGlyphs, point);
	}

	[Export("moveToPoint:")]
	public virtual void MoveTo(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selMoveToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selMoveToPoint_Handle, point);
		}
	}

	[Export("lineToPoint:")]
	public virtual void LineTo(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selLineToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selLineToPoint_Handle, point);
		}
	}

	[Export("curveToPoint:controlPoint1:controlPoint2:")]
	public virtual void CurveTo(CGPoint endPoint, CGPoint controlPoint1, CGPoint controlPoint2)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGPoint_CGPoint(base.Handle, selCurveToPointControlPoint1ControlPoint2_Handle, endPoint, controlPoint1, controlPoint2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_CGPoint(base.SuperHandle, selCurveToPointControlPoint1ControlPoint2_Handle, endPoint, controlPoint1, controlPoint2);
		}
	}

	[Export("closePath")]
	public virtual void ClosePath()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClosePathHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClosePathHandle);
		}
	}

	[Export("removeAllPoints")]
	public virtual void RemoveAllPoints()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllPointsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllPointsHandle);
		}
	}

	[Export("relativeMoveToPoint:")]
	public virtual void RelativeMoveTo(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selRelativeMoveToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selRelativeMoveToPoint_Handle, point);
		}
	}

	[Export("relativeLineToPoint:")]
	public virtual void RelativeLineTo(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selRelativeLineToPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selRelativeLineToPoint_Handle, point);
		}
	}

	[Export("relativeCurveToPoint:controlPoint1:controlPoint2:")]
	public virtual void RelativeCurveTo(CGPoint endPoint, CGPoint controlPoint1, CGPoint controlPoint2)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGPoint_CGPoint(base.Handle, selRelativeCurveToPointControlPoint1ControlPoint2_Handle, endPoint, controlPoint1, controlPoint2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_CGPoint(base.SuperHandle, selRelativeCurveToPointControlPoint1ControlPoint2_Handle, endPoint, controlPoint1, controlPoint2);
		}
	}

	[Export("getLineDash:count:phase:")]
	internal virtual void _GetLineDash(IntPtr pattern, out long count, out double phase)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_out_Int64_out_Double(base.Handle, selGetLineDashCountPhase_Handle, pattern, out count, out phase);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_out_Int64_out_Double(base.SuperHandle, selGetLineDashCountPhase_Handle, pattern, out count, out phase);
		}
	}

	[Export("setLineDash:count:phase:")]
	internal virtual void _SetLineDash(IntPtr pattern, long count, double phase)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_Double(base.Handle, selSetLineDashCountPhase_Handle, pattern, count, phase);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_Double(base.SuperHandle, selSetLineDashCountPhase_Handle, pattern, count, phase);
		}
	}

	[Export("stroke")]
	public virtual void Stroke()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStrokeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStrokeHandle);
		}
	}

	[Export("fill")]
	public virtual void Fill()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFillHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFillHandle);
		}
	}

	[Export("addClip")]
	public virtual void AddClip()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAddClipHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAddClipHandle);
		}
	}

	[Export("setClip")]
	public virtual void SetClip()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetClipHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetClipHandle);
		}
	}

	[Export("bezierPathByFlatteningPath")]
	public virtual NSBezierPath BezierPathByFlatteningPath()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSBezierPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBezierPathByFlatteningPathHandle));
		}
		return (NSBezierPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBezierPathByFlatteningPathHandle));
	}

	[Export("bezierPathByReversingPath")]
	public virtual NSBezierPath BezierPathByReversingPath()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSBezierPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBezierPathByReversingPathHandle));
		}
		return (NSBezierPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBezierPathByReversingPathHandle));
	}

	[Export("transformUsingAffineTransform:")]
	public virtual void TransformUsingAffineTransform(NSAffineTransform transform)
	{
		NSApplication.EnsureUIThread();
		if (transform == null)
		{
			throw new ArgumentNullException("transform");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTransformUsingAffineTransform_Handle, transform.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTransformUsingAffineTransform_Handle, transform.Handle);
		}
	}

	[Export("elementAtIndex:associatedPoints:")]
	internal virtual NSBezierPathElement _ElementAt(long index, IntPtr points)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSBezierPathElement)Messaging.int_objc_msgSend_Int64_IntPtr(base.Handle, selElementAtIndexAssociatedPoints_Handle, index, points);
		}
		return (NSBezierPathElement)Messaging.int_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selElementAtIndexAssociatedPoints_Handle, index, points);
	}

	[Export("elementAtIndex:")]
	public virtual NSBezierPathElement ElementAt(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSBezierPathElement)Messaging.int_objc_msgSend_Int64(base.Handle, selElementAtIndex_Handle, index);
		}
		return (NSBezierPathElement)Messaging.int_objc_msgSendSuper_Int64(base.SuperHandle, selElementAtIndex_Handle, index);
	}

	[Export("setAssociatedPoints:atIndex:")]
	internal virtual void _SetAssociatedPointsAtIndex(IntPtr points, long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetAssociatedPointsAtIndex_Handle, points, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetAssociatedPointsAtIndex_Handle, points, index);
		}
	}

	[Export("appendBezierPath:")]
	public virtual void AppendPath(NSBezierPath path)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendBezierPath_Handle, path.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendBezierPath_Handle, path.Handle);
		}
	}

	[Export("appendBezierPathWithRect:")]
	public virtual void AppendPathWithRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selAppendBezierPathWithRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selAppendBezierPathWithRect_Handle, rect);
		}
	}

	[Export("appendBezierPathWithPoints:count:")]
	internal virtual void _AppendPathWithPoints(IntPtr points, long count)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selAppendBezierPathWithPointsCount_Handle, points, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selAppendBezierPathWithPointsCount_Handle, points, count);
		}
	}

	[Export("appendBezierPathWithOvalInRect:")]
	public virtual void AppendPathWithOvalInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selAppendBezierPathWithOvalInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selAppendBezierPathWithOvalInRect_Handle, rect);
		}
	}

	[Export("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:clockwise:")]
	public virtual void AppendPathWithArc(CGPoint center, double radius, double startAngle, double endAngle, bool clockwise)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_Double_Double_Double_bool(base.Handle, selAppendBezierPathWithArcWithCenterRadiusStartAngleEndAngleClockwise_Handle, center, radius, startAngle, endAngle, clockwise);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_Double_Double_Double_bool(base.SuperHandle, selAppendBezierPathWithArcWithCenterRadiusStartAngleEndAngleClockwise_Handle, center, radius, startAngle, endAngle, clockwise);
		}
	}

	[Export("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:")]
	public virtual void AppendPathWithArc(CGPoint center, double radius, double startAngle, double endAngle)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_Double_Double_Double(base.Handle, selAppendBezierPathWithArcWithCenterRadiusStartAngleEndAngle_Handle, center, radius, startAngle, endAngle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_Double_Double_Double(base.SuperHandle, selAppendBezierPathWithArcWithCenterRadiusStartAngleEndAngle_Handle, center, radius, startAngle, endAngle);
		}
	}

	[Export("appendBezierPathWithArcFromPoint:toPoint:radius:")]
	public virtual void AppendPathWithArc(CGPoint point1, CGPoint point2, double radius)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGPoint_Double(base.Handle, selAppendBezierPathWithArcFromPointToPointRadius_Handle, point1, point2, radius);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_Double(base.SuperHandle, selAppendBezierPathWithArcFromPointToPointRadius_Handle, point1, point2, radius);
		}
	}

	[Export("appendBezierPathWithGlyph:inFont:")]
	public virtual void AppendPathWithGlyph(ulong glyph, NSFont font)
	{
		NSApplication.EnsureUIThread();
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selAppendBezierPathWithGlyphInFont_Handle, glyph, font.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selAppendBezierPathWithGlyphInFont_Handle, glyph, font.Handle);
		}
	}

	[Export("appendBezierPathWithGlyphs:count:inFont:")]
	internal virtual void _AppendPathWithGlyphs(IntPtr glyphs, long count, NSFont font)
	{
		NSApplication.EnsureUIThread();
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selAppendBezierPathWithGlyphsCountInFont_Handle, glyphs, count, font.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selAppendBezierPathWithGlyphsCountInFont_Handle, glyphs, count, font.Handle);
		}
	}

	[Export("appendBezierPathWithPackedGlyphs:")]
	public virtual void AppendPathWithPackedGlyphs(IntPtr packedGlyphs)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendBezierPathWithPackedGlyphs_Handle, packedGlyphs);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendBezierPathWithPackedGlyphs_Handle, packedGlyphs);
		}
	}

	[Export("appendBezierPathWithRoundedRect:xRadius:yRadius:")]
	public virtual void AppendPathWithRoundedRect(CGRect rect, double xRadius, double yRadius)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_Double_Double(base.Handle, selAppendBezierPathWithRoundedRectXRadiusYRadius_Handle, rect, xRadius, yRadius);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_Double_Double(base.SuperHandle, selAppendBezierPathWithRoundedRectXRadiusYRadius_Handle, rect, xRadius, yRadius);
		}
	}

	[Export("containsPoint:")]
	public virtual bool Contains(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint(base.Handle, selContainsPoint_Handle, point);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint(base.SuperHandle, selContainsPoint_Handle, point);
	}
}
