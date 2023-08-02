namespace Foundation;

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
	Correction = 0x200uL
}
