using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVSpeechSynthesizerDelegate", WrapperType = typeof(AVSpeechSynthesizerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartSpeechUtterance", Selector = "speechSynthesizer:didStartSpeechUtterance:", ParameterType = new Type[]
{
	typeof(AVSpeechSynthesizer),
	typeof(AVSpeechUtterance)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishSpeechUtterance", Selector = "speechSynthesizer:didFinishSpeechUtterance:", ParameterType = new Type[]
{
	typeof(AVSpeechSynthesizer),
	typeof(AVSpeechUtterance)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPauseSpeechUtterance", Selector = "speechSynthesizer:didPauseSpeechUtterance:", ParameterType = new Type[]
{
	typeof(AVSpeechSynthesizer),
	typeof(AVSpeechUtterance)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidContinueSpeechUtterance", Selector = "speechSynthesizer:didContinueSpeechUtterance:", ParameterType = new Type[]
{
	typeof(AVSpeechSynthesizer),
	typeof(AVSpeechUtterance)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancelSpeechUtterance", Selector = "speechSynthesizer:didCancelSpeechUtterance:", ParameterType = new Type[]
{
	typeof(AVSpeechSynthesizer),
	typeof(AVSpeechUtterance)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSpeakRangeOfSpeechString", Selector = "speechSynthesizer:willSpeakRangeOfSpeechString:utterance:", ParameterType = new Type[]
{
	typeof(AVSpeechSynthesizer),
	typeof(NSRange),
	typeof(AVSpeechUtterance)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IAVSpeechSynthesizerDelegate : INativeObject, IDisposable
{
}
