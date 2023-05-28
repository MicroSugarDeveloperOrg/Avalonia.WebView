using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSStringCompareOptions : ulong
{
	CaseInsensitiveSearch = 1uL,
	LiteralSearch = 2uL,
	BackwardsSearch = 4uL,
	AnchoredSearch = 8uL,
	NumericSearch = 0x40uL,
	DiacriticInsensitiveSearch = 0x80uL,
	WidthInsensitiveSearch = 0x100uL,
	ForcedOrderingSearch = 0x200uL,
	RegularExpressionSearch = 0x400uL
}
