using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSLayoutAttribute : long
{
	NoAttribute = 0L,
	Left = 1L,
	Right = 2L,
	Top = 3L,
	Bottom = 4L,
	Leading = 5L,
	Trailing = 6L,
	Width = 7L,
	Height = 8L,
	CenterX = 9L,
	CenterY = 10L,
	Baseline = 11L,
	[Mac(10, 11)]
	LastBaseline = 11L,
	[Mac(10, 11)]
	FirstBaseline = 12L
}
