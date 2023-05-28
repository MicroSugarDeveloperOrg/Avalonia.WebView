using ObjCRuntime;

namespace Security;

public enum SecTrustResult
{
	Invalid,
	Proceed,
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	Confirm,
	Deny,
	Unspecified,
	RecoverableTrustFailure,
	FatalTrustFailure,
	ResultOtherError
}
