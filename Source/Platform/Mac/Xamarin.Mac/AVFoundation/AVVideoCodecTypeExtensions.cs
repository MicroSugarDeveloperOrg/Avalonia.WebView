using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVVideoCodecTypeExtensions
{
	private static IntPtr[] values = new IntPtr[9];

	[Field("AVVideoCodecTypeH264", "AVFoundation")]
	internal unsafe static IntPtr AVVideoCodecTypeH264
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoCodecTypeH264", storage);
			}
		}
	}

	[Field("AVVideoCodecTypeJPEG", "AVFoundation")]
	internal unsafe static IntPtr AVVideoCodecTypeJPEG
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoCodecTypeJPEG", storage);
			}
		}
	}

	[Field("AVVideoCodecTypeAppleProRes422", "AVFoundation")]
	internal unsafe static IntPtr AVVideoCodecTypeAppleProRes422
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProRes422", storage);
			}
		}
	}

	[Field("AVVideoCodecTypeAppleProRes4444", "AVFoundation")]
	internal unsafe static IntPtr AVVideoCodecTypeAppleProRes4444
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProRes4444", storage);
			}
		}
	}

	[Field("AVVideoCodecTypeHEVC", "AVFoundation")]
	internal unsafe static IntPtr AVVideoCodecTypeHEVC
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoCodecTypeHEVC", storage);
			}
		}
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Field("AVVideoCodecTypeAppleProRes422HQ", "AVFoundation")]
	internal unsafe static IntPtr AVVideoCodecTypeAppleProRes422HQ
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProRes422HQ", storage);
			}
		}
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Field("AVVideoCodecTypeAppleProRes422LT", "AVFoundation")]
	internal unsafe static IntPtr AVVideoCodecTypeAppleProRes422LT
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProRes422LT", storage);
			}
		}
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Field("AVVideoCodecTypeAppleProRes422Proxy", "AVFoundation")]
	internal unsafe static IntPtr AVVideoCodecTypeAppleProRes422Proxy
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoCodecTypeAppleProRes422Proxy", storage);
			}
		}
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Field("AVVideoCodecTypeHEVCWithAlpha", "AVFoundation")]
	internal unsafe static IntPtr AVVideoCodecTypeHEVCWithAlpha
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVVideoCodecTypeHEVCWithAlpha", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVVideoCodecType self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVVideoCodecTypeH264;
			break;
		case 1:
			ptr = AVVideoCodecTypeJPEG;
			break;
		case 3:
			ptr = AVVideoCodecTypeAppleProRes422;
			break;
		case 4:
			ptr = AVVideoCodecTypeAppleProRes4444;
			break;
		case 5:
			ptr = AVVideoCodecTypeHEVC;
			break;
		case 6:
			ptr = AVVideoCodecTypeAppleProRes422HQ;
			break;
		case 7:
			ptr = AVVideoCodecTypeAppleProRes422LT;
			break;
		case 8:
			ptr = AVVideoCodecTypeAppleProRes422Proxy;
			break;
		case 9:
			ptr = AVVideoCodecTypeHEVCWithAlpha;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVVideoCodecType GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVVideoCodecTypeH264))
		{
			return AVVideoCodecType.H264;
		}
		if (constant.IsEqualTo(AVVideoCodecTypeJPEG))
		{
			return AVVideoCodecType.Jpeg;
		}
		if (constant.IsEqualTo(AVVideoCodecTypeAppleProRes422))
		{
			return AVVideoCodecType.AppleProRes422;
		}
		if (constant.IsEqualTo(AVVideoCodecTypeAppleProRes4444))
		{
			return AVVideoCodecType.AppleProRes4444;
		}
		if (constant.IsEqualTo(AVVideoCodecTypeHEVC))
		{
			return AVVideoCodecType.Hevc;
		}
		if (constant.IsEqualTo(AVVideoCodecTypeAppleProRes422HQ))
		{
			return AVVideoCodecType.AppleProRes422HQ;
		}
		if (constant.IsEqualTo(AVVideoCodecTypeAppleProRes422LT))
		{
			return AVVideoCodecType.AppleProRes422LT;
		}
		if (constant.IsEqualTo(AVVideoCodecTypeAppleProRes422Proxy))
		{
			return AVVideoCodecType.AppleProRes422Proxy;
		}
		if (constant.IsEqualTo(AVVideoCodecTypeHEVCWithAlpha))
		{
			return AVVideoCodecType.HevcWithAlpha;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
