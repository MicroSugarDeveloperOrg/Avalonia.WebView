using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class NSPersonNameComponent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ComponentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Delimiter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FamilyName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GivenName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MiddleName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Nickname;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Prefix;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Suffix;

	[Field("NSPersonNameComponentKey", "Foundation")]
	public static NSString ComponentKey
	{
		get
		{
			if (_ComponentKey == null)
			{
				_ComponentKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSPersonNameComponentKey");
			}
			return _ComponentKey;
		}
	}

	[Field("NSPersonNameComponentDelimiter", "Foundation")]
	public static NSString Delimiter
	{
		get
		{
			if (_Delimiter == null)
			{
				_Delimiter = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSPersonNameComponentDelimiter");
			}
			return _Delimiter;
		}
	}

	[Field("NSPersonNameComponentFamilyName", "Foundation")]
	public static NSString FamilyName
	{
		get
		{
			if (_FamilyName == null)
			{
				_FamilyName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSPersonNameComponentFamilyName");
			}
			return _FamilyName;
		}
	}

	[Field("NSPersonNameComponentGivenName", "Foundation")]
	public static NSString GivenName
	{
		get
		{
			if (_GivenName == null)
			{
				_GivenName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSPersonNameComponentGivenName");
			}
			return _GivenName;
		}
	}

	[Field("NSPersonNameComponentMiddleName", "Foundation")]
	public static NSString MiddleName
	{
		get
		{
			if (_MiddleName == null)
			{
				_MiddleName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSPersonNameComponentMiddleName");
			}
			return _MiddleName;
		}
	}

	[Field("NSPersonNameComponentNickname", "Foundation")]
	public static NSString Nickname
	{
		get
		{
			if (_Nickname == null)
			{
				_Nickname = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSPersonNameComponentNickname");
			}
			return _Nickname;
		}
	}

	[Field("NSPersonNameComponentPrefix", "Foundation")]
	public static NSString Prefix
	{
		get
		{
			if (_Prefix == null)
			{
				_Prefix = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSPersonNameComponentPrefix");
			}
			return _Prefix;
		}
	}

	[Field("NSPersonNameComponentSuffix", "Foundation")]
	public static NSString Suffix
	{
		get
		{
			if (_Suffix == null)
			{
				_Suffix = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSPersonNameComponentSuffix");
			}
			return _Suffix;
		}
	}
}
