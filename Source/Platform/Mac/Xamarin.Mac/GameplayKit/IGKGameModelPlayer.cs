using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "GKGameModelPlayer", WrapperType = typeof(GKGameModelPlayerWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPlayerId", Selector = "playerId", ReturnType = typeof(nint))]
public interface IGKGameModelPlayer : INativeObject, IDisposable
{
}
