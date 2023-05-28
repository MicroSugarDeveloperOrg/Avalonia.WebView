using System;
using ObjCRuntime;

namespace Foundation;

[Native]
[Flags]
public enum NSMatchingOptions : ulong
{
	ReportProgress = 1uL,
	ReportCompletion = 2uL,
	Anchored = 4uL,
	WithTransparentBounds = 8uL,
	WithoutAnchoringBounds = 0x10uL
}
