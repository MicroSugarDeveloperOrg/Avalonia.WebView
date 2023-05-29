using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public enum CTRunStatus
{
	NoStatus = 0,
	RightToLeft = 1,
	NonMonotonic = 2,
	HasNonIdentityMatrix = 4
}
