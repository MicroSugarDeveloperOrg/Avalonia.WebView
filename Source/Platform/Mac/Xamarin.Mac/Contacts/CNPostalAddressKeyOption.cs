using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public enum CNPostalAddressKeyOption
{
	Street,
	City,
	State,
	PostalCode,
	Country,
	IsoCountryCode,
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 3, PlatformArchitecture.All, null)]
	SubLocality,
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 3, PlatformArchitecture.All, null)]
	SubAdministrativeArea
}
