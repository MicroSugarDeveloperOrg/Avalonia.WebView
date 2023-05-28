using ObjCRuntime;

namespace AppKit;

[Mac(10, 12)]
[Native]
public enum NSWindowUserTabbingPreference : long
{
	Manual,
	Always,
	InFullScreen
}
