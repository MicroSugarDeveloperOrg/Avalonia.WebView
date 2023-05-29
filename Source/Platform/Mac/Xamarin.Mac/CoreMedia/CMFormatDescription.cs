using System;
using System.Runtime.InteropServices;
using AudioToolbox;
using CoreFoundation;
using CoreGraphics;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Since(4, 0)]
public class CMFormatDescription : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public uint MediaSubType => CMFormatDescriptionGetMediaSubType(handle);

	public AudioFormatType AudioFormatType
	{
		get
		{
			if (MediaType != CMMediaType.Audio)
			{
				return (AudioFormatType)0;
			}
			return (AudioFormatType)MediaSubType;
		}
	}

	public CMSubtitleFormatType SubtitleFormatType
	{
		get
		{
			if (MediaType != CMMediaType.Subtitle)
			{
				return (CMSubtitleFormatType)0u;
			}
			return (CMSubtitleFormatType)MediaSubType;
		}
	}

	public CMClosedCaptionFormatType ClosedCaptionFormatType
	{
		get
		{
			if (MediaType != CMMediaType.ClosedCaption)
			{
				return (CMClosedCaptionFormatType)0u;
			}
			return (CMClosedCaptionFormatType)MediaSubType;
		}
	}

	public CMMuxedStreamType MuxedStreamType
	{
		get
		{
			if (MediaType != CMMediaType.Muxed)
			{
				return (CMMuxedStreamType)0u;
			}
			return (CMMuxedStreamType)MediaSubType;
		}
	}

	public CMVideoCodecType VideoCodecType
	{
		get
		{
			if (MediaType != CMMediaType.Video)
			{
				return (CMVideoCodecType)0;
			}
			return (CMVideoCodecType)MediaSubType;
		}
	}

	public CMMetadataFormatType MetadataFormatType
	{
		get
		{
			if (MediaType != CMMediaType.TimedMetadata)
			{
				return (CMMetadataFormatType)0u;
			}
			return (CMMetadataFormatType)MediaSubType;
		}
	}

	public CMTimeCodeFormatType TimeCodeFormatType
	{
		get
		{
			if (MediaType != CMMediaType.TimeCode)
			{
				return (CMTimeCodeFormatType)0u;
			}
			return (CMTimeCodeFormatType)MediaSubType;
		}
	}

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
			int size;
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
			int size;
			IntPtr intPtr = CMAudioFormatDescriptionGetFormatList(handle, out size);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			int num = size / sizeof(AudioFormat);
			AudioFormat[] array = new AudioFormat[num];
			AudioFormat* ptr = (AudioFormat*)(void*)intPtr;
			for (int i = 0; i < num; i++)
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
			int size;
			IntPtr intPtr = CMAudioFormatDescriptionGetMagicCookie(handle, out size);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			byte[] array = new byte[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = Marshal.ReadByte(intPtr, i);
			}
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

	[Advice("Use CMVideoFormatDescription")]
	public CMVideoDimensions VideoDimensions => CMVideoFormatDescriptionGetDimensions(handle);

	internal CMFormatDescription(IntPtr handle)
	{
		this.handle = handle;
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

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMFormatDescriptionGetExtensions(IntPtr handle);

	public NSDictionary GetExtensions()
	{
		IntPtr intPtr = CMFormatDescriptionGetExtensions(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return (NSDictionary)Runtime.GetNSObject(intPtr);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern uint CMFormatDescriptionGetMediaSubType(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMMediaType CMFormatDescriptionGetMediaType(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern int CMFormatDescriptionGetTypeID();

	public static int GetTypeID()
	{
		return CMFormatDescriptionGetTypeID();
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMFormatDescriptionError CMFormatDescriptionCreate(IntPtr allocator, CMMediaType mediaType, uint mediaSubtype, IntPtr extensions, out IntPtr handle);

	public static CMFormatDescription Create(CMMediaType mediaType, uint mediaSubtype, out CMFormatDescriptionError error)
	{
		error = CMFormatDescriptionCreate(IntPtr.Zero, mediaType, mediaSubtype, IntPtr.Zero, out var intPtr);
		if (error != 0)
		{
			return null;
		}
		return Create(mediaType, intPtr, owns: true);
	}

	public static CMFormatDescription Create(IntPtr handle, bool owns)
	{
		return Create(CMFormatDescriptionGetMediaType(handle), handle, owns);
	}

	private static CMFormatDescription Create(CMMediaType type, IntPtr handle, bool owns)
	{
		return type switch
		{
			CMMediaType.Video => new CMVideoFormatDescription(handle), 
			CMMediaType.Audio => new CMAudioFormatDescription(handle), 
			_ => new CMFormatDescription(handle), 
		};
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetStreamBasicDescription(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetChannelLayout(IntPtr handle, out int size);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetFormatList(IntPtr handle, out int size);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetMagicCookie(IntPtr handle, out int size);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetMostCompatibleFormat(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMAudioFormatDescriptionGetRichestDecodableFormat(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	internal static extern CMVideoDimensions CMVideoFormatDescriptionGetDimensions(IntPtr handle);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	internal static extern CGRect CMVideoFormatDescriptionGetCleanAperture(IntPtr handle, bool originIsAtTopLeft);

	[Advice("Use CMVideoFormatDescription")]
	public CGRect GetVideoCleanAperture(bool originIsAtTopLeft)
	{
		return CMVideoFormatDescriptionGetCleanAperture(handle, originIsAtTopLeft);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMVideoFormatDescriptionGetExtensionKeysCommonWithImageBuffers();

	public static NSObject[] GetExtensionKeysCommonWithImageBuffers()
	{
		return NSArray.ArrayFromHandle<NSString>(CMVideoFormatDescriptionGetExtensionKeysCommonWithImageBuffers());
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	internal static extern CGSize CMVideoFormatDescriptionGetPresentationDimensions(IntPtr handle, bool usePixelAspectRatio, bool useCleanAperture);

	[Advice("Use CMVideoFormatDescription")]
	public CGSize GetVideoPresentationDimensions(bool usePixelAspectRatio, bool useCleanAperture)
	{
		return CMVideoFormatDescriptionGetPresentationDimensions(handle, usePixelAspectRatio, useCleanAperture);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern int CMVideoFormatDescriptionMatchesImageBuffer(IntPtr handle, IntPtr imageBufferRef);

	public bool VideoMatchesImageBuffer(CVImageBuffer imageBuffer)
	{
		if (imageBuffer == null)
		{
			throw new ArgumentNullException("imageBuffer");
		}
		return CMVideoFormatDescriptionMatchesImageBuffer(handle, imageBuffer.Handle) != 0;
	}
}
