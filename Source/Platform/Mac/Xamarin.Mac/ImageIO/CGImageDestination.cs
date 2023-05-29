using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

public class CGImageDestination : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public static string[] TypeIdentifiers => NSArray.StringArrayFromHandle(CGImageDestinationCopyTypeIdentifiers());

	internal CGImageDestination(IntPtr handle)
		: this(handle, owns: false)
	{
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGImageDestination(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	~CGImageDestination()
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

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO", EntryPoint = "CGImageDestinationGetTypeID")]
	public static extern int GetTypeID();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageDestinationCopyTypeIdentifiers();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageDestinationCreateWithData(IntPtr data, IntPtr stringType, IntPtr count, IntPtr options);

	public static CGImageDestination FromData(NSData data, string typeIdentifier, int imageCount)
	{
		return FromData(data, typeIdentifier, imageCount, null);
	}

	public static CGImageDestination FromData(NSData data, string typeIdentifier, int imageCount, CGImageDestinationOptions options)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		IntPtr stringType = NSString.CreateNative(typeIdentifier);
		IntPtr intPtr = CGImageDestinationCreateWithData(data.Handle, stringType, (IntPtr)imageCount, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		NSString.ReleaseNative(stringType);
		CGImageDestination result = ((intPtr == IntPtr.Zero) ? null : new CGImageDestination(intPtr, owns: true));
		nSMutableDictionary?.Dispose();
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageDestinationCreateWithURL(IntPtr url, IntPtr stringType, IntPtr count, IntPtr options);

	public static CGImageDestination FromUrl(NSUrl url, string typeIdentifier, int imageCount)
	{
		return FromUrl(url, typeIdentifier, imageCount, null);
	}

	public static CGImageDestination FromUrl(NSUrl url, string typeIdentifier, int imageCount, CGImageDestinationOptions options)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		IntPtr stringType = NSString.CreateNative(typeIdentifier);
		IntPtr intPtr = CGImageDestinationCreateWithURL(url.Handle, stringType, (IntPtr)imageCount, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		NSString.ReleaseNative(stringType);
		CGImageDestination result = ((intPtr == IntPtr.Zero) ? null : new CGImageDestination(intPtr, owns: true));
		nSMutableDictionary?.Dispose();
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern void CGImageDestinationSetProperties(IntPtr handle, IntPtr props);

	public void SetProperties(NSDictionary properties)
	{
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		CGImageDestinationSetProperties(handle, properties.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern void CGImageDestinationAddImage(IntPtr handle, IntPtr image, IntPtr properties);

	public void AddImage(CGImage image, NSDictionary properties)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		CGImageDestinationAddImage(handle, image.Handle, properties?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern void CGImageDestinationAddImageFromSource(IntPtr handle, IntPtr sourceHandle, IntPtr index, IntPtr properties);

	public void AddImage(CGImageSource source, int index, NSDictionary properties)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		CGImageDestinationAddImageFromSource(handle, source.Handle, (IntPtr)index, properties?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern bool CGImageDestinationFinalize(IntPtr handle);

	public bool Close()
	{
		bool result = CGImageDestinationFinalize(handle);
		Dispose();
		return result;
	}
}
