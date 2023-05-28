using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Protocol(Name = "GKSavedGameListener", WrapperType = typeof(GKSavedGameListenerWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidModifySavedGame", Selector = "player:didModifySavedGame:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKSavedGame)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasConflictingSavedGames", Selector = "player:hasConflictingSavedGames:", ParameterType = new Type[]
{
	typeof(GKPlayer),
	typeof(GKSavedGame[])
}, ParameterByRef = new bool[] { false, false })]
public interface IGKSavedGameListener : INativeObject, IDisposable
{
}
