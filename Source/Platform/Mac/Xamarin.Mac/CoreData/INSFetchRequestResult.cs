using System;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "NSFetchRequestResult", WrapperType = typeof(NSFetchRequestResultWrapper))]
public interface INSFetchRequestResult : INativeObject, IDisposable
{
}
