using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Native]
public enum PHProjectTextElementType : long
{
	Body,
	Title,
	Subtitle
}
