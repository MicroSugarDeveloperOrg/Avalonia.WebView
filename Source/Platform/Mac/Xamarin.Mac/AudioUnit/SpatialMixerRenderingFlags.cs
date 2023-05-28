using System;
using ObjCRuntime;

namespace AudioUnit;

[Flags]
[iOS(8, 0)]
public enum SpatialMixerRenderingFlags
{
	InterAuralDelay = 1,
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	DistanceAttenuation = 4
}
