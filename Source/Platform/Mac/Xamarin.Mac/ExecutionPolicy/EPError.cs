using ObjCRuntime;

namespace ExecutionPolicy;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum EPError : long
{
	Generic = 1L,
	NotADeveloperTool
}
