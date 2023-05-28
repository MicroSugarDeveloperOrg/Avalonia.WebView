using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSWindowOcclusionState : ulong
{
	Visible = 2uL
}
