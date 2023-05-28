using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSCollectionViewDelegateFlowLayoutWrapper : BaseWrapper, INSCollectionViewDelegateFlowLayout, INativeObject, IDisposable, INSCollectionViewDelegate
{
	[Preserve(Conditional = true)]
	public NSCollectionViewDelegateFlowLayoutWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
