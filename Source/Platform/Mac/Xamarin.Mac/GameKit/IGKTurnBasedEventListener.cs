using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "GKTurnBasedEventListener", WrapperType = typeof(GKTurnBasedEventListenerWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestMatchWithPlayers", Selector = "player:didRequestMatchWithPlayers:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(string[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedTurnEvent", Selector = "player:receivedTurnEventForMatch:didBecomeActive:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKTurnBasedMatch),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MatchEnded", Selector = "player:matchEnded:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKTurnBasedMatch)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedExchangeRequest", Selector = "player:receivedExchangeRequest:forMatch:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKTurnBasedExchange),
	typeof(GKTurnBasedMatch)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedExchangeCancellation", Selector = "player:receivedExchangeCancellation:forMatch:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKTurnBasedExchange),
	typeof(GKTurnBasedMatch)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedExchangeReplies", Selector = "player:receivedExchangeReplies:forCompletedExchange:forMatch:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKTurnBasedExchangeReply[]),
	typeof(GKTurnBasedExchange),
	typeof(GKTurnBasedMatch)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestMatchWithOtherPlayers", Selector = "player:didRequestMatchWithOtherPlayers:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKPlayer[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WantsToQuitMatch", Selector = "player:wantsToQuitMatch:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKTurnBasedMatch)
}, ParameterByRef = new bool[] { false, false })]
public interface IGKTurnBasedEventListener : INativeObject, IDisposable
{
}
