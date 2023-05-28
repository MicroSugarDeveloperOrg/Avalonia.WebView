using System;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Protocol(Name = "AVCaptureAudioDataOutputSampleBufferDelegate", WrapperType = typeof(AVCaptureAudioDataOutputSampleBufferDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputSampleBuffer", Selector = "captureOutput:didOutputSampleBuffer:fromConnection:", ParameterType = new Type[]
{
	typeof(AVCaptureOutput),
	typeof(CMSampleBuffer),
	typeof(AVCaptureConnection)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IAVCaptureAudioDataOutputSampleBufferDelegate : INativeObject, IDisposable
{
}
