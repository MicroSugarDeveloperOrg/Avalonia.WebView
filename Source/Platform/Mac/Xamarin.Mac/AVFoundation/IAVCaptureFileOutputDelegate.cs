using System;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol(Name = "AVCaptureFileOutputDelegate", WrapperType = typeof(AVCaptureFileOutputDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShouldProvideSampleAccurateRecordingStart", Selector = "captureOutputShouldProvideSampleAccurateRecordingStart:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(AVCaptureOutput) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputSampleBuffer", Selector = "captureOutput:didOutputSampleBuffer:fromConnection:", ParameterType = new Type[]
{
	typeof(AVCaptureOutput),
	typeof(CMSampleBuffer),
	typeof(AVCaptureConnection)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IAVCaptureFileOutputDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("captureOutputShouldProvideSampleAccurateRecordingStart:")]
	[Preserve(Conditional = true)]
	bool ShouldProvideSampleAccurateRecordingStart(AVCaptureOutput captureOutput);
}
