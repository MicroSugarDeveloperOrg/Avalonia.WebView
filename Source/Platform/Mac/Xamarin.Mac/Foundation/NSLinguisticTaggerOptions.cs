using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSLinguisticTaggerOptions : ulong
{
	OmitWords = 1uL,
	OmitPunctuation = 2uL,
	OmitWhitespace = 4uL,
	OmitOther = 8uL,
	JoinNames = 0x10uL
}
