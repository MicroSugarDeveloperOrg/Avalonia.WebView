using System;
using ObjCRuntime;

namespace CoreVideo;

[Flags]
[Watch(4, 0)]
public enum CVTimeStampFlags : ulong
{
	VideoTimeValid = 1uL,
	HostTimeValid = 2uL,
	SMPTETimeValid = 4uL,
	VideoRefreshPeriodValid = 8uL,
	RateScalarValid = 0x10uL,
	TopField = 0x10000uL,
	BottomField = 0x20000uL,
	VideoHostTimeValid = 3uL,
	IsInterlaced = 0x30000uL
}
