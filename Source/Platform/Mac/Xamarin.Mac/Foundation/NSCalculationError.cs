using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSCalculationError : ulong
{
	None,
	PrecisionLoss,
	Underflow,
	Overflow,
	DivideByZero
}
