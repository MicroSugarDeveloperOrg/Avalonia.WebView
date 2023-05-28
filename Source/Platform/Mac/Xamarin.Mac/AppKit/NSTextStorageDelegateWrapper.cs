using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTextStorageDelegateWrapper : BaseWrapper, INSTextStorageDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTextStorageDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
