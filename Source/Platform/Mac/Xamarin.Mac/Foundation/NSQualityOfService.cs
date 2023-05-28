using ObjCRuntime;

namespace Foundation;

[iOS(8, 0)]
[Mac(10, 10)]
[Native]
public enum NSQualityOfService : long
{
	UserInteractive = 33L,
	UserInitiated = 25L,
	Utility = 17L,
	Background = 9L,
	Default = -1L
}
