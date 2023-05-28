using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIDissolveTransition", WrapperType = typeof(CIDissolveTransitionProtocolWrapper))]
public interface ICIDissolveTransitionProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
}
