using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'MultipeerConnectivity.MCSessionDelegate' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'MultipeerConnectivity.MCSessionDelegate' instead.")]
[Protocol(Name = "GKSessionDelegate", WrapperType = typeof(GKSessionDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PeerChangedState", Selector = "session:peer:didChangeState:", ParameterType = new Type[]
{
	typeof(GKSession),
	typeof(string),
	typeof(GKPeerConnectionState)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PeerConnectionRequest", Selector = "session:didReceiveConnectionRequestFromPeer:", ParameterType = new Type[]
{
	typeof(GKSession),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PeerConnectionFailed", Selector = "session:connectionWithPeerFailed:withError:", ParameterType = new Type[]
{
	typeof(GKSession),
	typeof(string),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedWithError", Selector = "session:didFailWithError:", ParameterType = new Type[]
{
	typeof(GKSession),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface IGKSessionDelegate : INativeObject, IDisposable
{
}
