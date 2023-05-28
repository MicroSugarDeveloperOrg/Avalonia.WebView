using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUserActivityDelegateWrapper : BaseWrapper, INSUserActivityDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSUserActivityDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
