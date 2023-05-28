using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSCorrectionResponse : long
{
	None,
	Accepted,
	Rejected,
	Ignored,
	Edited,
	Reverted
}
