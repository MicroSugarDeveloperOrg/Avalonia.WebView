using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVMediaTypesExtensions
{
	private static IntPtr[] values = new IntPtr[10];

	[Field("AVMediaTypeVideo", "AVFoundation")]
	internal unsafe static IntPtr AVMediaTypeVideo
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaTypeVideo", storage);
			}
		}
	}

	[Field("AVMediaTypeAudio", "AVFoundation")]
	internal unsafe static IntPtr AVMediaTypeAudio
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaTypeAudio", storage);
			}
		}
	}

	[Field("AVMediaTypeText", "AVFoundation")]
	internal unsafe static IntPtr AVMediaTypeText
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaTypeText", storage);
			}
		}
	}

	[Field("AVMediaTypeClosedCaption", "AVFoundation")]
	internal unsafe static IntPtr AVMediaTypeClosedCaption
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaTypeClosedCaption", storage);
			}
		}
	}

	[Field("AVMediaTypeSubtitle", "AVFoundation")]
	internal unsafe static IntPtr AVMediaTypeSubtitle
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaTypeSubtitle", storage);
			}
		}
	}

	[Field("AVMediaTypeTimecode", "AVFoundation")]
	internal unsafe static IntPtr AVMediaTypeTimecode
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaTypeTimecode", storage);
			}
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Always 'null'.")]
	[Obsoleted(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Always 'null'.")]
	[Field("AVMediaTypeTimedMetadata", "AVFoundation")]
	internal unsafe static IntPtr AVMediaTypeTimedMetadata
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaTypeTimedMetadata", storage);
			}
		}
	}

	[Field("AVMediaTypeMuxed", "AVFoundation")]
	internal unsafe static IntPtr AVMediaTypeMuxed
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaTypeMuxed", storage);
			}
		}
	}

	[Field("AVMediaTypeMetadata", "AVFoundation")]
	internal unsafe static IntPtr AVMediaTypeMetadata
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaTypeMetadata", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("AVMediaTypeDepthData", "AVFoundation")]
	internal unsafe static IntPtr AVMediaTypeDepthData
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMediaTypeDepthData", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVMediaTypes self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVMediaTypeVideo;
			break;
		case 1:
			ptr = AVMediaTypeAudio;
			break;
		case 2:
			ptr = AVMediaTypeText;
			break;
		case 3:
			ptr = AVMediaTypeClosedCaption;
			break;
		case 4:
			ptr = AVMediaTypeSubtitle;
			break;
		case 5:
			ptr = AVMediaTypeTimecode;
			break;
		case 6:
			ptr = AVMediaTypeTimedMetadata;
			break;
		case 7:
			ptr = AVMediaTypeMuxed;
			break;
		case 9:
			ptr = AVMediaTypeMetadata;
			break;
		case 10:
			ptr = AVMediaTypeDepthData;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVMediaTypes GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVMediaTypeVideo))
		{
			return AVMediaTypes.Video;
		}
		if (constant.IsEqualTo(AVMediaTypeAudio))
		{
			return AVMediaTypes.Audio;
		}
		if (constant.IsEqualTo(AVMediaTypeText))
		{
			return AVMediaTypes.Text;
		}
		if (constant.IsEqualTo(AVMediaTypeClosedCaption))
		{
			return AVMediaTypes.ClosedCaption;
		}
		if (constant.IsEqualTo(AVMediaTypeSubtitle))
		{
			return AVMediaTypes.Subtitle;
		}
		if (constant.IsEqualTo(AVMediaTypeTimecode))
		{
			return AVMediaTypes.Timecode;
		}
		if (constant.IsEqualTo(AVMediaTypeTimedMetadata))
		{
			return AVMediaTypes.TimedMetadata;
		}
		if (constant.IsEqualTo(AVMediaTypeMuxed))
		{
			return AVMediaTypes.Muxed;
		}
		if (constant.IsEqualTo(AVMediaTypeMetadata))
		{
			return AVMediaTypes.Metadata;
		}
		if (constant.IsEqualTo(AVMediaTypeDepthData))
		{
			return AVMediaTypes.DepthData;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
