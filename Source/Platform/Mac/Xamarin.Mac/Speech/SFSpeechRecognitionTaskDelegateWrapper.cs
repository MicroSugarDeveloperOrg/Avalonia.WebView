using System;
using Foundation;
using ObjCRuntime;

namespace Speech;

internal sealed class SFSpeechRecognitionTaskDelegateWrapper : BaseWrapper, ISFSpeechRecognitionTaskDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SFSpeechRecognitionTaskDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
