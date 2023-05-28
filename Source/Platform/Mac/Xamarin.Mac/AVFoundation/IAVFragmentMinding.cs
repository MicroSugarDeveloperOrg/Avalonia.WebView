using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVFragmentMinding", WrapperType = typeof(AVFragmentMindingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsAssociatedWithFragmentMinder", Selector = "isAssociatedWithFragmentMinder", ReturnType = typeof(bool))]
public interface IAVFragmentMinding : INativeObject, IDisposable
{
}
