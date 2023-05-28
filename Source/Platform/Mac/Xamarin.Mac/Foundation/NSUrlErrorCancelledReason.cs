using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSUrlErrorCancelledReason : long
{
	UserForceQuitApplication,
	BackgroundUpdatesDisabled,
	InsufficientSystemResources
}
