using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSScrollerPart : ulong
{
	None,
	DecrementPage,
	Knob,
	IncrementPage,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	DecrementLine,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	IncrementLine,
	KnobSlot
}
