using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSSpeechSynthesizerDelegate", WrapperType = typeof(NSSpeechSynthesizerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishSpeaking", Selector = "speechSynthesizer:didFinishSpeaking:", ParameterType = new Type[]
{
	typeof(NSSpeechSynthesizer),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSpeakWord", Selector = "speechSynthesizer:willSpeakWord:ofString:", ParameterType = new Type[]
{
	typeof(NSSpeechSynthesizer),
	typeof(NSRange),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSpeakPhoneme", Selector = "speechSynthesizer:willSpeakPhoneme:", ParameterType = new Type[]
{
	typeof(NSSpeechSynthesizer),
	typeof(short)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEncounterError", Selector = "speechSynthesizer:didEncounterErrorAtIndex:ofString:message:", ParameterType = new Type[]
{
	typeof(NSSpeechSynthesizer),
	typeof(nuint),
	typeof(string),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEncounterSyncMessage", Selector = "speechSynthesizer:didEncounterSyncMessage:", ParameterType = new Type[]
{
	typeof(NSSpeechSynthesizer),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface INSSpeechSynthesizerDelegate : INativeObject, IDisposable
{
}
