using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;

namespace CoreGraphics;

public class CGPattern : NativeObject
{
	public delegate void DrawPattern(CGContext ctx);

	private static CGPatternCallbacks callbacks = new CGPatternCallbacks
	{
		version = 0u,
		draw = DrawCallback,
		release = ReleaseCallback
	};

	private GCHandle gch;

	public CGPattern(IntPtr handle)
		: base(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	internal CGPattern(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	protected override void Retain()
	{
		CGPatternRetain(base.Handle);
	}

	protected override void Release()
	{
		CGPatternRelease(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPatternCreate(IntPtr info, CGRect bounds, CGAffineTransform matrix, nfloat xStep, nfloat yStep, CGPatternTiling tiling, bool isColored, ref CGPatternCallbacks callbacks);

	public CGPattern(CGRect bounds, CGAffineTransform matrix, nfloat xStep, nfloat yStep, CGPatternTiling tiling, bool isColored, DrawPattern drawPattern)
	{
		if (drawPattern == null)
		{
			throw new ArgumentNullException("drawPattern");
		}
		gch = GCHandle.Alloc(drawPattern);
		base.Handle = CGPatternCreate(GCHandle.ToIntPtr(gch), bounds, matrix, xStep, yStep, tiling, isColored, ref callbacks);
	}

	private static void DrawCallback(IntPtr voidptr, IntPtr cgcontextptr)
	{
		DrawPattern drawPattern = (DrawPattern)GCHandle.FromIntPtr(voidptr).Target;
		using CGContext ctx = new CGContext(cgcontextptr);
		drawPattern(ctx);
	}

	private static void ReleaseCallback(IntPtr voidptr)
	{
		GCHandle.FromIntPtr(voidptr).Free();
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPatternRelease(IntPtr pattern);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPatternRetain(IntPtr pattern);
}
