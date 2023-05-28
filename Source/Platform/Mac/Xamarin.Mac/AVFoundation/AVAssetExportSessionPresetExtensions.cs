using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVAssetExportSessionPresetExtensions
{
	private static IntPtr[] values = new IntPtr[12];

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("AVAssetExportPresetLowQuality", "AVFoundation")]
	internal unsafe static IntPtr AVAssetExportPresetLowQuality
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetExportPresetLowQuality", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("AVAssetExportPresetMediumQuality", "AVFoundation")]
	internal unsafe static IntPtr AVAssetExportPresetMediumQuality
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetExportPresetMediumQuality", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("AVAssetExportPresetHighestQuality", "AVFoundation")]
	internal unsafe static IntPtr AVAssetExportPresetHighestQuality
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetExportPresetHighestQuality", storage);
			}
		}
	}

	[Field("AVAssetExportPreset640x480", "AVFoundation")]
	internal unsafe static IntPtr AVAssetExportPreset640x480
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetExportPreset640x480", storage);
			}
		}
	}

	[Field("AVAssetExportPreset960x540", "AVFoundation")]
	internal unsafe static IntPtr AVAssetExportPreset960x540
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetExportPreset960x540", storage);
			}
		}
	}

	[Field("AVAssetExportPreset1280x720", "AVFoundation")]
	internal unsafe static IntPtr AVAssetExportPreset1280x720
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetExportPreset1280x720", storage);
			}
		}
	}

	[Field("AVAssetExportPreset1920x1080", "AVFoundation")]
	internal unsafe static IntPtr AVAssetExportPreset1920x1080
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetExportPreset1920x1080", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Field("AVAssetExportPreset3840x2160", "AVFoundation")]
	internal unsafe static IntPtr AVAssetExportPreset3840x2160
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetExportPreset3840x2160", storage);
			}
		}
	}

	[Field("AVAssetExportPresetAppleM4A", "AVFoundation")]
	internal unsafe static IntPtr AVAssetExportPresetAppleM4A
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleM4A", storage);
			}
		}
	}

	[Field("AVAssetExportPresetPassthrough", "AVFoundation")]
	internal unsafe static IntPtr AVAssetExportPresetPassthrough
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVAssetExportPresetPassthrough", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("AVOutputSettingsPresetHEVC1920x1080", "AVFoundation")]
	internal unsafe static IntPtr AVOutputSettingsPresetHEVC1920x1080
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC1920x1080", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("AVOutputSettingsPresetHEVC3840x2160", "AVFoundation")]
	internal unsafe static IntPtr AVOutputSettingsPresetHEVC3840x2160
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC3840x2160", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVAssetExportSessionPreset self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVAssetExportPresetLowQuality;
			break;
		case 1:
			ptr = AVAssetExportPresetMediumQuality;
			break;
		case 2:
			ptr = AVAssetExportPresetHighestQuality;
			break;
		case 3:
			ptr = AVAssetExportPreset640x480;
			break;
		case 4:
			ptr = AVAssetExportPreset960x540;
			break;
		case 5:
			ptr = AVAssetExportPreset1280x720;
			break;
		case 6:
			ptr = AVAssetExportPreset1920x1080;
			break;
		case 7:
			ptr = AVAssetExportPreset3840x2160;
			break;
		case 8:
			ptr = AVAssetExportPresetAppleM4A;
			break;
		case 9:
			ptr = AVAssetExportPresetPassthrough;
			break;
		case 11:
			ptr = AVOutputSettingsPresetHEVC1920x1080;
			break;
		case 12:
			ptr = AVOutputSettingsPresetHEVC3840x2160;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVAssetExportSessionPreset GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVAssetExportPresetLowQuality))
		{
			return AVAssetExportSessionPreset.LowQuality;
		}
		if (constant.IsEqualTo(AVAssetExportPresetMediumQuality))
		{
			return AVAssetExportSessionPreset.MediumQuality;
		}
		if (constant.IsEqualTo(AVAssetExportPresetHighestQuality))
		{
			return AVAssetExportSessionPreset.HighestQuality;
		}
		if (constant.IsEqualTo(AVAssetExportPreset640x480))
		{
			return AVAssetExportSessionPreset.Preset640x480;
		}
		if (constant.IsEqualTo(AVAssetExportPreset960x540))
		{
			return AVAssetExportSessionPreset.Preset960x540;
		}
		if (constant.IsEqualTo(AVAssetExportPreset1280x720))
		{
			return AVAssetExportSessionPreset.Preset1280x720;
		}
		if (constant.IsEqualTo(AVAssetExportPreset1920x1080))
		{
			return AVAssetExportSessionPreset.Preset1920x1080;
		}
		if (constant.IsEqualTo(AVAssetExportPreset3840x2160))
		{
			return AVAssetExportSessionPreset.Preset3840x2160;
		}
		if (constant.IsEqualTo(AVAssetExportPresetAppleM4A))
		{
			return AVAssetExportSessionPreset.AppleM4A;
		}
		if (constant.IsEqualTo(AVAssetExportPresetPassthrough))
		{
			return AVAssetExportSessionPreset.Passthrough;
		}
		if (constant.IsEqualTo(AVOutputSettingsPresetHEVC1920x1080))
		{
			return AVAssetExportSessionPreset.PresetHevc1920x1080;
		}
		if (constant.IsEqualTo(AVOutputSettingsPresetHEVC3840x2160))
		{
			return AVAssetExportSessionPreset.PresetHevc3840x2160;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
