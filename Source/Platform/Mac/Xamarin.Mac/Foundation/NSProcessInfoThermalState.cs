using ObjCRuntime;

namespace Foundation;

[Mac(10, 10, 3)]
[Watch(4, 0)]
[TV(11, 0)]
[iOS(11, 0)]
[Native]
public enum NSProcessInfoThermalState : long
{
	Nominal,
	Fair,
	Serious,
	Critical
}
