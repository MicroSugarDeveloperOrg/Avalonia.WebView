using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public enum NSItemDownloadingStatus
{
	Unknown = -1,
	Current,
	Downloaded,
	NotDownloaded
}
