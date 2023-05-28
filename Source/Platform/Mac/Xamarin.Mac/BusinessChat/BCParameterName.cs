using ObjCRuntime;

namespace BusinessChat;

[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public enum BCParameterName
{
	Intent,
	Group,
	Body
}
