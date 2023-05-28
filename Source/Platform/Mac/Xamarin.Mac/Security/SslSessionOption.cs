using ObjCRuntime;

namespace Security;

[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
public enum SslSessionOption
{
	BreakOnServerAuth,
	BreakOnCertRequested,
	BreakOnClientAuth,
	[iOS(7, 0)]
	[Mac(10, 9)]
	FalseStart,
	SendOneByteRecord,
	[iOS(9, 0)]
	[Mac(10, 11)]
	AllowServerIdentityChange,
	[iOS(8, 1)]
	[Mac(10, 10)]
	Fallback,
	[iOS(9, 0)]
	[Mac(10, 11)]
	BreakOnClientHello,
	[iOS(10, 0)]
	[Mac(10, 12)]
	AllowRenegotiation,
	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13)]
	EnableSessionTickets
}
