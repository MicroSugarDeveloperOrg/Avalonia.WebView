using ObjCRuntime;

namespace AppKit;

[Mac(10, 12)]
[Native]
public enum NSTabViewBorderType : ulong
{
	None,
	Line,
	Bezel
}
