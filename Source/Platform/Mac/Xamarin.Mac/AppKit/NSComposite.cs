using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSComposite : ulong
{
	Clear,
	Copy,
	SourceOver,
	SourceIn,
	SourceOut,
	SourceAtop,
	DestinationOver,
	DestinationIn,
	DestinationOut,
	DestinationAtop,
	XOR,
	PlusDarker,
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use NSCompositeSourceOver instead.")]
	Highlight,
	PlusLighter,
	[Mac(10, 10)]
	Multiply,
	[Mac(10, 10)]
	Screen,
	[Mac(10, 10)]
	Overlay,
	[Mac(10, 10)]
	Darken,
	[Mac(10, 10)]
	Lighten,
	[Mac(10, 10)]
	ColorDodge,
	[Mac(10, 10)]
	ColorBurn,
	[Mac(10, 10)]
	SoftLight,
	[Mac(10, 10)]
	HardLight,
	[Mac(10, 10)]
	Difference,
	[Mac(10, 10)]
	Exclusion,
	[Mac(10, 10)]
	Hue,
	[Mac(10, 10)]
	Saturation,
	[Mac(10, 10)]
	Color,
	[Mac(10, 10)]
	Luminosity
}
