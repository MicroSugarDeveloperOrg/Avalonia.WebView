using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSTableViewColumnAutoresizingStyle : ulong
{
	None,
	Uniform,
	Sequential,
	ReverseSequential,
	LastColumnOnly,
	FirstColumnOnly
}
