using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public static class MPLanguageOptionCharacteristics
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContainsOnlyForcedSubtitles;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DescribesMusicAndSound;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DescribesVideo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DubbedTranslation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EasyToRead;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsAuxiliaryContent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsMainProgramContent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LanguageTranslation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TranscribesSpokenDialog;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VoiceOverTranslation;

	[Field("MPLanguageOptionCharacteristicContainsOnlyForcedSubtitles", "MediaPlayer")]
	public static NSString ContainsOnlyForcedSubtitles
	{
		get
		{
			if (_ContainsOnlyForcedSubtitles == null)
			{
				_ContainsOnlyForcedSubtitles = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicContainsOnlyForcedSubtitles");
			}
			return _ContainsOnlyForcedSubtitles;
		}
	}

	[Field("MPLanguageOptionCharacteristicDescribesMusicAndSound", "MediaPlayer")]
	public static NSString DescribesMusicAndSound
	{
		get
		{
			if (_DescribesMusicAndSound == null)
			{
				_DescribesMusicAndSound = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicDescribesMusicAndSound");
			}
			return _DescribesMusicAndSound;
		}
	}

	[Field("MPLanguageOptionCharacteristicDescribesVideo", "MediaPlayer")]
	public static NSString DescribesVideo
	{
		get
		{
			if (_DescribesVideo == null)
			{
				_DescribesVideo = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicDescribesVideo");
			}
			return _DescribesVideo;
		}
	}

	[Field("MPLanguageOptionCharacteristicDubbedTranslation", "MediaPlayer")]
	public static NSString DubbedTranslation
	{
		get
		{
			if (_DubbedTranslation == null)
			{
				_DubbedTranslation = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicDubbedTranslation");
			}
			return _DubbedTranslation;
		}
	}

	[Field("MPLanguageOptionCharacteristicEasyToRead", "MediaPlayer")]
	public static NSString EasyToRead
	{
		get
		{
			if (_EasyToRead == null)
			{
				_EasyToRead = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicEasyToRead");
			}
			return _EasyToRead;
		}
	}

	[Field("MPLanguageOptionCharacteristicIsAuxiliaryContent", "MediaPlayer")]
	public static NSString IsAuxiliaryContent
	{
		get
		{
			if (_IsAuxiliaryContent == null)
			{
				_IsAuxiliaryContent = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicIsAuxiliaryContent");
			}
			return _IsAuxiliaryContent;
		}
	}

	[Field("MPLanguageOptionCharacteristicIsMainProgramContent", "MediaPlayer")]
	public static NSString IsMainProgramContent
	{
		get
		{
			if (_IsMainProgramContent == null)
			{
				_IsMainProgramContent = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicIsMainProgramContent");
			}
			return _IsMainProgramContent;
		}
	}

	[Field("MPLanguageOptionCharacteristicLanguageTranslation", "MediaPlayer")]
	public static NSString LanguageTranslation
	{
		get
		{
			if (_LanguageTranslation == null)
			{
				_LanguageTranslation = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicLanguageTranslation");
			}
			return _LanguageTranslation;
		}
	}

	[Field("MPLanguageOptionCharacteristicTranscribesSpokenDialog", "MediaPlayer")]
	public static NSString TranscribesSpokenDialog
	{
		get
		{
			if (_TranscribesSpokenDialog == null)
			{
				_TranscribesSpokenDialog = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicTranscribesSpokenDialog");
			}
			return _TranscribesSpokenDialog;
		}
	}

	[Field("MPLanguageOptionCharacteristicVoiceOverTranslation", "MediaPlayer")]
	public static NSString VoiceOverTranslation
	{
		get
		{
			if (_VoiceOverTranslation == null)
			{
				_VoiceOverTranslation = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPLanguageOptionCharacteristicVoiceOverTranslation");
			}
			return _VoiceOverTranslation;
		}
	}
}
