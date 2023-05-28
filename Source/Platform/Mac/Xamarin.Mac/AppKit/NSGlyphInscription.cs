using ObjCRuntime;

namespace AppKit;

[Native]
[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSGlyphProperty' instead.")]
public enum NSGlyphInscription : ulong
{
	Base,
	Below,
	Above,
	Overstrike,
	OverBelow
}
