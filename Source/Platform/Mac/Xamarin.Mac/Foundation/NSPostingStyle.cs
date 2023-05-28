using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSPostingStyle : ulong
{
	PostWhenIdle = 1uL,
	PostASAP,
	Now
}
