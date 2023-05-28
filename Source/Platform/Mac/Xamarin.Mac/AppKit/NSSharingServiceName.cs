using ObjCRuntime;

namespace AppKit;

public enum NSSharingServiceName
{
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	PostOnFacebook,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	PostOnTwitter,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	PostOnSinaWeibo,
	ComposeEmail,
	ComposeMessage,
	SendViaAirDrop,
	AddToSafariReadingList,
	AddToIPhoto,
	AddToAperture,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	UseAsTwitterProfileImage,
	UseAsDesktopPicture,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	PostImageOnFlickr,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	PostVideoOnVimeo,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	PostVideoOnYouku,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	PostVideoOnTudou,
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	CloudSharing,
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	PostOnTencentWeibo,
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	PostOnLinkedIn,
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	UseAsFacebookProfileImage,
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the proprietary SDK instead.")]
	UseAsLinkedInProfileImage
}
