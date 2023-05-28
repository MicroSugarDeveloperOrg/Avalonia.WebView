using System;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SKPhysicsContactDelegate", WrapperType = typeof(SKPhysicsContactDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginContact", Selector = "didBeginContact:", ParameterType = new Type[] { typeof(SKPhysicsContact) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndContact", Selector = "didEndContact:", ParameterType = new Type[] { typeof(SKPhysicsContact) }, ParameterByRef = new bool[] { false })]
public interface ISKPhysicsContactDelegate : INativeObject, IDisposable
{
}
