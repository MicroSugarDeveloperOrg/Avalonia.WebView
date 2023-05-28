using ObjCRuntime;

namespace Foundation;

[Mac(10, 10)]
[iOS(8, 0)]
[Native]
public enum NSDateIntervalFormatterStyle : ulong
{
	None,
	Short,
	Medium,
	Long,
	Full
}
