using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSSoundDelegate", WrapperType = typeof(NSSoundDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishPlaying", Selector = "sound:didFinishPlaying:", ParameterType = new Type[]
{
	typeof(NSSound),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
public interface INSSoundDelegate : INativeObject, IDisposable
{
}
