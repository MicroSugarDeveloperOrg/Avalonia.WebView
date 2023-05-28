using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSManagedObjectContext", true)]
public class NSManagedObjectContext : NSObject, INSCoding, INativeObject, IDisposable, INSLocking, INSEditor, INSEditorRegistration
{
	public static class Notifications
	{
		public static NSObject ObserveDidSave(EventHandler<NSManagedObjectChangeEventArgs> handler)
		{
			EventHandler<NSManagedObjectChangeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidSaveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSManagedObjectChangeEventArgs(notification));
			});
		}

		public static NSObject ObserveDidSave(NSObject objectToObserve, EventHandler<NSManagedObjectChangeEventArgs> handler)
		{
			EventHandler<NSManagedObjectChangeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidSaveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSManagedObjectChangeEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveObjectsDidChange(EventHandler<NSManagedObjectChangeEventArgs> handler)
		{
			EventHandler<NSManagedObjectChangeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ObjectsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSManagedObjectChangeEventArgs(notification));
			});
		}

		public static NSObject ObserveObjectsDidChange(NSObject objectToObserve, EventHandler<NSManagedObjectChangeEventArgs> handler)
		{
			EventHandler<NSManagedObjectChangeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ObjectsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSManagedObjectChangeEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillSave(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillSaveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillSave(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillSaveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssignObject_ToPersistentStore_ = "assignObject:toPersistentStore:";

	private static readonly IntPtr selAssignObject_ToPersistentStore_Handle = Selector.GetHandle("assignObject:toPersistentStore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticallyMergesChangesFromParent = "automaticallyMergesChangesFromParent";

	private static readonly IntPtr selAutomaticallyMergesChangesFromParentHandle = Selector.GetHandle("automaticallyMergesChangesFromParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitEditing = "commitEditing";

	private static readonly IntPtr selCommitEditingHandle = Selector.GetHandle("commitEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitEditingAndReturnError_ = "commitEditingAndReturnError:";

	private static readonly IntPtr selCommitEditingAndReturnError_Handle = Selector.GetHandle("commitEditingAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_ = "commitEditingWithDelegate:didCommitSelector:contextInfo:";

	private static readonly IntPtr selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle = Selector.GetHandle("commitEditingWithDelegate:didCommitSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConcurrencyType = "concurrencyType";

	private static readonly IntPtr selConcurrencyTypeHandle = Selector.GetHandle("concurrencyType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCountForFetchRequest_Error_ = "countForFetchRequest:error:";

	private static readonly IntPtr selCountForFetchRequest_Error_Handle = Selector.GetHandle("countForFetchRequest:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteObject_ = "deleteObject:";

	private static readonly IntPtr selDeleteObject_Handle = Selector.GetHandle("deleteObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeletedObjects = "deletedObjects";

	private static readonly IntPtr selDeletedObjectsHandle = Selector.GetHandle("deletedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetectConflictsForObject_ = "detectConflictsForObject:";

	private static readonly IntPtr selDetectConflictsForObject_Handle = Selector.GetHandle("detectConflictsForObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscardEditing = "discardEditing";

	private static readonly IntPtr selDiscardEditingHandle = Selector.GetHandle("discardEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecuteFetchRequest_Error_ = "executeFetchRequest:error:";

	private static readonly IntPtr selExecuteFetchRequest_Error_Handle = Selector.GetHandle("executeFetchRequest:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecuteRequest_Error_ = "executeRequest:error:";

	private static readonly IntPtr selExecuteRequest_Error_Handle = Selector.GetHandle("executeRequest:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExistingObjectWithID_Error_ = "existingObjectWithID:error:";

	private static readonly IntPtr selExistingObjectWithID_Error_Handle = Selector.GetHandle("existingObjectWithID:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasChanges = "hasChanges";

	private static readonly IntPtr selHasChangesHandle = Selector.GetHandle("hasChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithConcurrencyType_ = "initWithConcurrencyType:";

	private static readonly IntPtr selInitWithConcurrencyType_Handle = Selector.GetHandle("initWithConcurrencyType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertObject_ = "insertObject:";

	private static readonly IntPtr selInsertObject_Handle = Selector.GetHandle("insertObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertedObjects = "insertedObjects";

	private static readonly IntPtr selInsertedObjectsHandle = Selector.GetHandle("insertedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLock = "lock";

	private static readonly IntPtr selLockHandle = Selector.GetHandle("lock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMergeChangesFromContextDidSaveNotification_ = "mergeChangesFromContextDidSaveNotification:";

	private static readonly IntPtr selMergeChangesFromContextDidSaveNotification_Handle = Selector.GetHandle("mergeChangesFromContextDidSaveNotification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMergeChangesFromRemoteContextSave_IntoContexts_ = "mergeChangesFromRemoteContextSave:intoContexts:";

	private static readonly IntPtr selMergeChangesFromRemoteContextSave_IntoContexts_Handle = Selector.GetHandle("mergeChangesFromRemoteContextSave:intoContexts:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMergePolicy = "mergePolicy";

	private static readonly IntPtr selMergePolicyHandle = Selector.GetHandle("mergePolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectDidBeginEditing_ = "objectDidBeginEditing:";

	private static readonly IntPtr selObjectDidBeginEditing_Handle = Selector.GetHandle("objectDidBeginEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectDidEndEditing_ = "objectDidEndEditing:";

	private static readonly IntPtr selObjectDidEndEditing_Handle = Selector.GetHandle("objectDidEndEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectRegisteredForID_ = "objectRegisteredForID:";

	private static readonly IntPtr selObjectRegisteredForID_Handle = Selector.GetHandle("objectRegisteredForID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectWithID_ = "objectWithID:";

	private static readonly IntPtr selObjectWithID_Handle = Selector.GetHandle("objectWithID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObserveValueForKeyPath_OfObject_Change_Context_ = "observeValueForKeyPath:ofObject:change:context:";

	private static readonly IntPtr selObserveValueForKeyPath_OfObject_Change_Context_Handle = Selector.GetHandle("observeValueForKeyPath:ofObject:change:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObtainPermanentIDsForObjects_Error_ = "obtainPermanentIDsForObjects:error:";

	private static readonly IntPtr selObtainPermanentIDsForObjects_Error_Handle = Selector.GetHandle("obtainPermanentIDsForObjects:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentContext = "parentContext";

	private static readonly IntPtr selParentContextHandle = Selector.GetHandle("parentContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformBlock_ = "performBlock:";

	private static readonly IntPtr selPerformBlock_Handle = Selector.GetHandle("performBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformBlockAndWait_ = "performBlockAndWait:";

	private static readonly IntPtr selPerformBlockAndWait_Handle = Selector.GetHandle("performBlockAndWait:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentStoreCoordinator = "persistentStoreCoordinator";

	private static readonly IntPtr selPersistentStoreCoordinatorHandle = Selector.GetHandle("persistentStoreCoordinator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessPendingChanges = "processPendingChanges";

	private static readonly IntPtr selProcessPendingChangesHandle = Selector.GetHandle("processPendingChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropagatesDeletesAtEndOfEvent = "propagatesDeletesAtEndOfEvent";

	private static readonly IntPtr selPropagatesDeletesAtEndOfEventHandle = Selector.GetHandle("propagatesDeletesAtEndOfEvent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueryGenerationToken = "queryGenerationToken";

	private static readonly IntPtr selQueryGenerationTokenHandle = Selector.GetHandle("queryGenerationToken");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedo = "redo";

	private static readonly IntPtr selRedoHandle = Selector.GetHandle("redo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRefreshAllObjects = "refreshAllObjects";

	private static readonly IntPtr selRefreshAllObjectsHandle = Selector.GetHandle("refreshAllObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRefreshObject_MergeChanges_ = "refreshObject:mergeChanges:";

	private static readonly IntPtr selRefreshObject_MergeChanges_Handle = Selector.GetHandle("refreshObject:mergeChanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisteredObjects = "registeredObjects";

	private static readonly IntPtr selRegisteredObjectsHandle = Selector.GetHandle("registeredObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRetainsRegisteredObjects = "retainsRegisteredObjects";

	private static readonly IntPtr selRetainsRegisteredObjectsHandle = Selector.GetHandle("retainsRegisteredObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRollback = "rollback";

	private static readonly IntPtr selRollbackHandle = Selector.GetHandle("rollback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSave_ = "save:";

	private static readonly IntPtr selSave_Handle = Selector.GetHandle("save:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticallyMergesChangesFromParent_ = "setAutomaticallyMergesChangesFromParent:";

	private static readonly IntPtr selSetAutomaticallyMergesChangesFromParent_Handle = Selector.GetHandle("setAutomaticallyMergesChangesFromParent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMergePolicy_ = "setMergePolicy:";

	private static readonly IntPtr selSetMergePolicy_Handle = Selector.GetHandle("setMergePolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParentContext_ = "setParentContext:";

	private static readonly IntPtr selSetParentContext_Handle = Selector.GetHandle("setParentContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPersistentStoreCoordinator_ = "setPersistentStoreCoordinator:";

	private static readonly IntPtr selSetPersistentStoreCoordinator_Handle = Selector.GetHandle("setPersistentStoreCoordinator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPropagatesDeletesAtEndOfEvent_ = "setPropagatesDeletesAtEndOfEvent:";

	private static readonly IntPtr selSetPropagatesDeletesAtEndOfEvent_Handle = Selector.GetHandle("setPropagatesDeletesAtEndOfEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQueryGenerationFromToken_Error_ = "setQueryGenerationFromToken:error:";

	private static readonly IntPtr selSetQueryGenerationFromToken_Error_Handle = Selector.GetHandle("setQueryGenerationFromToken:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRetainsRegisteredObjects_ = "setRetainsRegisteredObjects:";

	private static readonly IntPtr selSetRetainsRegisteredObjects_Handle = Selector.GetHandle("setRetainsRegisteredObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldDeleteInaccessibleFaults_ = "setShouldDeleteInaccessibleFaults:";

	private static readonly IntPtr selSetShouldDeleteInaccessibleFaults_Handle = Selector.GetHandle("setShouldDeleteInaccessibleFaults:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStalenessInterval_ = "setStalenessInterval:";

	private static readonly IntPtr selSetStalenessInterval_Handle = Selector.GetHandle("setStalenessInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransactionAuthor_ = "setTransactionAuthor:";

	private static readonly IntPtr selSetTransactionAuthor_Handle = Selector.GetHandle("setTransactionAuthor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUndoManager_ = "setUndoManager:";

	private static readonly IntPtr selSetUndoManager_Handle = Selector.GetHandle("setUndoManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldDeleteInaccessibleFaults = "shouldDeleteInaccessibleFaults";

	private static readonly IntPtr selShouldDeleteInaccessibleFaultsHandle = Selector.GetHandle("shouldDeleteInaccessibleFaults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldHandleInaccessibleFault_ForObjectID_TriggeredByProperty_ = "shouldHandleInaccessibleFault:forObjectID:triggeredByProperty:";

	private static readonly IntPtr selShouldHandleInaccessibleFault_ForObjectID_TriggeredByProperty_Handle = Selector.GetHandle("shouldHandleInaccessibleFault:forObjectID:triggeredByProperty:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStalenessInterval = "stalenessInterval";

	private static readonly IntPtr selStalenessIntervalHandle = Selector.GetHandle("stalenessInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransactionAuthor = "transactionAuthor";

	private static readonly IntPtr selTransactionAuthorHandle = Selector.GetHandle("transactionAuthor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTryLock = "tryLock";

	private static readonly IntPtr selTryLockHandle = Selector.GetHandle("tryLock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndo = "undo";

	private static readonly IntPtr selUndoHandle = Selector.GetHandle("undo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndoManager = "undoManager";

	private static readonly IntPtr selUndoManagerHandle = Selector.GetHandle("undoManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlock = "unlock";

	private static readonly IntPtr selUnlockHandle = Selector.GetHandle("unlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdatedObjects = "updatedObjects";

	private static readonly IntPtr selUpdatedObjectsHandle = Selector.GetHandle("updatedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserInfo = "userInfo";

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSManagedObjectContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidSaveNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ObjectsDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillSaveNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool AutomaticallyMergesChangesFromParent
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("automaticallyMergesChangesFromParent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyMergesChangesFromParentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyMergesChangesFromParentHandle);
		}
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setAutomaticallyMergesChangesFromParent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyMergesChangesFromParent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyMergesChangesFromParent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectContextConcurrencyType ConcurrencyType
	{
		[Export("concurrencyType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSManagedObjectContextConcurrencyType)Messaging.UInt64_objc_msgSend(base.Handle, selConcurrencyTypeHandle);
			}
			return (NSManagedObjectContextConcurrencyType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selConcurrencyTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet DeletedObjects
	{
		[Export("deletedObjects", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeletedObjectsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeletedObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasChanges
	{
		[Export("hasChanges")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasChangesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasChangesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet InsertedObjects
	{
		[Export("insertedObjects", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selInsertedObjectsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInsertedObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr MergePolicy
	{
		[Export("mergePolicy", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selMergePolicyHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMergePolicyHandle);
		}
		[Export("setMergePolicy:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMergePolicy_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMergePolicy_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? Name
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectContext? ParentContext
	{
		[Export("parentContext", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentContextHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentContextHandle));
		}
		[Export("setParentContext:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParentContext_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParentContext_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentStoreCoordinator? PersistentStoreCoordinator
	{
		[Export("persistentStoreCoordinator", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPersistentStoreCoordinator>(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentStoreCoordinatorHandle));
			}
			return Runtime.GetNSObject<NSPersistentStoreCoordinator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentStoreCoordinatorHandle));
		}
		[Export("setPersistentStoreCoordinator:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPersistentStoreCoordinator_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPersistentStoreCoordinator_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PropagatesDeletesAtEndOfEvent
	{
		[Export("propagatesDeletesAtEndOfEvent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPropagatesDeletesAtEndOfEventHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPropagatesDeletesAtEndOfEventHandle);
		}
		[Export("setPropagatesDeletesAtEndOfEvent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPropagatesDeletesAtEndOfEvent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPropagatesDeletesAtEndOfEvent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSQueryGenerationToken? QueryGenerationToken
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("queryGenerationToken", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSQueryGenerationToken>(Messaging.IntPtr_objc_msgSend(base.Handle, selQueryGenerationTokenHandle));
			}
			return Runtime.GetNSObject<NSQueryGenerationToken>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQueryGenerationTokenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet RegisteredObjects
	{
		[Export("registeredObjects", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selRegisteredObjectsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRegisteredObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RetainsRegisteredObjects
	{
		[Export("retainsRegisteredObjects")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRetainsRegisteredObjectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRetainsRegisteredObjectsHandle);
		}
		[Export("setRetainsRegisteredObjects:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRetainsRegisteredObjects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRetainsRegisteredObjects_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool ShouldDeleteInaccessibleFaults
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("shouldDeleteInaccessibleFaults")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldDeleteInaccessibleFaultsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldDeleteInaccessibleFaultsHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setShouldDeleteInaccessibleFaults:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldDeleteInaccessibleFaults_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldDeleteInaccessibleFaults_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double StalenessInterval
	{
		[Export("stalenessInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selStalenessIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selStalenessIntervalHandle);
		}
		[Export("setStalenessInterval:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetStalenessInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetStalenessInterval_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string? TransactionAuthor
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("transactionAuthor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTransactionAuthorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransactionAuthorHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setTransactionAuthor:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTransactionAuthor_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTransactionAuthor_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use a queue style context and 'Perform' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use a queue style context and 'Perform' instead.")]
	public virtual bool TryLock
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use a queue style context and 'Perform' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use a queue style context and 'Perform' instead.")]
		[Export("tryLock")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTryLockHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTryLockHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUndoManager? UndoManager
	{
		[Export("undoManager", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUndoManager>(Messaging.IntPtr_objc_msgSend(base.Handle, selUndoManagerHandle));
			}
			return Runtime.GetNSObject<NSUndoManager>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUndoManagerHandle));
		}
		[Export("setUndoManager:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUndoManager_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUndoManager_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet UpdatedObjects
	{
		[Export("updatedObjects", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selUpdatedObjectsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUpdatedObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableDictionary UserInfo
	{
		[Export("userInfo", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle));
			}
			return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle));
		}
	}

	[Field("NSManagedObjectContextDidSaveNotification", "CoreData")]
	[Advice("Use NSManagedObjectContext.Notifications.ObserveDidSave helper method instead.")]
	public static NSString DidSaveNotification
	{
		get
		{
			if (_DidSaveNotification == null)
			{
				_DidSaveNotification = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSManagedObjectContextDidSaveNotification");
			}
			return _DidSaveNotification;
		}
	}

	[Field("NSManagedObjectContextObjectsDidChangeNotification", "CoreData")]
	[Advice("Use NSManagedObjectContext.Notifications.ObserveObjectsDidChange helper method instead.")]
	public static NSString ObjectsDidChangeNotification
	{
		get
		{
			if (_ObjectsDidChangeNotification == null)
			{
				_ObjectsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSManagedObjectContextObjectsDidChangeNotification");
			}
			return _ObjectsDidChangeNotification;
		}
	}

	[Field("NSManagedObjectContextWillSaveNotification", "CoreData")]
	[Advice("Use NSManagedObjectContext.Notifications.ObserveWillSave helper method instead.")]
	public static NSString WillSaveNotification
	{
		get
		{
			if (_WillSaveNotification == null)
			{
				_WillSaveNotification = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSManagedObjectContextWillSaveNotification");
			}
			return _WillSaveNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSManagedObjectContext(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected NSManagedObjectContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSManagedObjectContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'NSManagedObjectContext (NSManagedObjectContextConcurrencyType)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSManagedObjectContext (NSManagedObjectContextConcurrencyType)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSManagedObjectContext()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("initWithConcurrencyType:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSManagedObjectContext(NSManagedObjectContextConcurrencyType ct)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithConcurrencyType_Handle, (ulong)ct), "initWithConcurrencyType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithConcurrencyType_Handle, (ulong)ct), "initWithConcurrencyType:");
		}
	}

	[Export("assignObject:toPersistentStore:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AssignObject(IntPtr object1, NSPersistentStore store)
	{
		if (store == null)
		{
			throw new ArgumentNullException("store");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAssignObject_ToPersistentStore_Handle, object1, store.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAssignObject_ToPersistentStore_Handle, object1, store.Handle);
		}
	}

	[Export("commitEditing")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool CommitEditing()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCommitEditingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCommitEditingHandle);
	}

	[Export("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void CommitEditing(NSObject? delegateObject, Selector? didCommitSelector, IntPtr contextInfo)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle, delegateObject?.Handle ?? IntPtr.Zero, (didCommitSelector == null) ? IntPtr.Zero : didCommitSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle, delegateObject?.Handle ?? IntPtr.Zero, (didCommitSelector == null) ? IntPtr.Zero : didCommitSelector.Handle, contextInfo);
		}
	}

	[Export("commitEditingAndReturnError:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CommitEditing(out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selCommitEditingAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selCommitEditingAndReturnError_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("countForFetchRequest:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CountForFetchRequest(NSFetchRequest request, out NSError error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		IntPtr arg = IntPtr.Zero;
		nuint result = ((!base.IsDirectBinding) ? Messaging.nuint_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selCountForFetchRequest_Error_Handle, request.Handle, ref arg) : Messaging.nuint_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selCountForFetchRequest_Error_Handle, request.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("deleteObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteObject(NSManagedObject object1)
	{
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteObject_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteObject_Handle, object1.Handle);
		}
	}

	[Export("detectConflictsForObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DetectConflictsForObject(NSManagedObject object1)
	{
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDetectConflictsForObject_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDetectConflictsForObject_Handle, object1.Handle);
		}
	}

	[Export("discardEditing")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscardEditing()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardEditingHandle);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("executeFetchRequest:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[]? ExecuteFetchRequest(NSFetchRequest request, out NSError error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selExecuteFetchRequest_Error_Handle, request.Handle, ref arg)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selExecuteFetchRequest_Error_Handle, request.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("executeRequest:error:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentStoreResult ExecuteRequest(NSPersistentStoreRequest request, out NSError error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		IntPtr arg = IntPtr.Zero;
		NSPersistentStoreResult result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPersistentStoreResult>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selExecuteRequest_Error_Handle, request.Handle, ref arg)) : Runtime.GetNSObject<NSPersistentStoreResult>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selExecuteRequest_Error_Handle, request.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("existingObjectWithID:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObject GetExistingObject(NSManagedObjectID objectID, out NSError error)
	{
		if (objectID == null)
		{
			throw new ArgumentNullException("objectID");
		}
		IntPtr arg = IntPtr.Zero;
		NSManagedObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSManagedObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selExistingObjectWithID_Error_Handle, objectID.Handle, ref arg)) : Runtime.GetNSObject<NSManagedObject>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selExistingObjectWithID_Error_Handle, objectID.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("insertObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertObject(NSManagedObject object1)
	{
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsertObject_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsertObject_Handle, object1.Handle);
		}
	}

	[Export("lock")]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use a queue style context and 'PerformAndWait' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use a queue style context and 'PerformAndWait' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Lock()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLockHandle);
		}
	}

	[Export("mergeChangesFromContextDidSaveNotification:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MergeChangesFromContextDidSaveNotification(NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMergeChangesFromContextDidSaveNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMergeChangesFromContextDidSaveNotification_Handle, notification.Handle);
		}
	}

	[Export("mergeChangesFromRemoteContextSave:intoContexts:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MergeChangesFromRemoteContextSave(NSDictionary changeNotificationData, NSManagedObjectContext[] contexts)
	{
		if (changeNotificationData == null)
		{
			throw new ArgumentNullException("changeNotificationData");
		}
		if (contexts == null)
		{
			throw new ArgumentNullException("contexts");
		}
		NSArray nSArray = NSArray.FromNSObjects(contexts);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selMergeChangesFromRemoteContextSave_IntoContexts_Handle, changeNotificationData.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("objectDidBeginEditing:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ObjectDidBeginEditing(INSEditor editor)
	{
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selObjectDidBeginEditing_Handle, editor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectDidBeginEditing_Handle, editor.Handle);
		}
	}

	[Export("objectDidEndEditing:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ObjectDidEndEditing(INSEditor editor)
	{
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selObjectDidEndEditing_Handle, editor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectDidEndEditing_Handle, editor.Handle);
		}
	}

	[Export("objectRegisteredForID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObject ObjectRegisteredForID(NSManagedObjectID objectID)
	{
		if (objectID == null)
		{
			throw new ArgumentNullException("objectID");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSManagedObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectRegisteredForID_Handle, objectID.Handle));
		}
		return Runtime.GetNSObject<NSManagedObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectRegisteredForID_Handle, objectID.Handle));
	}

	[Export("objectWithID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObject ObjectWithID(NSManagedObjectID objectID)
	{
		if (objectID == null)
		{
			throw new ArgumentNullException("objectID");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSManagedObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectWithID_Handle, objectID.Handle));
		}
		return Runtime.GetNSObject<NSManagedObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectWithID_Handle, objectID.Handle));
	}

	[Export("observeValueForKeyPath:ofObject:change:context:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ObserveValueForKeyPath(string keyPath, IntPtr object1, NSDictionary? change, IntPtr context)
	{
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		IntPtr arg = NSString.CreateNative(keyPath);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selObserveValueForKeyPath_OfObject_Change_Context_Handle, arg, object1, change?.Handle ?? IntPtr.Zero, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selObserveValueForKeyPath_OfObject_Change_Context_Handle, arg, object1, change?.Handle ?? IntPtr.Zero, context);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("obtainPermanentIDsForObjects:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ObtainPermanentIDsForObjects(NSManagedObject[] objects, out NSError error)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selObtainPermanentIDsForObjects_Error_Handle, nSArray.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selObtainPermanentIDsForObjects_Error_Handle, nSArray.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("performBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Perform([BlockProxy(typeof(Trampolines.NIDAction))] Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, action);
		if (base.IsDirectBinding)
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformAndWait([BlockProxy(typeof(Trampolines.NIDAction))] Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, action);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformBlockAndWait_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformBlockAndWait_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("processPendingChanges")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ProcessPendingChanges()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selProcessPendingChangesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selProcessPendingChangesHandle);
		}
	}

	[Export("redo")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Redo()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRedoHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRedoHandle);
		}
	}

	[Export("refreshAllObjects")]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RefreshAllObjects()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRefreshAllObjectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRefreshAllObjectsHandle);
		}
	}

	[Export("refreshObject:mergeChanges:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RefreshObject(NSManagedObject object1, bool flag)
	{
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selRefreshObject_MergeChanges_Handle, object1.Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selRefreshObject_MergeChanges_Handle, object1.Handle, flag);
		}
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("rollback")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Rollback()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRollbackHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRollbackHandle);
		}
	}

	[Export("save:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Save(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selSave_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selSave_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setQueryGenerationFromToken:error:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetQueryGenerationFromToken(NSQueryGenerationToken? generation, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selSetQueryGenerationFromToken_Error_Handle, generation?.Handle ?? IntPtr.Zero, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selSetQueryGenerationFromToken_Error_Handle, generation?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("shouldHandleInaccessibleFault:forObjectID:triggeredByProperty:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldHandleInaccessibleFault(NSManagedObject fault, NSManagedObjectID oid, NSPropertyDescription? property)
	{
		if (fault == null)
		{
			throw new ArgumentNullException("fault");
		}
		if (oid == null)
		{
			throw new ArgumentNullException("oid");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selShouldHandleInaccessibleFault_ForObjectID_TriggeredByProperty_Handle, fault.Handle, oid.Handle, property?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selShouldHandleInaccessibleFault_ForObjectID_TriggeredByProperty_Handle, fault.Handle, oid.Handle, property?.Handle ?? IntPtr.Zero);
	}

	[Export("undo")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Undo()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUndoHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUndoHandle);
		}
	}

	[Export("unlock")]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use a queue style context and 'PerformAndWait' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use a queue style context and 'PerformAndWait' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Unlock()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnlockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnlockHandle);
		}
	}
}
