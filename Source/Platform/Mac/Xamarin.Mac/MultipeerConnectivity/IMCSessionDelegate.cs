using System;
using Foundation;
using ObjCRuntime;
using Security;

namespace MultipeerConnectivity;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "MCSessionDelegate", WrapperType = typeof(MCSessionDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidChangeState", Selector = "session:peer:didChangeState:", ParameterType = new Type[]
{
	typeof(MCSession),
	typeof(MCPeerID),
	typeof(MCSessionState)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveData", Selector = "session:didReceiveData:fromPeer:", ParameterType = new Type[]
{
	typeof(MCSession),
	typeof(NSData),
	typeof(MCPeerID)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidStartReceivingResource", Selector = "session:didStartReceivingResourceWithName:fromPeer:withProgress:", ParameterType = new Type[]
{
	typeof(MCSession),
	typeof(string),
	typeof(MCPeerID),
	typeof(NSProgress)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinishReceivingResource", Selector = "session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:", ParameterType = new Type[]
{
	typeof(MCSession),
	typeof(string),
	typeof(MCPeerID),
	typeof(NSUrl),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveStream", Selector = "session:didReceiveStream:withName:fromPeer:", ParameterType = new Type[]
{
	typeof(MCSession),
	typeof(NSInputStream),
	typeof(string),
	typeof(MCPeerID)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveCertificate", Selector = "session:didReceiveCertificate:fromPeer:certificateHandler:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(MCSession),
	typeof(SecCertificate[]),
	typeof(MCPeerID),
	typeof(Action<bool>)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	typeof(Trampolines.NIDActionArity1V0)
})]
public interface IMCSessionDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("session:peer:didChangeState:")]
	[Preserve(Conditional = true)]
	void DidChangeState(MCSession session, MCPeerID peerID, MCSessionState state);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("session:didReceiveData:fromPeer:")]
	[Preserve(Conditional = true)]
	void DidReceiveData(MCSession session, NSData data, MCPeerID peerID);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("session:didStartReceivingResourceWithName:fromPeer:withProgress:")]
	[Preserve(Conditional = true)]
	void DidStartReceivingResource(MCSession session, string resourceName, MCPeerID fromPeer, NSProgress progress);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:")]
	[Preserve(Conditional = true)]
	void DidFinishReceivingResource(MCSession session, string resourceName, MCPeerID fromPeer, NSUrl? localUrl, NSError? error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("session:didReceiveStream:withName:fromPeer:")]
	[Preserve(Conditional = true)]
	void DidReceiveStream(MCSession session, NSInputStream stream, string streamName, MCPeerID peerID);
}
