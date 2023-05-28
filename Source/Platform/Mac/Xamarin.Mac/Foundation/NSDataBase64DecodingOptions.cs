using System;
using ObjCRuntime;

namespace Foundation;

[iOS(7, 0)]
[Flags]
[Native]
public enum NSDataBase64DecodingOptions : ulong
{
	None = 0uL,
	IgnoreUnknownCharacters = 1uL
}
