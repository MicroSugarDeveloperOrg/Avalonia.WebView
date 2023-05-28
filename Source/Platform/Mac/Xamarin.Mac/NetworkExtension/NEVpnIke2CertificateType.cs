using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Native]
public enum NEVpnIke2CertificateType : long
{
	RSA = 1L,
	ECDSA256,
	ECDSA384,
	ECDSA521,
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	Ed25519
}
