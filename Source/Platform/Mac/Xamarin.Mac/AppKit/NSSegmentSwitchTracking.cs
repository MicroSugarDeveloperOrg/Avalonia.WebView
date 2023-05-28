using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSSegmentSwitchTracking : ulong
{
	SelectOne,
	SelectAny,
	Momentary,
	MomentaryAccelerator
}
