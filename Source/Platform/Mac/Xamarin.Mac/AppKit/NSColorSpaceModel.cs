using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSColorSpaceModel : long
{
	Unknown = -1L,
	Gray,
	RGB,
	CMYK,
	LAB,
	DeviceN,
	Indexed,
	Pattern
}
