using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Native]
public enum NEProviderStopReason : long
{
	None,
	UserInitiated,
	ProviderFailed,
	NoNetworkAvailable,
	UnrecoverableNetworkChange,
	ProviderDisabled,
	AuthenticationCanceled,
	ConfigurationFailed,
	IdleTimeout,
	ConfigurationDisabled,
	ConfigurationRemoved,
	Superseded,
	UserLogout,
	UserSwitch,
	ConnectionFailed
}
