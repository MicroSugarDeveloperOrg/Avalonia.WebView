using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Implement 'INStartAudioCallIntentHandling, INStartVideoCallIntentHandling and INSearchCallHistoryIntentHandling' instead.")]
[Deprecated(PlatformName.WatchOS, 13, 0, PlatformArchitecture.None, "Implement 'INStartAudioCallIntentHandling and INSearchCallHistoryIntentHandling' instead.")]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[Protocol(Name = "INCallsDomainHandling", WrapperType = typeof(INCallsDomainHandlingWrapper))]
public interface IINCallsDomainHandling : INativeObject, IDisposable, IINSearchCallHistoryIntentHandling, IINStartAudioCallIntentHandling, IINStartVideoCallIntentHandling
{
}
