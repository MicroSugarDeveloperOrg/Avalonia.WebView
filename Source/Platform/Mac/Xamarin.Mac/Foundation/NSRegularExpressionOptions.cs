using System;
using ObjCRuntime;

namespace Foundation;

[Native]
[Flags]
public enum NSRegularExpressionOptions : ulong
{
	CaseInsensitive = 1uL,
	AllowCommentsAndWhitespace = 2uL,
	IgnoreMetacharacters = 4uL,
	DotMatchesLineSeparators = 8uL,
	AnchorsMatchLines = 0x10uL,
	UseUnixLineSeparators = 0x20uL,
	UseUnicodeWordBoundaries = 0x40uL
}
