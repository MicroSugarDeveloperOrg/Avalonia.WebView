using System;
using ObjCRuntime;

namespace Security;

public enum SecPadding
{
	None = 0,
	PKCS1 = 1,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	OAEP = 2,
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	Raw = 16384,
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Obsolete("Don't use hash algorithm.", false)]
	PKCS1MD2 = 32768,
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Obsolete("Don't use hash algorithm.", false)]
	PKCS1MD5 = 32769,
	PKCS1SHA1 = 32770,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	PKCS1SHA224 = 32771,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	PKCS1SHA256 = 32772,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	PKCS1SHA384 = 32773,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	PKCS1SHA512 = 32774
}
