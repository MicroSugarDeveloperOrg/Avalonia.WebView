using System;

namespace Foundation;

[Flags]
public enum NSComparisonPredicateOptions : ulong
{
	None = 0uL,
	CaseInsensitive = 1uL,
	DiacriticInsensitive = 2uL,
	Normalized = 4uL
}
