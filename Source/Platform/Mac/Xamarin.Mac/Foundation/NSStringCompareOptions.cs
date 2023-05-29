namespace Foundation;

public enum NSStringCompareOptions : uint
{
	CaseInsensitiveSearch = 1u,
	LiteralSearch = 2u,
	BackwardsSearch = 4u,
	AnchoredSearch = 8u,
	NumericSearch = 0x40u,
	DiacriticInsensitiveSearch = 0x80u,
	WidthInsensitiveSearch = 0x100u,
	ForcedOrderingSearch = 0x200u,
	RegularExpressionSearch = 0x400u
}
