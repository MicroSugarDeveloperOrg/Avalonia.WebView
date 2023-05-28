using ObjCRuntime;

namespace ModelIO;

[Native]
public enum MDLLightType : ulong
{
	Unknown,
	Ambient,
	Directional,
	Spot,
	Point,
	Linear,
	DiscArea,
	RectangularArea,
	SuperElliptical,
	Photometric,
	Probe,
	Environment
}
