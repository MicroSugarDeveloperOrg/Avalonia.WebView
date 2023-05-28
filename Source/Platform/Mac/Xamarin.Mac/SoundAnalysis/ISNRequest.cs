using System;
using Foundation;
using ObjCRuntime;

namespace SoundAnalysis;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SNRequest", WrapperType = typeof(SNRequestWrapper))]
public interface ISNRequest : INativeObject, IDisposable
{
}
