using ObjCRuntime;

namespace Intents;

[Native]
public enum INPersonSuggestionType : long
{
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	None,
	SocialProfile,
	InstantMessageAddress
}
