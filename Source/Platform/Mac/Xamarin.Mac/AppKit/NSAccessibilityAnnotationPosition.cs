using ObjCRuntime;

namespace AppKit;

[Mac(10, 13)]
[Native]
public enum NSAccessibilityAnnotationPosition : long
{
	FullRange,
	Start,
	End
}
