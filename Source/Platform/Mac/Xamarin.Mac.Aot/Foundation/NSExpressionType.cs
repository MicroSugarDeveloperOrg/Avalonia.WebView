namespace Foundation;

public enum NSExpressionType : ulong
{
	ConstantValue = 0uL,
	EvaluatedObject = 1uL,
	Variable = 2uL,
	KeyPath = 3uL,
	Function = 4uL,
	UnionSet = 5uL,
	IntersectSet = 6uL,
	MinusSet = 7uL,
	Subquery = 13uL,
	NSAggregate = 14uL,
	Block = 19uL
}
