using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVMetadataFormatExtensions
{
	private static IntPtr[] values = new IntPtr[6];

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Field("AVMetadataFormatHLSMetadata", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataFormatHLSMetadata
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataFormatHLSMetadata", storage);
			}
		}
	}

	[Field("AVMetadataFormatiTunesMetadata", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataFormatiTunesMetadata
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataFormatiTunesMetadata", storage);
			}
		}
	}

	[Field("AVMetadataFormatID3Metadata", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataFormatID3Metadata
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataFormatID3Metadata", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Field("AVMetadataFormatISOUserData", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataFormatISOUserData
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataFormatISOUserData", storage);
			}
		}
	}

	[Field("AVMetadataFormatQuickTimeUserData", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataFormatQuickTimeUserData
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataFormatQuickTimeUserData", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("AVMetadataFormatUnknown", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataFormatUnknown
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataFormatUnknown", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVMetadataFormat self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVMetadataFormatHLSMetadata;
			break;
		case 1:
			ptr = AVMetadataFormatiTunesMetadata;
			break;
		case 2:
			ptr = AVMetadataFormatID3Metadata;
			break;
		case 3:
			ptr = AVMetadataFormatISOUserData;
			break;
		case 4:
			ptr = AVMetadataFormatQuickTimeUserData;
			break;
		case 5:
			ptr = AVMetadataFormatUnknown;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVMetadataFormat GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVMetadataFormatHLSMetadata))
		{
			return AVMetadataFormat.FormatHlsMetadata;
		}
		if (constant.IsEqualTo(AVMetadataFormatiTunesMetadata))
		{
			return AVMetadataFormat.FormatiTunesMetadata;
		}
		if (constant.IsEqualTo(AVMetadataFormatID3Metadata))
		{
			return AVMetadataFormat.FormatID3Metadata;
		}
		if (constant.IsEqualTo(AVMetadataFormatISOUserData))
		{
			return AVMetadataFormat.FormatISOUserData;
		}
		if (constant.IsEqualTo(AVMetadataFormatQuickTimeUserData))
		{
			return AVMetadataFormat.FormatQuickTimeUserData;
		}
		if (constant.IsEqualTo(AVMetadataFormatUnknown))
		{
			return AVMetadataFormat.Unknown;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
