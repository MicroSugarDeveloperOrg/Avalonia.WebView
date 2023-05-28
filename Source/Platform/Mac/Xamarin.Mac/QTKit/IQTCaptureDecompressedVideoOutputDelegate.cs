using System;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Protocol(Name = "QTCaptureDecompressedVideoOutput_Delegate", WrapperType = typeof(QTCaptureDecompressedVideoOutputDelegateWrapper), IsInformal = true)]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputVideoFrame", Selector = "captureOutput:didOutputVideoFrame:withSampleBuffer:fromConnection:", ParameterType = new Type[]
{
	typeof(QTCaptureOutput),
	typeof(CVImageBuffer),
	typeof(QTSampleBuffer),
	typeof(QTCaptureConnection)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDropVideoFrame", Selector = "captureOutput:didDropVideoFrameWithSampleBuffer:fromConnection:", ParameterType = new Type[]
{
	typeof(QTCaptureOutput),
	typeof(QTSampleBuffer),
	typeof(QTCaptureConnection)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IQTCaptureDecompressedVideoOutputDelegate : INativeObject, IDisposable
{
}
