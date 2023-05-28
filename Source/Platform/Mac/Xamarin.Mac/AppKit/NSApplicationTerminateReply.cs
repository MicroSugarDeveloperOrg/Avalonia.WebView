using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSApplicationTerminateReply : ulong
{
	Cancel,
	Now,
	Later
}
