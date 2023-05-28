using System;
using Foundation;
using ObjCRuntime;

namespace Speech;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "SFSpeechRecognitionTaskDelegate", WrapperType = typeof(SFSpeechRecognitionTaskDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDetectSpeech", Selector = "speechRecognitionDidDetectSpeech:", ParameterType = new Type[] { typeof(SFSpeechRecognitionTask) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHypothesizeTranscription", Selector = "speechRecognitionTask:didHypothesizeTranscription:", ParameterType = new Type[]
{
	typeof(SFSpeechRecognitionTask),
	typeof(SFTranscription)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishRecognition", Selector = "speechRecognitionTask:didFinishRecognition:", ParameterType = new Type[]
{
	typeof(SFSpeechRecognitionTask),
	typeof(SFSpeechRecognitionResult)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedReadingAudio", Selector = "speechRecognitionTaskFinishedReadingAudio:", ParameterType = new Type[] { typeof(SFSpeechRecognitionTask) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WasCancelled", Selector = "speechRecognitionTaskWasCancelled:", ParameterType = new Type[] { typeof(SFSpeechRecognitionTask) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishSuccessfully", Selector = "speechRecognitionTask:didFinishSuccessfully:", ParameterType = new Type[]
{
	typeof(SFSpeechRecognitionTask),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
public interface ISFSpeechRecognitionTaskDelegate : INativeObject, IDisposable
{
}
