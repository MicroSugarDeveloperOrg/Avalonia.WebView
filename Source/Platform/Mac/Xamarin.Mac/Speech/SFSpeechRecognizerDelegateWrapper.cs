using System;
using Foundation;
using ObjCRuntime;

namespace Speech;

internal sealed class SFSpeechRecognizerDelegateWrapper : BaseWrapper, ISFSpeechRecognizerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SFSpeechRecognizerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
