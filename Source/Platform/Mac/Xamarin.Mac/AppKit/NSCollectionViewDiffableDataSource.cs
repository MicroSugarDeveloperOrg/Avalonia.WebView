using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSCollectionViewDiffableDataSource", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionViewDiffableDataSource<SectionIdentifierType, ItemIdentifierType> : NSObject, INSCollectionViewDataSource, INativeObject, IDisposable where SectionIdentifierType : NSObject where ItemIdentifierType : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplySnapshot_AnimatingDifferences_ = "applySnapshot:animatingDifferences:";

	private static readonly IntPtr selApplySnapshot_AnimatingDifferences_Handle = Selector.GetHandle("applySnapshot:animatingDifferences:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollectionView_ItemForRepresentedObjectAtIndexPath_ = "collectionView:itemForRepresentedObjectAtIndexPath:";

	private static readonly IntPtr selCollectionView_ItemForRepresentedObjectAtIndexPath_Handle = Selector.GetHandle("collectionView:itemForRepresentedObjectAtIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollectionView_NumberOfItemsInSection_ = "collectionView:numberOfItemsInSection:";

	private static readonly IntPtr selCollectionView_NumberOfItemsInSection_Handle = Selector.GetHandle("collectionView:numberOfItemsInSection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollectionView_ViewForSupplementaryElementOfKind_AtIndexPath_ = "collectionView:viewForSupplementaryElementOfKind:atIndexPath:";

	private static readonly IntPtr selCollectionView_ViewForSupplementaryElementOfKind_AtIndexPath_Handle = Selector.GetHandle("collectionView:viewForSupplementaryElementOfKind:atIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathForItemIdentifier_ = "indexPathForItemIdentifier:";

	private static readonly IntPtr selIndexPathForItemIdentifier_Handle = Selector.GetHandle("indexPathForItemIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCollectionView_ItemProvider_ = "initWithCollectionView:itemProvider:";

	private static readonly IntPtr selInitWithCollectionView_ItemProvider_Handle = Selector.GetHandle("initWithCollectionView:itemProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemIdentifierForIndexPath_ = "itemIdentifierForIndexPath:";

	private static readonly IntPtr selItemIdentifierForIndexPath_Handle = Selector.GetHandle("itemIdentifierForIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfSectionsInCollectionView_ = "numberOfSectionsInCollectionView:";

	private static readonly IntPtr selNumberOfSectionsInCollectionView_Handle = Selector.GetHandle("numberOfSectionsInCollectionView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSupplementaryViewProvider_ = "setSupplementaryViewProvider:";

	private static readonly IntPtr selSetSupplementaryViewProvider_Handle = Selector.GetHandle("setSupplementaryViewProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSnapshot = "snapshot";

	private static readonly IntPtr selSnapshotHandle = Selector.GetHandle("snapshot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupplementaryViewProvider = "supplementaryViewProvider";

	private static readonly IntPtr selSupplementaryViewProviderHandle = Selector.GetHandle("supplementaryViewProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionViewDiffableDataSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType> Snapshot
	{
		[Export("snapshot")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType>>(Messaging.IntPtr_objc_msgSend(base.Handle, selSnapshotHandle));
			}
			return Runtime.GetNSObject<NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSnapshotHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSCollectionViewDiffableDataSourceSupplementaryViewProvider? SupplementaryViewProvider
	{
		[Export("supplementaryViewProvider", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDNSCollectionViewDiffableDataSourceSupplementaryViewProvider))]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupplementaryViewProviderHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selSupplementaryViewProviderHandle));
			return Trampolines.NIDNSCollectionViewDiffableDataSourceSupplementaryViewProvider.Create(block);
		}
		[Export("setSupplementaryViewProvider:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDNSCollectionViewDiffableDataSourceSupplementaryViewProvider))]
		set
		{
			NSApplication.EnsureUIThread();
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNSCollectionViewDiffableDataSourceSupplementaryViewProvider.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSupplementaryViewProvider_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSupplementaryViewProvider_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionViewDiffableDataSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewDiffableDataSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCollectionView:itemProvider:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe NSCollectionViewDiffableDataSource(NSCollectionView collectionView, [BlockProxy(typeof(Trampolines.NIDNSCollectionViewDiffableDataSourceItemProvider))] NSCollectionViewDiffableDataSourceItemProvider itemProvider)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (itemProvider == null)
		{
			throw new ArgumentNullException("itemProvider");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSCollectionViewDiffableDataSourceItemProvider.Handler, itemProvider);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCollectionView_ItemProvider_Handle, collectionView.Handle, (IntPtr)ptr), "initWithCollectionView:itemProvider:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCollectionView_ItemProvider_Handle, collectionView.Handle, (IntPtr)ptr), "initWithCollectionView:itemProvider:");
		}
		ptr->CleanupBlock();
	}

	[Export("applySnapshot:animatingDifferences:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Apply(NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType> snapshot, bool animatingDifferences)
	{
		NSApplication.EnsureUIThread();
		if (snapshot == null)
		{
			throw new ArgumentNullException("snapshot");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selApplySnapshot_AnimatingDifferences_Handle, snapshot.Handle, animatingDifferences);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selApplySnapshot_AnimatingDifferences_Handle, snapshot.Handle, animatingDifferences);
		}
	}

	[Export("indexPathForItemIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexPath? GetIndexPath(ItemIdentifierType identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIndexPathForItemIdentifier_Handle, identifier.Handle));
		}
		return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexPathForItemIdentifier_Handle, identifier.Handle));
	}

	[Export("collectionView:itemForRepresentedObjectAtIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewItem GetItem(NSCollectionView collectionView, NSIndexPath indexPath)
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
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCollectionView_ItemForRepresentedObjectAtIndexPath_Handle, collectionView.Handle, indexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCollectionView_ItemForRepresentedObjectAtIndexPath_Handle, collectionView.Handle, indexPath.Handle));
	}

	[Export("itemIdentifierForIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ItemIdentifierType? GetItemIdentifier(NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<ItemIdentifierType>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selItemIdentifierForIndexPath_Handle, indexPath.Handle));
		}
		return Runtime.GetNSObject<ItemIdentifierType>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemIdentifierForIndexPath_Handle, indexPath.Handle));
	}

	[Export("numberOfSectionsInCollectionView:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetNumberOfSections(NSCollectionView collectionView)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selNumberOfSectionsInCollectionView_Handle, collectionView.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selNumberOfSectionsInCollectionView_Handle, collectionView.Handle);
	}

	[Export("collectionView:numberOfItemsInSection:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetNumberofItems(NSCollectionView collectionView, nint section)
	{
		NSApplication.EnsureUIThread();
		if (collectionView == null)
		{
			throw new ArgumentNullException("collectionView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr_nint(base.Handle, selCollectionView_NumberOfItemsInSection_Handle, collectionView.Handle, section);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selCollectionView_NumberOfItemsInSection_Handle, collectionView.Handle, section);
	}

	[Export("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView GetView(NSCollectionView collectionView, NSString kind, NSIndexPath indexPath)
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
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCollectionView_ViewForSupplementaryElementOfKind_AtIndexPath_Handle, collectionView.Handle, kind.Handle, indexPath.Handle));
		}
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCollectionView_ViewForSupplementaryElementOfKind_AtIndexPath_Handle, collectionView.Handle, kind.Handle, indexPath.Handle));
	}
}
