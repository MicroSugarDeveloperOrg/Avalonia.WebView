using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSCollectionViewDataSource_Extensions
{
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetNumberOfSections(this INSCollectionViewDataSource This, NSCollectionView collectionView)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		return Messaging.nint_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("numberOfSectionsInCollectionView:"), collectionView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSView GetView(this INSCollectionViewDataSource This, NSCollectionView collectionView, NSString kind, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (kind == null)
		{
			throw new ArgumentNullException("kind");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("collectionView:viewForSupplementaryElementOfKind:atIndexPath:"), collectionView.Handle, kind.Handle, indexPath.Handle));
	}
}
