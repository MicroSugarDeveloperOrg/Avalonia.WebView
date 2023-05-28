using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSCollectionViewDelegateWrapper : BaseWrapper, INSCollectionViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSCollectionViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
