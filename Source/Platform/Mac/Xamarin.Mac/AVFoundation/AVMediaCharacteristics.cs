using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public enum AVMediaCharacteristics
{
	Visual,
	Audible,
	Legible,
	FrameBased,
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	UsesWideGamutColorSpace,
	IsMainProgramContent,
	IsAuxiliaryContent,
	ContainsOnlyForcedSubtitles,
	TranscribesSpokenDialogForAccessibility,
	DescribesMusicAndSoundForAccessibility,
	DescribesVideoForAccessibility,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	EasyToRead,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	LanguageTranslation,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	DubbedTranslation,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	VoiceOverTranslation,
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	IsOriginalContent
}
