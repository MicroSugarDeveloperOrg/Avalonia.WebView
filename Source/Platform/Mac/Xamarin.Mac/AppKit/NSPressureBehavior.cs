using ObjCRuntime;

namespace AppKit;

[Mac(10, 10, 3)]
[Native]
public enum NSPressureBehavior : long
{
	Unknown = -1L,
	PrimaryDefault = 0L,
	PrimaryClick = 1L,
	PrimaryGeneric = 2L,
	PrimaryAccelerator = 3L,
	PrimaryDeepClick = 5L,
	PrimaryDeepDrag = 6L
}
