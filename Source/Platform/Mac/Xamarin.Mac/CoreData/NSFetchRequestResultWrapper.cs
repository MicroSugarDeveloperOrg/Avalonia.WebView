using System;
using Foundation;
using ObjCRuntime;

namespace CoreData;

internal sealed class NSFetchRequestResultWrapper : BaseWrapper, INSFetchRequestResult, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSFetchRequestResultWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
