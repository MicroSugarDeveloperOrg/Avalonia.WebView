using System;

namespace AudioUnit;

[Flags]
public enum AudioUnitParameterFlag : uint
{
	CFNameRelease = 0x10u,
	[iOS(8, 0)]
	OmitFromPresets = 0x2000u,
	PlotHistory = 0x4000u,
	MeterReadOnly = 0x8000u,
	DisplayMask = 0x470000u,
	DisplaySquareRoot = 0x10000u,
	DisplaySquared = 0x20000u,
	DisplayCubed = 0x30000u,
	DisplayCubeRoot = 0x40000u,
	DisplayExponential = 0x50000u,
	HasClump = 0x100000u,
	ValuesHaveStrings = 0x200000u,
	DisplayLogarithmic = 0x400000u,
	IsHighResolution = 0x800000u,
	NonRealTime = 0x1000000u,
	CanRamp = 0x2000000u,
	ExpertMode = 0x4000000u,
	HasCFNameString = 0x8000000u,
	IsGlobalMeta = 0x10000000u,
	IsElementMeta = 0x20000000u,
	IsReadable = 0x40000000u,
	IsWritable = 0x80000000u
}
