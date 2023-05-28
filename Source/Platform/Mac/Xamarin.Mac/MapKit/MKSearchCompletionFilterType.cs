using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'MKLocalSearchCompleterResultType' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'MKLocalSearchCompleterResultType' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'MKLocalSearchCompleterResultType' instead.")]
[Native]
public enum MKSearchCompletionFilterType : long
{
	AndQueries,
	Only
}
