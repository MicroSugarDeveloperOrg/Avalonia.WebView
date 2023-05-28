using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVOutputSettingsPresetExtensions
{
	private static IntPtr[] values = new IntPtr[9];

	[Field("AVOutputSettingsPreset640x480", "AVFoundation")]
	internal unsafe static IntPtr AVOutputSettingsPreset640x480
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVOutputSettingsPreset640x480", storage);
			}
		}
	}

	[Field("AVOutputSettingsPreset960x540", "AVFoundation")]
	internal unsafe static IntPtr AVOutputSettingsPreset960x540
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVOutputSettingsPreset960x540", storage);
			}
		}
	}

	[Field("AVOutputSettingsPreset1280x720", "AVFoundation")]
	internal unsafe static IntPtr AVOutputSettingsPreset1280x720
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVOutputSettingsPreset1280x720", storage);
			}
		}
	}

	[Field("AVOutputSettingsPreset1920x1080", "AVFoundation")]
	internal unsafe static IntPtr AVOutputSettingsPreset1920x1080
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVOutputSettingsPreset1920x1080", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Field("AVOutputSettingsPreset3840x2160", "AVFoundation")]
	internal unsafe static IntPtr AVOutputSettingsPreset3840x2160
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVOutputSettingsPreset3840x2160", storage);
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
			fixed (IntPtr* storage = &values[5])
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
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC3840x2160", storage);
			}
		}
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Field("AVOutputSettingsPresetHEVC1920x1080WithAlpha", "AVFoundation")]
	internal unsafe static IntPtr AVOutputSettingsPresetHEVC1920x1080WithAlpha
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC1920x1080WithAlpha", storage);
			}
		}
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Field("AVOutputSettingsPresetHEVC3840x2160WithAlpha", "AVFoundation")]
	internal unsafe static IntPtr AVOutputSettingsPresetHEVC3840x2160WithAlpha
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC3840x2160WithAlpha", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVOutputSettingsPreset self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVOutputSettingsPreset640x480;
			break;
		case 1:
			ptr = AVOutputSettingsPreset960x540;
			break;
		case 2:
			ptr = AVOutputSettingsPreset1280x720;
			break;
		case 3:
			ptr = AVOutputSettingsPreset1920x1080;
			break;
		case 4:
			ptr = AVOutputSettingsPreset3840x2160;
			break;
		case 11:
			ptr = AVOutputSettingsPresetHEVC1920x1080;
			break;
		case 12:
			ptr = AVOutputSettingsPresetHEVC3840x2160;
			break;
		case 13:
			ptr = AVOutputSettingsPresetHEVC1920x1080WithAlpha;
			break;
		case 14:
			ptr = AVOutputSettingsPresetHEVC3840x2160WithAlpha;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVOutputSettingsPreset GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVOutputSettingsPreset640x480))
		{
			return AVOutputSettingsPreset.Preset640x480;
		}
		if (constant.IsEqualTo(AVOutputSettingsPreset960x540))
		{
			return AVOutputSettingsPreset.Preset960x540;
		}
		if (constant.IsEqualTo(AVOutputSettingsPreset1280x720))
		{
			return AVOutputSettingsPreset.Preset1280x720;
		}
		if (constant.IsEqualTo(AVOutputSettingsPreset1920x1080))
		{
			return AVOutputSettingsPreset.Preset1920x1080;
		}
		if (constant.IsEqualTo(AVOutputSettingsPreset3840x2160))
		{
			return AVOutputSettingsPreset.Preset3840x2160;
		}
		if (constant.IsEqualTo(AVOutputSettingsPresetHEVC1920x1080))
		{
			return AVOutputSettingsPreset.PresetHevc1920x1080;
		}
		if (constant.IsEqualTo(AVOutputSettingsPresetHEVC3840x2160))
		{
			return AVOutputSettingsPreset.PresetHevc3840x2160;
		}
		if (constant.IsEqualTo(AVOutputSettingsPresetHEVC1920x1080WithAlpha))
		{
			return AVOutputSettingsPreset.PresetHevc1920x1080WithAlpha;
		}
		if (constant.IsEqualTo(AVOutputSettingsPresetHEVC3840x2160WithAlpha))
		{
			return AVOutputSettingsPreset.PresetHevc3840x2160WithAlpha;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
