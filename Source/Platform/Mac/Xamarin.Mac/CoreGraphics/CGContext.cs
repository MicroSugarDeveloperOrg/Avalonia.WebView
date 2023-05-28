using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreGraphics;

public class CGContext : INativeObject, IDisposable
{
	private IntPtr handle;

	public IntPtr Handle
	{
		get
		{
			return handle;
		}
		internal set
		{
			if (value == IntPtr.Zero)
			{
				throw new Exception("Invalid parameters to context creation");
			}
			handle = value;
		}
	}

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
		: this(handle, owns: false)
	{
	}

	internal CGContext()
	{
	}

	[Preserve(Conditional = true)]
	internal CGContext(IntPtr handle, bool owns)
	{
		Handle = handle;
		if (!owns)
		{
			CGContextRetain(handle);
		}
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
	private static extern void CGContextRelease(IntPtr c);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGContextRetain(IntPtr c);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGContextRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSaveGState(IntPtr c);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextRestoreGState(IntPtr c);

	public void SaveState()
	{
		CGContextSaveGState(handle);
	}

	public void RestoreState()
	{
		CGContextRestoreGState(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextScaleCTM(IntPtr c, nfloat sx, nfloat sy);

	public void ScaleCTM(nfloat sx, nfloat sy)
	{
		CGContextScaleCTM(handle, sx, sy);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextTranslateCTM(IntPtr c, nfloat tx, nfloat ty);

	public void TranslateCTM(nfloat tx, nfloat ty)
	{
		CGContextTranslateCTM(handle, tx, ty);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextRotateCTM(IntPtr c, nfloat angle);

	public void RotateCTM(nfloat angle)
	{
		CGContextRotateCTM(handle, angle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextConcatCTM(IntPtr c, CGAffineTransform transform);

	public void ConcatCTM(CGAffineTransform transform)
	{
		CGContextConcatCTM(handle, transform);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetLineWidth(IntPtr c, nfloat width);

	public void SetLineWidth(nfloat w)
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
	private static extern void CGContextSetMiterLimit(IntPtr c, nfloat limit);

	public void SetMiterLimit(nfloat limit)
	{
		CGContextSetMiterLimit(handle, limit);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetLineDash(IntPtr c, nfloat phase, nfloat[] lengths, nint count);

	public void SetLineDash(nfloat phase, nfloat[] lengths)
	{
		int num = ((lengths != null) ? lengths.Length : 0);
		CGContextSetLineDash(handle, phase, lengths, num);
	}

	public void SetLineDash(nfloat phase, nfloat[] lengths, int n)
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
	private static extern void CGContextSetFlatness(IntPtr c, nfloat flatness);

	public void SetFlatness(nfloat flatness)
	{
		CGContextSetFlatness(handle, flatness);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetAlpha(IntPtr c, nfloat alpha);

	public void SetAlpha(nfloat alpha)
	{
		CGContextSetAlpha(handle, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetBlendMode(IntPtr c, CGBlendMode mode);

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
	private static extern void CGContextMoveToPoint(IntPtr c, nfloat x, nfloat y);

	public void MoveTo(nfloat x, nfloat y)
	{
		CGContextMoveToPoint(handle, x, y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddLineToPoint(IntPtr c, nfloat x, nfloat y);

	public void AddLineToPoint(nfloat x, nfloat y)
	{
		CGContextAddLineToPoint(handle, x, y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddCurveToPoint(IntPtr c, nfloat cp1x, nfloat cp1y, nfloat cp2x, nfloat cp2y, nfloat x, nfloat y);

	public void AddCurveToPoint(nfloat cp1x, nfloat cp1y, nfloat cp2x, nfloat cp2y, nfloat x, nfloat y)
	{
		CGContextAddCurveToPoint(handle, cp1x, cp1y, cp2x, cp2y, x, y);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddQuadCurveToPoint(IntPtr c, nfloat cpx, nfloat cpy, nfloat x, nfloat y);

	public void AddQuadCurveToPoint(nfloat cpx, nfloat cpy, nfloat x, nfloat y)
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
	private static extern void CGContextAddRects(IntPtr c, CGRect[] rects, nint count);

	public void AddRects(CGRect[] rects)
	{
		if (rects == null)
		{
			throw new ArgumentNullException("rects");
		}
		CGContextAddRects(handle, rects, rects.Length);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddLines(IntPtr c, CGPoint[] points, nint count);

	public void AddLines(CGPoint[] points)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		CGContextAddLines(handle, points, points.Length);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddEllipseInRect(IntPtr c, CGRect rect);

	public void AddEllipseInRect(CGRect rect)
	{
		CGContextAddEllipseInRect(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddArc(IntPtr c, nfloat x, nfloat y, nfloat radius, nfloat startAngle, nfloat endAngle, int clockwise);

	public void AddArc(nfloat x, nfloat y, nfloat radius, nfloat startAngle, nfloat endAngle, bool clockwise)
	{
		CGContextAddArc(handle, x, y, radius, startAngle, endAngle, clockwise ? 1 : 0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddArcToPoint(IntPtr c, nfloat x1, nfloat y1, nfloat x2, nfloat y2, nfloat radius);

	public void AddArcToPoint(nfloat x1, nfloat y1, nfloat x2, nfloat y2, nfloat radius)
	{
		CGContextAddArcToPoint(handle, x1, y1, x2, y2, radius);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextAddPath(IntPtr c, IntPtr path);

	public void AddPath(CGPath path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		CGContextAddPath(handle, path.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextReplacePathWithStrokedPath(IntPtr c);

	public void ReplacePathWithStrokedPath()
	{
		CGContextReplacePathWithStrokedPath(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGContextIsPathEmpty(IntPtr context);

	public bool IsPathEmpty()
	{
		return CGContextIsPathEmpty(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGPoint CGContextGetPathCurrentPoint(IntPtr context);

	public CGPoint GetPathCurrentPoint()
	{
		return CGContextGetPathCurrentPoint(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGContextGetPathBoundingBox(IntPtr context);

	public CGRect GetPathBoundingBox()
	{
		return CGContextGetPathBoundingBox(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGContextPathContainsPoint(IntPtr context, CGPoint point, CGPathDrawingMode mode);

	public bool PathContainsPoint(CGPoint point, CGPathDrawingMode mode)
	{
		return CGContextPathContainsPoint(handle, point, mode);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawPath(IntPtr context, CGPathDrawingMode mode);

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
	private static extern void CGContextFillRects(IntPtr c, CGRect[] rects, nint count);

	public void ContextFillRects(CGRect[] rects)
	{
		if (rects == null)
		{
			throw new ArgumentNullException("rects");
		}
		CGContextFillRects(handle, rects, rects.Length);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextStrokeRect(IntPtr c, CGRect rect);

	public void StrokeRect(CGRect rect)
	{
		CGContextStrokeRect(handle, rect);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextStrokeRectWithWidth(IntPtr c, CGRect rect, nfloat width);

	public void StrokeRectWithWidth(CGRect rect, nfloat width)
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
	private static extern void CGContextStrokeLineSegments(IntPtr c, CGPoint[] points, nint count);

	public void StrokeLineSegments(CGPoint[] points)
	{
		CGContextStrokeLineSegments(handle, points, (points != null) ? points.Length : 0);
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
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[Watch(4, 0)]
	private static extern void CGContextResetClip(IntPtr c);

	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[Watch(4, 0)]
	public void ResetClip()
	{
		CGContextResetClip(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextClipToMask(IntPtr c, CGRect rect, IntPtr mask);

	public void ClipToMask(CGRect rect, CGImage mask)
	{
		CGContextClipToMask(handle, rect, mask?.handle ?? IntPtr.Zero);
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
	private static extern void CGContextClipToRects(IntPtr c, CGRect[] rects, nint count);

	public void ClipToRects(CGRect[] rects)
	{
		if (rects == null)
		{
			throw new ArgumentNullException("rects");
		}
		CGContextClipToRects(handle, rects, rects.Length);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFillColorWithColor(IntPtr c, IntPtr color);

	public void SetFillColor(CGColor color)
	{
		CGContextSetFillColorWithColor(handle, (color == null) ? IntPtr.Zero : color.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetStrokeColorWithColor(IntPtr c, IntPtr color);

	public void SetStrokeColor(CGColor color)
	{
		CGContextSetStrokeColorWithColor(handle, (color == null) ? IntPtr.Zero : color.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFillColorSpace(IntPtr context, IntPtr space);

	public void SetFillColorSpace(CGColorSpace space)
	{
		CGContextSetFillColorSpace(handle, space?.handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetStrokeColorSpace(IntPtr context, IntPtr space);

	public void SetStrokeColorSpace(CGColorSpace space)
	{
		CGContextSetStrokeColorSpace(handle, space?.handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFillColor(IntPtr context, nfloat[] components);

	public void SetFillColor(nfloat[] components)
	{
		CGContextSetFillColor(handle, components);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetStrokeColor(IntPtr context, nfloat[] components);

	public void SetStrokeColor(nfloat[] components)
	{
		CGContextSetStrokeColor(handle, components);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFillPattern(IntPtr context, IntPtr pattern, nfloat[] components);

	public void SetFillPattern(CGPattern pattern, nfloat[] components)
	{
		CGContextSetFillPattern(handle, pattern.GetHandle(), components);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetStrokePattern(IntPtr context, IntPtr pattern, nfloat[] components);

	public void SetStrokePattern(CGPattern pattern, nfloat[] components)
	{
		CGContextSetStrokePattern(handle, pattern.GetHandle(), components);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetPatternPhase(IntPtr context, CGSize phase);

	public void SetPatternPhase(CGSize phase)
	{
		CGContextSetPatternPhase(handle, phase);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetGrayFillColor(IntPtr context, nfloat gray, nfloat alpha);

	public void SetFillColor(nfloat gray, nfloat alpha)
	{
		CGContextSetGrayFillColor(handle, gray, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetGrayStrokeColor(IntPtr context, nfloat gray, nfloat alpha);

	public void SetStrokeColor(nfloat gray, nfloat alpha)
	{
		CGContextSetGrayStrokeColor(handle, gray, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetRGBFillColor(IntPtr context, nfloat red, nfloat green, nfloat blue, nfloat alpha);

	public void SetFillColor(nfloat red, nfloat green, nfloat blue, nfloat alpha)
	{
		CGContextSetRGBFillColor(handle, red, green, blue, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetRGBStrokeColor(IntPtr context, nfloat red, nfloat green, nfloat blue, nfloat alpha);

	public void SetStrokeColor(nfloat red, nfloat green, nfloat blue, nfloat alpha)
	{
		CGContextSetRGBStrokeColor(handle, red, green, blue, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetCMYKFillColor(IntPtr context, nfloat cyan, nfloat magenta, nfloat yellow, nfloat black, nfloat alpha);

	public void SetFillColor(nfloat cyan, nfloat magenta, nfloat yellow, nfloat black, nfloat alpha)
	{
		CGContextSetCMYKFillColor(handle, cyan, magenta, yellow, black, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetCMYKStrokeColor(IntPtr context, nfloat cyan, nfloat magenta, nfloat yellow, nfloat black, nfloat alpha);

	public void SetStrokeColor(nfloat cyan, nfloat magenta, nfloat yellow, nfloat black, nfloat alpha)
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
		CGContextDrawImage(handle, rect, image?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawTiledImage(IntPtr c, CGRect rect, IntPtr image);

	public void DrawTiledImage(CGRect rect, CGImage image)
	{
		CGContextDrawTiledImage(handle, rect, image?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGInterpolationQuality CGContextGetInterpolationQuality(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetInterpolationQuality(IntPtr context, CGInterpolationQuality quality);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetShadowWithColor(IntPtr context, CGSize offset, nfloat blur, IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetShadow(IntPtr context, CGSize offset, nfloat blur);

	public void SetShadow(CGSize offset, nfloat blur, CGColor color = null)
	{
		if (color == null)
		{
			CGContextSetShadow(handle, offset, blur);
		}
		else
		{
			CGContextSetShadowWithColor(handle, offset, blur, color.handle);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawLinearGradient(IntPtr context, IntPtr gradient, CGPoint startPoint, CGPoint endPoint, CGGradientDrawingOptions options);

	public void DrawLinearGradient(CGGradient gradient, CGPoint startPoint, CGPoint endPoint, CGGradientDrawingOptions options)
	{
		CGContextDrawLinearGradient(handle, gradient?.handle ?? IntPtr.Zero, startPoint, endPoint, options);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawRadialGradient(IntPtr context, IntPtr gradient, CGPoint startCenter, nfloat startRadius, CGPoint endCenter, nfloat endRadius, CGGradientDrawingOptions options);

	public void DrawRadialGradient(CGGradient gradient, CGPoint startCenter, nfloat startRadius, CGPoint endCenter, nfloat endRadius, CGGradientDrawingOptions options)
	{
		CGContextDrawRadialGradient(handle, gradient?.handle ?? IntPtr.Zero, startCenter, startRadius, endCenter, endRadius, options);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawShading(IntPtr context, IntPtr shading);

	public void DrawShading(CGShading shading)
	{
		CGContextDrawShading(handle, shading?.handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetCharacterSpacing(IntPtr context, nfloat spacing);

	public void SetCharacterSpacing(nfloat spacing)
	{
		CGContextSetCharacterSpacing(handle, spacing);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetTextPosition(IntPtr c, nfloat x, nfloat y);

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
		CGContextSetFont(handle, font?.handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetFontSize(IntPtr c, nfloat size);

	public void SetFontSize(nfloat size)
	{
		CGContextSetFontSize(handle, size);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSelectFont(IntPtr c, string name, nfloat size, CGTextEncoding textEncoding);

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void SelectFont(string name, nfloat size, CGTextEncoding textEncoding)
	{
		CGContextSelectFont(handle, name, size, textEncoding);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowGlyphsAtPositions(IntPtr context, ushort[] glyphs, CGPoint[] positions, nint count);

	public void ShowGlyphsAtPositions(ushort[] glyphs, CGPoint[] positions, int count = -1)
	{
		if (glyphs == null)
		{
			count = 0;
		}
		else if (count < 0)
		{
			count = glyphs.Length;
		}
		CGContextShowGlyphsAtPositions(handle, glyphs, positions, count);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowText(IntPtr c, string s, nint length);

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void ShowText(string str, int count)
	{
		if (str == null)
		{
			count = 0;
		}
		else if (count > str.Length)
		{
			throw new ArgumentException("count");
		}
		CGContextShowText(handle, str, count);
	}

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void ShowText(string str)
	{
		CGContextShowText(handle, str, str?.Length ?? 0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowText(IntPtr c, byte[] bytes, nint length);

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void ShowText(byte[] bytes, int count)
	{
		if (bytes == null)
		{
			count = 0;
		}
		else if (count > bytes.Length)
		{
			throw new ArgumentException("count");
		}
		CGContextShowText(handle, bytes, count);
	}

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void ShowText(byte[] bytes)
	{
		CGContextShowText(handle, bytes, (bytes != null) ? bytes.Length : 0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowTextAtPoint(IntPtr c, nfloat x, nfloat y, string str, nint length);

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void ShowTextAtPoint(nfloat x, nfloat y, string str, int length)
	{
		CGContextShowTextAtPoint(handle, x, y, str, length);
	}

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void ShowTextAtPoint(nfloat x, nfloat y, string str)
	{
		CGContextShowTextAtPoint(handle, x, y, str, str?.Length ?? 0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowTextAtPoint(IntPtr c, nfloat x, nfloat y, byte[] bytes, nint length);

	public void ShowTextAtPoint(nfloat x, nfloat y, byte[] bytes, int length)
	{
		CGContextShowTextAtPoint(handle, x, y, bytes, length);
	}

	public void ShowTextAtPoint(nfloat x, nfloat y, byte[] bytes)
	{
		CGContextShowTextAtPoint(handle, x, y, bytes, (bytes != null) ? bytes.Length : 0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowGlyphs(IntPtr c, ushort[] glyphs, nint count);

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void ShowGlyphs(ushort[] glyphs)
	{
		CGContextShowGlyphs(handle, glyphs, (glyphs != null) ? glyphs.Length : 0);
	}

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void ShowGlyphs(ushort[] glyphs, int count)
	{
		if (glyphs == null)
		{
			count = 0;
		}
		else if (count > glyphs.Length)
		{
			throw new ArgumentException("count");
		}
		CGContextShowGlyphs(handle, glyphs, count);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowGlyphsAtPoint(IntPtr context, nfloat x, nfloat y, ushort[] glyphs, nint count);

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void ShowGlyphsAtPoint(nfloat x, nfloat y, ushort[] glyphs, int count)
	{
		if (glyphs == null)
		{
			count = 0;
		}
		else if (count > glyphs.Length)
		{
			throw new ArgumentException("count");
		}
		CGContextShowGlyphsAtPoint(handle, x, y, glyphs, count);
	}

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void ShowGlyphsAtPoint(nfloat x, nfloat y, ushort[] glyphs)
	{
		CGContextShowGlyphsAtPoint(handle, x, y, glyphs, (glyphs != null) ? glyphs.Length : 0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextShowGlyphsWithAdvances(IntPtr c, ushort[] glyphs, CGSize[] advances, nint count);

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the 'CoreText' API instead.")]
	public void ShowGlyphsWithAdvances(ushort[] glyphs, CGSize[] advances, int count)
	{
		if (glyphs == null)
		{
			count = 0;
		}
		if (count > glyphs.Length || count > advances.Length)
		{
			throw new ArgumentException("count");
		}
		CGContextShowGlyphsWithAdvances(handle, glyphs, advances, count);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextDrawPDFPage(IntPtr c, IntPtr page);

	public void DrawPDFPage(CGPDFPage page)
	{
		CGContextDrawPDFPage(handle, page?.handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private unsafe static extern void CGContextBeginPage(IntPtr c, CGRect* mediaBox);

	public unsafe void BeginPage(CGRect? rect)
	{
		if (rect.HasValue)
		{
			CGRect value = rect.Value;
			CGContextBeginPage(handle, &value);
		}
		else
		{
			CGContextBeginPage(handle, null);
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
	private static extern void CGContextSetShouldAntialias(IntPtr context, bool shouldAntialias);

	public void SetShouldAntialias(bool shouldAntialias)
	{
		CGContextSetShouldAntialias(handle, shouldAntialias);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetAllowsAntialiasing(IntPtr context, bool allowsAntialiasing);

	public void SetAllowsAntialiasing(bool allowsAntialiasing)
	{
		CGContextSetAllowsAntialiasing(handle, allowsAntialiasing);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetShouldSmoothFonts(IntPtr context, bool shouldSmoothFonts);

	public void SetShouldSmoothFonts(bool shouldSmoothFonts)
	{
		CGContextSetShouldSmoothFonts(handle, shouldSmoothFonts);
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

	public CGPath CopyPath()
	{
		IntPtr intPtr = CGContextCopyPath(handle);
		return new CGPath(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetAllowsFontSmoothing(IntPtr context, bool shouldSubpixelPositionFonts);

	public void SetAllowsFontSmoothing(bool allows)
	{
		CGContextSetAllowsFontSmoothing(handle, allows);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetAllowsFontSubpixelPositioning(IntPtr context, bool allowsFontSubpixelPositioning);

	public void SetAllowsSubpixelPositioning(bool allows)
	{
		CGContextSetAllowsFontSubpixelPositioning(handle, allows);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetAllowsFontSubpixelQuantization(IntPtr context, bool shouldSubpixelQuantizeFonts);

	public void SetAllowsFontSubpixelQuantization(bool allows)
	{
		CGContextSetAllowsFontSubpixelQuantization(handle, allows);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetShouldSubpixelPositionFonts(IntPtr context, bool shouldSubpixelPositionFonts);

	public void SetShouldSubpixelPositionFonts(bool shouldSubpixelPositionFonts)
	{
		CGContextSetShouldSubpixelPositionFonts(handle, shouldSubpixelPositionFonts);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextSetShouldSubpixelQuantizeFonts(IntPtr context, bool shouldSubpixelQuantizeFonts);

	public void ShouldSubpixelQuantizeFonts(bool shouldSubpixelQuantizeFonts)
	{
		CGContextSetShouldSubpixelQuantizeFonts(handle, shouldSubpixelQuantizeFonts);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextBeginTransparencyLayer(IntPtr context, IntPtr auxiliaryInfo);

	public void BeginTransparencyLayer(NSDictionary auxiliaryInfo = null)
	{
		CGContextBeginTransparencyLayer(handle, auxiliaryInfo?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextBeginTransparencyLayerWithRect(IntPtr context, CGRect rect, IntPtr auxiliaryInfo);

	public void BeginTransparencyLayer(CGRect rectangle, NSDictionary auxiliaryInfo = null)
	{
		CGContextBeginTransparencyLayerWithRect(handle, rectangle, auxiliaryInfo?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGContextEndTransparencyLayer(IntPtr context);

	public void EndTransparencyLayer()
	{
		CGContextEndTransparencyLayer(handle);
	}

	public CGBitmapContext AsBitmapContext()
	{
		return new CGBitmapContext(Handle, owns: false);
	}
}
