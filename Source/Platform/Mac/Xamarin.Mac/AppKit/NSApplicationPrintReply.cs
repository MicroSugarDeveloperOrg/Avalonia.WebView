using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSApplicationPrintReply : ulong
{
	Cancelled,
	Success,
	Failure,
	ReplyLater
}
