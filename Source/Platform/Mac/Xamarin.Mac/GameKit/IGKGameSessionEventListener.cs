using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'GKLocalPlayerListener' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'GKLocalPlayerListener' instead.")]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'GKLocalPlayerListener' instead.")]
[Protocol(Name = "GKGameSessionEventListener", WrapperType = typeof(GKGameSessionEventListenerWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddPlayer", Selector = "session:didAddPlayer:", ParameterType = new Type[]
{
	typeof(GKGameSession),
	typeof(GKCloudPlayer)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemovePlayer", Selector = "session:didRemovePlayer:", ParameterType = new Type[]
{
	typeof(GKGameSession),
	typeof(GKCloudPlayer)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeConnectionState", Selector = "session:player:didChangeConnectionState:", ParameterType = new Type[]
{
	typeof(GKGameSession),
	typeof(GKCloudPlayer),
	typeof(GKConnectionState)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSaveData", Selector = "session:player:didSaveData:", ParameterType = new Type[]
{
	typeof(GKGameSession),
	typeof(GKCloudPlayer),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveData", Selector = "session:didReceiveData:fromPlayer:", ParameterType = new Type[]
{
	typeof(GKGameSession),
	typeof(NSData),
	typeof(GKCloudPlayer)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveMessage", Selector = "session:didReceiveMessage:withData:fromPlayer:", ParameterType = new Type[]
{
	typeof(GKGameSession),
	typeof(string),
	typeof(NSData),
	typeof(GKCloudPlayer)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface IGKGameSessionEventListener : INativeObject, IDisposable
{
}
