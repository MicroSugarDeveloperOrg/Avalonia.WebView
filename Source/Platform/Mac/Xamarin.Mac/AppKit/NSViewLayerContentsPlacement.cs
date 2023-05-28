using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSViewLayerContentsPlacement : long
{
	ScaleAxesIndependently,
	ScaleProportionallyToFit,
	ScaleProportionallyToFill,
	Center,
	Top,
	TopRight,
	Right,
	BottomRight,
	Bottom,
	BottomLeft,
	Left,
	TopLeft
}
