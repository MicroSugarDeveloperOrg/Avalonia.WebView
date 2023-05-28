using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSWindowAnimationBehavior : long
{
	Default = 0L,
	None = 2L,
	DocumentWindow = 3L,
	UtilityWindow = 4L,
	AlertPanel = 5L
}
