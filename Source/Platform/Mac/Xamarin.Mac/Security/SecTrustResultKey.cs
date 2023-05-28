using Foundation;
using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public static class SecTrustResultKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CertificateTransparency;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CertificateTransparencyWhiteList;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EvaluationDate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtendedValidation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OrganizationName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResultValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RevocationChecked;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RevocationValidUntilDate;

	[Field("kSecTrustCertificateTransparency", "Security")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString CertificateTransparency
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_CertificateTransparency == null)
			{
				_CertificateTransparency = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecTrustCertificateTransparency");
			}
			return _CertificateTransparency;
		}
	}

	[Field("kSecTrustCertificateTransparencyWhiteList", "Security")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
	public static NSString CertificateTransparencyWhiteList
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
		get
		{
			if (_CertificateTransparencyWhiteList == null)
			{
				_CertificateTransparencyWhiteList = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecTrustCertificateTransparencyWhiteList");
			}
			return _CertificateTransparencyWhiteList;
		}
	}

	[Field("kSecTrustEvaluationDate", "Security")]
	public static NSString EvaluationDate
	{
		get
		{
			if (_EvaluationDate == null)
			{
				_EvaluationDate = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecTrustEvaluationDate");
			}
			return _EvaluationDate;
		}
	}

	[Field("kSecTrustExtendedValidation", "Security")]
	public static NSString ExtendedValidation
	{
		get
		{
			if (_ExtendedValidation == null)
			{
				_ExtendedValidation = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecTrustExtendedValidation");
			}
			return _ExtendedValidation;
		}
	}

	[Field("kSecTrustOrganizationName", "Security")]
	public static NSString OrganizationName
	{
		get
		{
			if (_OrganizationName == null)
			{
				_OrganizationName = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecTrustOrganizationName");
			}
			return _OrganizationName;
		}
	}

	[Field("kSecTrustResultValue", "Security")]
	public static NSString ResultValue
	{
		get
		{
			if (_ResultValue == null)
			{
				_ResultValue = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecTrustResultValue");
			}
			return _ResultValue;
		}
	}

	[Field("kSecTrustRevocationChecked", "Security")]
	public static NSString RevocationChecked
	{
		get
		{
			if (_RevocationChecked == null)
			{
				_RevocationChecked = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecTrustRevocationChecked");
			}
			return _RevocationChecked;
		}
	}

	[Field("kSecTrustRevocationValidUntilDate", "Security")]
	public static NSString RevocationValidUntilDate
	{
		get
		{
			if (_RevocationValidUntilDate == null)
			{
				_RevocationValidUntilDate = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecTrustRevocationValidUntilDate");
			}
			return _RevocationValidUntilDate;
		}
	}
}
