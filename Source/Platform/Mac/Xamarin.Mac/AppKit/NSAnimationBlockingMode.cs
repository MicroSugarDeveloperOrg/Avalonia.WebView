using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSAnimationBlockingMode : ulong
{
	Blocking,
	Nonblocking,
	NonblockingThreaded
}
