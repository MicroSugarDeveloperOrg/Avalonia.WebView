using System;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "SKSceneDelegate", WrapperType = typeof(SKSceneDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Update", Selector = "update:forScene:", ParameterType = new Type[]
{
	typeof(double),
	typeof(SKScene)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEvaluateActions", Selector = "didEvaluateActionsForScene:", ParameterType = new Type[] { typeof(SKScene) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSimulatePhysics", Selector = "didSimulatePhysicsForScene:", ParameterType = new Type[] { typeof(SKScene) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidApplyConstraints", Selector = "didApplyConstraintsForScene:", ParameterType = new Type[] { typeof(SKScene) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishUpdate", Selector = "didFinishUpdateForScene:", ParameterType = new Type[] { typeof(SKScene) }, ParameterByRef = new bool[] { false })]
public interface ISKSceneDelegate : INativeObject, IDisposable
{
}
