using System;

namespace CoreFoundation;

[Flags]
public enum MemoryPressureFlags
{
	Normal = 1,
	Warn = 2,
	Critical = 4
}
