using ObjCRuntime;

namespace AppKit;

[Mac(10, 9)]
[Native]
public enum NSAccessibilityPriorityLevel : long
{
	Low = 10L,
	Medium = 50L,
	High = 90L
}
