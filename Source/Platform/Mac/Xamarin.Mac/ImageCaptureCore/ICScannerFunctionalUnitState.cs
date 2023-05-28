using System;

namespace ImageCaptureCore;

[Flags]
public enum ICScannerFunctionalUnitState : uint
{
	Ready = 1u,
	ScanInProgress = 2u,
	OverviewScanInProgress = 4u
}
