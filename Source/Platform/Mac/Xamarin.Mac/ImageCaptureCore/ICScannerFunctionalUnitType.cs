using ObjCRuntime;

namespace ImageCaptureCore;

[Native]
public enum ICScannerFunctionalUnitType : ulong
{
	Flatbed,
	PositiveTransparency,
	NegativeTransparency,
	DocumentFeeder
}
