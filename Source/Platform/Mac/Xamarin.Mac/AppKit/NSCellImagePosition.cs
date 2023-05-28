using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSCellImagePosition : ulong
{
	NoImage,
	ImageOnly,
	ImageLeft,
	ImageRight,
	ImageBelow,
	ImageAbove,
	ImageOverlaps,
	[Mac(10, 12)]
	ImageLeading,
	[Mac(10, 12)]
	ImageTrailing
}
