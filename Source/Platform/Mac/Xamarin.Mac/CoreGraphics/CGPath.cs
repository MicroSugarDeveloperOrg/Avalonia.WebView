using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPath : INativeObject, IDisposable
{
	public delegate void ApplierFunction(CGPathElement element);

	private delegate void CGPathApplierFunction(IntPtr info, IntPtr CGPathElementPtr);

	internal IntPtr handle;

	public IntPtr Handle => handle;

	public bool IsEmpty => CGPathIsEmpty(handle) != 0;

	public CGPoint CurrentPoint => CGPathGetCurrentPoint(handle);

	public CGRect BoundingBox => CGPathGetBoundingBox(handle);

	public CGRect PathBoundingBox => CGPathGetPathBoundingBox(handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPathCreateMutable();

	public CGPath()
	{
		handle = CGPathCreateMutable();
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPathCreateMutableCopy(IntPtr path);

	public CGPath(CGPath basePath)
	{
		if (basePath == null)
		{
			throw new ArgumentNullException("basePath");
		}
		handle = CGPathCreateMutableCopy(basePath.handle);
	}

	public CGPath(IntPtr handle)
	{
		CGPathRetain(handle);
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGPath(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CGPathRetain(handle);
		}
		this.handle = handle;
	}

	~CGPath()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGPathRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPathEqualToPath(IntPtr path1, IntPtr path2);

	public static bool operator ==(CGPath path1, CGPath path2)
	{
		return object.Equals(path1, path2);
	}

	public static bool operator !=(CGPath path1, CGPath path2)
	{
		return !object.Equals(path1, path2);
	}

	public override int GetHashCode()
	{
		return handle.GetHashCode();
	}

	public override bool Equals(object o)
	{
		CGPath cGPath = o as CGPath;
		if (cGPath == null)
		{
			return false;
		}
		return CGPathEqualToPath(handle, cGPath.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathMoveToPoint(IntPtr path, ref CGAffineTransform m, double x, double y);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathMoveToPoint(IntPtr path, IntPtr zero, double x, double y);

	public void MoveToPoint(double x, double y)
	{
		CGPathMoveToPoint(handle, IntPtr.Zero, x, y);
	}

	public void MoveToPoint(CGPoint point)
	{
		CGPathMoveToPoint(handle, IntPtr.Zero, point.X, point.Y);
	}

	public void MoveToPoint(CGAffineTransform transform, double x, double y)
	{
		CGPathMoveToPoint(handle, ref transform, x, y);
	}

	public void MoveToPoint(CGAffineTransform transform, CGPoint point)
	{
		CGPathMoveToPoint(handle, ref transform, point.X, point.Y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddLineToPoint(IntPtr path, ref CGAffineTransform m, double x, double y);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddLineToPoint(IntPtr path, IntPtr m, double x, double y);

	[Advice("Use AddLineToPoint instead")]
	public void CGPathAddLineToPoint(double x, double y)
	{
		AddLineToPoint(x, y);
	}

	public void AddLineToPoint(double x, double y)
	{
		CGPathAddLineToPoint(handle, IntPtr.Zero, x, y);
	}

	public void AddLineToPoint(CGPoint point)
	{
		CGPathAddLineToPoint(handle, IntPtr.Zero, point.X, point.Y);
	}

	[Advice("Use AddLineToPoint instead")]
	public void CGPathAddLineToPoint(CGAffineTransform transform, double x, double y)
	{
		AddLineToPoint(transform, x, y);
	}

	public void AddLineToPoint(CGAffineTransform transform, double x, double y)
	{
		CGPathAddLineToPoint(handle, ref transform, x, y);
	}

	public void AddLineToPoint(CGAffineTransform transform, CGPoint point)
	{
		CGPathAddLineToPoint(handle, ref transform, point.X, point.Y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddQuadCurveToPoint(IntPtr path, ref CGAffineTransform m, double cpx, double cpy, double x, double y);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddQuadCurveToPoint(IntPtr path, IntPtr zero, double cpx, double cpy, double x, double y);

	public void AddQuadCurveToPoint(double cpx, double cpy, double x, double y)
	{
		CGPathAddQuadCurveToPoint(handle, IntPtr.Zero, cpx, cpy, x, y);
	}

	public void AddQuadCurveToPoint(CGAffineTransform transform, double cpx, double cpy, double x, double y)
	{
		CGPathAddQuadCurveToPoint(handle, ref transform, cpx, cpy, x, y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddCurveToPoint(IntPtr path, ref CGAffineTransform m, double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);

	public void AddCurveToPoint(CGAffineTransform transform, double cp1x, double cp1y, double cp2x, double cp2y, double x, double y)
	{
		CGPathAddCurveToPoint(handle, ref transform, cp1x, cp1y, cp2x, cp2y, x, y);
	}

	public void AddCurveToPoint(CGAffineTransform transform, CGPoint cp1, CGPoint cp2, CGPoint point)
	{
		CGPathAddCurveToPoint(handle, ref transform, cp1.X, cp1.Y, cp2.X, cp2.Y, point.X, point.Y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddCurveToPoint(IntPtr path, IntPtr zero, double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);

	public void AddCurveToPoint(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y)
	{
		CGPathAddCurveToPoint(handle, IntPtr.Zero, cp1x, cp1y, cp2x, cp2y, x, y);
	}

	public void AddCurveToPoint(CGPoint cp1, CGPoint cp2, CGPoint point)
	{
		CGPathAddCurveToPoint(handle, IntPtr.Zero, cp1.X, cp1.Y, cp2.X, cp2.Y, point.X, point.Y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathCloseSubpath(IntPtr path);

	public void CloseSubpath()
	{
		CGPathCloseSubpath(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddRect(IntPtr path, ref CGAffineTransform m, CGRect rect);

	public void AddRect(CGAffineTransform transform, CGRect rect)
	{
		CGPathAddRect(handle, ref transform, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddRect(IntPtr path, IntPtr zero, CGRect rect);

	public void AddRect(CGRect rect)
	{
		CGPathAddRect(handle, IntPtr.Zero, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddRects(IntPtr path, ref CGAffineTransform m, CGRect[] rects, IntPtr size_t_count);

	public void AddRects(CGAffineTransform m, CGRect[] rects)
	{
		CGPathAddRects(handle, ref m, rects, new IntPtr(rects.Length));
	}

	public void AddRects(CGAffineTransform m, CGRect[] rects, long count)
	{
		if (count > rects.Length)
		{
			throw new ArgumentException("counts");
		}
		CGPathAddRects(handle, ref m, rects, new IntPtr(count));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddRects(IntPtr path, IntPtr Zero, CGRect[] rects, IntPtr size_t_count);

	public void AddRects(CGRect[] rects)
	{
		CGPathAddRects(handle, IntPtr.Zero, rects, new IntPtr(rects.Length));
	}

	public void AddRects(CGRect[] rects, long count)
	{
		if (count > rects.Length)
		{
			throw new ArgumentException("count");
		}
		CGPathAddRects(handle, IntPtr.Zero, rects, new IntPtr(count));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddLines(IntPtr path, ref CGAffineTransform m, CGPoint[] points, IntPtr size_t_count);

	public void AddLines(CGAffineTransform m, CGPoint[] points)
	{
		CGPathAddLines(handle, ref m, points, new IntPtr(points.Length));
	}

	public void AddLines(CGAffineTransform m, CGPoint[] points, long count)
	{
		if (count > points.Length)
		{
			throw new ArgumentException("count");
		}
		CGPathAddLines(handle, ref m, points, new IntPtr(count));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddLines(IntPtr path, IntPtr zero, CGPoint[] points, IntPtr size_t_count);

	public void AddLines(CGPoint[] points)
	{
		AddLines(points, points.Length);
	}

	public void AddLines(CGPoint[] points, long count)
	{
		if (count > points.Length)
		{
			throw new ArgumentException("count");
		}
		CGPathAddLines(handle, IntPtr.Zero, points, new IntPtr(count));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddEllipseInRect(IntPtr path, ref CGAffineTransform m, CGRect rect);

	public void AddEllipseInRect(CGAffineTransform m, CGRect rect)
	{
		CGPathAddEllipseInRect(handle, ref m, rect);
	}

	[Obsolete("Use AddEllipseInRect instead")]
	public void AddElipseInRect(CGAffineTransform m, CGRect rect)
	{
		AddEllipseInRect(m, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddEllipseInRect(IntPtr path, IntPtr zero, CGRect rect);

	public void AddElipseInRect(CGRect rect)
	{
		CGPathAddEllipseInRect(handle, IntPtr.Zero, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddArc(IntPtr path, ref CGAffineTransform m, double x, double y, double radius, double startAngle, double endAngle, bool clockwise);

	public void AddArc(CGAffineTransform m, double x, double y, double radius, double startAngle, double endAngle, bool clockwise)
	{
		CGPathAddArc(handle, ref m, x, y, radius, startAngle, endAngle, clockwise);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddArc(IntPtr path, IntPtr zero, double x, double y, double radius, double startAngle, double endAngle, bool clockwise);

	public void AddArc(double x, double y, double radius, double startAngle, double endAngle, bool clockwise)
	{
		CGPathAddArc(handle, IntPtr.Zero, x, y, radius, startAngle, endAngle, clockwise);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddArcToPoint(IntPtr path, ref CGAffineTransform m, double x1, double y1, double x2, double y2, double radius);

	public void AddArcToPoint(CGAffineTransform m, double x1, double y1, double x2, double y2, double radius)
	{
		CGPathAddArcToPoint(handle, ref m, x1, y1, x2, y2, radius);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddArcToPoint(IntPtr path, IntPtr zero, double x1, double y1, double x2, double y2, double radius);

	public void AddArcToPoint(double x1, double y1, double x2, double y2, double radius)
	{
		CGPathAddArcToPoint(handle, IntPtr.Zero, x1, y1, x2, y2, radius);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddRelativeArc(IntPtr path, ref CGAffineTransform m, double x, double y, double radius, double startAngle, double delta);

	public void AddRelativeArc(CGAffineTransform m, double x, double y, double radius, double startAngle, double delta)
	{
		CGPathAddRelativeArc(handle, ref m, x, y, radius, startAngle, delta);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddRelativeArc(IntPtr path, IntPtr zero, double x, double y, double radius, double startAngle, double delta);

	public void AddRelativeArc(double x, double y, double radius, double startAngle, double delta)
	{
		CGPathAddRelativeArc(handle, IntPtr.Zero, x, y, radius, startAngle, delta);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddPath(IntPtr path1, ref CGAffineTransform m, IntPtr path2);

	public void AddPath(CGAffineTransform t, CGPath path2)
	{
		if (path2 == null)
		{
			throw new ArgumentNullException("path2");
		}
		CGPathAddPath(handle, ref t, path2.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathAddPath(IntPtr path1, IntPtr zero, IntPtr path2);

	public void AddPath(CGPath path2)
	{
		if (path2 == null)
		{
			throw new ArgumentNullException("path2");
		}
		CGPathAddPath(handle, IntPtr.Zero, path2.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPathIsEmpty(IntPtr path);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPathIsRect(IntPtr path, out CGRect rect);

	public bool IsRect(out CGRect rect)
	{
		return CGPathIsRect(handle, out rect) != 0;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGPoint CGPathGetCurrentPoint(IntPtr path);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGPathGetBoundingBox(IntPtr path);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGPathGetPathBoundingBox(IntPtr path);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPathContainsPoint(IntPtr path, ref CGAffineTransform m, CGPoint point, bool eoFill);

	public bool ContainsPoint(CGAffineTransform m, CGPoint point, bool eoFill)
	{
		return CGPathContainsPoint(handle, ref m, point, eoFill);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPathContainsPoint(IntPtr path, IntPtr zero, CGPoint point, bool eoFill);

	public bool ContainsPoint(CGPoint point, bool eoFill)
	{
		return CGPathContainsPoint(handle, IntPtr.Zero, point, eoFill);
	}

	private unsafe static void ApplierCallback(IntPtr info, IntPtr element_ptr)
	{
		GCHandle gCHandle = GCHandle.FromIntPtr(info);
		CGPathElement element = new CGPathElement(Marshal.ReadInt32(element_ptr, 0));
		ApplierFunction applierFunction = (ApplierFunction)gCHandle.Target;
		IntPtr intPtr = Marshal.ReadIntPtr(element_ptr, sizeof(IntPtr));
		int num = Marshal.SizeOf(typeof(CGPoint));
		switch (element.Type)
		{
		case CGPathElementType.MoveToPoint:
		case CGPathElementType.AddLineToPoint:
			element.Point1 = (CGPoint)Marshal.PtrToStructure(intPtr, typeof(CGPoint));
			break;
		case CGPathElementType.AddQuadCurveToPoint:
			element.Point1 = (CGPoint)Marshal.PtrToStructure(intPtr, typeof(CGPoint));
			element.Point2 = (CGPoint)Marshal.PtrToStructure((IntPtr)((long)intPtr + num), typeof(CGPoint));
			break;
		case CGPathElementType.AddCurveToPoint:
			element.Point1 = (CGPoint)Marshal.PtrToStructure(intPtr, typeof(CGPoint));
			element.Point2 = (CGPoint)Marshal.PtrToStructure((IntPtr)((long)intPtr + num), typeof(CGPoint));
			element.Point3 = (CGPoint)Marshal.PtrToStructure((IntPtr)((long)intPtr + 2 * num), typeof(CGPoint));
			break;
		}
		applierFunction(element);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPathApply(IntPtr path, IntPtr info, CGPathApplierFunction function);

	public void Apply(ApplierFunction func)
	{
		GCHandle value = GCHandle.Alloc(func);
		CGPathApply(handle, GCHandle.ToIntPtr(value), ApplierCallback);
		value.Free();
	}

	private static CGPath MakeMutable(IntPtr source)
	{
		IntPtr intPtr = CGPathCreateMutableCopy(source);
		CGPathRelease(source);
		return new CGPath(intPtr, owns: true);
	}
}
