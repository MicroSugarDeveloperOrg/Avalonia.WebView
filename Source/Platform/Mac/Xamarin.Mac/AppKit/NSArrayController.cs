using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSArrayController", true)]
public class NSArrayController : NSObjectController
{
	private static readonly IntPtr selAutomaticallyRearrangesObjectsHandle = Selector.GetHandle("automaticallyRearrangesObjects");

	private static readonly IntPtr selSetAutomaticallyRearrangesObjects_Handle = Selector.GetHandle("setAutomaticallyRearrangesObjects:");

	private static readonly IntPtr selSortDescriptorsHandle = Selector.GetHandle("sortDescriptors");

	private static readonly IntPtr selSetSortDescriptors_Handle = Selector.GetHandle("setSortDescriptors:");

	private static readonly IntPtr selFilterPredicateHandle = Selector.GetHandle("filterPredicate");

	private static readonly IntPtr selSetFilterPredicate_Handle = Selector.GetHandle("setFilterPredicate:");

	private static readonly IntPtr selClearsFilterPredicateOnInsertionHandle = Selector.GetHandle("clearsFilterPredicateOnInsertion");

	private static readonly IntPtr selSetClearsFilterPredicateOnInsertion_Handle = Selector.GetHandle("setClearsFilterPredicateOnInsertion:");

	private static readonly IntPtr selAvoidsEmptySelectionHandle = Selector.GetHandle("avoidsEmptySelection");

	private static readonly IntPtr selSetAvoidsEmptySelection_Handle = Selector.GetHandle("setAvoidsEmptySelection:");

	private static readonly IntPtr selPreservesSelectionHandle = Selector.GetHandle("preservesSelection");

	private static readonly IntPtr selSetPreservesSelection_Handle = Selector.GetHandle("setPreservesSelection:");

	private static readonly IntPtr selSelectsInsertedObjectsHandle = Selector.GetHandle("selectsInsertedObjects");

	private static readonly IntPtr selSetSelectsInsertedObjects_Handle = Selector.GetHandle("setSelectsInsertedObjects:");

	private static readonly IntPtr selAlwaysUsesMultipleValuesMarkerHandle = Selector.GetHandle("alwaysUsesMultipleValuesMarker");

	private static readonly IntPtr selSetAlwaysUsesMultipleValuesMarker_Handle = Selector.GetHandle("setAlwaysUsesMultipleValuesMarker:");

	private static readonly IntPtr selRearrangeObjectsHandle = Selector.GetHandle("rearrangeObjects");

	private static readonly IntPtr selAutomaticRearrangementKeyPathsHandle = Selector.GetHandle("automaticRearrangementKeyPaths");

	private static readonly IntPtr selDidChangeArrangementCriteriaHandle = Selector.GetHandle("didChangeArrangementCriteria");

	private static readonly IntPtr selArrangeObjects_Handle = Selector.GetHandle("arrangeObjects:");

	private static readonly IntPtr selArrangedObjectsHandle = Selector.GetHandle("arrangedObjects");

	private static readonly IntPtr selAddSelectionIndexes_Handle = Selector.GetHandle("addSelectionIndexes:");

	private static readonly IntPtr selRemoveSelectionIndexes_Handle = Selector.GetHandle("removeSelectionIndexes:");

	private static readonly IntPtr selAddSelectedObjects_Handle = Selector.GetHandle("addSelectedObjects:");

	private static readonly IntPtr selRemoveSelectedObjects_Handle = Selector.GetHandle("removeSelectedObjects:");

	private static readonly IntPtr selAdd_Handle = Selector.GetHandle("add:");

	private static readonly IntPtr selRemove_Handle = Selector.GetHandle("remove:");

	private static readonly IntPtr selInsert_Handle = Selector.GetHandle("insert:");

	private static readonly IntPtr selCanInsertHandle = Selector.GetHandle("canInsert");

	private static readonly IntPtr selSelectNext_Handle = Selector.GetHandle("selectNext:");

	private static readonly IntPtr selSelectPrevious_Handle = Selector.GetHandle("selectPrevious:");

	private static readonly IntPtr selCanSelectNextHandle = Selector.GetHandle("canSelectNext");

	private static readonly IntPtr selCanSelectPreviousHandle = Selector.GetHandle("canSelectPrevious");

	private static readonly IntPtr selAddObject_Handle = Selector.GetHandle("addObject:");

	private static readonly IntPtr selAddObjects_Handle = Selector.GetHandle("addObjects:");

	private static readonly IntPtr selInsertObjectAtArrangedObjectIndex_Handle = Selector.GetHandle("insertObject:atArrangedObjectIndex:");

	private static readonly IntPtr selInsertObjectsAtArrangedObjectIndexes_Handle = Selector.GetHandle("insertObjects:atArrangedObjectIndexes:");

	private static readonly IntPtr selRemoveObjectAtArrangedObjectIndex_Handle = Selector.GetHandle("removeObjectAtArrangedObjectIndex:");

	private static readonly IntPtr selRemoveObjectsAtArrangedObjectIndexes_Handle = Selector.GetHandle("removeObjectsAtArrangedObjectIndexes:");

	private static readonly IntPtr selRemoveObject_Handle = Selector.GetHandle("removeObject:");

	private static readonly IntPtr selRemoveObjects_Handle = Selector.GetHandle("removeObjects:");

	private static readonly IntPtr selSelectionIndexesHandle = Selector.GetHandle("selectionIndexes");

	private static readonly IntPtr selSetSelectionIndexes_Handle = Selector.GetHandle("setSelectionIndexes:");

	private static readonly IntPtr selSelectionIndexHandle = Selector.GetHandle("selectionIndex");

	private static readonly IntPtr selSetSelectionIndex_Handle = Selector.GetHandle("setSelectionIndex:");

	private static readonly IntPtr selSelectedObjectsHandle = Selector.GetHandle("selectedObjects");

	private static readonly IntPtr selSetSelectedObjects_Handle = Selector.GetHandle("setSelectedObjects:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSArrayController");

	private object __mt_SortDescriptors_var;

	private object __mt_FilterPredicate_var;

	public NSIndexSet SelectionIndexes
	{
		get
		{
			return GetSelectionIndexes();
		}
		set
		{
			SetSelectionIndexes(value);
		}
	}

	public int SelectionIndex
	{
		get
		{
			return (int)GetSelectionIndex();
		}
		set
		{
			SetSelectionIndex((uint)value);
		}
	}

	public new NSObject[] SelectedObjects
	{
		get
		{
			return GetSelectedObjects();
		}
		set
		{
			SetSelectedObjects(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool AutomaticallyRearrangesObjects
	{
		[Export("automaticallyRearrangesObjects")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyRearrangesObjectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyRearrangesObjectsHandle);
		}
		[Export("setAutomaticallyRearrangesObjects:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyRearrangesObjects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyRearrangesObjects_Handle, value);
			}
		}
	}

	public virtual NSObject[] SortDescriptors
	{
		[Export("sortDescriptors")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject[])(__mt_SortDescriptors_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorsHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorsHandle))));
		}
		[Export("setSortDescriptors:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_SortDescriptors_var = value;
		}
	}

	public virtual NSPredicate FilterPredicate
	{
		[Export("filterPredicate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPredicate)(__mt_FilterPredicate_var = ((!IsDirectBinding) ? ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterPredicateHandle))) : ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterPredicateHandle)))));
		}
		[Export("setFilterPredicate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFilterPredicate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFilterPredicate_Handle, value.Handle);
			}
			__mt_FilterPredicate_var = value;
		}
	}

	public virtual bool ClearsFilterPredicateOnInsertion
	{
		[Export("clearsFilterPredicateOnInsertion")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selClearsFilterPredicateOnInsertionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selClearsFilterPredicateOnInsertionHandle);
		}
		[Export("setClearsFilterPredicateOnInsertion:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetClearsFilterPredicateOnInsertion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetClearsFilterPredicateOnInsertion_Handle, value);
			}
		}
	}

	public virtual bool AvoidsEmptySelection
	{
		[Export("avoidsEmptySelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAvoidsEmptySelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAvoidsEmptySelectionHandle);
		}
		[Export("setAvoidsEmptySelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAvoidsEmptySelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAvoidsEmptySelection_Handle, value);
			}
		}
	}

	public virtual bool PreservesSelection
	{
		[Export("preservesSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesSelectionHandle);
		}
		[Export("setPreservesSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesSelection_Handle, value);
			}
		}
	}

	public virtual bool SelectsInsertedObjects
	{
		[Export("selectsInsertedObjects")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSelectsInsertedObjectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSelectsInsertedObjectsHandle);
		}
		[Export("setSelectsInsertedObjects:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectsInsertedObjects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectsInsertedObjects_Handle, value);
			}
		}
	}

	public virtual bool AlwaysUsesMultipleValuesMarker
	{
		[Export("alwaysUsesMultipleValuesMarker")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysUsesMultipleValuesMarkerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysUsesMultipleValuesMarkerHandle);
		}
		[Export("setAlwaysUsesMultipleValuesMarker:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysUsesMultipleValuesMarker_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysUsesMultipleValuesMarker_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSArrayController()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSArrayController(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSArrayController(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSArrayController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("rearrangeObjects")]
	public virtual void RearrangeObjects()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRearrangeObjectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRearrangeObjectsHandle);
		}
	}

	[Export("automaticRearrangementKeyPaths")]
	public virtual NSObject[] AutomaticRearrangementKeyPaths()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAutomaticRearrangementKeyPathsHandle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutomaticRearrangementKeyPathsHandle));
	}

	[Export("didChangeArrangementCriteria")]
	public virtual void DidChangeArrangementCriteria()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidChangeArrangementCriteriaHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidChangeArrangementCriteriaHandle);
		}
	}

	[Export("arrangeObjects:")]
	public virtual NSObject[] ArrangeObjects(NSObject[] objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		NSObject[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selArrangeObjects_Handle, nSArray.Handle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selArrangeObjects_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("arrangedObjects")]
	public virtual NSObject[] ArrangedObjects()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selArrangedObjectsHandle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrangedObjectsHandle));
	}

	[Export("addSelectionIndexes:")]
	public virtual bool AddSelectionIndexes(NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAddSelectionIndexes_Handle, indexes.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSelectionIndexes_Handle, indexes.Handle);
	}

	[Export("removeSelectionIndexes:")]
	public virtual bool RemoveSelectionIndexes(NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemoveSelectionIndexes_Handle, indexes.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveSelectionIndexes_Handle, indexes.Handle);
	}

	[Export("addSelectedObjects:")]
	public virtual bool AddSelectedObjects(NSObject[] objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSelectedObjects_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAddSelectedObjects_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("removeSelectedObjects:")]
	public virtual bool RemoveSelectedObjects(NSObject[] objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveSelectedObjects_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemoveSelectedObjects_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("add:")]
	public new virtual void Add(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAdd_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAdd_Handle, sender.Handle);
		}
	}

	[Export("remove:")]
	public virtual void RemoveOp(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemove_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemove_Handle, sender.Handle);
		}
	}

	[Export("insert:")]
	public virtual void Insert(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsert_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsert_Handle, sender.Handle);
		}
	}

	[Export("canInsert")]
	public virtual bool CanInsert()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanInsertHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanInsertHandle);
	}

	[Export("selectNext:")]
	public virtual void SelectNext(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNext_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNext_Handle, sender.Handle);
		}
	}

	[Export("selectPrevious:")]
	public virtual void SelectPrevious(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectPrevious_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectPrevious_Handle, sender.Handle);
		}
	}

	[Export("canSelectNext")]
	public virtual bool CanSelectNext()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanSelectNextHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanSelectNextHandle);
	}

	[Export("canSelectPrevious")]
	public virtual bool CanSelectPrevious()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanSelectPreviousHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanSelectPreviousHandle);
	}

	[Export("addObject:")]
	public new virtual void AddObject(NSObject aObject)
	{
		NSApplication.EnsureUIThread();
		if (aObject == null)
		{
			throw new ArgumentNullException("aObject");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, aObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObject_Handle, aObject.Handle);
		}
	}

	[Export("addObjects:")]
	public virtual void AddObjects(NSArray objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObjects_Handle, objects.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObjects_Handle, objects.Handle);
		}
	}

	[Export("insertObject:atArrangedObjectIndex:")]
	public virtual void Insert(NSObject aObject, long index)
	{
		NSApplication.EnsureUIThread();
		if (aObject == null)
		{
			throw new ArgumentNullException("aObject");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selInsertObjectAtArrangedObjectIndex_Handle, aObject.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selInsertObjectAtArrangedObjectIndex_Handle, aObject.Handle, index);
		}
	}

	[Export("insertObjects:atArrangedObjectIndexes:")]
	public virtual void Insert(NSObject[] objects, NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertObjectsAtArrangedObjectIndexes_Handle, nSArray.Handle, indexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertObjectsAtArrangedObjectIndexes_Handle, nSArray.Handle, indexes.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeObjectAtArrangedObjectIndex:")]
	public virtual void RemoveAt(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selRemoveObjectAtArrangedObjectIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selRemoveObjectAtArrangedObjectIndex_Handle, index);
		}
	}

	[Export("removeObjectsAtArrangedObjectIndexes:")]
	public virtual void Remove(NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectsAtArrangedObjectIndexes_Handle, indexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectsAtArrangedObjectIndexes_Handle, indexes.Handle);
		}
	}

	[Export("removeObject:")]
	public new virtual void Remove(NSObject aObject)
	{
		NSApplication.EnsureUIThread();
		if (aObject == null)
		{
			throw new ArgumentNullException("aObject");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObject_Handle, aObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObject_Handle, aObject.Handle);
		}
	}

	[Export("removeObjects:")]
	public virtual void Remove(NSObject[] objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjects_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjects_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("selectionIndexes")]
	protected virtual NSIndexSet GetSelectionIndexes()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexesHandle));
		}
		return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexesHandle));
	}

	[Export("setSelectionIndexes:")]
	protected virtual bool SetSelectionIndexes(NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexes_Handle, indexes.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexes_Handle, indexes.Handle);
	}

	[Export("selectionIndex")]
	protected virtual ulong GetSelectionIndex()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend(base.Handle, selSelectionIndexHandle);
		}
		return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSelectionIndexHandle);
	}

	[Export("setSelectionIndex:")]
	protected virtual bool SetSelectionIndex(ulong index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_UInt64(base.Handle, selSetSelectionIndex_Handle, index);
		}
		return Messaging.bool_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSelectionIndex_Handle, index);
	}

	[Export("selectedObjects")]
	protected virtual NSObject[] GetSelectedObjects()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedObjectsHandle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedObjectsHandle));
	}

	[Export("setSelectedObjects:")]
	protected virtual bool SetSelectedObjects(NSObject[] objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedObjects_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetSelectedObjects_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SortDescriptors_var = null;
			__mt_FilterPredicate_var = null;
		}
	}
}
