using ObjCRuntime;

namespace CoreLocation;

[Native]
public enum CLActivityType : long
{
	Other = 1L,
	AutomotiveNavigation,
	Fitness,
	OtherNavigation,
	[iOS(12, 0)]
	[TV(12, 0)]
	[Watch(5, 0)]
	[Mac(10, 14)]
	Airborne
}
