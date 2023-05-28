using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTextInputTraitsWrapper : BaseWrapper, INSTextInputTraits, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTextInputTraitsWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
