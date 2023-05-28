using ObjCRuntime;

namespace MapKit;

public enum MKDirectionsMode
{
	Driving,
	Walking,
	Transit,
	[iOS(10, 0)]
	[NoTV]
	[Watch(3, 0)]
	[Mac(10, 12)]
	Default
}
