using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSFetchRequest", true)]
public class NSFetchRequest : NSPersistentStoreRequest
{
	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	private static readonly IntPtr selSetEntity_Handle = Selector.GetHandle("setEntity:");

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	private static readonly IntPtr selSetPredicate_Handle = Selector.GetHandle("setPredicate:");

	private static readonly IntPtr selSortDescriptorsHandle = Selector.GetHandle("sortDescriptors");

	private static readonly IntPtr selSetSortDescriptors_Handle = Selector.GetHandle("setSortDescriptors:");

	private static readonly IntPtr selFetchLimitHandle = Selector.GetHandle("fetchLimit");

	private static readonly IntPtr selSetFetchLimit_Handle = Selector.GetHandle("setFetchLimit:");

	private static readonly IntPtr selAffectedStoresHandle = Selector.GetHandle("affectedStores");

	private static readonly IntPtr selSetAffectedStores_Handle = Selector.GetHandle("setAffectedStores:");

	private static readonly IntPtr selResultTypeHandle = Selector.GetHandle("resultType");

	private static readonly IntPtr selSetResultType_Handle = Selector.GetHandle("setResultType:");

	private static readonly IntPtr selIncludesSubentitiesHandle = Selector.GetHandle("includesSubentities");

	private static readonly IntPtr selSetIncludesSubentities_Handle = Selector.GetHandle("setIncludesSubentities:");

	private static readonly IntPtr selIncludesPropertyValuesHandle = Selector.GetHandle("includesPropertyValues");

	private static readonly IntPtr selSetIncludesPropertyValues_Handle = Selector.GetHandle("setIncludesPropertyValues:");

	private static readonly IntPtr selReturnsObjectsAsFaultsHandle = Selector.GetHandle("returnsObjectsAsFaults");

	private static readonly IntPtr selSetReturnsObjectsAsFaults_Handle = Selector.GetHandle("setReturnsObjectsAsFaults:");

	private static readonly IntPtr selRelationshipKeyPathsForPrefetchingHandle = Selector.GetHandle("relationshipKeyPathsForPrefetching");

	private static readonly IntPtr selSetRelationshipKeyPathsForPrefetching_Handle = Selector.GetHandle("setRelationshipKeyPathsForPrefetching:");

	private static readonly IntPtr selEntityNameHandle = Selector.GetHandle("entityName");

	private static readonly IntPtr selFetchBatchSizeHandle = Selector.GetHandle("fetchBatchSize");

	private static readonly IntPtr selSetFetchBatchSize_Handle = Selector.GetHandle("setFetchBatchSize:");

	private static readonly IntPtr selShouldRefreshRefetchedObjectsHandle = Selector.GetHandle("shouldRefreshRefetchedObjects");

	private static readonly IntPtr selSetShouldRefreshRefetchedObjects_Handle = Selector.GetHandle("setShouldRefreshRefetchedObjects:");

	private static readonly IntPtr selHavingPredicateHandle = Selector.GetHandle("havingPredicate");

	private static readonly IntPtr selSetHavingPredicate_Handle = Selector.GetHandle("setHavingPredicate:");

	private static readonly IntPtr selPropertiesToGroupByHandle = Selector.GetHandle("propertiesToGroupBy");

	private static readonly IntPtr selSetPropertiesToGroupBy_Handle = Selector.GetHandle("setPropertiesToGroupBy:");

	private static readonly IntPtr selFetchRequestWithEntityName_Handle = Selector.GetHandle("fetchRequestWithEntityName:");

	private static readonly IntPtr selInitWithEntityName_Handle = Selector.GetHandle("initWithEntityName:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFetchRequest");

	private object __mt_Entity_var;

	private object __mt_Predicate_var;

	private object __mt_SortDescriptors_var;

	private object __mt_AffectedStores_var;

	private object __mt_HavingPredicate_var;

	private object __mt_PropertiesToGroupBy_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSEntityDescription Entity
	{
		[Export("entity")]
		get
		{
			return (NSEntityDescription)(__mt_Entity_var = ((!IsDirectBinding) ? ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityHandle))) : ((NSEntityDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityHandle)))));
		}
		[Export("setEntity:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEntity_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEntity_Handle, value.Handle);
			}
			__mt_Entity_var = value;
		}
	}

	public virtual NSPredicate Predicate
	{
		[Export("predicate")]
		get
		{
			return (NSPredicate)(__mt_Predicate_var = ((!IsDirectBinding) ? ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle))) : ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle)))));
		}
		[Export("setPredicate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPredicate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPredicate_Handle, value.Handle);
			}
			__mt_Predicate_var = value;
		}
	}

	public virtual NSSortDescriptor[] SortDescriptors
	{
		[Export("sortDescriptors")]
		get
		{
			return (NSSortDescriptor[])(__mt_SortDescriptors_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorsHandle)) : NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorsHandle))));
		}
		[Export("setSortDescriptors:")]
		set
		{
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

	public virtual uint FetchLimit
	{
		[Export("fetchLimit")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selFetchLimitHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFetchLimitHandle);
		}
		[Export("setFetchLimit:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetFetchLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetFetchLimit_Handle, value);
			}
		}
	}

	public new virtual NSPersistentStore[] AffectedStores
	{
		[Export("affectedStores")]
		get
		{
			return (NSPersistentStore[])(__mt_AffectedStores_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPersistentStore>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAffectedStoresHandle)) : NSArray.ArrayFromHandle<NSPersistentStore>(Messaging.IntPtr_objc_msgSend(base.Handle, selAffectedStoresHandle))));
		}
		[Export("setAffectedStores:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAffectedStores_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAffectedStores_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_AffectedStores_var = value;
		}
	}

	public virtual NSFetchRequestResultType ResultType
	{
		[Export("resultType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSFetchRequestResultType)Messaging.UInt64_objc_msgSend(base.Handle, selResultTypeHandle);
			}
			return (NSFetchRequestResultType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResultTypeHandle);
		}
		[Export("setResultType:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetResultType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetResultType_Handle, (ulong)value);
			}
		}
	}

	public virtual bool IncludesSubentities
	{
		[Export("includesSubentities")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesSubentitiesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesSubentitiesHandle);
		}
		[Export("setIncludesSubentities:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesSubentities_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesSubentities_Handle, value);
			}
		}
	}

	public virtual bool IncludesPropertyValues
	{
		[Export("includesPropertyValues")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesPropertyValuesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesPropertyValuesHandle);
		}
		[Export("setIncludesPropertyValues:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesPropertyValues_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesPropertyValues_Handle, value);
			}
		}
	}

	public virtual bool ReturnsObjectsAsFaults
	{
		[Export("returnsObjectsAsFaults")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReturnsObjectsAsFaultsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReturnsObjectsAsFaultsHandle);
		}
		[Export("setReturnsObjectsAsFaults:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReturnsObjectsAsFaults_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReturnsObjectsAsFaults_Handle, value);
			}
		}
	}

	public virtual string[] RelationshipKeyPathsForPrefetching
	{
		[Export("relationshipKeyPathsForPrefetching")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRelationshipKeyPathsForPrefetchingHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelationshipKeyPathsForPrefetchingHandle));
		}
		[Export("setRelationshipKeyPathsForPrefetching:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRelationshipKeyPathsForPrefetching_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRelationshipKeyPathsForPrefetching_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[Since(5, 0)]
	public virtual string EntityName
	{
		[Export("entityName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityNameHandle));
		}
	}

	[Since(5, 0)]
	public virtual int FetchBatchSize
	{
		[Export("fetchBatchSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selFetchBatchSizeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selFetchBatchSizeHandle);
		}
		[Export("setFetchBatchSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetFetchBatchSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetFetchBatchSize_Handle, value);
			}
		}
	}

	[Since(5, 0)]
	public virtual bool ShouldRefreshRefetchedObjects
	{
		[Export("shouldRefreshRefetchedObjects")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldRefreshRefetchedObjectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldRefreshRefetchedObjectsHandle);
		}
		[Export("setShouldRefreshRefetchedObjects:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldRefreshRefetchedObjects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldRefreshRefetchedObjects_Handle, value);
			}
		}
	}

	[Since(5, 0)]
	public virtual NSPredicate HavingPredicate
	{
		[Export("havingPredicate")]
		get
		{
			return (NSPredicate)(__mt_HavingPredicate_var = ((!IsDirectBinding) ? ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHavingPredicateHandle))) : ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHavingPredicateHandle)))));
		}
		[Export("setHavingPredicate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHavingPredicate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHavingPredicate_Handle, value.Handle);
			}
			__mt_HavingPredicate_var = value;
		}
	}

	[Since(5, 0)]
	public virtual NSPropertyDescription[] PropertiesToGroupBy
	{
		[Export("propertiesToGroupBy")]
		get
		{
			return (NSPropertyDescription[])(__mt_PropertiesToGroupBy_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesToGroupByHandle)) : NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesToGroupByHandle))));
		}
		[Export("setPropertiesToGroupBy:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPropertiesToGroupBy_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPropertiesToGroupBy_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_PropertiesToGroupBy_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFetchRequest()
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
	public NSFetchRequest(NSCoder coder)
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
	public NSFetchRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFetchRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("fetchRequestWithEntityName:")]
	public static NSFetchRequest FromEntityName(string entityName)
	{
		if (entityName == null)
		{
			throw new ArgumentNullException("entityName");
		}
		IntPtr arg = NSString.CreateNative(entityName);
		NSFetchRequest result = (NSFetchRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFetchRequestWithEntityName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithEntityName:")]
	public NSFetchRequest(string entityName)
		: base(NSObjectFlag.Empty)
	{
		if (entityName == null)
		{
			throw new ArgumentNullException("entityName");
		}
		IntPtr arg = NSString.CreateNative(entityName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithEntityName_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithEntityName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Entity_var = null;
			__mt_Predicate_var = null;
			__mt_SortDescriptors_var = null;
			__mt_AffectedStores_var = null;
			__mt_HavingPredicate_var = null;
			__mt_PropertiesToGroupBy_var = null;
		}
	}
}
