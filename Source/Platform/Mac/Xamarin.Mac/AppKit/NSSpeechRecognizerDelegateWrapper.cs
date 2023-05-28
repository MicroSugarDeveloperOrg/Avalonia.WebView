using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSSpeechRecognizerDelegateWrapper : BaseWrapper, INSSpeechRecognizerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSSpeechRecognizerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
