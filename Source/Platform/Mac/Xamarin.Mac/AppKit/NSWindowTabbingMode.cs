using ObjCRuntime;

namespace AppKit;

[Mac(10, 12)]
[Native]
public enum NSWindowTabbingMode : long
{
	Automatic,
	Preferred,
	Disallowed
}
