using System;
using ObjCRuntime;

namespace AudioToolbox;

[Watch(3, 0)]
[Flags]
public enum AudioChannelFlags : uint
{
	AllOff = 0u,
	RectangularCoordinates = 1u,
	SphericalCoordinates = 2u,
	Meters = 4u
}
