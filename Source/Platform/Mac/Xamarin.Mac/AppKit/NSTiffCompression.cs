using System;

namespace AppKit;

public enum NSTiffCompression : ulong
{
	None = 1uL,
	CcittFax3 = 3uL,
	CcittFax4 = 4uL,
	Lzw = 5uL,
	[Obsolete("no longer supported")]
	Jpeg = 6uL,
	Next = 32766uL,
	PackBits = 32773uL,
	[Obsolete("no longer supported")]
	OldJpeg = 32865uL
}
