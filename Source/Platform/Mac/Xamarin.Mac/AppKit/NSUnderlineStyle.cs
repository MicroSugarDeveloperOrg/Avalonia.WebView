using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSUnderlineStyle : long
{
	None = 0L,
	Single = 1L,
	Thick = 2L,
	Double = 9L,
	PatternSolid = 0L,
	PatternDot = 256L,
	PatternDash = 512L,
	PatternDashDot = 768L,
	PatternDashDotDot = 1024L,
	ByWord = 32768L
}
