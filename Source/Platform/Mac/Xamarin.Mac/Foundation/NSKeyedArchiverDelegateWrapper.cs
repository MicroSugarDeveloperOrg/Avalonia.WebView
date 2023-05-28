using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSKeyedArchiverDelegateWrapper : BaseWrapper, INSKeyedArchiverDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSKeyedArchiverDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
