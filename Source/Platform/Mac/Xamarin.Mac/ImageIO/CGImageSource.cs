using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

public class CGImageSource : INativeObject, IDisposable
{
	internal IntPtr handle;

	public static string[] TypeIdentifiers
	{
		get
		{
			IntPtr obj = CGImageSourceCopyTypeIdentifiers();
			string[] result = NSArray.StringArrayFromHandle(obj);
			CFObject.CFRelease(obj);
			return result;
		}
	}

	public IntPtr Handle => handle;

	public string TypeIdentifier => NSString.FromHandle(CGImageSourceGetType(handle));

	public nint ImageCount => CGImageSourceGetCount(handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO", EntryPoint = "CGImageSourceGetTypeID")]
	public static extern nint GetTypeID();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCopyTypeIdentifiers();

	internal CGImageSource(IntPtr handle)
		: this(handle, owns: false)
	{
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGImageSource(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	~CGImageSource()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCreateWithURL(IntPtr url, IntPtr options);

	public static CGImageSource FromUrl(NSUrl url)
	{
		return FromUrl(url, null);
	}

	public static CGImageSource FromUrl(NSUrl url, CGImageOptions options)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		using NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		IntPtr intPtr = CGImageSourceCreateWithURL(url.Handle, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		return (intPtr == IntPtr.Zero) ? null : new CGImageSource(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCreateWithDataProvider(IntPtr provider, IntPtr options);

	public static CGImageSource FromDataProvider(CGDataProvider provider)
	{
		return FromDataProvider(provider, null);
	}

	public static CGImageSource FromDataProvider(CGDataProvider provider, CGImageOptions options)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		using NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		IntPtr intPtr = CGImageSourceCreateWithDataProvider(provider.Handle, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		return (intPtr == IntPtr.Zero) ? null : new CGImageSource(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCreateWithData(IntPtr data, IntPtr options);

	public static CGImageSource FromData(NSData data)
	{
		return FromData(data, null);
	}

	public static CGImageSource FromData(NSData data, CGImageOptions options)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		using NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		IntPtr intPtr = CGImageSourceCreateWithData(data.Handle, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		return (intPtr == IntPtr.Zero) ? null : new CGImageSource(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceGetType(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern nint CGImageSourceGetCount(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCopyProperties(IntPtr isrc, IntPtr options);

	[Advice("Use 'GetProperties'.")]
	public NSDictionary CopyProperties(NSDictionary dict)
	{
		IntPtr intPtr = CGImageSourceCopyProperties(handle, dict?.Handle ?? IntPtr.Zero);
		return (intPtr == IntPtr.Zero) ? null : Runtime.GetNSObject<NSDictionary>(intPtr);
	}

	[Advice("Use 'GetProperties'.")]
	public NSDictionary CopyProperties(CGImageOptions options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return CopyProperties(options.ToDictionary());
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCopyPropertiesAtIndex(IntPtr isrc, nint index, IntPtr options);

	[Advice("Use 'GetProperties'.")]
	public NSDictionary CopyProperties(NSDictionary dict, int imageIndex)
	{
		IntPtr intPtr = CGImageSourceCopyPropertiesAtIndex(handle, imageIndex, dict?.Handle ?? IntPtr.Zero);
		return (intPtr == IntPtr.Zero) ? null : Runtime.GetNSObject<NSDictionary>(intPtr);
	}

	[Advice("Use 'GetProperties'.")]
	public NSDictionary CopyProperties(CGImageOptions options, int imageIndex)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return CopyProperties(options.ToDictionary(), imageIndex);
	}

	public CoreGraphics.CGImageProperties GetProperties(CGImageOptions options = null)
	{
		return new CoreGraphics.CGImageProperties(CopyProperties(options?.ToDictionary()));
	}

	public CoreGraphics.CGImageProperties GetProperties(int index, CGImageOptions options = null)
	{
		return new CoreGraphics.CGImageProperties(CopyProperties(options?.ToDictionary(), index));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCreateImageAtIndex(IntPtr isrc, nint index, IntPtr options);

	public CGImage CreateImage(int index, CGImageOptions options)
	{
		using NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		IntPtr intPtr = CGImageSourceCreateImageAtIndex(handle, index, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCreateThumbnailAtIndex(IntPtr isrc, nint index, IntPtr options);

	public CGImage CreateThumbnail(int index, CGImageThumbnailOptions options)
	{
		using NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		IntPtr intPtr = CGImageSourceCreateThumbnailAtIndex(handle, index, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		return new CGImage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCreateIncremental(IntPtr options);

	public static CGImageSource CreateIncremental(CGImageOptions options)
	{
		using NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		return new CGImageSource(CGImageSourceCreateIncremental(nSMutableDictionary?.Handle ?? IntPtr.Zero), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern void CGImageSourceUpdateData(IntPtr isrc, IntPtr data, [MarshalAs(UnmanagedType.I1)] bool final);

	public void UpdateData(NSData data, bool final)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		CGImageSourceUpdateData(handle, data.Handle, final);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern void CGImageSourceUpdateDataProvider(IntPtr handle, IntPtr dataProvider, [MarshalAs(UnmanagedType.I1)] bool final);

	public void UpdateDataProvider(CGDataProvider provider, bool final)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		CGImageSourceUpdateDataProvider(handle, provider.Handle, final);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern CGImageSourceStatus CGImageSourceGetStatus(IntPtr isrc);

	public CGImageSourceStatus GetStatus()
	{
		return CGImageSourceGetStatus(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern CGImageSourceStatus CGImageSourceGetStatusAtIndex(IntPtr handle, nint idx);

	public CGImageSourceStatus GetStatus(int index)
	{
		return CGImageSourceGetStatusAtIndex(handle, index);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	private static extern IntPtr CGImageSourceCopyAuxiliaryDataInfoAtIndex(IntPtr isrc, nuint index, IntPtr auxiliaryImageDataType);

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public CGImageAuxiliaryDataInfo CopyAuxiliaryDataInfo(nuint index, CGImageAuxiliaryDataType auxiliaryImageDataType)
	{
		IntPtr intPtr = CGImageSourceCopyAuxiliaryDataInfoAtIndex(Handle, index, auxiliaryImageDataType.GetConstant().GetHandle());
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(intPtr);
		return new CGImageAuxiliaryDataInfo(nSObject);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	[Mac(10, 14)]
	[iOS(12, 0)]
	[TV(12, 0)]
	[Watch(5, 0)]
	private static extern nuint CGImageSourceGetPrimaryImageIndex(IntPtr src);

	[Mac(10, 14)]
	[iOS(12, 0)]
	[TV(12, 0)]
	[Watch(5, 0)]
	public nuint GetPrimaryImageIndex()
	{
		return CGImageSourceGetPrimaryImageIndex(handle);
	}
}
