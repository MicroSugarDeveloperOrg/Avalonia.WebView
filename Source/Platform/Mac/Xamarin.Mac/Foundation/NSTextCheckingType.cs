using System;

namespace Foundation;

[Flags]
public enum NSTextCheckingType : ulong
{
	Orthography = 1uL,
	Spelling = 2uL,
	Grammar = 4uL,
	Date = 8uL,
	Address = 0x10uL,
	Link = 0x20uL,
	Quote = 0x40uL,
	Dash = 0x80uL,
	Replacement = 0x100uL,
	Correction = 0x200uL,
	RegularExpression = 0x400uL,
	PhoneNumber = 0x800uL,
	TransitInformation = 0x1000uL
}
