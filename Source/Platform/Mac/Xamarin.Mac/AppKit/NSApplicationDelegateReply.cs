using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSApplicationDelegateReply : ulong
{
	Success,
	Cancel,
	Failure
}
