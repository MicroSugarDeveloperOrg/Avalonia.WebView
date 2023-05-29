using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGContext : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public CGInterpolationQuality InterpolationQuality
	{
		get
		{
			return CGContextGetInterpolationQuality(handle);
		}
		set
		{
			CGContextSetInterpolationQuality(handle, value);
		}
	}

	public CGPoint TextPosition
	{
		get
		{
			return CGContextGetTextPosition(handle);
		}
		set
		{
			CGContextSetTextPosition(handle, value.X, value.Y);
		}
	}

	public CGAffineTransform TextMatrix
	{
		get
		{
			return CGContextGetTextMatrix(handle);
		}
		set
		{
			CGContextSetTextMatrix(handle, value);
		}
	}

	public CGContext(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid parameters to context creation");
		}
		CGContextRetain(handle);
		this.handle = handle;
	}

	internal CGContext()
	{
	}

	[Preserve(Conditional = true)]
	internal CGContext(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CGContextRetain(handle);
		}
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid handle");
		}
		this.handle = handle;
	}

	~CGContext()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGContextRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSaveGState(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextRestoreGState(IntPtr context);

	public void SaveState()
	{
		CGContextSaveGState(handle);
	}

	public void RestoreState()
	{
		CGContextRestoreGState(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextScaleCTM(IntPtr ctx, double sx, double sy);

	public void ScaleCTM(double sx, double sy)
	{
		CGContextScaleCTM(handle, sx, sy);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextTranslateCTM(IntPtr ctx, double tx, double ty);

	public void TranslateCTM(double tx, double ty)
	{
		CGContextTranslateCTM(handle, tx, ty);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextRotateCTM(IntPtr ctx, double angle);

	public void RotateCTM(double angle)
	{
		CGContextRotateCTM(handle, angle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextConcatCTM(IntPtr ctx, CGAffineTransform transform);

	public void ConcatCTM(CGAffineTransform transform)
	{
		CGContextConcatCTM(handle, transform);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetLineWidth(IntPtr c, double width);

	public void SetLineWidth(double w)
	{
		CGContextSetLineWidth(handle, w);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetLineCap(IntPtr c, CGLineCap cap);

	public void SetLineCap(CGLineCap cap)
	{
		CGContextSetLineCap(handle, cap);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetLineJoin(IntPtr c, CGLineJoin join);

	public void SetLineJoin(CGLineJoin join)
	{
		CGContextSetLineJoin(handle, join);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetMiterLimit(IntPtr c, double limit);

	public void SetMiterLimit(double limit)
	{
		CGContextSetMiterLimit(handle, limit);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetLineDash(IntPtr c, double phase, double[] lengths, long count);

	public void SetLineDash(double phase, double[] lengths)
	{
		SetLineDash(phase, lengths, lengths.Length);
	}

	public void SetLineDash(double phase, double[] lengths, int n)
	{
		if (lengths == null)
		{
			n = 0;
		}
		else if (n < 0 || n > lengths.Length)
		{
			throw new ArgumentException("n");
		}
		CGContextSetLineDash(handle, phase, lengths, n);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFlatness(IntPtr c, double flatness);

	public void SetFlatness(double flatness)
	{
		CGContextSetFlatness(handle, flatness);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetAlpha(IntPtr c, double alpha);

	public void SetAlpha(double alpha)
	{
		CGContextSetAlpha(handle, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetBlendMode(IntPtr context, CGBlendMode mode);

	public void SetBlendMode(CGBlendMode mode)
	{
		CGContextSetBlendMode(handle, mode);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGAffineTransform CGContextGetCTM(IntPtr c);

	public CGAffineTransform GetCTM()
	{
		return CGContextGetCTM(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextBeginPath(IntPtr c);

	public void BeginPath()
	{
		CGContextBeginPath(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextMoveToPoint(IntPtr c, double x, double y);

	public void MoveTo(double x, double y)
	{
		CGContextMoveToPoint(handle, x, y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddLineToPoint(IntPtr c, double x, double y);

	public void AddLineToPoint(double x, double y)
	{
		CGContextAddLineToPoint(handle, x, y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddCurveToPoint(IntPtr c, double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);

	public void AddCurveToPoint(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y)
	{
		CGContextAddCurveToPoint(handle, cp1x, cp1y, cp2x, cp2y, x, y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddQuadCurveToPoint(IntPtr c, double cpx, double cpy, double x, double y);

	public void AddQuadCurveToPoint(double cpx, double cpy, double x, double y)
	{
		CGContextAddQuadCurveToPoint(handle, cpx, cpy, x, y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextClosePath(IntPtr c);

	public void ClosePath()
	{
		CGContextClosePath(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddRect(IntPtr c, CGRect rect);

	public void AddRect(CGRect rect)
	{
		CGContextAddRect(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddRects(IntPtr c, CGRect[] rects, IntPtr size_t_count);

	public void AddRects(CGRect[] rects)
	{
		CGContextAddRects(handle, rects, new IntPtr(rects.Length));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddLines(IntPtr c, CGPoint[] points, IntPtr size_t_count);

	public void AddLines(CGPoint[] points)
	{
		CGContextAddLines(handle, points, new IntPtr(points.Length));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddEllipseInRect(IntPtr context, CGRect rect);

	public void AddEllipseInRect(CGRect rect)
	{
		CGContextAddEllipseInRect(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddArc(IntPtr c, double x, double y, double radius, double startAngle, double endAngle, int clockwise);

	public void AddArc(double x, double y, double radius, double startAngle, double endAngle, bool clockwise)
	{
		CGContextAddArc(handle, x, y, radius, startAngle, endAngle, clockwise ? 1 : 0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddArcToPoint(IntPtr c, double x1, double y1, double x2, double y2, double radius);

	public void AddArcToPoint(double x1, double y1, double x2, double y2, double radius)
	{
		CGContextAddArcToPoint(handle, x1, y1, x2, y2, radius);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddPath(IntPtr context, IntPtr path_ref);

	public void AddPath(CGPath path)
	{
		CGContextAddPath(handle, path.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextReplacePathWithStrokedPath(IntPtr c);

	public void ReplacePathWithStrokedPath()
	{
		CGContextReplacePathWithStrokedPath(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGContextIsPathEmpty(IntPtr c);

	public bool IsPathEmpty()
	{
		return CGContextIsPathEmpty(handle) != 0;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGPoint CGContextGetPathCurrentPoint(IntPtr c);

	public CGPoint GetPathCurrentPoint()
	{
		return CGContextGetPathCurrentPoint(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGContextGetPathBoundingBox(IntPtr c);

	public CGRect GetPathBoundingBox()
	{
		return CGContextGetPathBoundingBox(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGContextPathContainsPoint(IntPtr context, CGPoint point, CGPathDrawingMode mode);

	public bool PathContainsPoint(CGPoint point, CGPathDrawingMode mode)
	{
		return CGContextPathContainsPoint(handle, point, mode) != 0;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawPath(IntPtr c, CGPathDrawingMode mode);

	public void DrawPath(CGPathDrawingMode mode)
	{
		CGContextDrawPath(handle, mode);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextFillPath(IntPtr c);

	public void FillPath()
	{
		CGContextFillPath(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextEOFillPath(IntPtr c);

	public void EOFillPath()
	{
		CGContextEOFillPath(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextStrokePath(IntPtr c);

	public void StrokePath()
	{
		CGContextStrokePath(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextFillRect(IntPtr c, CGRect rect);

	public void FillRect(CGRect rect)
	{
		CGContextFillRect(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextFillRects(IntPtr c, CGRect[] rects, IntPtr size_t_count);

	public void ContextFillRects(CGRect[] rects)
	{
		CGContextFillRects(handle, rects, new IntPtr(rects.Length));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextStrokeRect(IntPtr c, CGRect rect);

	public void StrokeRect(CGRect rect)
	{
		CGContextStrokeRect(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextStrokeRectWithWidth(IntPtr c, CGRect rect, double width);

	public void StrokeRectWithWidth(CGRect rect, double width)
	{
		CGContextStrokeRectWithWidth(handle, rect, width);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextClearRect(IntPtr c, CGRect rect);

	public void ClearRect(CGRect rect)
	{
		CGContextClearRect(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextFillEllipseInRect(IntPtr context, CGRect rect);

	public void FillEllipseInRect(CGRect rect)
	{
		CGContextFillEllipseInRect(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextStrokeEllipseInRect(IntPtr context, CGRect rect);

	public void StrokeEllipseInRect(CGRect rect)
	{
		CGContextStrokeEllipseInRect(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextStrokeLineSegments(IntPtr c, CGPoint[] points, IntPtr size_t_count);

	public void StrokeLineSegments(CGPoint[] points)
	{
		CGContextStrokeLineSegments(handle, points, new IntPtr(points.Length));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextClip(IntPtr c);

	public void Clip()
	{
		CGContextClip(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextEOClip(IntPtr c);

	public void EOClip()
	{
		CGContextEOClip(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextClipToMask(IntPtr c, CGRect rect, IntPtr mask);

	public void ClipToMask(CGRect rect, CGImage mask)
	{
		CGContextClipToMask(handle, rect, mask.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGContextGetClipBoundingBox(IntPtr c);

	public CGRect GetClipBoundingBox()
	{
		return CGContextGetClipBoundingBox(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextClipToRect(IntPtr c, CGRect rect);

	public void ClipToRect(CGRect rect)
	{
		CGContextClipToRect(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextClipToRects(IntPtr c, CGRect[] rects, IntPtr size_t_count);

	public void ClipToRects(CGRect[] rects)
	{
		CGContextClipToRects(handle, rects, new IntPtr(rects.Length));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFillColorWithColor(IntPtr c, IntPtr color);

	public void SetFillColor(CGColor color)
	{
		CGContextSetFillColorWithColor(handle, color.handle);
	}

	[Advice("Use SetFillColor() instead.")]
	public void SetFillColorWithColor(CGColor color)
	{
		CGContextSetFillColorWithColor(handle, color.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetStrokeColorWithColor(IntPtr c, IntPtr color);

	public void SetStrokeColor(CGColor color)
	{
		CGContextSetStrokeColorWithColor(handle, color.handle);
	}

	[Advice("Use SetStrokeColor() instead.")]
	public void SetStrokeColorWithColor(CGColor color)
	{
		CGContextSetStrokeColorWithColor(handle, color.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFillColorSpace(IntPtr context, IntPtr space);

	public void SetFillColorSpace(CGColorSpace space)
	{
		CGContextSetFillColorSpace(handle, space.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetStrokeColorSpace(IntPtr context, IntPtr space);

	public void SetStrokeColorSpace(CGColorSpace space)
	{
		CGContextSetStrokeColorSpace(handle, space.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFillColor(IntPtr context, double[] components);

	public void SetFillColor(double[] components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		CGContextSetFillColor(handle, components);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetStrokeColor(IntPtr context, double[] components);

	public void SetStrokeColor(double[] components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		CGContextSetStrokeColor(handle, components);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFillPattern(IntPtr context, IntPtr pattern, double[] components);

	public void SetFillPattern(CGPattern pattern, double[] components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		CGContextSetFillPattern(handle, pattern.handle, components);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetStrokePattern(IntPtr context, IntPtr pattern, double[] components);

	public void SetStrokePattern(CGPattern pattern, double[] components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		CGContextSetStrokePattern(handle, pattern.handle, components);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetPatternPhase(IntPtr context, CGSize phase);

	public void SetPatternPhase(CGSize phase)
	{
		CGContextSetPatternPhase(handle, phase);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetGrayFillColor(IntPtr context, double gray, double alpha);

	public void SetFillColor(double gray, double alpha)
	{
		CGContextSetGrayFillColor(handle, gray, alpha);
	}

	[Advice("Use SetFillColor() instead.")]
	public void SetGrayFillColor(double gray, double alpha)
	{
		CGContextSetGrayFillColor(handle, gray, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetGrayStrokeColor(IntPtr context, double gray, double alpha);

	public void SetStrokeColor(double gray, double alpha)
	{
		CGContextSetGrayStrokeColor(handle, gray, alpha);
	}

	[Advice("Use SetStrokeColor() instead.")]
	public void SetGrayStrokeColor(double gray, double alpha)
	{
		CGContextSetGrayStrokeColor(handle, gray, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetRGBFillColor(IntPtr context, double red, double green, double blue, double alpha);

	public void SetFillColor(double red, double green, double blue, double alpha)
	{
		CGContextSetRGBFillColor(handle, red, green, blue, alpha);
	}

	[Advice("Use SetFillColor() instead.")]
	public void SetRGBFillColor(double red, double green, double blue, double alpha)
	{
		CGContextSetRGBFillColor(handle, red, green, blue, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetRGBStrokeColor(IntPtr context, double red, double green, double blue, double alpha);

	public void SetStrokeColor(double red, double green, double blue, double alpha)
	{
		CGContextSetRGBStrokeColor(handle, red, green, blue, alpha);
	}

	[Advice("Use SetStrokeColor() instead.")]
	public void SetRGBStrokeColor(double red, double green, double blue, double alpha)
	{
		CGContextSetRGBStrokeColor(handle, red, green, blue, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetCMYKFillColor(IntPtr context, double cyan, double magenta, double yellow, double black, double alpha);

	public void SetFillColor(double cyan, double magenta, double yellow, double black, double alpha)
	{
		CGContextSetCMYKFillColor(handle, cyan, magenta, yellow, black, alpha);
	}

	[Advice("Use SetFillColor() instead.")]
	public void SetCMYKFillColor(double cyan, double magenta, double yellow, double black, double alpha)
	{
		CGContextSetCMYKFillColor(handle, cyan, magenta, yellow, black, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetCMYKStrokeColor(IntPtr context, double cyan, double magenta, double yellow, double black, double alpha);

	public void SetStrokeColor(double cyan, double magenta, double yellow, double black, double alpha)
	{
		CGContextSetCMYKStrokeColor(handle, cyan, magenta, yellow, black, alpha);
	}

	[Advice("Use SetStrokeColor() instead.")]
	public void SetCMYKStrokeColor(double cyan, double magenta, double yellow, double black, double alpha)
	{
		CGContextSetCMYKStrokeColor(handle, cyan, magenta, yellow, black, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetRenderingIntent(IntPtr context, CGColorRenderingIntent intent);

	public void SetRenderingIntent(CGColorRenderingIntent intent)
	{
		CGContextSetRenderingIntent(handle, intent);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawImage(IntPtr c, CGRect rect, IntPtr image);

	public void DrawImage(CGRect rect, CGImage image)
	{
		CGContextDrawImage(handle, rect, image.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawTiledImage(IntPtr c, CGRect rect, IntPtr image);

	public void DrawTiledImage(CGRect rect, CGImage image)
	{
		CGContextDrawTiledImage(handle, rect, image.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGInterpolationQuality CGContextGetInterpolationQuality(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetInterpolationQuality(IntPtr context, CGInterpolationQuality quality);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetShadowWithColor(IntPtr context, CGSize offset, double blur, IntPtr color);

	public void SetShadowWithColor(CGSize offset, double blur, CGColor color)
	{
		CGContextSetShadowWithColor(handle, offset, blur, color.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetShadow(IntPtr context, CGSize offset, double blur);

	public void SetShadow(CGSize offset, double blur)
	{
		CGContextSetShadow(handle, offset, blur);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawLinearGradient(IntPtr context, IntPtr gradient, CGPoint startPoint, CGPoint endPoint, CGGradientDrawingOptions options);

	public void DrawLinearGradient(CGGradient gradient, CGPoint startPoint, CGPoint endPoint, CGGradientDrawingOptions options)
	{
		CGContextDrawLinearGradient(handle, gradient.handle, startPoint, endPoint, options);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawRadialGradient(IntPtr context, IntPtr gradient, CGPoint startCenter, double startRadius, CGPoint endCenter, double endRadius, CGGradientDrawingOptions options);

	public void DrawRadialGradient(CGGradient gradient, CGPoint startCenter, double startRadius, CGPoint endCenter, double endRadius, CGGradientDrawingOptions options)
	{
		CGContextDrawRadialGradient(handle, gradient.handle, startCenter, startRadius, endCenter, endRadius, options);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawShading(IntPtr context, IntPtr shading);

	public void DrawShading(CGShading shading)
	{
		CGContextDrawShading(handle, shading.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetCharacterSpacing(IntPtr context, double spacing);

	public void SetCharacterSpacing(double spacing)
	{
		CGContextSetCharacterSpacing(handle, spacing);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetTextPosition(IntPtr c, double x, double y);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGPoint CGContextGetTextPosition(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetTextMatrix(IntPtr c, CGAffineTransform t);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGAffineTransform CGContextGetTextMatrix(IntPtr c);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetTextDrawingMode(IntPtr c, CGTextDrawingMode mode);

	public void SetTextDrawingMode(CGTextDrawingMode mode)
	{
		CGContextSetTextDrawingMode(handle, mode);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFont(IntPtr c, IntPtr font);

	public void SetFont(CGFont font)
	{
		CGContextSetFont(handle, font.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFontSize(IntPtr c, double size);

	public void SetFontSize(double size)
	{
		CGContextSetFontSize(handle, size);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSelectFont(IntPtr c, string name, double size, CGTextEncoding textEncoding);

	public void SelectFont(string name, double size, CGTextEncoding textEncoding)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		CGContextSelectFont(handle, name, size, textEncoding);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowGlyphsAtPositions(IntPtr context, ushort[] glyphs, CGPoint[] positions, IntPtr size_t_count);

	public void ShowGlyphsAtPositions(ushort[] glyphs, CGPoint[] positions, int size_t_count)
	{
		if (positions == null)
		{
			throw new ArgumentNullException("positions");
		}
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		CGContextShowGlyphsAtPositions(handle, glyphs, positions, new IntPtr(size_t_count));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowText(IntPtr c, string s, IntPtr size_t_length);

	public void ShowText(string str, int count)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (count > str.Length)
		{
			throw new ArgumentException("count");
		}
		CGContextShowText(handle, str, new IntPtr(count));
	}

	public void ShowText(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		CGContextShowText(handle, str, new IntPtr(str.Length));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowText(IntPtr c, byte[] bytes, IntPtr size_t_length);

	public void ShowText(byte[] bytes, int count)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		if (count > bytes.Length)
		{
			throw new ArgumentException("count");
		}
		CGContextShowText(handle, bytes, new IntPtr(count));
	}

	public void ShowText(byte[] bytes)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		CGContextShowText(handle, bytes, new IntPtr(bytes.Length));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowTextAtPoint(IntPtr c, double x, double y, string str, IntPtr size_t_length);

	public void ShowTextAtPoint(double x, double y, string str, int length)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		CGContextShowTextAtPoint(handle, x, y, str, new IntPtr(length));
	}

	public void ShowTextAtPoint(double x, double y, string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		CGContextShowTextAtPoint(handle, x, y, str, new IntPtr(str.Length));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowTextAtPoint(IntPtr c, double x, double y, byte[] bytes, IntPtr size_t_length);

	public void ShowTextAtPoint(double x, double y, byte[] bytes, int length)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		CGContextShowTextAtPoint(handle, x, y, bytes, new IntPtr(length));
	}

	public void ShowTextAtPoint(double x, double y, byte[] bytes)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		CGContextShowTextAtPoint(handle, x, y, bytes, new IntPtr(bytes.Length));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowGlyphs(IntPtr c, ushort[] glyphs, IntPtr size_t_count);

	public void ShowGlyphs(ushort[] glyphs)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		CGContextShowGlyphs(handle, glyphs, new IntPtr(glyphs.Length));
	}

	public void ShowGlyphs(ushort[] glyphs, int count)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		if (count > glyphs.Length)
		{
			throw new ArgumentException("count");
		}
		CGContextShowGlyphs(handle, glyphs, new IntPtr(count));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowGlyphsAtPoint(IntPtr context, double x, double y, ushort[] glyphs, IntPtr size_t_count);

	public void ShowGlyphsAtPoint(double x, double y, ushort[] glyphs, int count)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		if (count > glyphs.Length)
		{
			throw new ArgumentException("count");
		}
		CGContextShowGlyphsAtPoint(handle, x, y, glyphs, new IntPtr(count));
	}

	public void ShowGlyphsAtPoint(double x, double y, ushort[] glyphs)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		CGContextShowGlyphsAtPoint(handle, x, y, glyphs, new IntPtr(glyphs.Length));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowGlyphsWithAdvances(IntPtr c, ushort[] glyphs, CGSize[] advances, IntPtr size_t_count);

	public void ShowGlyphsWithAdvances(ushort[] glyphs, CGSize[] advances, int count)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		if (advances == null)
		{
			throw new ArgumentNullException("advances");
		}
		if (count > glyphs.Length || count > advances.Length)
		{
			throw new ArgumentException("count");
		}
		CGContextShowGlyphsWithAdvances(handle, glyphs, advances, new IntPtr(count));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawPDFPage(IntPtr c, IntPtr page);

	public void DrawPDFPage(CGPDFPage page)
	{
		CGContextDrawPDFPage(handle, page.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextBeginPage(IntPtr c, ref CGRect mediaBox);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextBeginPage(IntPtr c, IntPtr zero);

	public void BeginPage(CGRect? rect)
	{
		if (rect.HasValue)
		{
			CGRect mediaBox = rect.Value;
			CGContextBeginPage(handle, ref mediaBox);
		}
		else
		{
			CGContextBeginPage(handle, IntPtr.Zero);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextEndPage(IntPtr c);

	public void EndPage()
	{
		CGContextEndPage(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextFlush(IntPtr c);

	public void Flush()
	{
		CGContextFlush(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSynchronize(IntPtr c);

	public void Synchronize()
	{
		CGContextSynchronize(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetShouldAntialias(IntPtr c, int shouldAntialias);

	public void SetShouldAntialias(bool shouldAntialias)
	{
		CGContextSetShouldAntialias(handle, shouldAntialias ? 1 : 0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetAllowsAntialiasing(IntPtr context, int allowsAntialiasing);

	public void SetAllowsAntialiasing(bool allowsAntialiasing)
	{
		CGContextSetAllowsAntialiasing(handle, allowsAntialiasing ? 1 : 0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetShouldSmoothFonts(IntPtr c, int shouldSmoothFonts);

	public void SetShouldSmoothFonts(bool shouldSmoothFonts)
	{
		CGContextSetShouldSmoothFonts(handle, shouldSmoothFonts ? 1 : 0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGAffineTransform CGContextGetUserSpaceToDeviceSpaceTransform(IntPtr context);

	public CGAffineTransform GetUserSpaceToDeviceSpaceTransform()
	{
		return CGContextGetUserSpaceToDeviceSpaceTransform(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGPoint CGContextConvertPointToDeviceSpace(IntPtr context, CGPoint point);

	public CGPoint PointToDeviceSpace(CGPoint point)
	{
		return CGContextConvertPointToDeviceSpace(handle, point);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGPoint CGContextConvertPointToUserSpace(IntPtr context, CGPoint point);

	public CGPoint ConvertPointToUserSpace(CGPoint point)
	{
		return CGContextConvertPointToUserSpace(handle, point);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGSize CGContextConvertSizeToDeviceSpace(IntPtr context, CGSize size);

	public CGSize ConvertSizeToDeviceSpace(CGSize size)
	{
		return CGContextConvertSizeToDeviceSpace(handle, size);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGSize CGContextConvertSizeToUserSpace(IntPtr context, CGSize size);

	public CGSize ConvertSizeToUserSpace(CGSize size)
	{
		return CGContextConvertSizeToUserSpace(handle, size);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGContextConvertRectToDeviceSpace(IntPtr context, CGRect rect);

	public CGRect ConvertRectToDeviceSpace(CGRect rect)
	{
		return CGContextConvertRectToDeviceSpace(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGContextConvertRectToUserSpace(IntPtr context, CGRect rect);

	public CGRect ConvertRectToUserSpace(CGRect rect)
	{
		return CGContextConvertRectToUserSpace(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawLayerInRect(IntPtr context, CGRect rect, IntPtr layer);

	public void DrawLayer(CGLayer layer, CGRect rect)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		CGContextDrawLayerInRect(handle, rect, layer.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawLayerAtPoint(IntPtr context, CGPoint rect, IntPtr layer);

	public void DrawLayer(CGLayer layer, CGPoint point)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		CGContextDrawLayerAtPoint(handle, point, layer.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGContextCopyPath(IntPtr context);

	[Since(4, 0)]
	public CGPath CopyPath()
	{
		return new CGPath(CGContextCopyPath(handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGContextSetAllowsFontSmoothing(IntPtr context, bool allows);

	[Since(4, 0)]
	public void SetAllowsFontSmoothing(bool allows)
	{
		CGContextSetAllowsFontSmoothing(handle, allows);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGContextSetAllowsFontSubpixelPositioning(IntPtr context, bool allows);

	[Since(4, 0)]
	public void SetAllowsSubpixelPositioning(bool allows)
	{
		CGContextSetAllowsFontSubpixelPositioning(handle, allows);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGContextSetAllowsFontSubpixelQuantization(IntPtr context, bool allows);

	[Since(4, 0)]
	public void SetAllowsFontSubpixelQuantization(bool allows)
	{
		CGContextSetAllowsFontSubpixelQuantization(handle, allows);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGContextSetShouldSubpixelPositionFonts(IntPtr context, bool should);

	[Since(4, 0)]
	public void SetShouldSubpixelPositionFonts(bool shouldSubpixelPositionFonts)
	{
		CGContextSetShouldSubpixelPositionFonts(handle, shouldSubpixelPositionFonts);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGContextSetShouldSubpixelQuantizeFonts(IntPtr context, bool should);

	[Since(4, 0)]
	public void ShouldSubpixelQuantizeFonts(bool shouldSubpixelQuantizeFonts)
	{
		CGContextSetShouldSubpixelQuantizeFonts(handle, shouldSubpixelQuantizeFonts);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGContextBeginTransparencyLayer(IntPtr context, IntPtr dictionary);

	public void BeginTransparencyLayer()
	{
		CGContextBeginTransparencyLayer(handle, IntPtr.Zero);
	}

	public void BeginTransparencyLayer(NSDictionary auxiliaryInfo = null)
	{
		CGContextBeginTransparencyLayer(handle, auxiliaryInfo?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGContextBeginTransparencyLayerWithRect(IntPtr context, CGRect rect, IntPtr dictionary);

	public void BeginTransparencyLayer(CGRect rectangle, NSDictionary auxiliaryInfo = null)
	{
		CGContextBeginTransparencyLayerWithRect(handle, rectangle, auxiliaryInfo?.Handle ?? IntPtr.Zero);
	}

	public void BeginTransparencyLayer(CGRect rectangle)
	{
		CGContextBeginTransparencyLayerWithRect(handle, rectangle, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGContextEndTransparencyLayer(IntPtr context);

	public void EndTransparencyLayer()
	{
		CGContextEndTransparencyLayer(handle);
	}
}
