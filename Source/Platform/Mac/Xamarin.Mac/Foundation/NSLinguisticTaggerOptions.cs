using System;

namespace Foundation;

[Flags]
public enum NSLinguisticTaggerOptions : ulong
{
	OmitWords = 1uL,
	OmitPunctuation = 2uL,
	OmitWhitespace = 4uL,
	OmitOther = 8uL,
	JoinNames = 0x10uL
}
