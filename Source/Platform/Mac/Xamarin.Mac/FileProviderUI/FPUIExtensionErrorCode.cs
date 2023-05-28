using ObjCRuntime;

namespace FileProviderUI;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum FPUIExtensionErrorCode : ulong
{
	UserCancelled,
	Failed
}
