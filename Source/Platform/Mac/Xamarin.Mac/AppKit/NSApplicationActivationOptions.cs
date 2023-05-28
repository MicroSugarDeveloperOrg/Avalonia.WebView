using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSApplicationActivationOptions : ulong
{
	Default,
	ActivateAllWindows,
	ActivateIgnoringOtherWindows
}
