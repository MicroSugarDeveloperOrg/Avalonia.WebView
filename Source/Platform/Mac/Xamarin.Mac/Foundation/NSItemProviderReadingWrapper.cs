using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSItemProviderReadingWrapper : BaseWrapper, INSItemProviderReading, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSItemProviderReadingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
