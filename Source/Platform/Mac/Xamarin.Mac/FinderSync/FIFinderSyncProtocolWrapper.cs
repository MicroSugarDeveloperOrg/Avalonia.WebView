using System;
using Foundation;
using ObjCRuntime;

namespace FinderSync;

internal sealed class FIFinderSyncProtocolWrapper : BaseWrapper, IFIFinderSyncProtocol, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public FIFinderSyncProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
