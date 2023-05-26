namespace Foundation;

public enum NSPredicateOperatorType : ulong
{
	LessThan = 0uL,
	LessThanOrEqualTo = 1uL,
	GreaterThan = 2uL,
	GreaterThanOrEqualTo = 3uL,
	EqualTo = 4uL,
	NotEqualTo = 5uL,
	Matches = 6uL,
	Like = 7uL,
	BeginsWith = 8uL,
	EndsWith = 9uL,
	In = 10uL,
	CustomSelector = 11uL,
	Contains = 99uL,
	Between = 100uL
}
