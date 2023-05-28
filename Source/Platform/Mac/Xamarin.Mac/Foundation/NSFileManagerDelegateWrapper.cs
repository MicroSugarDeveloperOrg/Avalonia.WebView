using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSFileManagerDelegateWrapper : BaseWrapper, INSFileManagerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSFileManagerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
