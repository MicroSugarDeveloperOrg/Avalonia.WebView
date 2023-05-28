using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSLineBreakMode : ulong
{
	ByWordWrapping,
	CharWrapping,
	Clipping,
	TruncatingHead,
	TruncatingTail,
	TruncatingMiddle
}
