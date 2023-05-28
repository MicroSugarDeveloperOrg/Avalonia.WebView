using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDiffableDataSourceSnapshot", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType> : NSObject, INSCopying, INativeObject, IDisposable where SectionIdentifierType : NSObject where ItemIdentifierType : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendItemsWithIdentifiers_ = "appendItemsWithIdentifiers:";

	private static readonly IntPtr selAppendItemsWithIdentifiers_Handle = Selector.GetHandle("appendItemsWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendItemsWithIdentifiers_IntoSectionWithIdentifier_ = "appendItemsWithIdentifiers:intoSectionWithIdentifier:";

	private static readonly IntPtr selAppendItemsWithIdentifiers_IntoSectionWithIdentifier_Handle = Selector.GetHandle("appendItemsWithIdentifiers:intoSectionWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendSectionsWithIdentifiers_ = "appendSectionsWithIdentifiers:";

	private static readonly IntPtr selAppendSectionsWithIdentifiers_Handle = Selector.GetHandle("appendSectionsWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteAllItems = "deleteAllItems";

	private static readonly IntPtr selDeleteAllItemsHandle = Selector.GetHandle("deleteAllItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteItemsWithIdentifiers_ = "deleteItemsWithIdentifiers:";

	private static readonly IntPtr selDeleteItemsWithIdentifiers_Handle = Selector.GetHandle("deleteItemsWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteSectionsWithIdentifiers_ = "deleteSectionsWithIdentifiers:";

	private static readonly IntPtr selDeleteSectionsWithIdentifiers_Handle = Selector.GetHandle("deleteSectionsWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemIdentifier_ = "indexOfItemIdentifier:";

	private static readonly IntPtr selIndexOfItemIdentifier_Handle = Selector.GetHandle("indexOfItemIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfSectionIdentifier_ = "indexOfSectionIdentifier:";

	private static readonly IntPtr selIndexOfSectionIdentifier_Handle = Selector.GetHandle("indexOfSectionIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertItemsWithIdentifiers_AfterItemWithIdentifier_ = "insertItemsWithIdentifiers:afterItemWithIdentifier:";

	private static readonly IntPtr selInsertItemsWithIdentifiers_AfterItemWithIdentifier_Handle = Selector.GetHandle("insertItemsWithIdentifiers:afterItemWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertItemsWithIdentifiers_BeforeItemWithIdentifier_ = "insertItemsWithIdentifiers:beforeItemWithIdentifier:";

	private static readonly IntPtr selInsertItemsWithIdentifiers_BeforeItemWithIdentifier_Handle = Selector.GetHandle("insertItemsWithIdentifiers:beforeItemWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSectionsWithIdentifiers_AfterSectionWithIdentifier_ = "insertSectionsWithIdentifiers:afterSectionWithIdentifier:";

	private static readonly IntPtr selInsertSectionsWithIdentifiers_AfterSectionWithIdentifier_Handle = Selector.GetHandle("insertSectionsWithIdentifiers:afterSectionWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSectionsWithIdentifiers_BeforeSectionWithIdentifier_ = "insertSectionsWithIdentifiers:beforeSectionWithIdentifier:";

	private static readonly IntPtr selInsertSectionsWithIdentifiers_BeforeSectionWithIdentifier_Handle = Selector.GetHandle("insertSectionsWithIdentifiers:beforeSectionWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemIdentifiers = "itemIdentifiers";

	private static readonly IntPtr selItemIdentifiersHandle = Selector.GetHandle("itemIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemIdentifiersInSectionWithIdentifier_ = "itemIdentifiersInSectionWithIdentifier:";

	private static readonly IntPtr selItemIdentifiersInSectionWithIdentifier_Handle = Selector.GetHandle("itemIdentifiersInSectionWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveItemWithIdentifier_AfterItemWithIdentifier_ = "moveItemWithIdentifier:afterItemWithIdentifier:";

	private static readonly IntPtr selMoveItemWithIdentifier_AfterItemWithIdentifier_Handle = Selector.GetHandle("moveItemWithIdentifier:afterItemWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveItemWithIdentifier_BeforeItemWithIdentifier_ = "moveItemWithIdentifier:beforeItemWithIdentifier:";

	private static readonly IntPtr selMoveItemWithIdentifier_BeforeItemWithIdentifier_Handle = Selector.GetHandle("moveItemWithIdentifier:beforeItemWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveSectionWithIdentifier_AfterSectionWithIdentifier_ = "moveSectionWithIdentifier:afterSectionWithIdentifier:";

	private static readonly IntPtr selMoveSectionWithIdentifier_AfterSectionWithIdentifier_Handle = Selector.GetHandle("moveSectionWithIdentifier:afterSectionWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveSectionWithIdentifier_BeforeSectionWithIdentifier_ = "moveSectionWithIdentifier:beforeSectionWithIdentifier:";

	private static readonly IntPtr selMoveSectionWithIdentifier_BeforeSectionWithIdentifier_Handle = Selector.GetHandle("moveSectionWithIdentifier:beforeSectionWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfItems = "numberOfItems";

	private static readonly IntPtr selNumberOfItemsHandle = Selector.GetHandle("numberOfItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfItemsInSection_ = "numberOfItemsInSection:";

	private static readonly IntPtr selNumberOfItemsInSection_Handle = Selector.GetHandle("numberOfItemsInSection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfSections = "numberOfSections";

	private static readonly IntPtr selNumberOfSectionsHandle = Selector.GetHandle("numberOfSections");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadItemsWithIdentifiers_ = "reloadItemsWithIdentifiers:";

	private static readonly IntPtr selReloadItemsWithIdentifiers_Handle = Selector.GetHandle("reloadItemsWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadSectionsWithIdentifiers_ = "reloadSectionsWithIdentifiers:";

	private static readonly IntPtr selReloadSectionsWithIdentifiers_Handle = Selector.GetHandle("reloadSectionsWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSectionIdentifierForSectionContainingItemIdentifier_ = "sectionIdentifierForSectionContainingItemIdentifier:";

	private static readonly IntPtr selSectionIdentifierForSectionContainingItemIdentifier_Handle = Selector.GetHandle("sectionIdentifierForSectionContainingItemIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSectionIdentifiers = "sectionIdentifiers";

	private static readonly IntPtr selSectionIdentifiersHandle = Selector.GetHandle("sectionIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDiffableDataSourceSnapshot");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ItemIdentifierType[] ItemIdentifiers
	{
		[Export("itemIdentifiers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<ItemIdentifierType>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemIdentifiersHandle));
			}
			return NSArray.ArrayFromHandle<ItemIdentifierType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemIdentifiersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfItems
	{
		[Export("numberOfItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfItemsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfItemsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfSections
	{
		[Export("numberOfSections")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfSectionsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfSectionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SectionIdentifierType[] SectionIdentifiers
	{
		[Export("sectionIdentifiers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SectionIdentifierType>(Messaging.IntPtr_objc_msgSend(base.Handle, selSectionIdentifiersHandle));
			}
			return NSArray.ArrayFromHandle<SectionIdentifierType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSectionIdentifiersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDiffableDataSourceSnapshot()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSDiffableDataSourceSnapshot(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDiffableDataSourceSnapshot(IntPtr handle)
		: base(handle)
	{
	}

	[Export("appendItemsWithIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendItems(ItemIdentifierType[] identifiers)
	{
		NSApplication.EnsureUIThread();
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromNSObjects(identifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendItemsWithIdentifiers_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendItemsWithIdentifiers_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("appendItemsWithIdentifiers:intoSectionWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendItems(ItemIdentifierType[] identifiers, SectionIdentifierType sectionIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		if (sectionIdentifier == null)
		{
			throw new ArgumentNullException("sectionIdentifier");
		}
		NSArray nSArray = NSArray.FromNSObjects(identifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAppendItemsWithIdentifiers_IntoSectionWithIdentifier_Handle, nSArray.Handle, sectionIdentifier.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAppendItemsWithIdentifiers_IntoSectionWithIdentifier_Handle, nSArray.Handle, sectionIdentifier.Handle);
		}
		nSArray.Dispose();
	}

	[Export("appendSectionsWithIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendSections(SectionIdentifierType[] sectionIdentifiers)
	{
		NSApplication.EnsureUIThread();
		if (sectionIdentifiers == null)
		{
			throw new ArgumentNullException("sectionIdentifiers");
		}
		NSArray nSArray = NSArray.FromNSObjects(sectionIdentifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendSectionsWithIdentifiers_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendSectionsWithIdentifiers_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("deleteAllItems")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteAllItems()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeleteAllItemsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeleteAllItemsHandle);
		}
	}

	[Export("deleteItemsWithIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteItems(ItemIdentifierType[] identifiers)
	{
		NSApplication.EnsureUIThread();
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromNSObjects(identifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteItemsWithIdentifiers_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteItemsWithIdentifiers_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("deleteSectionsWithIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteSections(SectionIdentifierType[] sectionIdentifiers)
	{
		NSApplication.EnsureUIThread();
		if (sectionIdentifiers == null)
		{
			throw new ArgumentNullException("sectionIdentifiers");
		}
		NSArray nSArray = NSArray.FromNSObjects(sectionIdentifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteSectionsWithIdentifiers_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteSectionsWithIdentifiers_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("indexOfItemIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetIndex(ItemIdentifierType itemIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfItemIdentifier_Handle, itemIdentifier.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemIdentifier_Handle, itemIdentifier.Handle);
	}

	[Export("indexOfSectionIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetIndex(SectionIdentifierType sectionIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (sectionIdentifier == null)
		{
			throw new ArgumentNullException("sectionIdentifier");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfSectionIdentifier_Handle, sectionIdentifier.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfSectionIdentifier_Handle, sectionIdentifier.Handle);
	}

	[Export("itemIdentifiersInSectionWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ItemIdentifierType[] GetItemIdentifiersInSection(SectionIdentifierType sectionIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (sectionIdentifier == null)
		{
			throw new ArgumentNullException("sectionIdentifier");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<ItemIdentifierType>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selItemIdentifiersInSectionWithIdentifier_Handle, sectionIdentifier.Handle));
		}
		return NSArray.ArrayFromHandle<ItemIdentifierType>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemIdentifiersInSectionWithIdentifier_Handle, sectionIdentifier.Handle));
	}

	[Export("numberOfItemsInSection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetNumberOfItems(SectionIdentifierType sectionIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (sectionIdentifier == null)
		{
			throw new ArgumentNullException("sectionIdentifier");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selNumberOfItemsInSection_Handle, sectionIdentifier.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selNumberOfItemsInSection_Handle, sectionIdentifier.Handle);
	}

	[Export("sectionIdentifierForSectionContainingItemIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SectionIdentifierType? GetSectionIdentifierForSection(ItemIdentifierType itemIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SectionIdentifierType>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSectionIdentifierForSectionContainingItemIdentifier_Handle, itemIdentifier.Handle));
		}
		return Runtime.GetNSObject<SectionIdentifierType>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSectionIdentifierForSectionContainingItemIdentifier_Handle, itemIdentifier.Handle));
	}

	[Export("insertItemsWithIdentifiers:afterItemWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertItemsAfter(ItemIdentifierType[] identifiers, ItemIdentifierType itemIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		NSArray nSArray = NSArray.FromNSObjects(identifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertItemsWithIdentifiers_AfterItemWithIdentifier_Handle, nSArray.Handle, itemIdentifier.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertItemsWithIdentifiers_AfterItemWithIdentifier_Handle, nSArray.Handle, itemIdentifier.Handle);
		}
		nSArray.Dispose();
	}

	[Export("insertItemsWithIdentifiers:beforeItemWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertItemsBefore(ItemIdentifierType[] identifiers, ItemIdentifierType itemIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		NSArray nSArray = NSArray.FromNSObjects(identifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertItemsWithIdentifiers_BeforeItemWithIdentifier_Handle, nSArray.Handle, itemIdentifier.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertItemsWithIdentifiers_BeforeItemWithIdentifier_Handle, nSArray.Handle, itemIdentifier.Handle);
		}
		nSArray.Dispose();
	}

	[Export("insertSectionsWithIdentifiers:afterSectionWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertSectionsAfter(SectionIdentifierType[] sectionIdentifiers, SectionIdentifierType toSectionIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (sectionIdentifiers == null)
		{
			throw new ArgumentNullException("sectionIdentifiers");
		}
		if (toSectionIdentifier == null)
		{
			throw new ArgumentNullException("toSectionIdentifier");
		}
		NSArray nSArray = NSArray.FromNSObjects(sectionIdentifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertSectionsWithIdentifiers_AfterSectionWithIdentifier_Handle, nSArray.Handle, toSectionIdentifier.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertSectionsWithIdentifiers_AfterSectionWithIdentifier_Handle, nSArray.Handle, toSectionIdentifier.Handle);
		}
		nSArray.Dispose();
	}

	[Export("insertSectionsWithIdentifiers:beforeSectionWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertSectionsBefore(SectionIdentifierType[] sectionIdentifiers, SectionIdentifierType toSectionIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (sectionIdentifiers == null)
		{
			throw new ArgumentNullException("sectionIdentifiers");
		}
		if (toSectionIdentifier == null)
		{
			throw new ArgumentNullException("toSectionIdentifier");
		}
		NSArray nSArray = NSArray.FromNSObjects(sectionIdentifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertSectionsWithIdentifiers_BeforeSectionWithIdentifier_Handle, nSArray.Handle, toSectionIdentifier.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertSectionsWithIdentifiers_BeforeSectionWithIdentifier_Handle, nSArray.Handle, toSectionIdentifier.Handle);
		}
		nSArray.Dispose();
	}

	[Export("moveItemWithIdentifier:afterItemWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveItemAfter(ItemIdentifierType fromIdentifier, ItemIdentifierType toIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (fromIdentifier == null)
		{
			throw new ArgumentNullException("fromIdentifier");
		}
		if (toIdentifier == null)
		{
			throw new ArgumentNullException("toIdentifier");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMoveItemWithIdentifier_AfterItemWithIdentifier_Handle, fromIdentifier.Handle, toIdentifier.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMoveItemWithIdentifier_AfterItemWithIdentifier_Handle, fromIdentifier.Handle, toIdentifier.Handle);
		}
	}

	[Export("moveItemWithIdentifier:beforeItemWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveItemBefore(ItemIdentifierType fromIdentifier, ItemIdentifierType toIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (fromIdentifier == null)
		{
			throw new ArgumentNullException("fromIdentifier");
		}
		if (toIdentifier == null)
		{
			throw new ArgumentNullException("toIdentifier");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMoveItemWithIdentifier_BeforeItemWithIdentifier_Handle, fromIdentifier.Handle, toIdentifier.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMoveItemWithIdentifier_BeforeItemWithIdentifier_Handle, fromIdentifier.Handle, toIdentifier.Handle);
		}
	}

	[Export("moveSectionWithIdentifier:afterSectionWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveSectionAfter(SectionIdentifierType fromSectionIdentifier, SectionIdentifierType toSectionIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (fromSectionIdentifier == null)
		{
			throw new ArgumentNullException("fromSectionIdentifier");
		}
		if (toSectionIdentifier == null)
		{
			throw new ArgumentNullException("toSectionIdentifier");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMoveSectionWithIdentifier_AfterSectionWithIdentifier_Handle, fromSectionIdentifier.Handle, toSectionIdentifier.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMoveSectionWithIdentifier_AfterSectionWithIdentifier_Handle, fromSectionIdentifier.Handle, toSectionIdentifier.Handle);
		}
	}

	[Export("moveSectionWithIdentifier:beforeSectionWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveSectionBefore(SectionIdentifierType fromSectionIdentifier, SectionIdentifierType toSectionIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (fromSectionIdentifier == null)
		{
			throw new ArgumentNullException("fromSectionIdentifier");
		}
		if (toSectionIdentifier == null)
		{
			throw new ArgumentNullException("toSectionIdentifier");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMoveSectionWithIdentifier_BeforeSectionWithIdentifier_Handle, fromSectionIdentifier.Handle, toSectionIdentifier.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMoveSectionWithIdentifier_BeforeSectionWithIdentifier_Handle, fromSectionIdentifier.Handle, toSectionIdentifier.Handle);
		}
	}

	[Export("reloadItemsWithIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadItems(ItemIdentifierType[] identifiers)
	{
		NSApplication.EnsureUIThread();
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromNSObjects(identifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReloadItemsWithIdentifiers_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReloadItemsWithIdentifiers_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("reloadSectionsWithIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadSections(SectionIdentifierType[] sectionIdentifiers)
	{
		NSApplication.EnsureUIThread();
		if (sectionIdentifiers == null)
		{
			throw new ArgumentNullException("sectionIdentifiers");
		}
		NSArray nSArray = NSArray.FromNSObjects(sectionIdentifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReloadSectionsWithIdentifiers_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReloadSectionsWithIdentifiers_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}
}
