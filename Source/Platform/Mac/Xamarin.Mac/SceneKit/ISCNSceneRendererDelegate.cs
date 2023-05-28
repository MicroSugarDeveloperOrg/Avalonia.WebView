using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNSceneRendererDelegate", WrapperType = typeof(SCNSceneRendererDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillRenderScene", Selector = "renderer:willRenderScene:atTime:", ParameterType = new Type[]
{
	typeof(SCNSceneRenderer),
	typeof(SCNScene),
	typeof(double)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRenderScene", Selector = "renderer:didRenderScene:atTime:", ParameterType = new Type[]
{
	typeof(SCNSceneRenderer),
	typeof(SCNScene),
	typeof(double)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Update", Selector = "renderer:updateAtTime:", ParameterType = new Type[]
{
	typeof(SCNSceneRenderer),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidApplyAnimations", Selector = "renderer:didApplyAnimationsAtTime:", ParameterType = new Type[]
{
	typeof(SCNSceneRenderer),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSimulatePhysics", Selector = "renderer:didSimulatePhysicsAtTime:", ParameterType = new Type[]
{
	typeof(SCNSceneRenderer),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidApplyConstraints", Selector = "renderer:didApplyConstraintsAtTime:", ParameterType = new Type[]
{
	typeof(SCNSceneRenderer),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
public interface ISCNSceneRendererDelegate : INativeObject, IDisposable
{
}
