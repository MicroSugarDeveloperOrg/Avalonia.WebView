using System;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Protocol(Name = "QTCaptureFileOutput_Delegate", WrapperType = typeof(QTCaptureFileOutputDelegateWrapper), IsInformal = true)]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputSampleBuffer", Selector = "captureOutput:didOutputSampleBuffer:fromConnection:", ParameterType = new Type[]
{
	typeof(QTCaptureFileOutput),
	typeof(QTSampleBuffer),
	typeof(QTCaptureConnection)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartRecording", Selector = "captureOutput:willStartRecordingToOutputFileAtURL:forConnections:", ParameterType = new Type[]
{
	typeof(QTCaptureFileOutput),
	typeof(NSUrl),
	typeof(QTCaptureConnection[])
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartRecording", Selector = "captureOutput:didStartRecordingToOutputFileAtURL:forConnections:", ParameterType = new Type[]
{
	typeof(QTCaptureFileOutput),
	typeof(NSUrl),
	typeof(QTCaptureConnection[])
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeOutputFile", Selector = "captureOutput:shouldChangeOutputFileAtURL:forConnections:dueToError:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(QTCaptureFileOutput),
	typeof(NSUrl),
	typeof(QTCaptureConnection[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MustChangeOutputFile", Selector = "captureOutput:mustChangeOutputFileAtURL:forConnections:dueToError:", ParameterType = new Type[]
{
	typeof(QTCaptureFileOutput),
	typeof(NSUrl),
	typeof(QTCaptureConnection[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillFinishRecording", Selector = "captureOutput:willFinishRecordingToOutputFileAtURL:forConnections:dueToError:", ParameterType = new Type[]
{
	typeof(QTCaptureFileOutput),
	typeof(NSUrl),
	typeof(QTCaptureConnection[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishRecording", Selector = "captureOutput:didFinishRecordingToOutputFileAtURL:forConnections:dueToError:", ParameterType = new Type[]
{
	typeof(QTCaptureFileOutput),
	typeof(NSUrl),
	typeof(QTCaptureConnection[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPauseRecording", Selector = "captureOutput:didPauseRecordingToOutputFileAtURL:forConnections:", ParameterType = new Type[]
{
	typeof(QTCaptureFileOutput),
	typeof(NSUrl),
	typeof(QTCaptureConnection[])
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResumeRecording", Selector = "captureOutput:didResumeRecordingToOutputFileAtURL:forConnections:", ParameterType = new Type[]
{
	typeof(QTCaptureFileOutput),
	typeof(NSUrl),
	typeof(QTCaptureConnection[])
}, ParameterByRef = new bool[] { false, false, false })]
public interface IQTCaptureFileOutputDelegate : INativeObject, IDisposable
{
}
