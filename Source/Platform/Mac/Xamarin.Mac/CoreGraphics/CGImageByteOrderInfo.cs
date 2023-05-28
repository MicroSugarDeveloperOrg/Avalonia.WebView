using System;

namespace CoreGraphics;

[Flags]
public enum CGImageByteOrderInfo : uint
{
	ByteOrderMask = 0x7000u,
	ByteOrderDefault = 0u,
	ByteOrder16Little = 0x1000u,
	ByteOrder32Little = 0x2000u,
	ByteOrder16Big = 0x3000u,
	ByteOrder32Big = 0x4000u
}
