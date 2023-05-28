using System;
using Foundation;
using ObjCRuntime;

namespace Speech;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "SFSpeechRecognizerDelegate", WrapperType = typeof(SFSpeechRecognizerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AvailabilityDidChange", Selector = "speechRecognizer:availabilityDidChange:", ParameterType = new Type[]
{
	typeof(SFSpeechRecognizer),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
public interface ISFSpeechRecognizerDelegate : INativeObject, IDisposable
{
}
