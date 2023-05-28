using ObjCRuntime;

namespace AppKit;

[Mac(10, 12)]
[Native]
public enum NSPasteboardContentsOptions : ulong
{
	CurrentHostOnly = 1uL
}
