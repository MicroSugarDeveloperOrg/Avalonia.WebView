using ObjCRuntime;

namespace AppKit;

[Mac(10, 14)]
[Native]
public enum NSColorSystemEffect : long
{
	None,
	Pressed,
	DeepPressed,
	Disabled,
	Rollover
}
