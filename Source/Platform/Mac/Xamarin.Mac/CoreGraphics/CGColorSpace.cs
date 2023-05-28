using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreGraphics;

public class CGColorSpace : INativeObject, IDisposable
{
	internal IntPtr handle;

	[Obsolete("Use a real 'null' value instead of this managed wrapper over a null native instance.")]
	public static readonly CGColorSpace Null = new CGColorSpace(IntPtr.Zero);

	public IntPtr Handle => handle;

	public CGColorSpaceModel Model => CGColorSpaceGetModel(handle);

	public nint Components => CGColorSpaceGetNumberOfComponents(handle);

	[iOS(10, 0)]
	[TV(10, 0)]
	public string Name => CFString.FetchString(CGColorSpaceCopyName(handle), releaseHandle: true);

	[iOS(10, 0)]
	[Mac(10, 12)]
	[Watch(3, 0)]
	[TV(10, 0)]
	public bool IsWideGamutRgb => CGColorSpaceIsWideGamutRGB(handle);

	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	public bool SupportsOutput => CGColorSpaceSupportsOutput(handle);

	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	[Deprecated(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 13, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 13, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 6, 2, PlatformArchitecture.None, null)]
	public bool IsHdr => CGColorSpaceIsHDR(handle);

	public CGColorSpace(IntPtr handle)
	{
		this.handle = handle;
		CGColorSpaceRetain(handle);
	}

	public CGColorSpace(CFPropertyList propertyList)
	{
		if (propertyList == null)
		{
			throw new ArgumentNullException("propertyList");
		}
		handle = CGColorSpaceCreateWithPropertyList(propertyList.Handle);
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
	private static extern void CGColorSpaceRelease(IntPtr space);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceRetain(IntPtr space);

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

	public static CGColorSpace CreateDeviceCmyk()
	{
		return new CGColorSpace(CGColorSpaceCreateDeviceCMYK(), owns: true);
	}

	[Obsolete("This method has been renamed 'CreateDeviceCmyk'.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static CGColorSpace CreateDeviceCMYK()
	{
		return new CGColorSpace(CGColorSpaceCreateDeviceCMYK(), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateCalibratedGray(nfloat[] whitepoint, nfloat[] blackpoint, nfloat gamma);

	public static CGColorSpace CreateCalibratedGray(nfloat[] whitepoint, nfloat[] blackpoint, nfloat gamma)
	{
		if (whitepoint == null)
		{
			throw new ArgumentNullException("whitepoint");
		}
		if (whitepoint.Length != 3)
		{
			throw new ArgumentException("Must have exactly 3 values", "whitepoint");
		}
		if (blackpoint != null && blackpoint.Length != 3)
		{
			throw new ArgumentException("Must be null or have exactly 3 values", "blackpoint");
		}
		IntPtr intPtr = CGColorSpaceCreateCalibratedGray(whitepoint, blackpoint, gamma);
		return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateCalibratedRGB(nfloat[] whitePoint, nfloat[] blackPoint, nfloat[] gamma, nfloat[] matrix);

	public static CGColorSpace CreateCalibratedRGB(nfloat[] whitepoint, nfloat[] blackpoint, nfloat[] gamma, nfloat[] matrix)
	{
		if (whitepoint == null)
		{
			throw new ArgumentNullException("whitepoint");
		}
		if (whitepoint.Length != 3)
		{
			throw new ArgumentException("Must have exactly 3 values", "whitepoint");
		}
		if (blackpoint != null && blackpoint.Length != 3)
		{
			throw new ArgumentException("Must be null or have exactly 3 values", "blackpoint");
		}
		if (gamma != null && gamma.Length != 3)
		{
			throw new ArgumentException("Must be null or have exactly 3 values", "gamma");
		}
		if (matrix != null && matrix.Length != 9)
		{
			throw new ArgumentException("Must be null or have exactly 9 values", "matrix");
		}
		IntPtr intPtr = CGColorSpaceCreateCalibratedRGB(whitepoint, blackpoint, gamma, matrix);
		return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateLab(nfloat[] whitepoint, nfloat[] blackpoint, nfloat[] range);

	public static CGColorSpace CreateLab(nfloat[] whitepoint, nfloat[] blackpoint, nfloat[] range)
	{
		if (whitepoint == null)
		{
			throw new ArgumentNullException("whitepoint");
		}
		if (whitepoint.Length != 3)
		{
			throw new ArgumentException("Must have exactly 3 values", "whitepoint");
		}
		if (blackpoint != null && blackpoint.Length != 3)
		{
			throw new ArgumentException("Must be null or have exactly 3 values", "blackpoint");
		}
		if (range != null && range.Length != 4)
		{
			throw new ArgumentException("Must be null or have exactly 4 values", "range");
		}
		IntPtr intPtr = CGColorSpaceCreateLab(whitepoint, blackpoint, range);
		return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateIndexed(IntPtr baseSpace, nint lastIndex, byte[] colorTable);

	public static CGColorSpace CreateIndexed(CGColorSpace baseSpace, int lastIndex, byte[] colorTable)
	{
		IntPtr intPtr = CGColorSpaceCreateIndexed(baseSpace?.handle ?? IntPtr.Zero, lastIndex, colorTable);
		return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreatePattern(IntPtr baseSpace);

	public static CGColorSpace CreatePattern(CGColorSpace baseSpace)
	{
		IntPtr intPtr = CGColorSpaceCreatePattern(baseSpace?.handle ?? IntPtr.Zero);
		return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateWithName(IntPtr name);

	public static CGColorSpace CreateWithName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		using NSString nSString = new NSString(name);
		IntPtr intPtr = CGColorSpaceCreateWithName(nSString.Handle);
		return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: true);
	}

	private static CGColorSpace Create(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		IntPtr intPtr = CGColorSpaceCreateWithName(handle);
		return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: true);
	}

	[iOS(9, 0)]
	public static CGColorSpace CreateGenericGray()
	{
		return Create(CGColorSpaceNames.GenericGray.Handle);
	}

	[iOS(9, 0)]
	public static CGColorSpace CreateGenericRgb()
	{
		return Create(CGColorSpaceNames.GenericRgb.Handle);
	}

	[iOS(8, 0)]
	public static CGColorSpace CreateGenericCmyk()
	{
		return Create(CGColorSpaceNames.GenericCmyk.Handle);
	}

	[iOS(9, 0)]
	public static CGColorSpace CreateGenericRgbLinear()
	{
		return Create(CGColorSpaceNames.GenericRgbLinear.Handle);
	}

	[iOS(8, 0)]
	public static CGColorSpace CreateAdobeRgb1988()
	{
		return Create(CGColorSpaceNames.AdobeRgb1998.Handle);
	}

	[iOS(8, 0)]
	public static CGColorSpace CreateSrgb()
	{
		return Create(CGColorSpaceNames.Srgb.Handle);
	}

	[iOS(8, 0)]
	public static CGColorSpace CreateGenericGrayGamma2_2()
	{
		return Create(CGColorSpaceNames.GenericGrayGamma2_2.Handle);
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static CGColorSpace CreateGenericXyz()
	{
		return Create(CGColorSpaceNames.GenericXyz.Handle);
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static CGColorSpace CreateAcesCGLinear()
	{
		return Create(CGColorSpaceNames.AcesCGLinear.Handle);
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static CGColorSpace CreateItuR_709()
	{
		return Create(CGColorSpaceNames.ItuR_709.Handle);
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static CGColorSpace CreateItuR_2020()
	{
		return Create(CGColorSpaceNames.ItuR_2020.Handle);
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static CGColorSpace CreateRommRgb()
	{
		return Create(CGColorSpaceNames.RommRgb.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceGetBaseColorSpace(IntPtr space);

	public CGColorSpace GetBaseColorSpace()
	{
		IntPtr intPtr = CGColorSpaceGetBaseColorSpace(handle);
		return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: false);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGColorSpaceModel CGColorSpaceGetModel(IntPtr space);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGColorSpaceGetNumberOfComponents(IntPtr space);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGColorSpaceGetColorTableCount(IntPtr space);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGColorSpaceGetColorTable(IntPtr space, byte[] table);

	public byte[] GetColorTable()
	{
		nint nint = CGColorSpaceGetColorTableCount(handle);
		if (nint == 0)
		{
			return Array.Empty<byte>();
		}
		byte[] array = new byte[(long)(nint * GetBaseColorSpace().Components)];
		CGColorSpaceGetColorTable(handle, array);
		return array;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CreateIDCCData' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CreateIDCCData' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CreateIDCCData' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CreateIDCCData' instead.")]
	private static extern IntPtr CGColorSpaceCreateWithICCProfile(IntPtr data);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(10, 0)]
	[Mac(10, 12)]
	[Watch(3, 0)]
	[TV(10, 0)]
	private static extern IntPtr CGColorSpaceCreateWithICCData(IntPtr data);

	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CreateIDCCData' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CreateIDCCData' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CreateIDCCData' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CreateIDCCData' instead.")]
	public static CGColorSpace CreateICCProfile(NSData data)
	{
		IntPtr intPtr = CGColorSpaceCreateWithICCProfile(data.GetHandle());
		return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: true);
	}

	[iOS(10, 0)]
	[Mac(10, 12)]
	public static CGColorSpace CreateIccData(NSData data)
	{
		return CreateIccData(data.GetHandle());
	}

	[iOS(10, 0)]
	[Mac(10, 12)]
	[Watch(3, 0)]
	[TV(10, 0)]
	public static CGColorSpace CreateIccData(CGDataProvider provider)
	{
		return CreateIccData(provider.GetHandle());
	}

	private static CGColorSpace CreateIccData(IntPtr handle)
	{
		IntPtr intPtr = CGColorSpaceCreateWithICCData(handle);
		return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorSpaceCreateICCBased(nint nComponents, nfloat[] range, IntPtr profile, IntPtr alternate);

	public static CGColorSpace CreateICCProfile(nfloat[] range, CGDataProvider profile, CGColorSpace alternate)
	{
		nint nComponents = ((range != null) ? (range.Length / 2) : 0);
		IntPtr profile2 = profile?.Handle ?? IntPtr.Zero;
		IntPtr alternate2 = alternate?.Handle ?? IntPtr.Zero;
		IntPtr intPtr = CGColorSpaceCreateICCBased(nComponents, range, profile2, alternate2);
		return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'GetICCData' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'GetICCData' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'GetICCData' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'GetICCData' instead.")]
	private static extern IntPtr CGColorSpaceCopyICCProfile(IntPtr space);

	[iOS(7, 0)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'GetICCData' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'GetICCData' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'GetICCData' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'GetICCData' instead.")]
	public NSData GetICCProfile()
	{
		IntPtr intPtr = CGColorSpaceCopyICCProfile(handle);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(10, 0)]
	[Mac(10, 12)]
	[Watch(3, 0)]
	[TV(10, 0)]
	private static extern IntPtr CGColorSpaceCopyICCData(IntPtr space);

	[iOS(10, 0)]
	[Mac(10, 12)]
	[Watch(3, 0)]
	[TV(10, 0)]
	public NSData GetIccData()
	{
		IntPtr intPtr = CGColorSpaceCopyICCData(handle);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(10, 0)]
	[TV(10, 0)]
	private static extern IntPtr CGColorSpaceCopyName(IntPtr space);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(10, 0)]
	[Mac(10, 12)]
	[Watch(3, 0)]
	[TV(10, 0)]
	private static extern bool CGColorSpaceIsWideGamutRGB(IntPtr space);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	private static extern bool CGColorSpaceSupportsOutput(IntPtr space);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	[Watch(5, 0)]
	private static extern IntPtr CGColorSpaceCopyPropertyList(IntPtr space);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	[Watch(5, 0)]
	private static extern IntPtr CGColorSpaceCreateWithPropertyList(IntPtr plist);

	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	[Watch(5, 0)]
	public CFPropertyList ToPropertyList()
	{
		IntPtr intPtr = CGColorSpaceCopyPropertyList(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CFPropertyList(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	[Deprecated(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 13, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 13, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 6, 2, PlatformArchitecture.None, null)]
	private static extern bool CGColorSpaceIsHDR(IntPtr space);
}
