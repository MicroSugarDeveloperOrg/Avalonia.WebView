using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSManagedObject", true)]
public class NSManagedObject : NSObject, INSFetchRequestResult, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAwakeFromFetch = "awakeFromFetch";

	private static readonly IntPtr selAwakeFromFetchHandle = Selector.GetHandle("awakeFromFetch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAwakeFromInsert = "awakeFromInsert";

	private static readonly IntPtr selAwakeFromInsertHandle = Selector.GetHandle("awakeFromInsert");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAwakeFromSnapshotEvents_ = "awakeFromSnapshotEvents:";

	private static readonly IntPtr selAwakeFromSnapshotEvents_Handle = Selector.GetHandle("awakeFromSnapshotEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangedValues = "changedValues";

	private static readonly IntPtr selChangedValuesHandle = Selector.GetHandle("changedValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangedValuesForCurrentEvent = "changedValuesForCurrentEvent";

	private static readonly IntPtr selChangedValuesForCurrentEventHandle = Selector.GetHandle("changedValuesForCurrentEvent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommittedValuesForKeys_ = "committedValuesForKeys:";

	private static readonly IntPtr selCommittedValuesForKeys_Handle = Selector.GetHandle("committedValuesForKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextShouldIgnoreUnmodeledPropertyChanges = "contextShouldIgnoreUnmodeledPropertyChanges";

	private static readonly IntPtr selContextShouldIgnoreUnmodeledPropertyChangesHandle = Selector.GetHandle("contextShouldIgnoreUnmodeledPropertyChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidAccessValueForKey_ = "didAccessValueForKey:";

	private static readonly IntPtr selDidAccessValueForKey_Handle = Selector.GetHandle("didAccessValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidChangeValueForKey_ = "didChangeValueForKey:";

	private static readonly IntPtr selDidChangeValueForKey_Handle = Selector.GetHandle("didChangeValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidChangeValueForKey_WithSetMutation_UsingObjects_ = "didChangeValueForKey:withSetMutation:usingObjects:";

	private static readonly IntPtr selDidChangeValueForKey_WithSetMutation_UsingObjects_Handle = Selector.GetHandle("didChangeValueForKey:withSetMutation:usingObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidSave = "didSave";

	private static readonly IntPtr selDidSaveHandle = Selector.GetHandle("didSave");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidTurnIntoFault = "didTurnIntoFault";

	private static readonly IntPtr selDidTurnIntoFaultHandle = Selector.GetHandle("didTurnIntoFault");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntity = "entity";

	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFaultingState = "faultingState";

	private static readonly IntPtr selFaultingStateHandle = Selector.GetHandle("faultingState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRequest = "fetchRequest";

	private static readonly IntPtr selFetchRequestHandle = Selector.GetHandle("fetchRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasChanges = "hasChanges";

	private static readonly IntPtr selHasChangesHandle = Selector.GetHandle("hasChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasFaultForRelationshipNamed_ = "hasFaultForRelationshipNamed:";

	private static readonly IntPtr selHasFaultForRelationshipNamed_Handle = Selector.GetHandle("hasFaultForRelationshipNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasPersistentChangedValues = "hasPersistentChangedValues";

	private static readonly IntPtr selHasPersistentChangedValuesHandle = Selector.GetHandle("hasPersistentChangedValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContext_ = "initWithContext:";

	private static readonly IntPtr selInitWithContext_Handle = Selector.GetHandle("initWithContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithEntity_InsertIntoManagedObjectContext_ = "initWithEntity:insertIntoManagedObjectContext:";

	private static readonly IntPtr selInitWithEntity_InsertIntoManagedObjectContext_Handle = Selector.GetHandle("initWithEntity:insertIntoManagedObjectContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDeleted = "isDeleted";

	private static readonly IntPtr selIsDeletedHandle = Selector.GetHandle("isDeleted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFault = "isFault";

	private static readonly IntPtr selIsFaultHandle = Selector.GetHandle("isFault");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInserted = "isInserted";

	private static readonly IntPtr selIsInsertedHandle = Selector.GetHandle("isInserted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUpdated = "isUpdated";

	private static readonly IntPtr selIsUpdatedHandle = Selector.GetHandle("isUpdated");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManagedObjectContext = "managedObjectContext";

	private static readonly IntPtr selManagedObjectContextHandle = Selector.GetHandle("managedObjectContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectID = "objectID";

	private static readonly IntPtr selObjectIDHandle = Selector.GetHandle("objectID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectIDsForRelationshipNamed_ = "objectIDsForRelationshipNamed:";

	private static readonly IntPtr selObjectIDsForRelationshipNamed_Handle = Selector.GetHandle("objectIDsForRelationshipNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservationInfo = "observationInfo";

	private static readonly IntPtr selObservationInfoHandle = Selector.GetHandle("observationInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForDeletion = "prepareForDeletion";

	private static readonly IntPtr selPrepareForDeletionHandle = Selector.GetHandle("prepareForDeletion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimitiveValueForKey_ = "primitiveValueForKey:";

	private static readonly IntPtr selPrimitiveValueForKey_Handle = Selector.GetHandle("primitiveValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObservationInfo_ = "setObservationInfo:";

	private static readonly IntPtr selSetObservationInfo_Handle = Selector.GetHandle("setObservationInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimitiveValue_ForKey_ = "setPrimitiveValue:forKey:";

	private static readonly IntPtr selSetPrimitiveValue_ForKey_Handle = Selector.GetHandle("setPrimitiveValue:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForKey_ = "setValue:forKey:";

	private static readonly IntPtr selSetValue_ForKey_Handle = Selector.GetHandle("setValue:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateForDelete_ = "validateForDelete:";

	private static readonly IntPtr selValidateForDelete_Handle = Selector.GetHandle("validateForDelete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateForInsert_ = "validateForInsert:";

	private static readonly IntPtr selValidateForInsert_Handle = Selector.GetHandle("validateForInsert:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateForUpdate_ = "validateForUpdate:";

	private static readonly IntPtr selValidateForUpdate_Handle = Selector.GetHandle("validateForUpdate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateValue_ForKey_Error_ = "validateValue:forKey:error:";

	private static readonly IntPtr selValidateValue_ForKey_Error_Handle = Selector.GetHandle("validateValue:forKey:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForKey_ = "valueForKey:";

	private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillAccessValueForKey_ = "willAccessValueForKey:";

	private static readonly IntPtr selWillAccessValueForKey_Handle = Selector.GetHandle("willAccessValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillChangeValueForKey_ = "willChangeValueForKey:";

	private static readonly IntPtr selWillChangeValueForKey_Handle = Selector.GetHandle("willChangeValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillChangeValueForKey_WithSetMutation_UsingObjects_ = "willChangeValueForKey:withSetMutation:usingObjects:";

	private static readonly IntPtr selWillChangeValueForKey_WithSetMutation_UsingObjects_Handle = Selector.GetHandle("willChangeValueForKey:withSetMutation:usingObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillSave = "willSave";

	private static readonly IntPtr selWillSaveHandle = Selector.GetHandle("willSave");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillTurnIntoFault = "willTurnIntoFault";

	private static readonly IntPtr selWillTurnIntoFaultHandle = Selector.GetHandle("willTurnIntoFault");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSManagedObject");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ChangedValues
	{
		[Export("changedValues")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selChangedValuesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangedValuesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ChangedValuesForCurrentEvent
	{
		[Export("changedValuesForCurrentEvent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selChangedValuesForCurrentEventHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangedValuesForCurrentEventHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ContextShouldIgnoreUnModeledPropertyChanges
	{
		[Export("contextShouldIgnoreUnmodeledPropertyChanges")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selContextShouldIgnoreUnmodeledPropertyChangesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityDescription Entity
	{
		[Export("entity", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityHandle));
			}
			return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FaultingState
	{
		[Export("faultingState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFaultingStateHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFaultingStateHandle);
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
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool HasPersistentChangedValues
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("hasPersistentChangedValues")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasPersistentChangedValuesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasPersistentChangedValuesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDeleted
	{
		[Export("isDeleted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDeletedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDeletedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFault
	{
		[Export("isFault")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFaultHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFaultHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsInserted
	{
		[Export("isInserted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInsertedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInsertedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsUpdated
	{
		[Export("isUpdated")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUpdatedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUpdatedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectContext? ManagedObjectContext
	{
		[Export("managedObjectContext")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selManagedObjectContextHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManagedObjectContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectID ObjectID
	{
		[Export("objectID", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectIDHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual IntPtr ObservationInfo
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("observationInfo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selObservationInfoHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObservationInfoHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("setObservationInfo:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObservationInfo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObservationInfo_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSManagedObject(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSManagedObject(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithEntity:insertIntoManagedObjectContext:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSManagedObject(NSEntityDescription entity, NSManagedObjectContext? context)
		: base(NSObjectFlag.Empty)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithEntity_InsertIntoManagedObjectContext_Handle, entity.Handle, context?.Handle ?? IntPtr.Zero), "initWithEntity:insertIntoManagedObjectContext:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithEntity_InsertIntoManagedObjectContext_Handle, entity.Handle, context?.Handle ?? IntPtr.Zero), "initWithEntity:insertIntoManagedObjectContext:");
		}
	}

	[Export("initWithContext:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSManagedObject(NSManagedObjectContext moc)
		: base(NSObjectFlag.Empty)
	{
		if (moc == null)
		{
			throw new ArgumentNullException("moc");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContext_Handle, moc.Handle), "initWithContext:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContext_Handle, moc.Handle), "initWithContext:");
		}
	}

	[Export("awakeFromFetch")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AwakeFromFetch()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAwakeFromFetchHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAwakeFromFetchHandle);
		}
	}

	[Export("awakeFromInsert")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AwakeFromInsert()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAwakeFromInsertHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAwakeFromInsertHandle);
		}
	}

	[Export("awakeFromSnapshotEvents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AwakeFromSnapshotEvents(NSSnapshotEventType flags)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selAwakeFromSnapshotEvents_Handle, (ulong)flags);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selAwakeFromSnapshotEvents_Handle, (ulong)flags);
		}
	}

	[Export("committedValuesForKeys:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary CommittedValuesForKeys(string[]? keys)
	{
		NSArray nSArray = ((keys == null) ? null : NSArray.FromStrings(keys));
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCommittedValuesForKeys_Handle, nSArray?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCommittedValuesForKeys_Handle, nSArray?.Handle ?? IntPtr.Zero)));
		nSArray?.Dispose();
		return result;
	}

	[Export("fetchRequest")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFetchRequest CreateFetchRequest()
	{
		return Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSend(class_ptr, selFetchRequestHandle));
	}

	[Export("didAccessValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidAccessValueForKey(string? key)
	{
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidAccessValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidAccessValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("didChangeValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidChangeValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidChangeValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("didChangeValueForKey:withSetMutation:usingObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeValueForKey(string inKey, NSKeyValueSetMutationKind inMutationKind, NSSet inObjects)
	{
		if (inKey == null)
		{
			throw new ArgumentNullException("inKey");
		}
		if (inObjects == null)
		{
			throw new ArgumentNullException("inObjects");
		}
		IntPtr arg = NSString.CreateNative(inKey);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selDidChangeValueForKey_WithSetMutation_UsingObjects_Handle, arg, (ulong)inMutationKind, inObjects.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selDidChangeValueForKey_WithSetMutation_UsingObjects_Handle, arg, (ulong)inMutationKind, inObjects.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("didSave")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSave()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidSaveHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidSaveHandle);
		}
	}

	[Export("didTurnIntoFault")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidTurnIntoFault()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidTurnIntoFaultHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidTurnIntoFaultHandle);
		}
	}

	[Export("entity")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSEntityDescription GetEntityDescription()
	{
		return Runtime.GetNSObject<NSEntityDescription>(Messaging.IntPtr_objc_msgSend(class_ptr, selEntityHandle));
	}

	[Export("objectIDsForRelationshipNamed:")]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectID[] GetObjectIDs(string relationshipName)
	{
		if (relationshipName == null)
		{
			throw new ArgumentNullException("relationshipName");
		}
		IntPtr arg = NSString.CreateNative(relationshipName);
		NSManagedObjectID[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSManagedObjectID>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectIDsForRelationshipNamed_Handle, arg)) : NSArray.ArrayFromHandle<NSManagedObjectID>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectIDsForRelationshipNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("hasFaultForRelationshipNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasFaultForRelationshipNamed(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasFaultForRelationshipNamed_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasFaultForRelationshipNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("prepareForDeletion")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareForDeletion()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareForDeletionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareForDeletionHandle);
		}
	}

	[Export("primitiveValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr PrimitiveValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrimitiveValueForKey_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPrimitiveValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setPrimitiveValue:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetPrimitiveValue(IntPtr value, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetPrimitiveValue_ForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetPrimitiveValue_ForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setValue:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(IntPtr value, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValue_ForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValue_ForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("validateForDelete:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateForDelete(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selValidateForDelete_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selValidateForDelete_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("validateForInsert:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateForInsert(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selValidateForInsert_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selValidateForInsert_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("validateForUpdate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateForUpdate(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selValidateForUpdate_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selValidateForUpdate_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("validateValue:forKey:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateValue(ref NSObject value, string key, out NSError error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = ((value == null) ? IntPtr.Zero : value.Handle);
		IntPtr arg2 = IntPtr.Zero;
		IntPtr arg3 = NSString.CreateNative(key);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selValidateValue_ForKey_Error_Handle, ref arg, arg3, ref arg2) : Messaging.bool_objc_msgSend_ref_IntPtr_IntPtr_ref_IntPtr(base.Handle, selValidateValue_ForKey_Error_Handle, ref arg, arg3, ref arg2));
		NSString.ReleaseNative(arg3);
		value = Runtime.GetNSObject<NSObject>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}

	[Export("valueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr ValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForKey_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("willAccessValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillAccessValueForKey(string? key)
	{
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillAccessValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillAccessValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("willChangeValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillChangeValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillChangeValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillChangeValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("willChangeValueForKey:withSetMutation:usingObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillChangeValueForKey(string inKey, NSKeyValueSetMutationKind inMutationKind, NSSet inObjects)
	{
		if (inKey == null)
		{
			throw new ArgumentNullException("inKey");
		}
		if (inObjects == null)
		{
			throw new ArgumentNullException("inObjects");
		}
		IntPtr arg = NSString.CreateNative(inKey);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selWillChangeValueForKey_WithSetMutation_UsingObjects_Handle, arg, (ulong)inMutationKind, inObjects.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selWillChangeValueForKey_WithSetMutation_UsingObjects_Handle, arg, (ulong)inMutationKind, inObjects.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("willSave")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillSave()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWillSaveHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWillSaveHandle);
		}
	}

	[Export("willTurnIntoFault")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillTurnIntoFault()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWillTurnIntoFaultHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWillTurnIntoFaultHandle);
		}
	}
}
