using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVSpeechSynthesizerDelegateWrapper : BaseWrapper, IAVSpeechSynthesizerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVSpeechSynthesizerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
