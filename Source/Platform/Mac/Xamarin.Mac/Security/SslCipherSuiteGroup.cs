using ObjCRuntime;

namespace Security;

[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'TlsCipherSuiteGroup' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'TlsCipherSuiteGroup' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'TlsCipherSuiteGroup' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'TlsCipherSuiteGroup' instead.")]
public enum SslCipherSuiteGroup
{
	Default,
	Compatibility,
	Legacy,
	Ats,
	AtsCompatibility
}
