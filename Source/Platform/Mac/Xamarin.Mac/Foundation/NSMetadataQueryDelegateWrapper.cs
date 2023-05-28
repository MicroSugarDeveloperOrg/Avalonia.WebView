using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSMetadataQueryDelegateWrapper : BaseWrapper, INSMetadataQueryDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSMetadataQueryDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
