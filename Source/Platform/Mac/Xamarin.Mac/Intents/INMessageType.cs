using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum INMessageType : long
{
	Unspecified,
	Text,
	Audio,
	DigitalTouch,
	Handwriting,
	Sticker,
	TapbackLiked,
	TapbackDisliked,
	TapbackEmphasized,
	TapbackLoved,
	TapbackQuestioned,
	TapbackLaughed,
	MediaCalendar,
	MediaLocation,
	MediaAddressCard,
	MediaImage,
	MediaVideo,
	MediaPass,
	MediaAudio,
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	PaymentSent,
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	PaymentRequest,
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	PaymentNote,
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	Animoji,
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	ActivitySnippet,
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	File,
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	Link
}
