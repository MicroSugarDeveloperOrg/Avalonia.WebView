using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSManagedObject", true)]
public class NSManagedObject : NSObject
{
	private static readonly IntPtr selManagedObjectContextHandle = Selector.GetHandle("managedObjectContext");

	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	private static readonly IntPtr selObjectIDHandle = Selector.GetHandle("objectID");

	private static readonly IntPtr selIsInsertedHandle = Selector.GetHandle("isInserted");

	private static readonly IntPtr selIsUpdatedHandle = Selector.GetHandle("isUpdated");

	private static readonly IntPtr selIsDeletedHandle = Selector.GetHandle("isDeleted");

	private static readonly IntPtr selIsFaultHandle = Selector.GetHandle("isFault");

	private static readonly IntPtr selObservationInfoHandle = Selector.GetHandle("observationInfo");

	private static readonly IntPtr selSetObservationInfo_Handle = Selector.GetHandle("setObservationInfo:");

	private static readonly IntPtr selChangedValuesHandle = Selector.GetHandle("changedValues");

	private static readonly IntPtr selHasChangesHandle = Selector.GetHandle("hasChanges");

	private static readonly IntPtr selChangedValuesForCurrentEventHandle = Selector.GetHandle("changedValuesForCurrentEvent");

	private static readonly IntPtr selInitWithEntityInsertIntoManagedObjectContext_Handle = Selector.GetHandle("initWithEntity:insertIntoManagedObjectContext:");

	private static readonly IntPtr selHasFaultForRelationshipNamed_Handle = Selector.GetHandle("hasFaultForRelationshipNamed:");

	private static readonly IntPtr selWillAccessValueForKey_Handle = Selector.GetHandle("willAccessValueForKey:");

	private static readonly IntPtr selDidAccessValueForKey_Handle = Selector.GetHandle("didAccessValueForKey:");

	private static readonly IntPtr selWillChangeValueForKey_Handle = Selector.GetHandle("willChangeValueForKey:");

	private static readonly IntPtr selDidChangeValueForKey_Handle = Selector.GetHandle("didChangeValueForKey:");

	private static readonly IntPtr selWillChangeValueForKeyWithSetMutationUsingObjects_Handle = Selector.GetHandle("willChangeValueForKey:withSetMutation:usingObjects:");

	private static readonly IntPtr selDidChangeValueForKeyWithSetMutationUsingObjects_Handle = Selector.GetHandle("didChangeValueForKey:withSetMutation:usingObjects:");

	private static readonly IntPtr selAwakeFromFetchHandle = Selector.GetHandle("awakeFromFetch");

	private static readonly IntPtr selAwakeFromInsertHandle = Selector.GetHandle("awakeFromInsert");

	private static readonly IntPtr selWillSaveHandle = Selector.GetHandle("willSave");

	private static readonly IntPtr selDidSaveHandle = Selector.GetHandle("didSave");

	private static readonly IntPtr selWillTurnIntoFaultHandle = Selector.GetHandle("willTurnIntoFault");

	private static readonly IntPtr selDidTurnIntoFaultHandle = Selector.GetHandle("didTurnIntoFault");

	private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

	private static readonly IntPtr selSetValueForKey_Handle = Selector.GetHandle("setValue:forKey:");

	private static readonly IntPtr selPrimitiveValueForKey_Handle = Selector.GetHandle("primitiveValueForKey:");

	private static readonly IntPtr selSetPrimitiveValueForKey_Handle = Selector.GetHandle("setPrimitiveValue:forKey:");

	private static readonly IntPtr selCommittedValuesForKeys_Handle = Selector.GetHandle("committedValuesForKeys:");

	private static readonly IntPtr selValidateValueForKeyError_Handle = Selector.GetHandle("validateValue:forKey:error:");

	private static readonly IntPtr selValidateForDelete_Handle = Selector.GetHandle("validateForDelete:");

	private static readonly IntPtr selValidateForInsert_Handle = Selector.GetHandle("validateForInsert:");

	private static readonly IntPtr selValidateForUpdate_Handle = Selector.GetHandle("validateForUpdate:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSManagedObject");

	private object __mt_ManagedObjectContext_var;

	private object __mt_Entity_var;

	private object __mt_ObjectID_var;

	private object __mt_ChangedValues_var;

	private object __mt_ChangedValuesForCurrentEvent_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSManagedObjectContext ManagedObjectContext
	{
		[Export("managedObjectContext")]
		get
		{
			return (NSManagedObjectContext)(__mt_ManagedObjectContext_var = ((!IsDirectBinding) ? ((NSManagedObjectContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManagedObjectContextHandle))) : ((NSManagedObjectContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selManagedObjectContextHandle)))));
		}
	}

	public virtual NSEntityDescription Entity
	{
		[Export("entity")]
		get
		{
			return (NSEntityDescription)(__mt_Entity_var = ((!IsDirectBinding) ? ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityHandle))) : ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityHandle)))));
		}
	}

	public virtual NSManagedObjectID ObjectID
	{
		[Export("objectID")]
		get
		{
			return (NSManagedObjectID)(__mt_ObjectID_var = ((!IsDirectBinding) ? ((NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectIDHandle))) : ((NSManagedObjectID)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectIDHandle)))));
		}
	}

	public virtual bool IsInserted
	{
		[Export("isInserted")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInsertedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInsertedHandle);
		}
	}

	public virtual bool IsUpdated
	{
		[Export("isUpdated")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUpdatedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUpdatedHandle);
		}
	}

	public virtual bool IsDeleted
	{
		[Export("isDeleted")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDeletedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDeletedHandle);
		}
	}

	public virtual bool IsFault
	{
		[Export("isFault")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFaultHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFaultHandle);
		}
	}

	public virtual IntPtr ObservationInfo
	{
		[Export("observationInfo")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selObservationInfoHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObservationInfoHandle);
		}
		[Export("setObservationInfo:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObservationInfo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObservationInfo_Handle, value);
			}
		}
	}

	public virtual NSDictionary ChangedValues
	{
		[Export("changedValues")]
		get
		{
			return (NSDictionary)(__mt_ChangedValues_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangedValuesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selChangedValuesHandle)))));
		}
	}

	[Since(5, 0)]
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

	public virtual NSDictionary ChangedValuesForCurrentEvent
	{
		[Export("changedValuesForCurrentEvent")]
		get
		{
			return (NSDictionary)(__mt_ChangedValuesForCurrentEvent_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangedValuesForCurrentEventHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selChangedValuesForCurrentEventHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSManagedObject(NSCoder coder)
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
	public NSManagedObject(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSManagedObject(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithEntity:insertIntoManagedObjectContext:")]
	public NSManagedObject(NSEntityDescription entity, NSManagedObjectContext context)
		: base(NSObjectFlag.Empty)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithEntityInsertIntoManagedObjectContext_Handle, entity.Handle, context.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithEntityInsertIntoManagedObjectContext_Handle, entity.Handle, context.Handle);
		}
	}

	[Export("hasFaultForRelationshipNamed:")]
	public virtual bool HasFaultForRelationshipNamed(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasFaultForRelationshipNamed_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasFaultForRelationshipNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("willAccessValueForKey:")]
	public virtual void WillAccessValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillAccessValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillAccessValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("didAccessValueForKey:")]
	public virtual void DidAccessValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidAccessValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidAccessValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("willChangeValueForKey:")]
	public virtual void WillChangeValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillChangeValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillChangeValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("didChangeValueForKey:")]
	public virtual void DidChangeValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidChangeValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidChangeValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("willChangeValueForKey:withSetMutation:usingObjects:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selWillChangeValueForKeyWithSetMutationUsingObjects_Handle, arg, (ulong)inMutationKind, inObjects.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selWillChangeValueForKeyWithSetMutationUsingObjects_Handle, arg, (ulong)inMutationKind, inObjects.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("didChangeValueForKey:withSetMutation:usingObjects:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selDidChangeValueForKeyWithSetMutationUsingObjects_Handle, arg, (ulong)inMutationKind, inObjects.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selDidChangeValueForKeyWithSetMutationUsingObjects_Handle, arg, (ulong)inMutationKind, inObjects.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("awakeFromFetch")]
	public virtual void AwakeFromFetch()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAwakeFromFetchHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAwakeFromFetchHandle);
		}
	}

	[Export("awakeFromInsert")]
	public virtual void AwakeFromInsert()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAwakeFromInsertHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAwakeFromInsertHandle);
		}
	}

	[Export("willSave")]
	public virtual void WillSave()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWillSaveHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWillSaveHandle);
		}
	}

	[Export("didSave")]
	public virtual void DidSave()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidSaveHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidSaveHandle);
		}
	}

	[Export("willTurnIntoFault")]
	public virtual void WillTurnIntoFault()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWillTurnIntoFaultHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWillTurnIntoFaultHandle);
		}
	}

	[Export("didTurnIntoFault")]
	public virtual void DidTurnIntoFault()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidTurnIntoFaultHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidTurnIntoFaultHandle);
		}
	}

	[Export("valueForKey:")]
	public virtual IntPtr ValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr result = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForKey_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setValue:forKey:")]
	public virtual void SetValue(IntPtr value, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValueForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValueForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("primitiveValueForKey:")]
	public virtual IntPtr PrimitiveValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr result = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrimitiveValueForKey_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPrimitiveValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setPrimitiveValue:forKey:")]
	public virtual void SetPrimitiveValue(IntPtr value, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetPrimitiveValueForKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetPrimitiveValueForKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("committedValuesForKeys:")]
	public virtual NSDictionary CommittedValuesForKeys(string[] keys)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		NSArray nSArray = NSArray.FromStrings(keys);
		NSDictionary result = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCommittedValuesForKeys_Handle, nSArray.Handle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCommittedValuesForKeys_Handle, nSArray.Handle))));
		nSArray.Dispose();
		return result;
	}

	[Export("validateValue:forKey:error:")]
	public virtual bool ValidateValue(NSObject value, string key, out NSError error)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selValidateValueForKeyError_Handle, value.Handle, arg, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selValidateValueForKeyError_Handle, value.Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("validateForDelete:")]
	public virtual bool ValidateForDelete(out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateForDelete_Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateForDelete_Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("validateForInsert:")]
	public virtual bool ValidateForInsert(out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateForInsert_Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateForInsert_Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("validateForUpdate:")]
	public virtual bool ValidateForUpdate(out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateForUpdate_Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateForUpdate_Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ManagedObjectContext_var = null;
			__mt_Entity_var = null;
			__mt_ObjectID_var = null;
			__mt_ChangedValues_var = null;
			__mt_ChangedValuesForCurrentEvent_var = null;
		}
	}
}
