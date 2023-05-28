using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSEventSwipeTrackingOptions : ulong
{
	LockDirection = 1uL,
	ClampGestureAmount = 2uL
}
