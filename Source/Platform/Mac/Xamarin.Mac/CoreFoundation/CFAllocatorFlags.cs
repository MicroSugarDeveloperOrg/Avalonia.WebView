using System;

namespace CoreFoundation;

[Flags]
public enum CFAllocatorFlags : ulong
{
	GCScannedMemory = 0x200uL,
	GCObjectMemory = 0x400uL
}
