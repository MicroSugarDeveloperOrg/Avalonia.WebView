using ObjCRuntime;

namespace Foundation;

[Mac(10, 11)]
[iOS(9, 0)]
[Native]
public enum NSPersonNameComponentsFormatterStyle : long
{
	Default,
	Short,
	Medium,
	Long,
	Abbreviated
}
