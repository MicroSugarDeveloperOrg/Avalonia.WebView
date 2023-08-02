using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGGradient : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	[Preserve(Conditional = true)]
	internal CGGradient(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CGGradientRetain(handle);
		}
		this.handle = handle;
	}

	~CGGradient()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGGradientRetain(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGGradientRelease(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGGradientRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGGradientCreateWithColorComponents(IntPtr colorspace, double[] components, double[] locations, IntPtr size_t_count);

	public CGGradient(CGColorSpace colorspace, double[] components, double[] locations)
	{
		if (colorspace == null)
		{
			throw new ArgumentNullException("colorspace");
		}
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		handle = CGGradientCreateWithColorComponents(colorspace.handle, components, locations, new IntPtr(components.Length / (colorspace.Components + 1)));
	}

	public CGGradient(CGColorSpace colorspace, double[] components)
	{
		if (colorspace == null)
		{
			throw new ArgumentNullException("colorspace");
		}
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		handle = CGGradientCreateWithColorComponents(colorspace.handle, components, null, new IntPtr(components.Length / (colorspace.Components + 1)));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGGradientCreateWithColors(IntPtr colorspace, IntPtr colors, double[] locations);

	public CGGradient(CGColorSpace colorspace, CGColor[] colors, double[] locations)
	{
		if (colors == null)
		{
			throw new ArgumentNullException("colors");
		}
		IntPtr colorspace2 = colorspace?.handle ?? IntPtr.Zero;
		using CFArray cFArray = CFArray.FromNativeObjects(colors);
		handle = CGGradientCreateWithColors(colorspace2, cFArray.Handle, locations);
	}

	public CGGradient(CGColorSpace colorspace, CGColor[] colors)
	{
		if (colors == null)
		{
			throw new ArgumentNullException("colors");
		}
		IntPtr colorspace2 = colorspace?.handle ?? IntPtr.Zero;
		using CFArray cFArray = CFArray.FromNativeObjects(colors);
		handle = CGGradientCreateWithColors(colorspace2, cFArray.Handle, null);
	}
}
