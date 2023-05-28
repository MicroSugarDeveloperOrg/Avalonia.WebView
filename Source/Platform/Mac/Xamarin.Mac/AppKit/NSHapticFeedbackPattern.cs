using ObjCRuntime;

namespace AppKit;

[Mac(10, 11)]
[Native]
public enum NSHapticFeedbackPattern : long
{
	Generic,
	Alignment,
	LevelChange
}
