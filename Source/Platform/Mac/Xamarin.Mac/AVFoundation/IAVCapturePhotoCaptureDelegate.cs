using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVCapturePhotoCaptureDelegate", WrapperType = typeof(AVCapturePhotoCaptureDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginCapture", Selector = "captureOutput:willBeginCaptureForResolvedSettings:", ParameterType = new Type[]
{
	typeof(AVCapturePhotoOutput),
	typeof(AVCaptureResolvedPhotoSettings)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillCapturePhoto", Selector = "captureOutput:willCapturePhotoForResolvedSettings:", ParameterType = new Type[]
{
	typeof(AVCapturePhotoOutput),
	typeof(AVCaptureResolvedPhotoSettings)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCapturePhoto", Selector = "captureOutput:didCapturePhotoForResolvedSettings:", ParameterType = new Type[]
{
	typeof(AVCapturePhotoOutput),
	typeof(AVCaptureResolvedPhotoSettings)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishProcessingPhoto", Selector = "captureOutput:didFinishProcessingPhoto:error:", ParameterType = new Type[]
{
	typeof(AVCapturePhotoOutput),
	typeof(AVCapturePhoto),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishCapture", Selector = "captureOutput:didFinishCaptureForResolvedSettings:error:", ParameterType = new Type[]
{
	typeof(AVCapturePhotoOutput),
	typeof(AVCaptureResolvedPhotoSettings),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IAVCapturePhotoCaptureDelegate : INativeObject, IDisposable
{
}
