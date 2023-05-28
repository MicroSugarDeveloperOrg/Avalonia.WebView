using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

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
	private static extern IntPtr CGGradientRetain(IntPtr gradient);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGGradientRelease(IntPtr gradient);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGGradientRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGGradientCreateWithColorComponents(IntPtr colorspace, nfloat[] components, nfloat[] locations, nint count);

	public CGGradient(CGColorSpace colorspace, nfloat[] components, nfloat[] locations)
	{
		if (colorspace == null)
		{
			throw new ArgumentNullException("colorspace");
		}
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		handle = CGGradientCreateWithColorComponents(colorspace.handle, components, locations, components.Length / (colorspace.Components + 1));
	}

	public CGGradient(CGColorSpace colorspace, nfloat[] components)
	{
		if (colorspace == null)
		{
			throw new ArgumentNullException("colorspace");
		}
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		handle = CGGradientCreateWithColorComponents(colorspace.handle, components, null, components.Length / (colorspace.Components + 1));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGGradientCreateWithColors(IntPtr space, IntPtr colors, nfloat[] locations);

	public CGGradient(CGColorSpace colorspace, CGColor[] colors, nfloat[] locations)
	{
		if (colors == null)
		{
			throw new ArgumentNullException("colors");
		}
		IntPtr space = colorspace?.handle ?? IntPtr.Zero;
		using CFArray cFArray = CFArray.FromNativeObjects(colors);
		handle = CGGradientCreateWithColors(space, cFArray.Handle, locations);
	}

	public CGGradient(CGColorSpace colorspace, CGColor[] colors)
	{
		if (colors == null)
		{
			throw new ArgumentNullException("colors");
		}
		IntPtr space = colorspace?.handle ?? IntPtr.Zero;
		using CFArray cFArray = CFArray.FromNativeObjects(colors);
		handle = CGGradientCreateWithColors(space, cFArray.Handle, null);
	}
}
