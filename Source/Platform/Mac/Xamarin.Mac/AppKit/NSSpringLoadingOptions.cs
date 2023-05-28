using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Mac(10, 11)]
[Native]
public enum NSSpringLoadingOptions : ulong
{
	Disabled = 0uL,
	Enabled = 1uL,
	ContinuousActivation = 2uL,
	NoHover = 8uL
}
