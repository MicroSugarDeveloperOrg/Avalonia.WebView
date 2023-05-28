using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSCollectionViewElementWrapper : BaseWrapper, INSCollectionViewElement, INativeObject, IDisposable, INSUserInterfaceItemIdentification
{
	[Preserve(Conditional = true)]
	public NSCollectionViewElementWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
