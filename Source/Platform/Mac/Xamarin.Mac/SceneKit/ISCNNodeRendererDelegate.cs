using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNNodeRendererDelegate", WrapperType = typeof(SCNNodeRendererDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Render", Selector = "renderNode:renderer:arguments:", ParameterType = new Type[]
{
	typeof(SCNNode),
	typeof(SCNRenderer),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false, false })]
public interface ISCNNodeRendererDelegate : INativeObject, IDisposable
{
}
