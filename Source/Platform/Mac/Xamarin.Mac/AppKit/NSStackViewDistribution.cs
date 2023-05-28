using ObjCRuntime;

namespace AppKit;

[Mac(10, 11)]
[Native]
public enum NSStackViewDistribution : long
{
	GravityAreas = -1L,
	Fill,
	FillEqually,
	FillProportionally,
	EqualSpacing,
	EqualCentering
}
