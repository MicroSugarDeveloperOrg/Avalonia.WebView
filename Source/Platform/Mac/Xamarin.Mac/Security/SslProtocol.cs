using ObjCRuntime;

namespace Security;

[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'TlsProtocolVersion' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'TlsProtocolVersion' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'TlsProtocolVersion' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'TlsProtocolVersion' instead.")]
public enum SslProtocol
{
	Unknown = 0,
	Ssl_3_0 = 2,
	Tls_1_0 = 4,
	Tls_1_1 = 7,
	Tls_1_2 = 8,
	Dtls_1_0 = 9,
	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13)]
	Tls_1_3 = 10,
	Ssl_2_0 = 1,
	Ssl_3_0_only = 3,
	Tls_1_0_only = 5,
	All = 6
}
