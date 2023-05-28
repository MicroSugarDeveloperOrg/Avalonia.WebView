using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSCollectionViewPrefetching_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CancelPrefetching(this INSCollectionViewPrefetching This, NSCollectionView collectionView, NSIndexPath[] indexPaths)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:cancelPrefetchingForItemsAtIndexPaths:"), collectionView.Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}
