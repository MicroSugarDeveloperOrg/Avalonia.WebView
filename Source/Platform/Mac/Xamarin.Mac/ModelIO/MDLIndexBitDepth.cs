using ObjCRuntime;

namespace ModelIO;

[Native]
public enum MDLIndexBitDepth : ulong
{
	Invalid = 0uL,
	UInt8 = 8uL,
	UInt16 = 0x10uL,
	UInt32 = 0x20uL
}
