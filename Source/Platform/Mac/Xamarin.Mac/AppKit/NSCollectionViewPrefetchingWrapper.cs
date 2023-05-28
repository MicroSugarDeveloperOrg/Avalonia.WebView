using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSCollectionViewPrefetchingWrapper : BaseWrapper, INSCollectionViewPrefetching, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSCollectionViewPrefetchingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("collectionView:prefetchItemsAtIndexPaths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PrefetchItems(NSCollectionView collectionView, NSIndexPath[] indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		NSArray nSArray = NSArray.FromNSObjects(indexPaths);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("collectionView:prefetchItemsAtIndexPaths:"), collectionView.Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}
