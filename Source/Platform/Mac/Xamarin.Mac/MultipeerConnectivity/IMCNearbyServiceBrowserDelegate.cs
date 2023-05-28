using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "MCNearbyServiceBrowserDelegate", WrapperType = typeof(MCNearbyServiceBrowserDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FoundPeer", Selector = "browser:foundPeer:withDiscoveryInfo:", ParameterType = new Type[]
{
	typeof(MCNearbyServiceBrowser),
	typeof(MCPeerID),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "LostPeer", Selector = "browser:lostPeer:", ParameterType = new Type[]
{
	typeof(MCNearbyServiceBrowser),
	typeof(MCPeerID)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidNotStartBrowsingForPeers", Selector = "browser:didNotStartBrowsingForPeers:", ParameterType = new Type[]
{
	typeof(MCNearbyServiceBrowser),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface IMCNearbyServiceBrowserDelegate : INativeObject, IDisposable
{
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("browser:foundPeer:withDiscoveryInfo:")]
	[Preserve(Conditional = true)]
	void FoundPeer(MCNearbyServiceBrowser browser, MCPeerID peerID, NSDictionary? info);

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("browser:lostPeer:")]
	[Preserve(Conditional = true)]
	void LostPeer(MCNearbyServiceBrowser browser, MCPeerID peerID);
}
