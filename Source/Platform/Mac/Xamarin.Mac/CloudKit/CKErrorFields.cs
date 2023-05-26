using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public static class CKErrorFields
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorRetryAfterKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PartialErrorsByItemIdKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RecordChangedErrorAncestorRecordKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RecordChangedErrorClientRecordKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RecordChangedErrorServerRecordKey;

	[Field("CKErrorDomain", "CloudKit")]
	public static NSString ErrorDomain
	{
		get
		{
			if (_ErrorDomain == null)
			{
				_ErrorDomain = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKErrorDomain");
			}
			return _ErrorDomain;
		}
	}

	[Field("CKErrorRetryAfterKey", "CloudKit")]
	public static NSString ErrorRetryAfterKey
	{
		get
		{
			if (_ErrorRetryAfterKey == null)
			{
				_ErrorRetryAfterKey = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKErrorRetryAfterKey");
			}
			return _ErrorRetryAfterKey;
		}
	}

	[Field("CKPartialErrorsByItemIDKey", "CloudKit")]
	public static NSString PartialErrorsByItemIdKey
	{
		get
		{
			if (_PartialErrorsByItemIdKey == null)
			{
				_PartialErrorsByItemIdKey = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKPartialErrorsByItemIDKey");
			}
			return _PartialErrorsByItemIdKey;
		}
	}

	[Field("CKRecordChangedErrorAncestorRecordKey", "CloudKit")]
	public static NSString RecordChangedErrorAncestorRecordKey
	{
		get
		{
			if (_RecordChangedErrorAncestorRecordKey == null)
			{
				_RecordChangedErrorAncestorRecordKey = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKRecordChangedErrorAncestorRecordKey");
			}
			return _RecordChangedErrorAncestorRecordKey;
		}
	}

	[Field("CKRecordChangedErrorClientRecordKey", "CloudKit")]
	public static NSString RecordChangedErrorClientRecordKey
	{
		get
		{
			if (_RecordChangedErrorClientRecordKey == null)
			{
				_RecordChangedErrorClientRecordKey = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKRecordChangedErrorClientRecordKey");
			}
			return _RecordChangedErrorClientRecordKey;
		}
	}

	[Field("CKRecordChangedErrorServerRecordKey", "CloudKit")]
	public static NSString RecordChangedErrorServerRecordKey
	{
		get
		{
			if (_RecordChangedErrorServerRecordKey == null)
			{
				_RecordChangedErrorServerRecordKey = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKRecordChangedErrorServerRecordKey");
			}
			return _RecordChangedErrorServerRecordKey;
		}
	}
}
