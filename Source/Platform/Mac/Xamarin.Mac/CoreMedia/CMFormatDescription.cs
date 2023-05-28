using System.Runtime.InteropServices;
using AudioToolbox;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreMedia;

[Watch(6, 0)]
public class CMFormatDescription : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public uint MediaSubType => CMFormatDescriptionGetMediaSubType(handle);

	public AudioFormatType AudioFormatType => (MediaType == CMMediaType.Audio) ? ((AudioFormatType)MediaSubType) : ((AudioFormatType)0u);

	public CMSubtitleFormatType SubtitleFormatType => (MediaType == CMMediaType.Subtitle) ? ((CMSubtitleFormatType)MediaSubType) : ((CMSubtitleFormatType)0u);

	public CMClosedCaptionFormatType ClosedCaptionFormatType => (MediaType == CMMediaType.ClosedCaption) ? ((CMClosedCaptionFormatType)MediaSubType) : ((CMClosedCaptionFormatType)0u);

	public CMMuxedStreamType MuxedStreamType => (MediaType == CMMediaType.Muxed) ? ((CMMuxedStreamType)MediaSubType) : ((CMMuxedStreamType)0u);

	public CMVideoCodecType VideoCodecType => (MediaType == CMMediaType.Video) ? ((CMVideoCodecType)MediaSubType) : ((CMVideoCodecType)0u);

	public CMMetadataFormatType MetadataFormatType => (MediaType == CMMediaType.Metadata) ? ((CMMetadataFormatType)MediaSubType) : ((CMMetadataFormatType)0u);

	public CMTimeCodeFormatType TimeCodeFormatType => (MediaType == CMMediaType.TimeCode) ? ((CMTimeCodeFormatType)MediaSubType) : ((CMTimeCodeFormatType)0u);

	public CMMediaType MediaType => CMFormatDescriptionGetMediaType(handle);

	public unsafe AudioStreamBasicDescription? AudioStreamBasicDescription
	{
		get
		{
			IntPtr intPtr = CMAudioFormatDescriptionGetStreamBasicDescription(handle);
			if (intPtr != IntPtr.Zero)
			{
				return *(AudioStreamBasicDescription*)(void*)intPtr;
			}
			return null;
		}
	}

	public AudioChannelLayout AudioChannelLayout
	{
		get
		{
			nint size;
			IntPtr intPtr = CMAudioFormatDescriptionGetChannelLayout(handle, out size);
			if (intPtr == IntPtr.Zero || size == 0)
			{
				return null;
			}
			return AudioChannelLayout.FromHandle(intPtr);
		}
	}

	public unsafe AudioFormat[] AudioFormats
	{
		get
		{
			nint size;
			IntPtr intPtr = CMAudioFormatDescriptionGetFormatList(handle, out size);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			nint nint = size / sizeof(AudioFormat);
			AudioFormat[] array = new AudioFormat[(long)nint];
			AudioFormat* ptr = (AudioFormat*)(void*)intPtr;
			for (int i = 0; i < nint; i++)
			{
				array[i] = ptr[i];
			}
			return array;
		}
	}

	public byte[] AudioMagicCookie
	{
		get
		{
			nint size;
			IntPtr intPtr = CMAudioFormatDescriptionGetMagicCookie(handle, out size);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			byte[] array = new byte[(long)size];
			Marshal.Copy(intPtr, array, 0, array.Length);
			return array;
		}
	}

	public unsafe AudioFormat AudioMostCompatibleFormat
	{
		get
		{
			AudioFormat* ptr = (AudioFormat*)(void*)CMAudioFormatDescriptionGetMostCompatibleFormat(handle);
			if (ptr == null)
			{
				return default(AudioFormat);
			}
			return *ptr;
		}
	}

	public unsafe AudioFormat AudioRichestDecodableFormat
	{
		get
		{
			AudioFormat* ptr = (AudioFormat*)(void*)CMAudioFormatDescriptionGetRichestDecodableFormat(handle);
			if (ptr == null)
			{
				return default(AudioFormat);
			}
			return *ptr;
		}
	}

	internal CMFormatDescription(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	internal CMFormatDescription(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CMFormatDescription()
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

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMFormatDescriptionGetExtensions(IntPtr desc);

	public NSDictionary GetExtensions()
	{
		IntPtr intPtr = CMFormatDescriptionGetExtensions(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return Runtime.GetNSObject<NSDictionary>(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMFormatDescriptionGetExtension(IntPtr desc, IntPtr extensionkey);

	public NSObject GetExtension(string extensionKey)
	{
		using NSString nSString = new NSString(extensionKey);
		IntPtr intPtr = CMFormatDescriptionGetExtension(handle, nSString.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return Runtime.GetNSObject<NSObject>(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern uint CMFormatDescriptionGetMediaSubType(IntPtr desc);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMMediaType CMFormatDescriptionGetMediaType(IntPtr desc);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern nint CMFormatDescriptionGetTypeID();

	public static nint GetTypeID()
	{
		return CMFormatDescriptionGetTypeID();
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMFormatDescriptionError CMFormatDescriptionCreate(IntPtr allocator, CMMediaType mediaType, uint mediaSubtype, IntPtr extensions, out IntPtr descOut);

	public static CMFormatDescription Create(CMMediaType mediaType, uint mediaSubtype, out CMFormatDescriptionError error)
	{
		error = CMFormatDescriptionCreate(IntPtr.Zero, mediaType, mediaSubtype, IntPtr.Zero, out var descOut);
		if (error != 0)
		{
			return null;
		}
		return Create(mediaType, descOut, owns: true);
	}

	public static CMFormatDescription Create(IntPtr handle, bool owns)
	{
		return Create(CMFormatDescriptionGetMediaType(handle), handle, owns);
	}

	public static CMFormatDescription Create(IntPtr handle)
	{
		return Create(handle, owns: false);
	}

	private static CMFormatDescription Create(CMMediaType type, IntPtr handle, bool owns)
	{
		return type switch
		{
			CMMediaType.Video => new CMVideoFormatDescription(handle, owns), 
			CMMediaType.Audio => new CMAudioFormatDescription(handle, owns), 
			_ => new CMFormatDescription(handle, owns), 
		};
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetStreamBasicDescription(IntPtr desc);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetChannelLayout(IntPtr desc, out nint size);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetFormatList(IntPtr desc, out nint size);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetMagicCookie(IntPtr desc, out nint size);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetMostCompatibleFormat(IntPtr desc);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetRichestDecodableFormat(IntPtr desc);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	internal static extern CMVideoDimensions CMVideoFormatDescriptionGetDimensions(IntPtr videoDesc);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	internal static extern CGRect CMVideoFormatDescriptionGetCleanAperture(IntPtr videoDesc, bool originIsAtTopLeft);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	internal static extern IntPtr CMVideoFormatDescriptionGetExtensionKeysCommonWithImageBuffers();

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	internal static extern CGSize CMVideoFormatDescriptionGetPresentationDimensions(IntPtr videoDesc, bool usePixelAspectRatio, bool useCleanAperture);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	internal static extern bool CMVideoFormatDescriptionMatchesImageBuffer(IntPtr videoDesc, IntPtr imageBuffer);
}
