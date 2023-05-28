using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNCameraControllerDelegate", WrapperType = typeof(SCNCameraControllerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraInertiaWillStart", Selector = "cameraInertiaWillStartForController:", ParameterType = new Type[] { typeof(SCNCameraController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraInertiaDidEnd", Selector = "cameraInertiaDidEndForController:", ParameterType = new Type[] { typeof(SCNCameraController) }, ParameterByRef = new bool[] { false })]
public interface ISCNCameraControllerDelegate : INativeObject, IDisposable
{
}
