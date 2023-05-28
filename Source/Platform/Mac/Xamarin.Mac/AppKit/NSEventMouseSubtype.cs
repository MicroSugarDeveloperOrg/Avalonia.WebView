using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSEventMouseSubtype : ulong
{
	Mouse,
	TablePoint,
	TabletProximity,
	Touch
}
