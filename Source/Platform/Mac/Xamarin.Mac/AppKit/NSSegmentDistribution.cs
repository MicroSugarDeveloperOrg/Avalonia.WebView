using ObjCRuntime;

namespace AppKit;

[Mac(10, 13)]
[Native]
public enum NSSegmentDistribution : long
{
	Fit,
	Fill,
	FillEqually,
	FillProportionally
}
