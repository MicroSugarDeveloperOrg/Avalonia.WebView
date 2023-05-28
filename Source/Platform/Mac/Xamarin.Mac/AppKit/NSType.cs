using ObjCRuntime;

namespace AppKit;

[Native]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use formatters instead.")]
public enum NSType : ulong
{
	Any = 0uL,
	Int = 1uL,
	PositiveInt = 2uL,
	Float = 3uL,
	PositiveFloat = 4uL,
	Double = 6uL,
	PositiveDouble = 7uL
}
