using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSCollectionViewDelegateFlowLayout_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize SizeForItem(this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (collectionViewLayout == null)
		{
			throw new ArgumentNullException("collectionViewLayout");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		return Messaging.CGSize_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:layout:sizeForItemAtIndexPath:"), collectionView.Handle, collectionViewLayout.Handle, indexPath.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSEdgeInsets InsetForSection(this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (collectionViewLayout == null)
		{
			throw new ArgumentNullException("collectionViewLayout");
		}
		Messaging.NSEdgeInsets_objc_msgSend_stret_IntPtr_IntPtr_nint(out var retval, This.Handle, Selector.GetHandle("collectionView:layout:insetForSectionAtIndex:"), collectionView.Handle, collectionViewLayout.Handle, section);
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat MinimumLineSpacing(this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (collectionViewLayout == null)
		{
			throw new ArgumentNullException("collectionViewLayout");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("collectionView:layout:minimumLineSpacingForSectionAtIndex:"), collectionView.Handle, collectionViewLayout.Handle, section);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat MinimumInteritemSpacingForSection(this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (collectionViewLayout == null)
		{
			throw new ArgumentNullException("collectionViewLayout");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:"), collectionView.Handle, collectionViewLayout.Handle, section);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize ReferenceSizeForHeader(this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (collectionViewLayout == null)
		{
			throw new ArgumentNullException("collectionViewLayout");
		}
		return Messaging.CGSize_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("collectionView:layout:referenceSizeForHeaderInSection:"), collectionView.Handle, collectionViewLayout.Handle, section);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize ReferenceSizeForFooter(this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (collectionViewLayout == null)
		{
			throw new ArgumentNullException("collectionViewLayout");
		}
		return Messaging.CGSize_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("collectionView:layout:referenceSizeForFooterInSection:"), collectionView.Handle, collectionViewLayout.Handle, section);
	}
}
