using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSArrayController", true)]
public class NSArrayController : NSObjectController
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdd_ = "add:";

	private static readonly IntPtr selAdd_Handle = Selector.GetHandle("add:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObject_ = "addObject:";

	private static readonly IntPtr selAddObject_Handle = Selector.GetHandle("addObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObjects_ = "addObjects:";

	private static readonly IntPtr selAddObjects_Handle = Selector.GetHandle("addObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSelectedObjects_ = "addSelectedObjects:";

	private static readonly IntPtr selAddSelectedObjects_Handle = Selector.GetHandle("addSelectedObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSelectionIndexes_ = "addSelectionIndexes:";

	private static readonly IntPtr selAddSelectionIndexes_Handle = Selector.GetHandle("addSelectionIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlwaysUsesMultipleValuesMarker = "alwaysUsesMultipleValuesMarker";

	private static readonly IntPtr selAlwaysUsesMultipleValuesMarkerHandle = Selector.GetHandle("alwaysUsesMultipleValuesMarker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrangeObjects_ = "arrangeObjects:";

	private static readonly IntPtr selArrangeObjects_Handle = Selector.GetHandle("arrangeObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrangedObjects = "arrangedObjects";

	private static readonly IntPtr selArrangedObjectsHandle = Selector.GetHandle("arrangedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticRearrangementKeyPaths = "automaticRearrangementKeyPaths";

	private static readonly IntPtr selAutomaticRearrangementKeyPathsHandle = Selector.GetHandle("automaticRearrangementKeyPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticallyRearrangesObjects = "automaticallyRearrangesObjects";

	private static readonly IntPtr selAutomaticallyRearrangesObjectsHandle = Selector.GetHandle("automaticallyRearrangesObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvoidsEmptySelection = "avoidsEmptySelection";

	private static readonly IntPtr selAvoidsEmptySelectionHandle = Selector.GetHandle("avoidsEmptySelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInsert = "canInsert";

	private static readonly IntPtr selCanInsertHandle = Selector.GetHandle("canInsert");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanSelectNext = "canSelectNext";

	private static readonly IntPtr selCanSelectNextHandle = Selector.GetHandle("canSelectNext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanSelectPrevious = "canSelectPrevious";

	private static readonly IntPtr selCanSelectPreviousHandle = Selector.GetHandle("canSelectPrevious");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearsFilterPredicateOnInsertion = "clearsFilterPredicateOnInsertion";

	private static readonly IntPtr selClearsFilterPredicateOnInsertionHandle = Selector.GetHandle("clearsFilterPredicateOnInsertion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidChangeArrangementCriteria = "didChangeArrangementCriteria";

	private static readonly IntPtr selDidChangeArrangementCriteriaHandle = Selector.GetHandle("didChangeArrangementCriteria");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterPredicate = "filterPredicate";

	private static readonly IntPtr selFilterPredicateHandle = Selector.GetHandle("filterPredicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsert_ = "insert:";

	private static readonly IntPtr selInsert_Handle = Selector.GetHandle("insert:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertObject_AtArrangedObjectIndex_ = "insertObject:atArrangedObjectIndex:";

	private static readonly IntPtr selInsertObject_AtArrangedObjectIndex_Handle = Selector.GetHandle("insertObject:atArrangedObjectIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertObjects_AtArrangedObjectIndexes_ = "insertObjects:atArrangedObjectIndexes:";

	private static readonly IntPtr selInsertObjects_AtArrangedObjectIndexes_Handle = Selector.GetHandle("insertObjects:atArrangedObjectIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreservesSelection = "preservesSelection";

	private static readonly IntPtr selPreservesSelectionHandle = Selector.GetHandle("preservesSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRearrangeObjects = "rearrangeObjects";

	private static readonly IntPtr selRearrangeObjectsHandle = Selector.GetHandle("rearrangeObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemove_ = "remove:";

	private static readonly IntPtr selRemove_Handle = Selector.GetHandle("remove:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObject_ = "removeObject:";

	private static readonly IntPtr selRemoveObject_Handle = Selector.GetHandle("removeObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectAtArrangedObjectIndex_ = "removeObjectAtArrangedObjectIndex:";

	private static readonly IntPtr selRemoveObjectAtArrangedObjectIndex_Handle = Selector.GetHandle("removeObjectAtArrangedObjectIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjects_ = "removeObjects:";

	private static readonly IntPtr selRemoveObjects_Handle = Selector.GetHandle("removeObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectsAtArrangedObjectIndexes_ = "removeObjectsAtArrangedObjectIndexes:";

	private static readonly IntPtr selRemoveObjectsAtArrangedObjectIndexes_Handle = Selector.GetHandle("removeObjectsAtArrangedObjectIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveSelectedObjects_ = "removeSelectedObjects:";

	private static readonly IntPtr selRemoveSelectedObjects_Handle = Selector.GetHandle("removeSelectedObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveSelectionIndexes_ = "removeSelectionIndexes:";

	private static readonly IntPtr selRemoveSelectionIndexes_Handle = Selector.GetHandle("removeSelectionIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectNext_ = "selectNext:";

	private static readonly IntPtr selSelectNext_Handle = Selector.GetHandle("selectNext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectPrevious_ = "selectPrevious:";

	private static readonly IntPtr selSelectPrevious_Handle = Selector.GetHandle("selectPrevious:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedObjects = "selectedObjects";

	private static readonly IntPtr selSelectedObjectsHandle = Selector.GetHandle("selectedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionIndex = "selectionIndex";

	private static readonly IntPtr selSelectionIndexHandle = Selector.GetHandle("selectionIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionIndexes = "selectionIndexes";

	private static readonly IntPtr selSelectionIndexesHandle = Selector.GetHandle("selectionIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectsInsertedObjects = "selectsInsertedObjects";

	private static readonly IntPtr selSelectsInsertedObjectsHandle = Selector.GetHandle("selectsInsertedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlwaysUsesMultipleValuesMarker_ = "setAlwaysUsesMultipleValuesMarker:";

	private static readonly IntPtr selSetAlwaysUsesMultipleValuesMarker_Handle = Selector.GetHandle("setAlwaysUsesMultipleValuesMarker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticallyRearrangesObjects_ = "setAutomaticallyRearrangesObjects:";

	private static readonly IntPtr selSetAutomaticallyRearrangesObjects_Handle = Selector.GetHandle("setAutomaticallyRearrangesObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAvoidsEmptySelection_ = "setAvoidsEmptySelection:";

	private static readonly IntPtr selSetAvoidsEmptySelection_Handle = Selector.GetHandle("setAvoidsEmptySelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClearsFilterPredicateOnInsertion_ = "setClearsFilterPredicateOnInsertion:";

	private static readonly IntPtr selSetClearsFilterPredicateOnInsertion_Handle = Selector.GetHandle("setClearsFilterPredicateOnInsertion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFilterPredicate_ = "setFilterPredicate:";

	private static readonly IntPtr selSetFilterPredicate_Handle = Selector.GetHandle("setFilterPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreservesSelection_ = "setPreservesSelection:";

	private static readonly IntPtr selSetPreservesSelection_Handle = Selector.GetHandle("setPreservesSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedObjects_ = "setSelectedObjects:";

	private static readonly IntPtr selSetSelectedObjects_Handle = Selector.GetHandle("setSelectedObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionIndex_ = "setSelectionIndex:";

	private static readonly IntPtr selSetSelectionIndex_Handle = Selector.GetHandle("setSelectionIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionIndexes_ = "setSelectionIndexes:";

	private static readonly IntPtr selSetSelectionIndexes_Handle = Selector.GetHandle("setSelectionIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectsInsertedObjects_ = "setSelectsInsertedObjects:";

	private static readonly IntPtr selSetSelectsInsertedObjects_Handle = Selector.GetHandle("setSelectsInsertedObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSortDescriptors_ = "setSortDescriptors:";

	private static readonly IntPtr selSetSortDescriptors_Handle = Selector.GetHandle("setSortDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortDescriptors = "sortDescriptors";

	private static readonly IntPtr selSortDescriptorsHandle = Selector.GetHandle("sortDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSArrayController");

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

	public ulong SelectionIndex
	{
		get
		{
			return GetSelectionIndex();
		}
		set
		{
			SetSelectionIndex((nuint)value);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AlwaysUsesMultipleValuesMarker
	{
		[Export("alwaysUsesMultipleValuesMarker")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysUsesMultipleValuesMarkerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysUsesMultipleValuesMarkerHandle);
		}
		[Export("setAlwaysUsesMultipleValuesMarker:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysUsesMultipleValuesMarker_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysUsesMultipleValuesMarker_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticallyRearrangesObjects
	{
		[Export("automaticallyRearrangesObjects")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyRearrangesObjectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyRearrangesObjectsHandle);
		}
		[Export("setAutomaticallyRearrangesObjects:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyRearrangesObjects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyRearrangesObjects_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AvoidsEmptySelection
	{
		[Export("avoidsEmptySelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAvoidsEmptySelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAvoidsEmptySelectionHandle);
		}
		[Export("setAvoidsEmptySelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAvoidsEmptySelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAvoidsEmptySelection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ClearsFilterPredicateOnInsertion
	{
		[Export("clearsFilterPredicateOnInsertion")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selClearsFilterPredicateOnInsertionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selClearsFilterPredicateOnInsertionHandle);
		}
		[Export("setClearsFilterPredicateOnInsertion:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetClearsFilterPredicateOnInsertion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetClearsFilterPredicateOnInsertion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate? FilterPredicate
	{
		[Export("filterPredicate", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterPredicateHandle));
			}
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterPredicateHandle));
		}
		[Export("setFilterPredicate:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFilterPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFilterPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PreservesSelection
	{
		[Export("preservesSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesSelectionHandle);
		}
		[Export("setPreservesSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesSelection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelectsInsertedObjects
	{
		[Export("selectsInsertedObjects")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSelectsInsertedObjectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSelectsInsertedObjectsHandle);
		}
		[Export("setSelectsInsertedObjects:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectsInsertedObjects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectsInsertedObjects_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] SortDescriptors
	{
		[Export("sortDescriptors", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorsHandle));
		}
		[Export("setSortDescriptors:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSArrayController()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSArrayController(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSArrayController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSArrayController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("add:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void Add(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAdd_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAdd_Handle, sender.Handle);
		}
	}

	[Export("addObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void AddObject(NSObject aObject)
	{
		NSApplication.EnsureUIThread();
		if (aObject == null)
		{
			throw new ArgumentNullException("aObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, aObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObject_Handle, aObject.Handle);
		}
	}

	[Export("addObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObjects(NSArray objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObjects_Handle, objects.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObjects_Handle, objects.Handle);
		}
	}

	[Export("addSelectedObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AddSelectedObjects(NSObject[] objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSelectedObjects_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAddSelectedObjects_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("addSelectionIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AddSelectionIndexes(NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAddSelectionIndexes_Handle, indexes.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSelectionIndexes_Handle, indexes.Handle);
	}

	[Export("arrangeObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] ArrangeObjects(NSObject[] objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		NSObject[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selArrangeObjects_Handle, nSArray.Handle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selArrangeObjects_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("arrangedObjects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] ArrangedObjects()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selArrangedObjectsHandle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrangedObjectsHandle));
	}

	[Export("automaticRearrangementKeyPaths")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] AutomaticRearrangementKeyPaths()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAutomaticRearrangementKeyPathsHandle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutomaticRearrangementKeyPathsHandle));
	}

	[Export("canInsert")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanInsert()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanInsertHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanInsertHandle);
	}

	[Export("canSelectNext")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanSelectNext()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanSelectNextHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanSelectNextHandle);
	}

	[Export("canSelectPrevious")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanSelectPrevious()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanSelectPreviousHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanSelectPreviousHandle);
	}

	[Export("didChangeArrangementCriteria")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeArrangementCriteria()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidChangeArrangementCriteriaHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidChangeArrangementCriteriaHandle);
		}
	}

	[Export("selectedObjects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSObject[] GetSelectedObjects()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedObjectsHandle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedObjectsHandle));
	}

	[Export("selectionIndex")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual nuint GetSelectionIndex()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend(base.Handle, selSelectionIndexHandle);
		}
		return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSelectionIndexHandle);
	}

	[Export("selectionIndexes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSIndexSet GetSelectionIndexes()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexesHandle));
		}
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexesHandle));
	}

	[Export("insert:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Insert(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsert_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsert_Handle, sender.Handle);
		}
	}

	[Export("insertObject:atArrangedObjectIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Insert(NSObject aObject, nint index)
	{
		NSApplication.EnsureUIThread();
		if (aObject == null)
		{
			throw new ArgumentNullException("aObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertObject_AtArrangedObjectIndex_Handle, aObject.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertObject_AtArrangedObjectIndex_Handle, aObject.Handle, index);
		}
	}

	[Export("insertObjects:atArrangedObjectIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertObjects_AtArrangedObjectIndexes_Handle, nSArray.Handle, indexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertObjects_AtArrangedObjectIndexes_Handle, nSArray.Handle, indexes.Handle);
		}
		nSArray.Dispose();
	}

	[Export("rearrangeObjects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RearrangeObjects()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRearrangeObjectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRearrangeObjectsHandle);
		}
	}

	[Export("removeObjectsAtArrangedObjectIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Remove(NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectsAtArrangedObjectIndexes_Handle, indexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectsAtArrangedObjectIndexes_Handle, indexes.Handle);
		}
	}

	[Export("removeObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void Remove(NSObject aObject)
	{
		NSApplication.EnsureUIThread();
		if (aObject == null)
		{
			throw new ArgumentNullException("aObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObject_Handle, aObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObject_Handle, aObject.Handle);
		}
	}

	[Export("removeObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Remove(NSObject[] objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjects_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjects_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeObjectAtArrangedObjectIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAt(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveObjectAtArrangedObjectIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveObjectAtArrangedObjectIndex_Handle, index);
		}
	}

	[Export("remove:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveOp(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemove_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemove_Handle, sender.Handle);
		}
	}

	[Export("removeSelectedObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveSelectedObjects(NSObject[] objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveSelectedObjects_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemoveSelectedObjects_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("removeSelectionIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveSelectionIndexes(NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemoveSelectionIndexes_Handle, indexes.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveSelectionIndexes_Handle, indexes.Handle);
	}

	[Export("selectNext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectNext(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNext_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNext_Handle, sender.Handle);
		}
	}

	[Export("selectPrevious:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectPrevious(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectPrevious_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectPrevious_Handle, sender.Handle);
		}
	}

	[Export("setSelectedObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool SetSelectedObjects(NSObject[] objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedObjects_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetSelectedObjects_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("setSelectionIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool SetSelectionIndex(nuint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nuint(base.Handle, selSetSelectionIndex_Handle, index);
		}
		return Messaging.bool_objc_msgSendSuper_nuint(base.SuperHandle, selSetSelectionIndex_Handle, index);
	}

	[Export("setSelectionIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool SetSelectionIndexes(NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexes_Handle, indexes.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexes_Handle, indexes.Handle);
	}
}
