using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGShading : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public CGShading(IntPtr handle)
	{
		this.handle = handle;
		CGShadingRetain(handle);
	}

	[Preserve(Conditional = true)]
	internal CGShading(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CGShadingRetain(handle);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGShadingCreateAxial(IntPtr space, CGPoint start, CGPoint end, IntPtr functionHandle, bool extendStart, bool extendEnd);

	public static CGShading CreateAxial(CGColorSpace colorspace, CGPoint start, CGPoint end, CGFunction function, bool extendStart, bool extendEnd)
	{
		if (colorspace == null)
		{
			throw new ArgumentNullException("colorspace");
		}
		if (colorspace.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("colorspace");
		}
		if (function == null)
		{
			throw new ArgumentNullException("function");
		}
		if (function.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("function");
		}
		return new CGShading(CGShadingCreateAxial(colorspace.Handle, start, end, function.Handle, extendStart, extendEnd), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGShadingCreateRadial(IntPtr space, CGPoint start, double startRadius, CGPoint end, double endRadius, IntPtr function, bool extendStart, bool extendEnd);

	public static CGShading CreateRadial(CGColorSpace colorspace, CGPoint start, double startRadius, CGPoint end, double endRadius, CGFunction function, bool extendStart, bool extendEnd)
	{
		if (colorspace == null)
		{
			throw new ArgumentNullException("colorspace");
		}
		if (colorspace.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("colorspace");
		}
		if (function == null)
		{
			throw new ArgumentNullException("function");
		}
		if (function.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("function");
		}
		return new CGShading(CGShadingCreateRadial(colorspace.Handle, start, startRadius, end, endRadius, function.Handle, extendStart, extendEnd), owns: true);
	}

	~CGShading()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGShadingRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGShadingRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGShadingRelease(handle);
			handle = IntPtr.Zero;
		}
	}
}
