using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "GKInviteEventListener", WrapperType = typeof(GKInviteEventListenerWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAcceptInvite", Selector = "player:didAcceptInvite:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKInvite)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestMatch", Selector = "player:didRequestMatchWithRecipients:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKPlayer[])
}, ParameterByRef = new bool[] { false, false })]
public interface IGKInviteEventListener : INativeObject, IDisposable
{
}
