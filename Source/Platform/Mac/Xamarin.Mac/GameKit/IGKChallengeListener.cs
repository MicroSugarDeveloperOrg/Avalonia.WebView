using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "GKChallengeListener", WrapperType = typeof(GKChallengeListenerWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WantsToPlayChallenge", Selector = "player:wantsToPlayChallenge:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKChallenge)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveChallenge", Selector = "player:didReceiveChallenge:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKChallenge)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCompleteChallenge", Selector = "player:didCompleteChallenge:issuedByFriend:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKChallenge),
	typeof(GKPlayer)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IssuedChallengeWasCompleted", Selector = "player:issuedChallengeWasCompleted:byFriend:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKChallenge),
	typeof(GKPlayer)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IGKChallengeListener : INativeObject, IDisposable
{
}
