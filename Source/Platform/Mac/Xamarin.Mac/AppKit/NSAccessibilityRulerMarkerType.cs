using ObjCRuntime;

namespace AppKit;

[Mac(10, 10)]
[Native]
public enum NSAccessibilityRulerMarkerType : long
{
	Unknown,
	TabStopLeft,
	TabStopRight,
	TabStopCenter,
	TabStopDecimal,
	IndentHead,
	IndentTail,
	IndentFirstLine
}
