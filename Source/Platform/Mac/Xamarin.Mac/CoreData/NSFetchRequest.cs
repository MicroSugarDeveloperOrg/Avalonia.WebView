using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreData;

[Register("NSFetchRequest", true)]
public class NSFetchRequest : NSPersistentStoreRequest, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAffectedStores = "affectedStores";

	private static readonly IntPtr selAffectedStoresHandle = Selector.GetHandle("affectedStores");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntity = "entity";

	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntityName = "entityName";

	private static readonly IntPtr selEntityNameHandle = Selector.GetHandle("entityName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecute_ = "execute:";

	private static readonly IntPtr selExecute_Handle = Selector.GetHandle("execute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchBatchSize = "fetchBatchSize";

	private static readonly IntPtr selFetchBatchSizeHandle = Selector.GetHandle("fetchBatchSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchLimit = "fetchLimit";

	private static readonly IntPtr selFetchLimitHandle = Selector.GetHandle("fetchLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchOffset = "fetchOffset";

	private static readonly IntPtr selFetchOffsetHandle = Selector.GetHandle("fetchOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRequestWithEntityName_ = "fetchRequestWithEntityName:";

	private static readonly IntPtr selFetchRequestWithEntityName_Handle = Selector.GetHandle("fetchRequestWithEntityName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHavingPredicate = "havingPredicate";

	private static readonly IntPtr selHavingPredicateHandle = Selector.GetHandle("havingPredicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesPendingChanges = "includesPendingChanges";

	private static readonly IntPtr selIncludesPendingChangesHandle = Selector.GetHandle("includesPendingChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesPropertyValues = "includesPropertyValues";

	private static readonly IntPtr selIncludesPropertyValuesHandle = Selector.GetHandle("includesPropertyValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesSubentities = "includesSubentities";

	private static readonly IntPtr selIncludesSubentitiesHandle = Selector.GetHandle("includesSubentities");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithEntityName_ = "initWithEntityName:";

	private static readonly IntPtr selInitWithEntityName_Handle = Selector.GetHandle("initWithEntityName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicate = "predicate";

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertiesToFetch = "propertiesToFetch";

	private static readonly IntPtr selPropertiesToFetchHandle = Selector.GetHandle("propertiesToFetch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertiesToGroupBy = "propertiesToGroupBy";

	private static readonly IntPtr selPropertiesToGroupByHandle = Selector.GetHandle("propertiesToGroupBy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelationshipKeyPathsForPrefetching = "relationshipKeyPathsForPrefetching";

	private static readonly IntPtr selRelationshipKeyPathsForPrefetchingHandle = Selector.GetHandle("relationshipKeyPathsForPrefetching");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultType = "resultType";

	private static readonly IntPtr selResultTypeHandle = Selector.GetHandle("resultType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReturnsDistinctResults = "returnsDistinctResults";

	private static readonly IntPtr selReturnsDistinctResultsHandle = Selector.GetHandle("returnsDistinctResults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReturnsObjectsAsFaults = "returnsObjectsAsFaults";

	private static readonly IntPtr selReturnsObjectsAsFaultsHandle = Selector.GetHandle("returnsObjectsAsFaults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAffectedStores_ = "setAffectedStores:";

	private static readonly IntPtr selSetAffectedStores_Handle = Selector.GetHandle("setAffectedStores:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEntity_ = "setEntity:";

	private static readonly IntPtr selSetEntity_Handle = Selector.GetHandle("setEntity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchBatchSize_ = "setFetchBatchSize:";

	private static readonly IntPtr selSetFetchBatchSize_Handle = Selector.GetHandle("setFetchBatchSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchLimit_ = "setFetchLimit:";

	private static readonly IntPtr selSetFetchLimit_Handle = Selector.GetHandle("setFetchLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchOffset_ = "setFetchOffset:";

	private static readonly IntPtr selSetFetchOffset_Handle = Selector.GetHandle("setFetchOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHavingPredicate_ = "setHavingPredicate:";

	private static readonly IntPtr selSetHavingPredicate_Handle = Selector.GetHandle("setHavingPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludesPendingChanges_ = "setIncludesPendingChanges:";

	private static readonly IntPtr selSetIncludesPendingChanges_Handle = Selector.GetHandle("setIncludesPendingChanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludesPropertyValues_ = "setIncludesPropertyValues:";

	private static readonly IntPtr selSetIncludesPropertyValues_Handle = Selector.GetHandle("setIncludesPropertyValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludesSubentities_ = "setIncludesSubentities:";

	private static readonly IntPtr selSetIncludesSubentities_Handle = Selector.GetHandle("setIncludesSubentities:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPredicate_ = "setPredicate:";

	private static readonly IntPtr selSetPredicate_Handle = Selector.GetHandle("setPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPropertiesToFetch_ = "setPropertiesToFetch:";

	private static readonly IntPtr selSetPropertiesToFetch_Handle = Selector.GetHandle("setPropertiesToFetch:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPropertiesToGroupBy_ = "setPropertiesToGroupBy:";

	private static readonly IntPtr selSetPropertiesToGroupBy_Handle = Selector.GetHandle("setPropertiesToGroupBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRelationshipKeyPathsForPrefetching_ = "setRelationshipKeyPathsForPrefetching:";

	private static readonly IntPtr selSetRelationshipKeyPathsForPrefetching_Handle = Selector.GetHandle("setRelationshipKeyPathsForPrefetching:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultType_ = "setResultType:";

	private static readonly IntPtr selSetResultType_Handle = Selector.GetHandle("setResultType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReturnsDistinctResults_ = "setReturnsDistinctResults:";

	private static readonly IntPtr selSetReturnsDistinctResults_Handle = Selector.GetHandle("setReturnsDistinctResults:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReturnsObjectsAsFaults_ = "setReturnsObjectsAsFaults:";

	private static readonly IntPtr selSetReturnsObjectsAsFaults_Handle = Selector.GetHandle("setReturnsObjectsAsFaults:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldRefreshRefetchedObjects_ = "setShouldRefreshRefetchedObjects:";

	private static readonly IntPtr selSetShouldRefreshRefetchedObjects_Handle = Selector.GetHandle("setShouldRefreshRefetchedObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSortDescriptors_ = "setSortDescriptors:";

	private static readonly IntPtr selSetSortDescriptors_Handle = Selector.GetHandle("setSortDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldRefreshRefetchedObjects = "shouldRefreshRefetchedObjects";

	private static readonly IntPtr selShouldRefreshRefetchedObjectsHandle = Selector.GetHandle("shouldRefreshRefetchedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortDescriptors = "sortDescriptors";

	private static readonly IntPtr selSortDescriptorsHandle = Selector.GetHandle("sortDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFetchRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSPersistentStore[]? AffectedStores
	{
		[Export("affectedStores", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPersistentStore>(Messaging.IntPtr_objc_msgSend(base.Handle, selAffectedStoresHandle));
			}
			return NSArray.ArrayFromHandle<NSPersistentStore>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAffectedStoresHandle));
		}
		[Export("setAffectedStores:", ArgumentSemantic.Retain)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAffectedStores_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAffectedStores_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityDescription? Entity
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
		[Export("setEntity:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEntity_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEntity_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? EntityName
	{
		[Export("entityName", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint FetchBatchSize
	{
		[Export("fetchBatchSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selFetchBatchSizeHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selFetchBatchSizeHandle);
		}
		[Export("setFetchBatchSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetFetchBatchSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetFetchBatchSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FetchLimit
	{
		[Export("fetchLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFetchLimitHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFetchLimitHandle);
		}
		[Export("setFetchLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetFetchLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetFetchLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FetchOffset
	{
		[Export("fetchOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFetchOffsetHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFetchOffsetHandle);
		}
		[Export("setFetchOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetFetchOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetFetchOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate? HavingPredicate
	{
		[Export("havingPredicate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selHavingPredicateHandle));
			}
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHavingPredicateHandle));
		}
		[Export("setHavingPredicate:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHavingPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHavingPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncludesPendingChanges
	{
		[Export("includesPendingChanges")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesPendingChangesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesPendingChangesHandle);
		}
		[Export("setIncludesPendingChanges:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesPendingChanges_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesPendingChanges_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncludesPropertyValues
	{
		[Export("includesPropertyValues")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesPropertyValuesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesPropertyValuesHandle);
		}
		[Export("setIncludesPropertyValues:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesPropertyValues_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesPropertyValues_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncludesSubentities
	{
		[Export("includesSubentities")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesSubentitiesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesSubentitiesHandle);
		}
		[Export("setIncludesSubentities:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesSubentities_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesSubentities_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate? Predicate
	{
		[Export("predicate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle));
			}
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle));
		}
		[Export("setPredicate:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPropertyDescription[]? PropertiesToFetch
	{
		[Export("propertiesToFetch", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesToFetchHandle));
			}
			return NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesToFetchHandle));
		}
		[Export("setPropertiesToFetch:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPropertiesToFetch_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPropertiesToFetch_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPropertyDescription[]? PropertiesToGroupBy
	{
		[Export("propertiesToGroupBy", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesToGroupByHandle));
			}
			return NSArray.ArrayFromHandle<NSPropertyDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesToGroupByHandle));
		}
		[Export("setPropertiesToGroupBy:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPropertiesToGroupBy_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPropertiesToGroupBy_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? RelationshipKeyPathsForPrefetching
	{
		[Export("relationshipKeyPathsForPrefetching")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRelationshipKeyPathsForPrefetchingHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelationshipKeyPathsForPrefetchingHandle));
		}
		[Export("setRelationshipKeyPathsForPrefetching:")]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRelationshipKeyPathsForPrefetching_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRelationshipKeyPathsForPrefetching_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFetchRequestResultType ResultType
	{
		[Export("resultType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSFetchRequestResultType)Messaging.UInt64_objc_msgSend(base.Handle, selResultTypeHandle);
			}
			return (NSFetchRequestResultType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResultTypeHandle);
		}
		[Export("setResultType:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetResultType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetResultType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReturnsDistinctResults
	{
		[Export("returnsDistinctResults")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReturnsDistinctResultsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReturnsDistinctResultsHandle);
		}
		[Export("setReturnsDistinctResults:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReturnsDistinctResults_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReturnsDistinctResults_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReturnsObjectsAsFaults
	{
		[Export("returnsObjectsAsFaults")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReturnsObjectsAsFaultsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReturnsObjectsAsFaultsHandle);
		}
		[Export("setReturnsObjectsAsFaults:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReturnsObjectsAsFaults_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReturnsObjectsAsFaults_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldRefreshRefetchedObjects
	{
		[Export("shouldRefreshRefetchedObjects")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldRefreshRefetchedObjectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldRefreshRefetchedObjectsHandle);
		}
		[Export("setShouldRefreshRefetchedObjects:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldRefreshRefetchedObjects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldRefreshRefetchedObjects_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSortDescriptor[]? SortDescriptors
	{
		[Export("sortDescriptors", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorsHandle));
			}
			return NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorsHandle));
		}
		[Export("setSortDescriptors:", ArgumentSemantic.Retain)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSortDescriptors_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSortDescriptors_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFetchRequest(NSCoder coder)
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
	protected NSFetchRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFetchRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFetchRequest()
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

	[Export("initWithEntityName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFetchRequest(string entityName)
		: base(NSObjectFlag.Empty)
	{
		if (entityName == null)
		{
			throw new ArgumentNullException("entityName");
		}
		IntPtr arg = NSString.CreateNative(entityName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithEntityName_Handle, arg), "initWithEntityName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithEntityName_Handle, arg), "initWithEntityName:");
		}
		NSString.ReleaseNative(arg);
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

	[Export("execute:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSFetchRequestResult[]? Execute(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		INSFetchRequestResult[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<INSFetchRequestResult>(Messaging.IntPtr_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selExecute_Handle, ref arg)) : NSArray.ArrayFromHandle<INSFetchRequestResult>(Messaging.IntPtr_objc_msgSend_ref_IntPtr(base.Handle, selExecute_Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("fetchRequestWithEntityName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFetchRequest FromEntityName(string entityName)
	{
		if (entityName == null)
		{
			throw new ArgumentNullException("entityName");
		}
		IntPtr arg = NSString.CreateNative(entityName);
		NSFetchRequest nSObject = Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFetchRequestWithEntityName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
