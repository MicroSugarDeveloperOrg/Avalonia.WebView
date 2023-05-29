using System;

namespace AppKit;

[Flags]
public enum NSBitmapFormat : ulong
{
	AlphaFirst = 1uL,
	AlphaNonpremultiplied = 2uL,
	FloatingPointSamples = 4uL,
	LittleEndian16Bit = 0x100uL,
	LittleEndian32Bit = 0x200uL,
	BigEndian16Bit = 0x400uL,
	BigEndian32Bit = 0x800uL
}
