using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "GKLocalPlayerListener", WrapperType = typeof(GKLocalPlayerListenerWrapper))]
public interface IGKLocalPlayerListener : INativeObject, IDisposable, IGKChallengeListener, IGKInviteEventListener, IGKSavedGameListener, IGKTurnBasedEventListener
{
}
