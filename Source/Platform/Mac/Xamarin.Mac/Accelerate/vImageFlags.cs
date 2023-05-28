using System;

namespace Accelerate;

[Flags]
public enum vImageFlags : uint
{
	NoFlags = 0u,
	LeaveAlphaUnchanged = 1u,
	CopyInPlace = 2u,
	BackgroundColorFill = 4u,
	EdgeExtend = 8u,
	DoNotTile = 0x10u,
	HighQualityResampling = 0x20u,
	TruncateKernel = 0x40u,
	GetTempBufferSize = 0x80u,
	PrintDiagnosticsToConsole = 0x100u,
	NoAllocate = 0x200u
}
