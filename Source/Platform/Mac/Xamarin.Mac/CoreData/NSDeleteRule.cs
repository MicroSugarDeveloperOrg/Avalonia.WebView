using ObjCRuntime;

namespace CoreData;

[Native]
public enum NSDeleteRule : ulong
{
	NoAction,
	Nullify,
	Cascade,
	Deny
}
