using ObjCRuntime;

namespace CoreSpotlight;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Native]
public enum CSSearchQueryErrorCode : long
{
	Unknown = -2000L,
	IndexUnreachable = -2001L,
	InvalidQuery = -2002L,
	Cancelled = -2003L
}
