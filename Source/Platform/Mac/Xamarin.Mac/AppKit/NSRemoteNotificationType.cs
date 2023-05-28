using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSRemoteNotificationType : ulong
{
	None = 0uL,
	Badge = 1uL,
	Sound = 2uL,
	Alert = 4uL
}
