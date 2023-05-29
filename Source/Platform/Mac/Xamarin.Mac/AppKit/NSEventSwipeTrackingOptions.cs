using System;

namespace AppKit;

[Flags]
public enum NSEventSwipeTrackingOptions : ulong
{
	LockDirection = 1uL,
	ClampGestureAmount = 2uL
}
