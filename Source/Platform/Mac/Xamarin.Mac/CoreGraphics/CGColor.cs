using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreGraphics;

public class CGColor : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public nint NumberOfComponents => CGColorGetNumberOfComponents(handle);

	public unsafe nfloat[] Components
	{
		get
		{
			int num = (int)NumberOfComponents;
			nfloat[] array = new nfloat[num];
			nfloat* ptr = CGColorGetComponents(handle);
			for (int i = 0; i < num; i++)
			{
				array[i] = ptr[i];
			}
			return array;
		}
	}

	public nfloat Alpha => CGColorGetAlpha(handle);

	public CGColorSpace ColorSpace
	{
		get
		{
			IntPtr intPtr = CGColorGetColorSpace(handle);
			return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: false);
		}
	}

	public CGPattern Pattern
	{
		get
		{
			IntPtr intPtr = CGColorGetPattern(handle);
			return (intPtr == IntPtr.Zero) ? null : new CGPattern(intPtr);
		}
	}

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
	private static extern IntPtr CGColorCreate(IntPtr space, nfloat[] components);

	public CGColor(CGColorSpace colorspace, nfloat[] components)
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
	private static extern IntPtr CGColorCreateGenericGray(nfloat gray, nfloat alpha);

	public CGColor(nfloat gray, nfloat alpha)
	{
		handle = CGColorCreateGenericGray(gray, alpha);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorCreateGenericRGB(nfloat red, nfloat green, nfloat blue, nfloat alpha);

	public CGColor(nfloat red, nfloat green, nfloat blue, nfloat alpha)
	{
		handle = CGColorCreateGenericRGB(red, green, blue, alpha);
	}

	public CGColor(nfloat red, nfloat green, nfloat blue)
	{
		handle = CGColorCreateGenericRGB(red, green, blue, 1f);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorGetConstantColor(IntPtr colorName);

	public CGColor(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		using CFString cFString = new CFString(name);
		handle = CGColorGetConstantColor(cFString.Handle);
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException("name");
		}
		CGColorRetain(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorCreateWithPattern(IntPtr space, IntPtr pattern, nfloat[] components);

	public CGColor(CGColorSpace colorspace, CGPattern pattern, nfloat[] components)
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
		handle = CGColorCreateWithPattern(colorspace.handle, pattern.Handle, components);
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException();
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorCreateCopyWithAlpha(IntPtr color, nfloat alpha);

	public CGColor(CGColor source, nfloat alpha)
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
	private static extern nint CGColorGetNumberOfComponents(IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private unsafe static extern nfloat* CGColorGetComponents(IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nfloat CGColorGetAlpha(IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorGetColorSpace(IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorGetPattern(IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorRetain(IntPtr color);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGColorRelease(IntPtr color);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGColorRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern IntPtr CGColorCreateCopyByMatchingToColorSpace(IntPtr space, CGColorRenderingIntent intent, IntPtr color, IntPtr options);

	private static CGColor CreateByMatchingToColorSpace(CGColorSpace space, CGColorRenderingIntent intent, CGColor color, NSDictionary options)
	{
		IntPtr intPtr = CGColorCreateCopyByMatchingToColorSpace(space?.Handle ?? IntPtr.Zero, intent, (color == null) ? IntPtr.Zero : color.Handle, options?.Handle ?? IntPtr.Zero);
		return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	private static extern IntPtr CGColorCreateSRGB(nfloat red, nfloat green, nfloat blue, nfloat alpha);

	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	public static CGColor CreateSrgb(nfloat red, nfloat green, nfloat blue, nfloat alpha)
	{
		IntPtr intPtr = CGColorCreateSRGB(red, green, blue, alpha);
		return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	private static extern IntPtr CGColorCreateGenericGrayGamma2_2(nfloat gray, nfloat alpha);

	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	public static CGColor CreateGenericGrayGamma2_2(nfloat gray, nfloat alpha)
	{
		IntPtr intPtr = CGColorCreateGenericGrayGamma2_2(gray, alpha);
		return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
	}
}
