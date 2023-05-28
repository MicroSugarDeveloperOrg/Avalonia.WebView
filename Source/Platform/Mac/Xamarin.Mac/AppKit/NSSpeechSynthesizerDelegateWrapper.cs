using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSSpeechSynthesizerDelegateWrapper : BaseWrapper, INSSpeechSynthesizerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSSpeechSynthesizerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
