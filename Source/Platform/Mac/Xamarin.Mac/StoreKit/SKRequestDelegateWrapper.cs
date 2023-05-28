using System;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

internal sealed class SKRequestDelegateWrapper : BaseWrapper, ISKRequestDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SKRequestDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
