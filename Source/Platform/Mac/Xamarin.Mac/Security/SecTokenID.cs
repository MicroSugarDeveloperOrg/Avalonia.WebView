using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public enum SecTokenID
{
	None,
	SecureEnclave
}
