using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSSpeechRecognizerDelegate", WrapperType = typeof(NSSpeechRecognizerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRecognizeCommand", Selector = "speechRecognizer:didRecognizeCommand:", ParameterType = new Type[]
{
	typeof(NSSpeechRecognizer),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface INSSpeechRecognizerDelegate : INativeObject, IDisposable
{
}
