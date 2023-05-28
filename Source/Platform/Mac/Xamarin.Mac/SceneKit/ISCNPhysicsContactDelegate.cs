using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNPhysicsContactDelegate", WrapperType = typeof(SCNPhysicsContactDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginContact", Selector = "physicsWorld:didBeginContact:", ParameterType = new Type[]
{
	typeof(SCNPhysicsWorld),
	typeof(SCNPhysicsContact)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateContact", Selector = "physicsWorld:didUpdateContact:", ParameterType = new Type[]
{
	typeof(SCNPhysicsWorld),
	typeof(SCNPhysicsContact)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndContact", Selector = "physicsWorld:didEndContact:", ParameterType = new Type[]
{
	typeof(SCNPhysicsWorld),
	typeof(SCNPhysicsContact)
}, ParameterByRef = new bool[] { false, false })]
public interface ISCNPhysicsContactDelegate : INativeObject, IDisposable
{
}
