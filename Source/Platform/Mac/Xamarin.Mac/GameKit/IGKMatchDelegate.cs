using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "GKMatchDelegate", WrapperType = typeof(GKMatchDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DataReceived", Selector = "match:didReceiveData:fromPlayer:", ParameterType = new Type[]
{
	typeof(GKMatch),
	typeof(NSData),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "StateChanged", Selector = "match:player:didChangeState:", ParameterType = new Type[]
{
	typeof(GKMatch),
	typeof(string),
	typeof(GKPlayerConnectionState)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConnectionFailed", Selector = "xamarin:selector:removed:", ParameterType = new Type[]
{
	typeof(GKMatch),
	typeof(string),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Failed", Selector = "match:didFailWithError:", ParameterType = new Type[]
{
	typeof(GKMatch),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReinvitePlayer", Selector = "match:shouldReinvitePlayer:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(GKMatch),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DataReceivedFromPlayer", Selector = "match:didReceiveData:fromRemotePlayer:", ParameterType = new Type[]
{
	typeof(GKMatch),
	typeof(NSData),
	typeof(GKPlayer)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "StateChangedForPlayer", Selector = "match:player:didChangeConnectionState:", ParameterType = new Type[]
{
	typeof(GKMatch),
	typeof(GKPlayer),
	typeof(GKPlayerConnectionState)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReinviteDisconnectedPlayer", Selector = "match:shouldReinviteDisconnectedPlayer:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(GKMatch),
	typeof(GKPlayer)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DataReceivedForRecipient", Selector = "match:didReceiveData:forRecipient:fromRemotePlayer:", ParameterType = new Type[]
{
	typeof(GKMatch),
	typeof(NSData),
	typeof(GKPlayer),
	typeof(GKPlayer)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface IGKMatchDelegate : INativeObject, IDisposable
{
}
