using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNErrorUserInfoKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AffectedRecordIdentifiers;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AffectedRecords;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyPaths;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ValidationErrors;

	[Field("CNErrorUserInfoAffectedRecordIdentifiersKey", "Contacts")]
	public static NSString AffectedRecordIdentifiers
	{
		get
		{
			if (_AffectedRecordIdentifiers == null)
			{
				_AffectedRecordIdentifiers = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNErrorUserInfoAffectedRecordIdentifiersKey");
			}
			return _AffectedRecordIdentifiers;
		}
	}

	[Field("CNErrorUserInfoAffectedRecordsKey", "Contacts")]
	public static NSString AffectedRecords
	{
		get
		{
			if (_AffectedRecords == null)
			{
				_AffectedRecords = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNErrorUserInfoAffectedRecordsKey");
			}
			return _AffectedRecords;
		}
	}

	[Field("CNErrorUserInfoKeyPathsKey", "Contacts")]
	public static NSString KeyPaths
	{
		get
		{
			if (_KeyPaths == null)
			{
				_KeyPaths = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNErrorUserInfoKeyPathsKey");
			}
			return _KeyPaths;
		}
	}

	[Field("CNErrorUserInfoValidationErrorsKey", "Contacts")]
	public static NSString ValidationErrors
	{
		get
		{
			if (_ValidationErrors == null)
			{
				_ValidationErrors = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNErrorUserInfoValidationErrorsKey");
			}
			return _ValidationErrors;
		}
	}
}
