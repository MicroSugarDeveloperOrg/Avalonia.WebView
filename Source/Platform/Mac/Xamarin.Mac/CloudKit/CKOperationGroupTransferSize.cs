using ObjCRuntime;

namespace CloudKit;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum CKOperationGroupTransferSize : long
{
	Unknown,
	Kilobytes,
	Megabytes,
	TensOfMegabytes,
	HundredsOfMegabytes,
	Gigabytes,
	TensOfGigabytes,
	HundredsOfGigabytes
}
