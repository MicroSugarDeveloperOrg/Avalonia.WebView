using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public static class AVAudioTimePitchAlgorithm
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Spectral;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Varispeed;

	[Field("AVAudioTimePitchAlgorithmSpectral", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString Spectral
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_Spectral == null)
			{
				_Spectral = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioTimePitchAlgorithmSpectral");
			}
			return _Spectral;
		}
	}

	[Field("AVAudioTimePitchAlgorithmTimeDomain", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString TimeDomain
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_TimeDomain == null)
			{
				_TimeDomain = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioTimePitchAlgorithmTimeDomain");
			}
			return _TimeDomain;
		}
	}

	[Field("AVAudioTimePitchAlgorithmVarispeed", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString Varispeed
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_Varispeed == null)
			{
				_Varispeed = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioTimePitchAlgorithmVarispeed");
			}
			return _Varispeed;
		}
	}
}
