using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSTextFinderMatchingType : long
{
	Contains,
	StartsWith,
	FullWord,
	EndsWith
}
