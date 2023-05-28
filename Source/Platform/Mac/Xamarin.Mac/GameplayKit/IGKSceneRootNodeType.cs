using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "GKSceneRootNodeType", WrapperType = typeof(GKSceneRootNodeTypeWrapper))]
public interface IGKSceneRootNodeType : INativeObject, IDisposable
{
}
