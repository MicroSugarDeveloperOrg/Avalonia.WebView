using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSCacheDelegateWrapper : BaseWrapper, INSCacheDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSCacheDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
