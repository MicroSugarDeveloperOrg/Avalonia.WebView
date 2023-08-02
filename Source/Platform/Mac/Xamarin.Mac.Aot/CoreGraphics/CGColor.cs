using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGColor : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public int NumberOfComponents => CGColorGetNumberOfComponents(handle);

	public unsafe double[] Components
	{
		get
		{
			int numberOfComponents = NumberOfComponents;
			double[] array = new double[numberOfComponents];
			double* ptr = CGColorGetComponents(handle);
			for (int i = 0; i < numberOfComponents; i++)
			{
				array[i] = ptr[i];
			}
			return array;
		}
	}

	public double Alpha => CGColorGetAlpha(handle);

	public CGColorSpace ColorSpace => new CGColorSpace(CGColorGetColorSpace(handle));

	public CGPattern Pattern => new CGPattern(CGColorGetPattern(handle));

	~CGColor()
	{
		Dispose(disposing: false);
	}

	public CGColor(IntPtr handle)
	{
		this.handle = handle;
		CGColorRetain(handle);
	}

	[Preserve(Conditional = true)]
	internal CGColor(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CGColorRetain(handle);
		}
		this.handle = handle;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorCreate(IntPtr space, double[] components);

	public CGColor(CGColorSpace colorspace, double[] components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		if (colorspace == null)
		{
			throw new ArgumentNullException("colorspace");
		}
		if (colorspace.handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("colorspace");
		}
		handle = CGColorCreate(colorspace.handle, components);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorCreateGenericGray(double gray, double alpha);

	public CGColor(double gray, double alpha)
	{
		handle = CGColorCreateGenericGray(gray, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorCreateGenericRGB(double red, double green, double blue, double alpha);

	public CGColor(double red, double green, double blue, double alpha)
	{
		handle = CGColorCreateGenericRGB(red, green, blue, alpha);
	}

	public CGColor(double red, double green, double blue)
	{
		handle = CGColorCreateGenericRGB(red, green, blue, 1.0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorGetConstantColor(IntPtr cfstring_colorName);

	public CGColor(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		using CFString cFString = new CFString(name);
		handle = CGColorGetConstantColor(cFString.handle);
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException("name");
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorCreateWithPattern(IntPtr space, IntPtr pattern, double[] components);

	public CGColor(CGColorSpace colorspace, CGPattern pattern, double[] components)
	{
		if (colorspace == null)
		{
			throw new ArgumentNullException("colorspace");
		}
		if (colorspace.handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("colorspace");
		}
		if (pattern == null)
		{
			throw new ArgumentNullException("pattern");
		}
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		handle = CGColorCreateWithPattern(colorspace.handle, pattern.handle, components);
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException();
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorCreateCopyWithAlpha(IntPtr color, double alpha);

	public CGColor(CGColor source, double alpha)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (source.handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("source");
		}
		handle = CGColorCreateCopyWithAlpha(source.handle, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGColorEqualToColor(IntPtr color1, IntPtr color2);

	public static bool operator ==(CGColor color1, CGColor color2)
	{
		return object.Equals(color1, color2);
	}

	public static bool operator !=(CGColor color1, CGColor color2)
	{
		return !object.Equals(color1, color2);
	}

	public override int GetHashCode()
	{
		return handle.GetHashCode();
	}

	public override bool Equals(object o)
	{
		CGColor cGColor = o as CGColor;
		if (cGColor == null)
		{
			return false;
		}
		return CGColorEqualToColor(handle, cGColor.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGColorGetNumberOfComponents(IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private unsafe static extern double* CGColorGetComponents(IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern double CGColorGetAlpha(IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorGetColorSpace(IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorGetPattern(IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGColorRetain(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGColorRelease(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGColorRelease(handle);
			handle = IntPtr.Zero;
		}
	}
}
