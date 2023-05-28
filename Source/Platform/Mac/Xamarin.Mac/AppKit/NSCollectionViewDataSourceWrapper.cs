using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSCollectionViewDataSourceWrapper : BaseWrapper, INSCollectionViewDataSource, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSCollectionViewDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("collectionView:numberOfItemsInSection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint GetNumberofItems(NSCollectionView collectionView, nint section)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		return Messaging.nint_objc_msgSend_IntPtr_nint(base.Handle, Selector.GetHandle("collectionView:numberOfItemsInSection:"), collectionView.Handle, section);
	}

	[Export("collectionView:itemForRepresentedObjectAtIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCollectionViewItem GetItem(NSCollectionView collectionView, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		return Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("collectionView:itemForRepresentedObjectAtIndexPath:"), collectionView.Handle, indexPath.Handle));
	}
}
