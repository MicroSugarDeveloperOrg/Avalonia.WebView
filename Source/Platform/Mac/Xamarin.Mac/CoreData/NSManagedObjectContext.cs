using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSManagedObjectContext", true)]
public class NSManagedObjectContext : NSObject
{
	private static readonly IntPtr selPersistentStoreCoordinatorHandle = Selector.GetHandle("persistentStoreCoordinator");

	private static readonly IntPtr selSetPersistentStoreCoordinator_Handle = Selector.GetHandle("setPersistentStoreCoordinator:");

	private static readonly IntPtr selUndoManagerHandle = Selector.GetHandle("undoManager");

	private static readonly IntPtr selSetUndoManager_Handle = Selector.GetHandle("setUndoManager:");

	private static readonly IntPtr selHasChangesHandle = Selector.GetHandle("hasChanges");

	private static readonly IntPtr selInsertedObjectsHandle = Selector.GetHandle("insertedObjects");

	private static readonly IntPtr selUpdatedObjectsHandle = Selector.GetHandle("updatedObjects");

	private static readonly IntPtr selDeletedObjectsHandle = Selector.GetHandle("deletedObjects");

	private static readonly IntPtr selRegisteredObjectsHandle = Selector.GetHandle("registeredObjects");

	private static readonly IntPtr selTryLockHandle = Selector.GetHandle("tryLock");

	private static readonly IntPtr selPropagatesDeletesAtEndOfEventHandle = Selector.GetHandle("propagatesDeletesAtEndOfEvent");

	private static readonly IntPtr selSetPropagatesDeletesAtEndOfEvent_Handle = Selector.GetHandle("setPropagatesDeletesAtEndOfEvent:");

	private static readonly IntPtr selRetainsRegisteredObjectsHandle = Selector.GetHandle("retainsRegisteredObjects");

	private static readonly IntPtr selSetRetainsRegisteredObjects_Handle = Selector.GetHandle("setRetainsRegisteredObjects:");

	private static readonly IntPtr selStalenessIntervalHandle = Selector.GetHandle("stalenessInterval");

	private static readonly IntPtr selSetStalenessInterval_Handle = Selector.GetHandle("setStalenessInterval:");

	private static readonly IntPtr selMergePolicyHandle = Selector.GetHandle("mergePolicy");

	private static readonly IntPtr selSetMergePolicy_Handle = Selector.GetHandle("setMergePolicy:");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selConcurrencyTypeHandle = Selector.GetHandle("concurrencyType");

	private static readonly IntPtr selParentContextHandle = Selector.GetHandle("parentContext");

	private static readonly IntPtr selSetParentContext_Handle = Selector.GetHandle("setParentContext:");

	private static readonly IntPtr selObjectRegisteredForID_Handle = Selector.GetHandle("objectRegisteredForID:");

	private static readonly IntPtr selObjectWithID_Handle = Selector.GetHandle("objectWithID:");

	private static readonly IntPtr selExecuteFetchRequestError_Handle = Selector.GetHandle("executeFetchRequest:error:");

	private static readonly IntPtr selCountForFetchRequestError_Handle = Selector.GetHandle("countForFetchRequest:error:");

	private static readonly IntPtr selInsertObject_Handle = Selector.GetHandle("insertObject:");

	private static readonly IntPtr selDeleteObject_Handle = Selector.GetHandle("deleteObject:");

	private static readonly IntPtr selRefreshObjectMergeChanges_Handle = Selector.GetHandle("refreshObject:mergeChanges:");

	private static readonly IntPtr selDetectConflictsForObject_Handle = Selector.GetHandle("detectConflictsForObject:");

	private static readonly IntPtr selObserveValueForKeyPathOfObjectChangeContext_Handle = Selector.GetHandle("observeValueForKeyPath:ofObject:change:context:");

	private static readonly IntPtr selProcessPendingChangesHandle = Selector.GetHandle("processPendingChanges");

	private static readonly IntPtr selAssignObjectToPersistentStore_Handle = Selector.GetHandle("assignObject:toPersistentStore:");

	private static readonly IntPtr selUndoHandle = Selector.GetHandle("undo");

	private static readonly IntPtr selRedoHandle = Selector.GetHandle("redo");

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	private static readonly IntPtr selRollbackHandle = Selector.GetHandle("rollback");

	private static readonly IntPtr selSave_Handle = Selector.GetHandle("save:");

	private static readonly IntPtr selLockHandle = Selector.GetHandle("lock");

	private static readonly IntPtr selUnlockHandle = Selector.GetHandle("unlock");

	private static readonly IntPtr selObtainPermanentIDsForObjectsError_Handle = Selector.GetHandle("obtainPermanentIDsForObjects:error:");

	private static readonly IntPtr selMergeChangesFromContextDidSaveNotification_Handle = Selector.GetHandle("mergeChangesFromContextDidSaveNotification:");

	private static readonly IntPtr selInitWithConcurrencyType_Handle = Selector.GetHandle("initWithConcurrencyType:");

	private static readonly IntPtr selPerformBlock_Handle = Selector.GetHandle("performBlock:");

	private static readonly IntPtr selPerformBlockAndWait_Handle = Selector.GetHandle("performBlockAndWait:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSManagedObjectContext");

	private object __mt_PersistentStoreCoordinator_var;

	private object __mt_UndoManager_var;

	private object __mt_InsertedObjects_var;

	private object __mt_UpdatedObjects_var;

	private object __mt_DeletedObjects_var;

	private object __mt_RegisteredObjects_var;

	private object __mt_UserInfo_var;

	private object __mt_ParentContext_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSPersistentStoreCoordinator PersistentStoreCoordinator
	{
		[Export("persistentStoreCoordinator")]
		get
		{
			return (NSPersistentStoreCoordinator)(__mt_PersistentStoreCoordinator_var = ((!IsDirectBinding) ? ((NSPersistentStoreCoordinator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentStoreCoordinatorHandle))) : ((NSPersistentStoreCoordinator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentStoreCoordinatorHandle)))));
		}
		[Export("setPersistentStoreCoordinator:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPersistentStoreCoordinator_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPersistentStoreCoordinator_Handle, value.Handle);
			}
			__mt_PersistentStoreCoordinator_var = value;
		}
	}

	public virtual NSUndoManager UndoManager
	{
		[Export("undoManager")]
		get
		{
			return (NSUndoManager)(__mt_UndoManager_var = ((!IsDirectBinding) ? ((NSUndoManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUndoManagerHandle))) : ((NSUndoManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUndoManagerHandle)))));
		}
		[Export("setUndoManager:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUndoManager_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUndoManager_Handle, value.Handle);
			}
			__mt_UndoManager_var = value;
		}
	}

	public virtual bool HasChanges
	{
		[Export("hasChanges")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasChangesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasChangesHandle);
		}
	}

	public virtual NSSet InsertedObjects
	{
		[Export("insertedObjects")]
		get
		{
			return (NSSet)(__mt_InsertedObjects_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInsertedObjectsHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInsertedObjectsHandle)))));
		}
	}

	public virtual NSSet UpdatedObjects
	{
		[Export("updatedObjects")]
		get
		{
			return (NSSet)(__mt_UpdatedObjects_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUpdatedObjectsHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUpdatedObjectsHandle)))));
		}
	}

	public virtual NSSet DeletedObjects
	{
		[Export("deletedObjects")]
		get
		{
			return (NSSet)(__mt_DeletedObjects_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeletedObjectsHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeletedObjectsHandle)))));
		}
	}

	public virtual NSSet RegisteredObjects
	{
		[Export("registeredObjects")]
		get
		{
			return (NSSet)(__mt_RegisteredObjects_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRegisteredObjectsHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRegisteredObjectsHandle)))));
		}
	}

	public virtual bool TryLock
	{
		[Export("tryLock")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTryLockHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTryLockHandle);
		}
	}

	public virtual bool PropagatesDeletesAtEndOfEvent
	{
		[Export("propagatesDeletesAtEndOfEvent")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPropagatesDeletesAtEndOfEventHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPropagatesDeletesAtEndOfEventHandle);
		}
		[Export("setPropagatesDeletesAtEndOfEvent:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPropagatesDeletesAtEndOfEvent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPropagatesDeletesAtEndOfEvent_Handle, value);
			}
		}
	}

	public virtual bool RetainsRegisteredObjects
	{
		[Export("retainsRegisteredObjects")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRetainsRegisteredObjectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRetainsRegisteredObjectsHandle);
		}
		[Export("setRetainsRegisteredObjects:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRetainsRegisteredObjects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRetainsRegisteredObjects_Handle, value);
			}
		}
	}

	public virtual double StalenessInterval
	{
		[Export("stalenessInterval")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selStalenessIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selStalenessIntervalHandle);
		}
		[Export("setStalenessInterval:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetStalenessInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetStalenessInterval_Handle, value);
			}
		}
	}

	public virtual IntPtr MergePolicy
	{
		[Export("mergePolicy")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selMergePolicyHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMergePolicyHandle);
		}
		[Export("setMergePolicy:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMergePolicy_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMergePolicy_Handle, value);
			}
		}
	}

	public virtual NSMutableDictionary UserInfo
	{
		[Export("userInfo")]
		get
		{
			return (NSMutableDictionary)(__mt_UserInfo_var = ((!IsDirectBinding) ? ((NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle))) : ((NSMutableDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle)))));
		}
	}

	public virtual NSManagedObjectContextConcurrencyType ConcurrencyType
	{
		[Export("concurrencyType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSManagedObjectContextConcurrencyType)Messaging.UInt64_objc_msgSend(base.Handle, selConcurrencyTypeHandle);
			}
			return (NSManagedObjectContextConcurrencyType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selConcurrencyTypeHandle);
		}
	}

	public virtual NSManagedObjectContext ParentContext
	{
		[Export("parentContext")]
		get
		{
			return (NSManagedObjectContext)(__mt_ParentContext_var = ((!IsDirectBinding) ? ((NSManagedObjectContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentContextHandle))) : ((NSManagedObjectContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentContextHandle)))));
		}
		[Export("setParentContext:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParentContext_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParentContext_Handle, value.Handle);
			}
			__mt_ParentContext_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSManagedObjectContext()
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
	public NSManagedObjectContext(NSCoder coder)
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
	public NSManagedObjectContext(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSManagedObjectContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("objectRegisteredForID:")]
	public virtual NSManagedObject ObjectRegisteredForID(NSManagedObjectID objectID)
	{
		if (objectID == null)
		{
			throw new ArgumentNullException("objectID");
		}
		if (IsDirectBinding)
		{
			return (NSManagedObject)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectRegisteredForID_Handle, objectID.Handle));
		}
		return (NSManagedObject)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectRegisteredForID_Handle, objectID.Handle));
	}

	[Export("objectWithID:")]
	public virtual NSManagedObject ObjectWithID(NSManagedObjectID objectID)
	{
		if (objectID == null)
		{
			throw new ArgumentNullException("objectID");
		}
		if (IsDirectBinding)
		{
			return (NSManagedObject)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectWithID_Handle, objectID.Handle));
		}
		return (NSManagedObject)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectWithID_Handle, objectID.Handle));
	}

	[Export("executeFetchRequest:error:")]
	public virtual NSObject[] ExecuteFetchRequest(NSFetchRequest request, out NSError error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSObject[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selExecuteFetchRequestError_Handle, request.Handle, intPtr)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selExecuteFetchRequestError_Handle, request.Handle, intPtr)));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("countForFetchRequest:error:")]
	public virtual uint CountForFetchRequest(NSFetchRequest request, out NSError error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		uint result = ((!IsDirectBinding) ? Messaging.UInt32_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCountForFetchRequestError_Handle, request.Handle, intPtr) : Messaging.UInt32_objc_msgSend_IntPtr_IntPtr(base.Handle, selCountForFetchRequestError_Handle, request.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("insertObject:")]
	public virtual void InsertObject(NSManagedObject object1)
	{
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsertObject_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsertObject_Handle, object1.Handle);
		}
	}

	[Export("deleteObject:")]
	public virtual void DeleteObject(NSManagedObject object1)
	{
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteObject_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteObject_Handle, object1.Handle);
		}
	}

	[Export("refreshObject:mergeChanges:")]
	public virtual void RefreshObject(NSManagedObject object1, bool flag)
	{
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selRefreshObjectMergeChanges_Handle, object1.Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selRefreshObjectMergeChanges_Handle, object1.Handle, flag);
		}
	}

	[Export("detectConflictsForObject:")]
	public virtual void DetectConflictsForObject(NSManagedObject object1)
	{
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDetectConflictsForObject_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDetectConflictsForObject_Handle, object1.Handle);
		}
	}

	[Export("observeValueForKeyPath:ofObject:change:context:")]
	public virtual void ObserveValueForKeyPath(string keyPath, IntPtr object1, NSDictionary change, IntPtr context)
	{
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		if (change == null)
		{
			throw new ArgumentNullException("change");
		}
		IntPtr arg = NSString.CreateNative(keyPath);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selObserveValueForKeyPathOfObjectChangeContext_Handle, arg, object1, change.Handle, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selObserveValueForKeyPathOfObjectChangeContext_Handle, arg, object1, change.Handle, context);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("processPendingChanges")]
	public virtual void ProcessPendingChanges()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selProcessPendingChangesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selProcessPendingChangesHandle);
		}
	}

	[Export("assignObject:toPersistentStore:")]
	public virtual void AssignObject(IntPtr object1, NSPersistentStore store)
	{
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAssignObjectToPersistentStore_Handle, object1, store.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAssignObjectToPersistentStore_Handle, object1, store.Handle);
		}
	}

	[Export("undo")]
	public virtual void Undo()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUndoHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUndoHandle);
		}
	}

	[Export("redo")]
	public virtual void Redo()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRedoHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRedoHandle);
		}
	}

	[Export("reset")]
	public virtual void Reset()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("rollback")]
	public virtual void Rollback()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRollbackHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRollbackHandle);
		}
	}

	[Export("save:")]
	public virtual bool Save(out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSave_Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSave_Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("lock")]
	public virtual void Lock()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLockHandle);
		}
	}

	[Export("unlock")]
	public virtual void Unlock()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnlockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnlockHandle);
		}
	}

	[Export("obtainPermanentIDsForObjects:error:")]
	public virtual bool ObtainPermanentIDsForObjects(NSManagedObject[] objects, out NSError error)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selObtainPermanentIDsForObjectsError_Handle, nSArray.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selObtainPermanentIDsForObjectsError_Handle, nSArray.Handle, intPtr));
		nSArray.Dispose();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("mergeChangesFromContextDidSaveNotification:")]
	public virtual void MergeChangesFromContextDidSaveNotification(NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMergeChangesFromContextDidSaveNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMergeChangesFromContextDidSaveNotification_Handle, notification.Handle);
		}
	}

	[Export("initWithConcurrencyType:")]
	public NSManagedObjectContext(NSManagedObjectContextConcurrencyType ct)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithConcurrencyType_Handle, (ulong)ct);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithConcurrencyType_Handle, (ulong)ct);
		}
	}

	[Export("performBlock:")]
	public unsafe virtual void Perform(NSAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, action);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("performBlockAndWait:")]
	public unsafe virtual void PerformAndWait(NSAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, action);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformBlockAndWait_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformBlockAndWait_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PersistentStoreCoordinator_var = null;
			__mt_UndoManager_var = null;
			__mt_InsertedObjects_var = null;
			__mt_UpdatedObjects_var = null;
			__mt_DeletedObjects_var = null;
			__mt_RegisteredObjects_var = null;
			__mt_UserInfo_var = null;
			__mt_ParentContext_var = null;
		}
	}
}
