using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSBezierPathElement : ulong
{
	MoveTo,
	LineTo,
	CurveTo,
	ClosePath
}
