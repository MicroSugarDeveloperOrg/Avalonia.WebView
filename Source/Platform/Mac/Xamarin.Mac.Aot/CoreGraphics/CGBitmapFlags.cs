using System;

namespace CoreGraphics;

[Flags]
public enum CGBitmapFlags
{
	None = 0,
	PremultipliedLast = 1,
	PremultipliedFirst = 2,
	Last = 3,
	First = 4,
	NoneSkipLast = 5,
	NoneSkipFirst = 6,
	Only = 7,
	AlphaInfoMask = 0x1F,
	FloatComponents = 0x100,
	ByteOrderMask = 0x7000,
	ByteOrderDefault = 0,
	ByteOrder16Little = 0x1000,
	ByteOrder32Little = 0x2000,
	ByteOrder16Big = 0x3000,
	ByteOrder32Big = 0x4000
}
