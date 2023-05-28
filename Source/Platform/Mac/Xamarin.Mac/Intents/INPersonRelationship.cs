using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public enum INPersonRelationship
{
	None,
	Father,
	Mother,
	Parent,
	Brother,
	Sister,
	Child,
	Friend,
	Spouse,
	Partner,
	Assistant,
	Manager,
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	Son,
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	Daughter
}
