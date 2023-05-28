using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSWindowNumberListOptions : ulong
{
	AllApplication = 1uL,
	AllSpaces = 0x10uL
}
