using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVAudioPlayerDelegate", WrapperType = typeof(AVAudioPlayerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedPlaying", Selector = "audioPlayerDidFinishPlaying:successfully:", ParameterType = new Type[]
{
	typeof(AVAudioPlayer),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecoderError", Selector = "audioPlayerDecodeErrorDidOccur:error:", ParameterType = new Type[]
{
	typeof(AVAudioPlayer),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface IAVAudioPlayerDelegate : INativeObject, IDisposable
{
}
