using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSEventButtonMask : ulong
{
	Pen = 1uL,
	PenLower = 2uL,
	PenUpper = 4uL
}
