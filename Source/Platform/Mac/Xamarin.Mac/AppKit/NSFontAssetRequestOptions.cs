using System;
using ObjCRuntime;

namespace AppKit;

[Mac(10, 13)]
[Native]
[Flags]
public enum NSFontAssetRequestOptions : ulong
{
	UsesStandardUI = 1uL
}
