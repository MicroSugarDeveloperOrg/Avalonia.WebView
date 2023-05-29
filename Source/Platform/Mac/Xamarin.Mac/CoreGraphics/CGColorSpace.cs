using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGColorSpace : INativeObject, IDisposable
{
	internal IntPtr handle;

	public static CGColorSpace Null = new CGColorSpace(IntPtr.Zero);

	private static byte[] Empty = new byte[0];

	public IntPtr Handle => handle;

	public CGColorSpaceModel Model => CGColorSpaceGetModel(handle);

	public int Components => CGColorSpaceGetNumberOfComponents(handle);

	public CGColorSpace(IntPtr handle)
	{
		this.handle = handle;
		CGColorSpaceRetain(handle);
	}

	[Preserve(Conditional = true)]
	internal CGColorSpace(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CGColorSpaceRetain(handle);
		}
		this.handle = handle;
	}

	~CGColorSpace()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGColorSpaceRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGColorSpaceRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGColorSpaceRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateDeviceGray();

	public static CGColorSpace CreateDeviceGray()
	{
		return new CGColorSpace(CGColorSpaceCreateDeviceGray(), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateDeviceRGB();

	public static CGColorSpace CreateDeviceRGB()
	{
		return new CGColorSpace(CGColorSpaceCreateDeviceRGB(), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateDeviceCMYK();

	public static CGColorSpace CreateDeviceCMYK()
	{
		return new CGColorSpace(CGColorSpaceCreateDeviceCMYK(), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateCalibratedGray(double[] whitepoint, double[] blackpoint, double gamma);

	public static CGColorSpace CreateCalibratedGray(double[] whitepoint, double[] blackpoint, double gamma)
	{
		if (whitepoint.Length != 3)
		{
			throw new ArgumentException("Must have 3 values", "whitepoint");
		}
		if (blackpoint.Length != 3)
		{
			throw new ArgumentException("Must have 3 values", "blackpoint");
		}
		return new CGColorSpace(CGColorSpaceCreateCalibratedGray(whitepoint, blackpoint, gamma), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateCalibratedRGB(double[] whitePoint, double[] blackPoint, double[] gamma, double[] matrix);

	public static CGColorSpace CreateCalibratedRGB(double[] whitepoint, double[] blackpoint, double[] gamma, double[] matrix)
	{
		if (whitepoint.Length != 3)
		{
			throw new ArgumentException("Must have 3 values", "whitepoint");
		}
		if (blackpoint.Length != 3)
		{
			throw new ArgumentException("Must have 3 values", "blackpoint");
		}
		if (gamma.Length != 3)
		{
			throw new ArgumentException("Must have 3 values", "gamma");
		}
		if (matrix.Length != 9)
		{
			throw new ArgumentException("Must have 9 values", "matrix");
		}
		return new CGColorSpace(CGColorSpaceCreateCalibratedRGB(whitepoint, blackpoint, gamma, matrix), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateIndexed(IntPtr baseSpace, IntPtr lastIndex, byte[] colorTable);

	public static CGColorSpace CreateIndexed(CGColorSpace baseSpace, int lastIndex, byte[] colorTable)
	{
		return new CGColorSpace(CGColorSpaceCreateIndexed(baseSpace?.handle ?? IntPtr.Zero, new IntPtr(lastIndex), colorTable), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreatePattern(IntPtr baseSpace);

	public static CGColorSpace CreatePattern(CGColorSpace baseSpace)
	{
		return new CGColorSpace(CGColorSpaceCreatePattern(baseSpace?.handle ?? IntPtr.Zero), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateWithName(IntPtr name);

	public static CGColorSpace CreateWithName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return new CGColorSpace(CGColorSpaceCreateWithName(new NSString(name).Handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceGetBaseColorSpace(IntPtr space);

	public CGColorSpace GetBaseColorSpace()
	{
		return new CGColorSpace(CGColorSpaceGetBaseColorSpace(handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGColorSpaceModel CGColorSpaceGetModel(IntPtr space);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGColorSpaceGetNumberOfComponents(IntPtr space);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceGetColorTableCount(IntPtr space);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGColorSpaceGetColorTable(IntPtr space, byte[] table);

	public byte[] GetColorTable()
	{
		int num = CGColorSpaceGetColorTableCount(handle).ToInt32();
		if (num == 0)
		{
			return Empty;
		}
		byte[] array = new byte[num * GetBaseColorSpace().Components];
		CGColorSpaceGetColorTable(handle, array);
		return array;
	}
}
