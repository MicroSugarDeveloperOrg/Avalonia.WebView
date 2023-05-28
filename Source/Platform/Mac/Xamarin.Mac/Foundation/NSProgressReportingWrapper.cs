using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSProgressReportingWrapper : BaseWrapper, INSProgressReporting, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSProgressReportingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
