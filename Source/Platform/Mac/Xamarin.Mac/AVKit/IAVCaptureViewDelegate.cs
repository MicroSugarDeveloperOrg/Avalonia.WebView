using System;
using AVFoundation;
using Foundation;
using ObjCRuntime;

namespace AVKit;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "AVCaptureViewDelegate", WrapperType = typeof(AVCaptureViewDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartRecording", Selector = "captureView:startRecordingToFileOutput:", ParameterType = new Type[]
{
	typeof(AVCaptureView),
	typeof(AVCaptureFileOutput)
}, ParameterByRef = new bool[] { false, false })]
public interface IAVCaptureViewDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("captureView:startRecordingToFileOutput:")]
	[Preserve(Conditional = true)]
	void StartRecording(AVCaptureView captureView, AVCaptureFileOutput fileOutput);
}
