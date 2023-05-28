using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSCollectionViewSectionHeaderViewWrapper : BaseWrapper, INSCollectionViewSectionHeaderView, INativeObject, IDisposable, INSCollectionViewElement, INSUserInterfaceItemIdentification
{
	[Preserve(Conditional = true)]
	public NSCollectionViewSectionHeaderViewWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
