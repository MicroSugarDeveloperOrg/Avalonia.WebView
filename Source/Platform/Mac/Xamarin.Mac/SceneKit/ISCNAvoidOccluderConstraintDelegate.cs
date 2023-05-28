using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNAvoidOccluderConstraintDelegate", WrapperType = typeof(SCNAvoidOccluderConstraintDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAvoidOccluder", Selector = "avoidOccluderConstraint:shouldAvoidOccluder:forNode:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(SCNAvoidOccluderConstraint),
	typeof(SCNNode),
	typeof(SCNNode)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAvoidOccluder", Selector = "avoidOccluderConstraint:didAvoidOccluder:forNode:", ParameterType = new Type[]
{
	typeof(SCNAvoidOccluderConstraint),
	typeof(SCNNode),
	typeof(SCNNode)
}, ParameterByRef = new bool[] { false, false, false })]
public interface ISCNAvoidOccluderConstraintDelegate : INativeObject, IDisposable
{
}
