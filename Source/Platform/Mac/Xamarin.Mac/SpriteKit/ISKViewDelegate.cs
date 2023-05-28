using System;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "SKViewDelegate", WrapperType = typeof(SKViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRender", Selector = "view:shouldRenderAtTime:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(SKView),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
public interface ISKViewDelegate : INativeObject, IDisposable
{
}
