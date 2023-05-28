using ObjCRuntime;

namespace AppKit;

[Mac(10, 9)]
[Native]
public enum NSModalResponse : long
{
	OK = 1L,
	Cancel = 0L,
	Stop = -1000L,
	Abort = -1001L,
	Continue = -1002L
}
