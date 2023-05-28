using Foundation;

namespace CoreData;

public class UserInfo : DictionaryContainer
{
	public NSError[]? DetailedErrors
	{
		get
		{
			return GetArray<NSError>(UserInfoKeys.DetailedErrorsKey);
		}
		set
		{
			SetArrayValue(UserInfoKeys.DetailedErrorsKey, value);
		}
	}

	public NSManagedObject? ObjectForValidationError
	{
		get
		{
			return base.Dictionary[UserInfoKeys.ObjectForValidationErrorKey] as NSManagedObject;
		}
		set
		{
			SetNativeValue(UserInfoKeys.ObjectForValidationErrorKey, value);
		}
	}

	public NSString? KeyForValidationError
	{
		get
		{
			return GetNSStringValue(UserInfoKeys.KeyForValidationErrorKey);
		}
		set
		{
			SetStringValue(UserInfoKeys.KeyForValidationErrorKey, value);
		}
	}

	public NSPredicate? PredicateForValidationError
	{
		get
		{
			return base.Dictionary[UserInfoKeys.PredicateForValidationErrorKey] as NSPredicate;
		}
		set
		{
			SetNativeValue(UserInfoKeys.PredicateForValidationErrorKey, value);
		}
	}

	public NSValue? ValueForValidationError
	{
		get
		{
			return base.Dictionary[UserInfoKeys.ValueForValidationErrorKey] as NSValue;
		}
		set
		{
			SetNativeValue(UserInfoKeys.ValueForValidationErrorKey, value);
		}
	}

	public NSMergeConflict[]? PersistentStoreSaveConflicts
	{
		get
		{
			return GetArray<NSMergeConflict>(UserInfoKeys.PersistentStoreSaveConflictsKey);
		}
		set
		{
			SetArrayValue(UserInfoKeys.PersistentStoreSaveConflictsKey, value);
		}
	}

	public NSPersistentStore[]? AffectedStoresForError
	{
		get
		{
			return GetArray<NSPersistentStore>(UserInfoKeys.AffectedStoresForErrorKey);
		}
		set
		{
			SetArrayValue(UserInfoKeys.AffectedStoresForErrorKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public UserInfo()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public UserInfo(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
