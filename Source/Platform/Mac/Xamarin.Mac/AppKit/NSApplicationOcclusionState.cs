using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSApplicationOcclusionState : ulong
{
	Visible = 2uL
}
