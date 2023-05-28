using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Native]
public enum SecKeyOperationType : long
{
	Sign,
	Verify,
	Encrypt,
	Decrypt,
	KeyExchange
}
