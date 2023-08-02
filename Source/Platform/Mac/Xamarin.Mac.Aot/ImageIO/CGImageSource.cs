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

	public static string[] TypeIdentifiers => NSArray.StringArrayFromHandle(CGImageSourceCopyTypeIdentifiers());

	public IntPtr Handle => handle;

	public string TypeIdentifier => NSString.FromHandle(CGImageSourceGetType(handle));

	public int ImageCount => CGImageSourceGetCount(handle).ToInt32();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO", EntryPoint = "CGImageSourceGetTypeID")]
	public static extern int GetTypeID();

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
		return new CGImageSource(CGImageSourceCreateWithURL(url.Handle, nSMutableDictionary?.Handle ?? IntPtr.Zero), owns: true);
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
		return new CGImageSource(CGImageSourceCreateWithDataProvider(provider.Handle, nSMutableDictionary?.Handle ?? IntPtr.Zero), owns: true);
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
		return new CGImageSource(CGImageSourceCreateWithData(data.Handle, nSMutableDictionary?.Handle ?? IntPtr.Zero), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceGetType(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceGetCount(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCopyProperties(IntPtr handle, IntPtr dictOptions);

	[Advice("Use GetProperties")]
	public NSDictionary CopyProperties(NSDictionary dict)
	{
		return new NSDictionary(CGImageSourceCopyProperties(handle, dict?.Handle ?? IntPtr.Zero));
	}

	[Advice("Use GetProperties")]
	public NSDictionary CopyProperties(CGImageOptions options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return CopyProperties(options.ToDictionary());
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCopyPropertiesAtIndex(IntPtr handle, IntPtr idx, IntPtr dictOptions);

	[Advice("Use GetProperties")]
	public NSDictionary CopyProperties(NSDictionary dict, int imageIndex)
	{
		return new NSDictionary(CGImageSourceCopyPropertiesAtIndex(handle, new IntPtr(imageIndex), dict?.Handle ?? IntPtr.Zero));
	}

	[Advice("Use GetProperties")]
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
	private static extern IntPtr CGImageSourceCreateImageAtIndex(IntPtr isrc, IntPtr index, IntPtr options);

	public CGImage CreateImage(int index, CGImageOptions options)
	{
		using NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		return new CGImage(CGImageSourceCreateImageAtIndex(handle, new IntPtr(index), nSMutableDictionary?.Handle ?? IntPtr.Zero), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCreateThumbnailAtIndex(IntPtr isrc, IntPtr index, IntPtr options);

	public CGImage CreateThumbnail(int index, CGImageThumbnailOptions options)
	{
		using NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		return new CGImage(CGImageSourceCreateThumbnailAtIndex(handle, new IntPtr(index), nSMutableDictionary?.Handle ?? IntPtr.Zero), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageSourceCreateIncremental(IntPtr options);

	public static CGImageSource CreateIncremental(CGImageOptions options)
	{
		using NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		return new CGImageSource(CGImageSourceCreateIncremental(nSMutableDictionary?.Handle ?? IntPtr.Zero), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern void CGImageSourceUpdateData(IntPtr handle, IntPtr data, bool final);

	public void UpdateData(NSData data, bool final)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		CGImageSourceUpdateData(handle, data.Handle, final);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern void CGImageSourceUpdateDataProvider(IntPtr handle, IntPtr dataProvider);

	public void UpdateDataProvider(CGDataProvider provider)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		CGImageSourceUpdateDataProvider(handle, provider.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern CGImageSourceStatus CGImageSourceGetStatus(IntPtr handle);

	public CGImageSourceStatus GetStatus()
	{
		return CGImageSourceGetStatus(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern CGImageSourceStatus CGImageSourceGetStatusAtIndex(IntPtr handle, IntPtr idx);

	public CGImageSourceStatus GetStatus(int index)
	{
		return CGImageSourceGetStatusAtIndex(handle, new IntPtr(index));
	}
}
