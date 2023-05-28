using System;
using Foundation;
using ObjCRuntime;

namespace AVKit;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "AVPictureInPictureControllerDelegate", WrapperType = typeof(AVPictureInPictureControllerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartPictureInPicture", Selector = "pictureInPictureControllerWillStartPictureInPicture:", ParameterType = new Type[] { typeof(AVPictureInPictureController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartPictureInPicture", Selector = "pictureInPictureControllerDidStartPictureInPicture:", ParameterType = new Type[] { typeof(AVPictureInPictureController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToStartPictureInPicture", Selector = "pictureInPictureController:failedToStartPictureInPictureWithError:", ParameterType = new Type[]
{
	typeof(AVPictureInPictureController),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStopPictureInPicture", Selector = "pictureInPictureControllerWillStopPictureInPicture:", ParameterType = new Type[] { typeof(AVPictureInPictureController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStopPictureInPicture", Selector = "pictureInPictureControllerDidStopPictureInPicture:", ParameterType = new Type[] { typeof(AVPictureInPictureController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreUserInterfaceForPictureInPicture", Selector = "pictureInPictureController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:", ParameterType = new Type[]
{
	typeof(AVPictureInPictureController),
	typeof(Action<bool>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V0)
})]
public interface IAVPictureInPictureControllerDelegate : INativeObject, IDisposable
{
}
