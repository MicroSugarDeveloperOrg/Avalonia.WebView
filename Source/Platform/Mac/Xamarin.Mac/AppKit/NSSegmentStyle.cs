using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSSegmentStyle : long
{
	Automatic = 0L,
	Rounded = 1L,
	TexturedRounded = 2L,
	RoundRect = 3L,
	TexturedSquare = 4L,
	Capsule = 5L,
	SmallSquare = 6L,
	[Mac(10, 10)]
	Separated = 8L
}
