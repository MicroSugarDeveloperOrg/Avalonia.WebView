using ObjCRuntime;

namespace Foundation;

[Mac(10, 10)]
[iOS(8, 0)]
[Native]
public enum NSFormattingUnitStyle : long
{
	Short = 1L,
	Medium,
	Long
}
