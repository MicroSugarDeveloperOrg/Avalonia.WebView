using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSKeyedUnarchiverDelegateWrapper : BaseWrapper, INSKeyedUnarchiverDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSKeyedUnarchiverDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
