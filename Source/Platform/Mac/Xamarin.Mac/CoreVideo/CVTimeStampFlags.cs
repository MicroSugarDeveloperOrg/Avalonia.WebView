using System;

namespace CoreVideo;

[Flags]
public enum CVTimeStampFlags
{
	VideoTimeValid = 1,
	HostTimeValid = 2,
	SMPTETimeValid = 4,
	VideoRefreshPeriodValid = 8,
	RateScalarValid = 0x10,
	TopField = 0x10000,
	BottomField = 0x20000,
	VideoHostTimeValid = 3,
	IsInterlaced = 0x30000
}
