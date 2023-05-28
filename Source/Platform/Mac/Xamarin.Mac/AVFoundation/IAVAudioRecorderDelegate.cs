using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVAudioRecorderDelegate", WrapperType = typeof(AVAudioRecorderDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedRecording", Selector = "audioRecorderDidFinishRecording:successfully:", ParameterType = new Type[]
{
	typeof(AVAudioRecorder),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EncoderError", Selector = "audioRecorderEncodeErrorDidOccur:error:", ParameterType = new Type[]
{
	typeof(AVAudioRecorder),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface IAVAudioRecorderDelegate : INativeObject, IDisposable
{
}
