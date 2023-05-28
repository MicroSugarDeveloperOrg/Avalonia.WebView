using System;

namespace CoreFoundation;

[Flags]
public enum ProcessMonitorFlags : uint
{
	Exit = 0x80000000u,
	Fork = 0x40000000u,
	Exec = 0x20000000u,
	Signal = 0x8000000u
}
