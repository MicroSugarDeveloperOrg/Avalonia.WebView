using ObjCRuntime;

namespace MapKit;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'MKPinAnnotationView.PinTintColor' instead.")]
[Native]
public enum MKPinAnnotationColor : ulong
{
	Red,
	Green,
	Purple
}
