using System;

namespace CoreGraphics;

[Flags]
public enum CGBitmapFlags : uint
{
	None = 0u,
	PremultipliedLast = 1u,
	PremultipliedFirst = 2u,
	Last = 3u,
	First = 4u,
	NoneSkipLast = 5u,
	NoneSkipFirst = 6u,
	Only = 7u,
	AlphaInfoMask = 0x1Fu,
	FloatInfoMask = 0xF00u,
	FloatComponents = 0x100u,
	ByteOrderMask = 0x7000u,
	ByteOrderDefault = 0u,
	ByteOrder16Little = 0x1000u,
	ByteOrder32Little = 0x2000u,
	ByteOrder16Big = 0x3000u,
	ByteOrder32Big = 0x4000u
}
