using ObjCRuntime;

namespace GameController;

[iOS(9, 0)]
[Mac(10, 11)]
[Native]
public enum GCControllerPlayerIndex : long
{
	Unset = -1L,
	Index1,
	Index2,
	Index3,
	Index4
}
