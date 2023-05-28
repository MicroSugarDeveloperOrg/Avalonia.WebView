using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSTabViewControllerTabStyle : long
{
	SegmentedControlOnTop = 0L,
	SegmentedControlOnBottom = 1L,
	Toolbar = 2L,
	Unspecified = -1L
}
