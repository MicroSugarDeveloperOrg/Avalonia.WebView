using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Native]
public enum PHProjectSectionType : long
{
	Undefined,
	Cover,
	Content,
	Auxiliary
}
