using ObjCRuntime;

namespace CoreMotion;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public enum CMError
{
	Null = 100,
	DeviceRequiresMovement,
	TrueNorthNotAvailable,
	Unknown,
	MotionActivityNotAvailable,
	MotionActivityNotAuthorized,
	MotionActivityNotEntitled,
	InvalidParameter,
	InvalidAction,
	NotAvailable,
	NotEntitled,
	NotAuthorized
}
