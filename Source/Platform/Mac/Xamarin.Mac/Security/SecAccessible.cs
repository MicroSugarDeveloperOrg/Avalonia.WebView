using ObjCRuntime;

namespace Security;

public enum SecAccessible
{
	Invalid = -1,
	WhenUnlocked,
	AfterFirstUnlock,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'AfterFirstUnlock' or a better suited option instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'AfterFirstUnlock' or a better suited option instead.")]
	Always,
	WhenUnlockedThisDeviceOnly,
	AfterFirstUnlockThisDeviceOnly,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'AfterFirstUnlockThisDeviceOnly' or a better suited option instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'AfterFirstUnlockThisDeviceOnly' or a better suited option instead.")]
	AlwaysThisDeviceOnly,
	WhenPasscodeSetThisDeviceOnly
}
