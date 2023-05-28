using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "MCBrowserViewControllerDelegate", WrapperType = typeof(MCBrowserViewControllerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "WasCancelled", Selector = "browserViewControllerWasCancelled:", ParameterType = new Type[] { typeof(MCBrowserViewController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "browserViewControllerDidFinish:", ParameterType = new Type[] { typeof(MCBrowserViewController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPresentNearbyPeer", Selector = "browserViewController:shouldPresentNearbyPeer:withDiscoveryInfo:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(MCBrowserViewController),
	typeof(MCPeerID),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IMCBrowserViewControllerDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("browserViewControllerWasCancelled:")]
	[Preserve(Conditional = true)]
	void WasCancelled(MCBrowserViewController browserViewController);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("browserViewControllerDidFinish:")]
	[Preserve(Conditional = true)]
	void DidFinish(MCBrowserViewController browserViewController);
}
