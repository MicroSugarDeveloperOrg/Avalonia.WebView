using ObjCRuntime;

namespace Foundation;

[Native]
[Mac(10, 10)]
[iOS(8, 0)]
public enum NSDateComponentsFormatterUnitsStyle : long
{
	Positional,
	Abbreviated,
	Short,
	Full,
	SpellOut,
	[iOS(10, 0)]
	[TV(10, 0)]
	[Watch(3, 0)]
	[Mac(10, 12)]
	Brief
}
