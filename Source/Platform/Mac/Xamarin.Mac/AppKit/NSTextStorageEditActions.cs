using System;
using ObjCRuntime;

namespace AppKit;

[Mac(10, 11)]
[Native]
[Flags]
public enum NSTextStorageEditActions : ulong
{
	Attributes = 1uL,
	Characters = 2uL
}
