using ObjCRuntime;

namespace AudioUnit;

public enum AudioTypeMixer
{
	MultiChannel = 1835232632,
	Matrix = 1836608888,
	Spacial = 862217581,
	Stereo = 1936554098,
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Spacial' instead.")]
	ThreeD = 862219640
}
