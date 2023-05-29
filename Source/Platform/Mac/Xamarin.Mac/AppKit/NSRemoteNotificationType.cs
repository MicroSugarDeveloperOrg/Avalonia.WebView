using System;

namespace AppKit;

[Flags]
public enum NSRemoteNotificationType : ulong
{
	None = 0uL,
	Badge = 1uL,
	Sound = 2uL,
	Alert = 4uL
}
