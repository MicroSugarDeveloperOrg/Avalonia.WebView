using System;
using ObjCRuntime;

namespace Foundation;

[iOS(7, 0)]
[Flags]
[Native]
public enum NSDataBase64EncodingOptions : ulong
{
	None = 0uL,
	SixtyFourCharacterLineLength = 1uL,
	SeventySixCharacterLineLength = 2uL,
	EndLineWithCarriageReturn = 0x10uL,
	EndLineWithLineFeed = 0x20uL
}
