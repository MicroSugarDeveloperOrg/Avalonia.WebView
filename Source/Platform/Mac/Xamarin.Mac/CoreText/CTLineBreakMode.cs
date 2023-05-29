using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public enum CTLineBreakMode : byte
{
	WordWrapping,
	CharWrapping,
	Clipping,
	TruncatingHead,
	TruncatingTail,
	TruncatingMiddle
}
