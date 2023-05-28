using ObjCRuntime;

namespace AppKit;

[Mac(10, 12)]
[Native]
public enum NSStatusItemBehavior : ulong
{
	RemovalAllowed = 2uL,
	TerminationOnRemoval = 4uL
}
