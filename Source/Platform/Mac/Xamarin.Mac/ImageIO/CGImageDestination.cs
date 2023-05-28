using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageIO;

public class CGImageDestination : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public static string[] TypeIdentifiers
	{
		get
		{
			IntPtr obj = CGImageDestinationCopyTypeIdentifiers();
			string[] result = NSArray.StringArrayFromHandle(obj);
			CFObject.CFRelease(obj);
			return result;
		}
	}

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
	public static extern nint GetTypeID();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageDestinationCopyTypeIdentifiers();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageDestinationCreateWithDataConsumer(IntPtr consumer, IntPtr type, nint count, IntPtr options);

	public static CGImageDestination Create(CGDataConsumer consumer, string typeIdentifier, int imageCount, CGImageDestinationOptions options = null)
	{
		if (consumer == null)
		{
			throw new ArgumentNullException("consumer");
		}
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		IntPtr type = NSString.CreateNative(typeIdentifier);
		IntPtr intPtr = CGImageDestinationCreateWithDataConsumer(consumer.Handle, type, imageCount, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		NSString.ReleaseNative(type);
		CGImageDestination result = ((intPtr == IntPtr.Zero) ? null : new CGImageDestination(intPtr, owns: true));
		nSMutableDictionary?.Dispose();
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageDestinationCreateWithData(IntPtr data, IntPtr stringType, nint count, IntPtr options);

	public static CGImageDestination Create(NSMutableData data, string typeIdentifier, int imageCount, CGImageDestinationOptions options = null)
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
		IntPtr intPtr = CGImageDestinationCreateWithData(data.Handle, stringType, imageCount, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		NSString.ReleaseNative(stringType);
		CGImageDestination result = ((intPtr == IntPtr.Zero) ? null : new CGImageDestination(intPtr, owns: true));
		nSMutableDictionary?.Dispose();
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageDestinationCreateWithURL(IntPtr url, IntPtr stringType, nint count, IntPtr options);

	public static CGImageDestination Create(NSUrl url, string typeIdentifier, int imageCount)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr stringType = NSString.CreateNative(typeIdentifier);
		IntPtr intPtr = CGImageDestinationCreateWithURL(url.Handle, stringType, imageCount, IntPtr.Zero);
		NSString.ReleaseNative(stringType);
		return (intPtr == IntPtr.Zero) ? null : new CGImageDestination(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern void CGImageDestinationSetProperties(IntPtr idst, IntPtr properties);

	public void SetProperties(NSDictionary properties)
	{
		CGImageDestinationSetProperties(handle, properties?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern void CGImageDestinationAddImage(IntPtr idst, IntPtr image, IntPtr properties);

	public void AddImage(CGImage image, CGImageDestinationOptions options = null)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		CGImageDestinationAddImage(handle, image.Handle, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		nSMutableDictionary?.Dispose();
	}

	public void AddImage(CGImage image, NSDictionary properties)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		CGImageDestinationAddImage(handle, image.Handle, properties?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern void CGImageDestinationAddImageFromSource(IntPtr idst, IntPtr sourceHandle, nint index, IntPtr properties);

	public void AddImage(CGImageSource source, int index, CGImageDestinationOptions options = null)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		NSMutableDictionary nSMutableDictionary = options?.ToDictionary();
		CGImageDestinationAddImageFromSource(handle, source.Handle, index, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		nSMutableDictionary?.Dispose();
	}

	public void AddImage(CGImageSource source, int index, NSDictionary properties)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		CGImageDestinationAddImageFromSource(handle, source.Handle, index, properties?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CGImageDestinationFinalize(IntPtr idst);

	public bool Close()
	{
		bool result = CGImageDestinationFinalize(handle);
		Dispose();
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	[iOS(7, 0)]
	private static extern void CGImageDestinationAddImageAndMetadata(IntPtr idst, IntPtr image, IntPtr metadata, IntPtr options);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[iOS(7, 0)]
	public void AddImageAndMetadata(CGImage image, CGImageMetadata meta, NSDictionary options)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr metadata = meta?.Handle ?? IntPtr.Zero;
		IntPtr options2 = options?.Handle ?? IntPtr.Zero;
		CGImageDestinationAddImageAndMetadata(handle, image.Handle, metadata, options2);
	}

	[iOS(7, 0)]
	public void AddImageAndMetadata(CGImage image, CGImageMetadata meta, CGImageDestinationOptions options)
	{
		NSDictionary nSDictionary = null;
		if (options != null)
		{
			nSDictionary = options.ToDictionary();
		}
		try
		{
			AddImageAndMetadata(image, meta, nSDictionary);
		}
		finally
		{
			if (options != null)
			{
				nSDictionary.Dispose();
			}
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	[iOS(7, 0)]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CGImageDestinationCopyImageSource(IntPtr idst, IntPtr image, IntPtr options, out IntPtr err);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[iOS(7, 0)]
	public bool CopyImageSource(CGImageSource image, NSDictionary options, out NSError error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr options2 = options?.Handle ?? IntPtr.Zero;
		IntPtr err;
		bool result = CGImageDestinationCopyImageSource(handle, image.Handle, options2, out err);
		error = ((err == IntPtr.Zero) ? null : new NSError(err));
		return result;
	}

	[iOS(7, 0)]
	public bool CopyImageSource(CGImageSource image, CGCopyImageSourceOptions options, out NSError error)
	{
		NSDictionary nSDictionary = null;
		if (options != null)
		{
			nSDictionary = options.ToDictionary();
		}
		try
		{
			return CopyImageSource(image, nSDictionary, out error);
		}
		finally
		{
			if (options != null)
			{
				nSDictionary.Dispose();
			}
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	private static extern void CGImageDestinationAddAuxiliaryDataInfo(IntPtr idst, IntPtr auxiliaryImageDataType, IntPtr auxiliaryDataInfoDictionary);

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public void AddAuxiliaryDataInfo(CGImageAuxiliaryDataType auxiliaryImageDataType, CGImageAuxiliaryDataInfo auxiliaryDataInfo)
	{
		using NSDictionary self = auxiliaryDataInfo?.Dictionary;
		CGImageDestinationAddAuxiliaryDataInfo(Handle, auxiliaryImageDataType.GetConstant().GetHandle(), self.GetHandle());
	}
}
