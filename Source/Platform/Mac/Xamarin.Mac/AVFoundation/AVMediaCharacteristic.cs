using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class AVMediaCharacteristic
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Audible;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContainsAlphaChannel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContainsOnlyForcedSubtitles;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DescribesMusicAndSoundForAccessibility;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DescribesVideoForAccessibility;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DubbedTranslation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameBased;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsAuxiliaryContent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsMainProgramContent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsOriginalContent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LanguageTranslation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Legible;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TranscribesSpokenDialogForAccessibility;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UsesWideGamutColorSpace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Visual;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VoiceOverTranslation;

	[Field("AVMediaCharacteristicAudible", "AVFoundation")]
	public static NSString Audible
	{
		get
		{
			if (_Audible == null)
			{
				_Audible = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicAudible");
			}
			return _Audible;
		}
	}

	[Field("AVMediaCharacteristicContainsAlphaChannel", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString ContainsAlphaChannel
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ContainsAlphaChannel == null)
			{
				_ContainsAlphaChannel = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicContainsAlphaChannel");
			}
			return _ContainsAlphaChannel;
		}
	}

	[Field("AVMediaCharacteristicContainsOnlyForcedSubtitles", "AVFoundation")]
	public static NSString ContainsOnlyForcedSubtitles
	{
		get
		{
			if (_ContainsOnlyForcedSubtitles == null)
			{
				_ContainsOnlyForcedSubtitles = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicContainsOnlyForcedSubtitles");
			}
			return _ContainsOnlyForcedSubtitles;
		}
	}

	[Field("AVMediaCharacteristicDescribesMusicAndSoundForAccessibility", "AVFoundation")]
	public static NSString DescribesMusicAndSoundForAccessibility
	{
		get
		{
			if (_DescribesMusicAndSoundForAccessibility == null)
			{
				_DescribesMusicAndSoundForAccessibility = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicDescribesMusicAndSoundForAccessibility");
			}
			return _DescribesMusicAndSoundForAccessibility;
		}
	}

	[Field("AVMediaCharacteristicDescribesVideoForAccessibility", "AVFoundation")]
	public static NSString DescribesVideoForAccessibility
	{
		get
		{
			if (_DescribesVideoForAccessibility == null)
			{
				_DescribesVideoForAccessibility = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicDescribesVideoForAccessibility");
			}
			return _DescribesVideoForAccessibility;
		}
	}

	[Field("AVMediaCharacteristicDubbedTranslation", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString DubbedTranslation
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_DubbedTranslation == null)
			{
				_DubbedTranslation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicDubbedTranslation");
			}
			return _DubbedTranslation;
		}
	}

	[Field("AVMediaCharacteristicFrameBased", "AVFoundation")]
	public static NSString FrameBased
	{
		get
		{
			if (_FrameBased == null)
			{
				_FrameBased = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicFrameBased");
			}
			return _FrameBased;
		}
	}

	[Field("AVMediaCharacteristicIsAuxiliaryContent", "AVFoundation")]
	public static NSString IsAuxiliaryContent
	{
		get
		{
			if (_IsAuxiliaryContent == null)
			{
				_IsAuxiliaryContent = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicIsAuxiliaryContent");
			}
			return _IsAuxiliaryContent;
		}
	}

	[Field("AVMediaCharacteristicIsMainProgramContent", "AVFoundation")]
	public static NSString IsMainProgramContent
	{
		get
		{
			if (_IsMainProgramContent == null)
			{
				_IsMainProgramContent = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicIsMainProgramContent");
			}
			return _IsMainProgramContent;
		}
	}

	[Field("AVMediaCharacteristicIsOriginalContent", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString IsOriginalContent
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_IsOriginalContent == null)
			{
				_IsOriginalContent = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicIsOriginalContent");
			}
			return _IsOriginalContent;
		}
	}

	[Field("AVMediaCharacteristicLanguageTranslation", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString LanguageTranslation
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_LanguageTranslation == null)
			{
				_LanguageTranslation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicLanguageTranslation");
			}
			return _LanguageTranslation;
		}
	}

	[Field("AVMediaCharacteristicLegible", "AVFoundation")]
	public static NSString Legible
	{
		get
		{
			if (_Legible == null)
			{
				_Legible = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicLegible");
			}
			return _Legible;
		}
	}

	[Field("AVMediaCharacteristicTranscribesSpokenDialogForAccessibility", "AVFoundation")]
	public static NSString TranscribesSpokenDialogForAccessibility
	{
		get
		{
			if (_TranscribesSpokenDialogForAccessibility == null)
			{
				_TranscribesSpokenDialogForAccessibility = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicTranscribesSpokenDialogForAccessibility");
			}
			return _TranscribesSpokenDialogForAccessibility;
		}
	}

	[Field("AVMediaCharacteristicUsesWideGamutColorSpace", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString UsesWideGamutColorSpace
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_UsesWideGamutColorSpace == null)
			{
				_UsesWideGamutColorSpace = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicUsesWideGamutColorSpace");
			}
			return _UsesWideGamutColorSpace;
		}
	}

	[Field("AVMediaCharacteristicVisual", "AVFoundation")]
	public static NSString Visual
	{
		get
		{
			if (_Visual == null)
			{
				_Visual = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicVisual");
			}
			return _Visual;
		}
	}

	[Field("AVMediaCharacteristicVoiceOverTranslation", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString VoiceOverTranslation
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_VoiceOverTranslation == null)
			{
				_VoiceOverTranslation = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicVoiceOverTranslation");
			}
			return _VoiceOverTranslation;
		}
	}
}
