using ObjCRuntime;

namespace LocalAuthentication;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Native]
public enum LAStatus : long
{
	Success = 0L,
	AuthenticationFailed = -1L,
	UserCancel = -2L,
	UserFallback = -3L,
	SystemCancel = -4L,
	PasscodeNotSet = -5L,
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'BiometryNotAvailable' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'BiometryNotAvailable' instead.")]
	TouchIDNotAvailable = -6L,
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'BiometryNotEnrolled' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'BiometryNotEnrolled' instead.")]
	TouchIDNotEnrolled = -7L,
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'BiometryLockout' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'BiometryLockout' instead.")]
	TouchIDLockout = -8L,
	AppCancel = -9L,
	InvalidContext = -10L,
	WatchNotAvailable = -11L,
	BiometryNotAvailable = -6L,
	BiometryNotEnrolled = -7L,
	BiometryLockout = -8L,
	NotInteractive = -1004L
}
