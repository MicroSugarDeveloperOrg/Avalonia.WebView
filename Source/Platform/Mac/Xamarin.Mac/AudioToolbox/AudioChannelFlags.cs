using System;

namespace AudioToolbox;

[Flags]
public enum AudioChannelFlags
{
	AllOff = 0,
	RectangularCoordinates = 1,
	SphericalCoordinates = 2,
	Meters = 4
}
