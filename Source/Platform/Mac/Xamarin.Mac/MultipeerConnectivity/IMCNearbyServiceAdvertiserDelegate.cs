using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "MCNearbyServiceAdvertiserDelegate", WrapperType = typeof(MCNearbyServiceAdvertiserDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveInvitationFromPeer", Selector = "advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:", ParameterType = new Type[]
{
	typeof(MCNearbyServiceAdvertiser),
	typeof(MCPeerID),
	typeof(NSData),
	typeof(MCNearbyServiceAdvertiserInvitationHandler)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	typeof(Trampolines.NIDMCNearbyServiceAdvertiserInvitationHandler)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidNotStartAdvertisingPeer", Selector = "advertiser:didNotStartAdvertisingPeer:", ParameterType = new Type[]
{
	typeof(MCNearbyServiceAdvertiser),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface IMCNearbyServiceAdvertiserDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:")]
	[Preserve(Conditional = true)]
	void DidReceiveInvitationFromPeer(MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, NSData? context, [BlockProxy(typeof(Trampolines.NIDMCNearbyServiceAdvertiserInvitationHandler))] MCNearbyServiceAdvertiserInvitationHandler invitationHandler);
}
