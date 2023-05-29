using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPattern : INativeObject, IDisposable
{
	public delegate void DrawPattern(CGContext ctx);

	internal IntPtr handle;

	private DrawPattern draw_pattern;

	private CGPatternCallbacks callbacks;

	private GCHandle gch;

	private IntPtr last_cgcontext_ptr;

	private WeakReference last_cgcontext;

	public IntPtr Handle => handle;

	public CGPattern(IntPtr handle)
	{
		this.handle = handle;
		CGPatternRetain(this.handle);
	}

	[Preserve(Conditional = true)]
	internal CGPattern(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CGPatternRetain(this.handle);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPatternCreate(IntPtr info, CGRect bounds, CGAffineTransform matrix, double xStep, double yStep, CGPatternTiling tiling, bool isColored, ref CGPatternCallbacks callbacks);

	public CGPattern(CGRect bounds, CGAffineTransform matrix, double xStep, double yStep, CGPatternTiling tiling, bool isColored, DrawPattern drawPattern)
	{
		if (drawPattern == null)
		{
			throw new ArgumentNullException("drawPattern");
		}
		callbacks.draw = DrawCallback;
		callbacks.release = ReleaseCallback;
		callbacks.version = 0u;
		draw_pattern = drawPattern;
		gch = GCHandle.Alloc(this);
		handle = CGPatternCreate(GCHandle.ToIntPtr(gch), bounds, matrix, xStep, yStep, tiling, isColored, ref callbacks);
	}

	private static void DrawCallback(IntPtr voidptr, IntPtr cgcontextptr)
	{
		CGPattern cGPattern = (CGPattern)GCHandle.FromIntPtr(voidptr).Target;
		CGContext cGContext = null;
		if (cgcontextptr == cGPattern.last_cgcontext_ptr)
		{
			cGContext = cGPattern.last_cgcontext.Target as CGContext;
		}
		if (cGContext == null)
		{
			cGContext = new CGContext(cgcontextptr);
			cGPattern.last_cgcontext = new WeakReference(cGContext);
			cGPattern.last_cgcontext_ptr = cgcontextptr;
		}
		cGPattern.draw_pattern(cGContext);
	}

	private static void ReleaseCallback(IntPtr voidptr)
	{
		GCHandle.FromIntPtr(voidptr).Free();
	}

	~CGPattern()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPatternRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPatternRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGPatternRelease(handle);
			handle = IntPtr.Zero;
		}
		last_cgcontext = null;
	}
}
