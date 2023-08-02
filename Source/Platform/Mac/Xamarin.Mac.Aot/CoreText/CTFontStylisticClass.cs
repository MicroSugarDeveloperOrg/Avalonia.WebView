using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public enum CTFontStylisticClass : uint
{
	None = 0u,
	Unknown = 0u,
	OldStyleSerifs = 268435456u,
	TransitionalSerifs = 536870912u,
	ModernSerifs = 805306368u,
	ClarendonSerifs = 1073741824u,
	SlabSerifs = 1342177280u,
	FreeformSerifs = 1879048192u,
	SansSerif = 2147483648u,
	Ornamentals = 2415919104u,
	Scripts = 2684354560u,
	Symbolic = 3221225472u
}
