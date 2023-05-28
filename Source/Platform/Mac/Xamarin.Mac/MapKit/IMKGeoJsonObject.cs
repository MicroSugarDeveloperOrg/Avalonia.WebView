using System;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MKGeoJSONObject", WrapperType = typeof(MKGeoJsonObjectWrapper))]
public interface IMKGeoJsonObject : INativeObject, IDisposable
{
}
