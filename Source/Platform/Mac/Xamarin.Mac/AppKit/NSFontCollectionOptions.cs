using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSFontCollectionOptions : long
{
	ApplicationOnlyMask = 1L
}
