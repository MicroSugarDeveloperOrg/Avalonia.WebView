using ObjCRuntime;

namespace AudioUnit;

public enum AudioTypeOutput
{
	Generic = 1734700658,
	HAL = 1634230636,
	Default = 1684366880,
	System = 1937339168,
	[Mac(10, 15)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	Remote = 1919512419,
	VoiceProcessingIO = 1987078511
}
