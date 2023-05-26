namespace AudioUnit;

public enum AudioUnitParameterOptions : uint
{
	CFNameRelease = 16u,
	OmitFromPresets = 8192u,
	PlotHistory = 16384u,
	MeterReadOnly = 32768u,
	DisplayMask = 4653056u,
	DisplaySquareRoot = 65536u,
	DisplaySquared = 131072u,
	DisplayCubed = 196608u,
	DisplayCubeRoot = 262144u,
	DisplayExponential = 327680u,
	HasClump = 1048576u,
	ValuesHaveStrings = 2097152u,
	DisplayLogarithmic = 4194304u,
	IsHighResolution = 8388608u,
	NonRealTime = 16777216u,
	CanRamp = 33554432u,
	ExpertMode = 67108864u,
	HasCFNameString = 134217728u,
	IsGlobalMeta = 268435456u,
	IsElementMeta = 536870912u,
	IsReadable = 1073741824u,
	IsWritable = 2147483648u
}
