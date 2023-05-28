using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSWindowBackingLocation : ulong
{
	Default,
	VideoMemory,
	MainMemory
}
