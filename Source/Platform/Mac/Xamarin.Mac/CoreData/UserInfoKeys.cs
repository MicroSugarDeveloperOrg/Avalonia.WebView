using Foundation;
using ObjCRuntime;

namespace CoreData;

public static class UserInfoKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AffectedStoresForErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DetailedErrorsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyForValidationErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ObjectForValidationErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PersistentStoreSaveConflictsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PredicateForValidationErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ValueForValidationErrorKey;

	[Field("NSAffectedStoresErrorKey", "CoreData")]
	public static NSString AffectedStoresForErrorKey
	{
		get
		{
			if (_AffectedStoresForErrorKey == null)
			{
				_AffectedStoresForErrorKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSAffectedStoresErrorKey");
			}
			return _AffectedStoresForErrorKey;
		}
	}

	[Field("NSDetailedErrorsKey", "CoreData")]
	public static NSString DetailedErrorsKey
	{
		get
		{
			if (_DetailedErrorsKey == null)
			{
				_DetailedErrorsKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSDetailedErrorsKey");
			}
			return _DetailedErrorsKey;
		}
	}

	[Field("NSValidationKeyErrorKey", "CoreData")]
	public static NSString KeyForValidationErrorKey
	{
		get
		{
			if (_KeyForValidationErrorKey == null)
			{
				_KeyForValidationErrorKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSValidationKeyErrorKey");
			}
			return _KeyForValidationErrorKey;
		}
	}

	[Field("NSValidationObjectErrorKey", "CoreData")]
	public static NSString ObjectForValidationErrorKey
	{
		get
		{
			if (_ObjectForValidationErrorKey == null)
			{
				_ObjectForValidationErrorKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSValidationObjectErrorKey");
			}
			return _ObjectForValidationErrorKey;
		}
	}

	[Field("NSPersistentStoreSaveConflictsErrorKey", "CoreData")]
	public static NSString PersistentStoreSaveConflictsKey
	{
		get
		{
			if (_PersistentStoreSaveConflictsKey == null)
			{
				_PersistentStoreSaveConflictsKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreSaveConflictsErrorKey");
			}
			return _PersistentStoreSaveConflictsKey;
		}
	}

	[Field("NSValidationPredicateErrorKey", "CoreData")]
	public static NSString PredicateForValidationErrorKey
	{
		get
		{
			if (_PredicateForValidationErrorKey == null)
			{
				_PredicateForValidationErrorKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSValidationPredicateErrorKey");
			}
			return _PredicateForValidationErrorKey;
		}
	}

	[Field("NSValidationValueErrorKey", "CoreData")]
	public static NSString ValueForValidationErrorKey
	{
		get
		{
			if (_ValueForValidationErrorKey == null)
			{
				_ValueForValidationErrorKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSValidationValueErrorKey");
			}
			return _ValueForValidationErrorKey;
		}
	}
}
