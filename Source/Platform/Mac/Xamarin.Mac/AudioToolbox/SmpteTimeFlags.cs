using System;

namespace AudioToolbox;

[Flags]
public enum SmpteTimeFlags : uint
{
	Unknown = 0u,
	TimeValid = 1u,
	TimeRunning = 2u
}
