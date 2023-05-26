using System;

namespace AudioToolbox;

[Flags]
public enum AudioFormatFlags : uint
{
	IsFloat = 1u,
	IsBigEndian = 2u,
	IsSignedInteger = 4u,
	IsPacked = 8u,
	IsAlignedHigh = 0x10u,
	IsNonInterleaved = 0x20u,
	IsNonMixable = 0x40u,
	FlagsAreAllClear = 0x80000000u,
	LinearPCMIsFloat = 1u,
	LinearPCMIsBigEndian = 2u,
	LinearPCMIsSignedInteger = 4u,
	LinearPCMIsPacked = 8u,
	LinearPCMIsAlignedHigh = 0x10u,
	LinearPCMIsNonInterleaved = 0x20u,
	LinearPCMIsNonMixable = 0x40u,
	LinearPCMSampleFractionShift = 7u,
	LinearPCMSampleFractionMask = 0x1F80u,
	LinearPCMFlagsAreAllClear = 0x80000000u,
	AppleLossless16BitSourceData = 1u,
	AppleLossless20BitSourceData = 2u,
	AppleLossless24BitSourceData = 3u,
	AppleLossless32BitSourceData = 4u
}
