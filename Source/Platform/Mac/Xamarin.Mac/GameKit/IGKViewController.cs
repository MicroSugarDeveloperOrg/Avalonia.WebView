using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "GKViewController", WrapperType = typeof(GKViewControllerWrapper))]
public interface IGKViewController : INativeObject, IDisposable
{
}
