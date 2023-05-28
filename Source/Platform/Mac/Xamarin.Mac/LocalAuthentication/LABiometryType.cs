using System;
using ObjCRuntime;

namespace LocalAuthentication;

[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum LABiometryType : long
{
	None = 0L,
	TouchId = 1L,
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	FaceId = 2L,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Obsolete("Use 'FaceId' instead.", false)]
	TypeFaceId = 2L
}
