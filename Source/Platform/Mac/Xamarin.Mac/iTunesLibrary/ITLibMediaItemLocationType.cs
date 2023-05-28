using ObjCRuntime;

namespace iTunesLibrary;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Native]
public enum ITLibMediaItemLocationType : ulong
{
	Unknown,
	File,
	Url,
	Remote
}
