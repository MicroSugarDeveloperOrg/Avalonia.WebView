using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Mac(10, 12)]
[Native]
public enum NSWindowListOptions : long
{
	OrderedFrontToBack = 1L
}
