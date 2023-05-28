using ObjCRuntime;

namespace MapKit;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Native]
public enum MKAnnotationViewDragState : ulong
{
	None,
	Starting,
	Dragging,
	Canceling,
	Ending
}
