using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSNumberFormatterStyle : ulong
{
	None,
	Decimal,
	Currency,
	Percent,
	Scientific,
	SpellOut
}
