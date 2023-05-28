using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "AVCaptureFileOutputRecordingDelegate", WrapperType = typeof(AVCaptureFileOutputRecordingDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartRecording", Selector = "captureOutput:didStartRecordingToOutputFileAtURL:fromConnections:", ParameterType = new Type[]
{
	typeof(AVCaptureFileOutput),
	typeof(NSUrl),
	typeof(NSObject[])
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishedRecording", Selector = "captureOutput:didFinishRecordingToOutputFileAtURL:fromConnections:error:", ParameterType = new Type[]
{
	typeof(AVCaptureFileOutput),
	typeof(NSUrl),
	typeof(NSObject[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPauseRecording", Selector = "captureOutput:didPauseRecordingToOutputFileAtURL:fromConnections:", ParameterType = new Type[]
{
	typeof(AVCaptureFileOutput),
	typeof(NSUrl),
	typeof(AVCaptureConnection[])
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResumeRecording", Selector = "captureOutput:didResumeRecordingToOutputFileAtURL:fromConnections:", ParameterType = new Type[]
{
	typeof(AVCaptureFileOutput),
	typeof(NSUrl),
	typeof(AVCaptureConnection[])
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillFinishRecording", Selector = "captureOutput:willFinishRecordingToOutputFileAtURL:fromConnections:error:", ParameterType = new Type[]
{
	typeof(AVCaptureFileOutput),
	typeof(NSUrl),
	typeof(AVCaptureConnection[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface IAVCaptureFileOutputRecordingDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("captureOutput:didFinishRecordingToOutputFileAtURL:fromConnections:error:")]
	[Preserve(Conditional = true)]
	void FinishedRecording(AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections, NSError? error);
}
