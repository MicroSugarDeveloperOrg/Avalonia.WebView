using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Obsoleted(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "All fields will return 'null'.")]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class AVAudioUnitType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Effect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FormatConverter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Generator;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MidiProcessor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Mixer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MusicDevice;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MusicEffect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OfflineEffect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Output;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Panner;

	[Field("AVAudioUnitTypeEffect", "AVFoundation")]
	public static NSString Effect
	{
		get
		{
			if (_Effect == null)
			{
				_Effect = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitTypeEffect");
			}
			return _Effect;
		}
	}

	[Field("AVAudioUnitTypeFormatConverter", "AVFoundation")]
	public static NSString FormatConverter
	{
		get
		{
			if (_FormatConverter == null)
			{
				_FormatConverter = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitTypeFormatConverter");
			}
			return _FormatConverter;
		}
	}

	[Field("AVAudioUnitTypeGenerator", "AVFoundation")]
	public static NSString Generator
	{
		get
		{
			if (_Generator == null)
			{
				_Generator = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitTypeGenerator");
			}
			return _Generator;
		}
	}

	[Field("AVAudioUnitTypeMIDIProcessor", "AVFoundation")]
	public static NSString MidiProcessor
	{
		get
		{
			if (_MidiProcessor == null)
			{
				_MidiProcessor = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitTypeMIDIProcessor");
			}
			return _MidiProcessor;
		}
	}

	[Field("AVAudioUnitTypeMixer", "AVFoundation")]
	public static NSString Mixer
	{
		get
		{
			if (_Mixer == null)
			{
				_Mixer = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitTypeMixer");
			}
			return _Mixer;
		}
	}

	[Field("AVAudioUnitTypeMusicDevice", "AVFoundation")]
	public static NSString MusicDevice
	{
		get
		{
			if (_MusicDevice == null)
			{
				_MusicDevice = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitTypeMusicDevice");
			}
			return _MusicDevice;
		}
	}

	[Field("AVAudioUnitTypeMusicEffect", "AVFoundation")]
	public static NSString MusicEffect
	{
		get
		{
			if (_MusicEffect == null)
			{
				_MusicEffect = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitTypeMusicEffect");
			}
			return _MusicEffect;
		}
	}

	[Field("AVAudioUnitTypeOfflineEffect", "AVFoundation")]
	public static NSString OfflineEffect
	{
		get
		{
			if (_OfflineEffect == null)
			{
				_OfflineEffect = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitTypeOfflineEffect");
			}
			return _OfflineEffect;
		}
	}

	[Field("AVAudioUnitTypeOutput", "AVFoundation")]
	public static NSString Output
	{
		get
		{
			if (_Output == null)
			{
				_Output = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitTypeOutput");
			}
			return _Output;
		}
	}

	[Field("AVAudioUnitTypePanner", "AVFoundation")]
	public static NSString Panner
	{
		get
		{
			if (_Panner == null)
			{
				_Panner = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitTypePanner");
			}
			return _Panner;
		}
	}
}
