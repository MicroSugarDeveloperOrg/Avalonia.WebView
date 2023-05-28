using ObjCRuntime;

namespace Security;

[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
public enum SslSessionStrengthPolicy
{
	Default,
	ATSv1,
	ATSv1NoPFS
}
