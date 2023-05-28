using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTextInputClientWrapper : BaseWrapper, INSTextInputClient, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTextInputClientWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
