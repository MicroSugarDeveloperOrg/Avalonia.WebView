using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVMediaCharacteristic
{
	private static NSString _Visual;

	private static NSString _Audible;

	private static NSString _Legible;

	private static NSString _FrameBased;

	private static NSString _IsMainProgramContent;

	private static NSString _IsAuxiliaryContent;

	private static NSString _ContainsOnlyForcedSubtitles;

	private static NSString _TranscribesSpokenDialogForAccessibility;

	private static NSString _DescribesMusicAndSoundForAccessibility;

	private static NSString _DescribesVideoForAccessibility;

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

	[Field("AVMediaCharacteristicIsMainProgramContent", "AVFoundation")]
	[MountainLion]
	public static NSString IsMainProgramContent
	{
		[MountainLion]
		get
		{
			if (_IsMainProgramContent == null)
			{
				_IsMainProgramContent = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicIsMainProgramContent");
			}
			return _IsMainProgramContent;
		}
	}

	[Field("AVMediaCharacteristicIsAuxiliaryContent", "AVFoundation")]
	[MountainLion]
	public static NSString IsAuxiliaryContent
	{
		[MountainLion]
		get
		{
			if (_IsAuxiliaryContent == null)
			{
				_IsAuxiliaryContent = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicIsAuxiliaryContent");
			}
			return _IsAuxiliaryContent;
		}
	}

	[Field("AVMediaCharacteristicContainsOnlyForcedSubtitles", "AVFoundation")]
	[MountainLion]
	public static NSString ContainsOnlyForcedSubtitles
	{
		[MountainLion]
		get
		{
			if (_ContainsOnlyForcedSubtitles == null)
			{
				_ContainsOnlyForcedSubtitles = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicContainsOnlyForcedSubtitles");
			}
			return _ContainsOnlyForcedSubtitles;
		}
	}

	[Field("AVMediaCharacteristicTranscribesSpokenDialogForAccessibility", "AVFoundation")]
	[MountainLion]
	public static NSString TranscribesSpokenDialogForAccessibility
	{
		[MountainLion]
		get
		{
			if (_TranscribesSpokenDialogForAccessibility == null)
			{
				_TranscribesSpokenDialogForAccessibility = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicTranscribesSpokenDialogForAccessibility");
			}
			return _TranscribesSpokenDialogForAccessibility;
		}
	}

	[Field("AVMediaCharacteristicDescribesMusicAndSoundForAccessibility", "AVFoundation")]
	[MountainLion]
	public static NSString DescribesMusicAndSoundForAccessibility
	{
		[MountainLion]
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
	[MountainLion]
	public static NSString DescribesVideoForAccessibility
	{
		[MountainLion]
		get
		{
			if (_DescribesVideoForAccessibility == null)
			{
				_DescribesVideoForAccessibility = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaCharacteristicDescribesVideoForAccessibility");
			}
			return _DescribesVideoForAccessibility;
		}
	}
}
