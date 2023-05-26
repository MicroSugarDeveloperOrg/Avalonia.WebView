using Foundation;
using ObjCRuntime;

namespace Accounts;

[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Facebook SDK instead.")]
[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Facebook SDK instead.")]
public static class ACFacebookKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Audience;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Permissions;

	[Field("ACFacebookAppIdKey", "Accounts")]
	public static NSString AppId
	{
		get
		{
			if (_AppId == null)
			{
				_AppId = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACFacebookAppIdKey");
			}
			return _AppId;
		}
	}

	[Field("ACFacebookAudienceKey", "Accounts")]
	public static NSString Audience
	{
		get
		{
			if (_Audience == null)
			{
				_Audience = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACFacebookAudienceKey");
			}
			return _Audience;
		}
	}

	[Field("ACFacebookPermissionsKey", "Accounts")]
	public static NSString Permissions
	{
		get
		{
			if (_Permissions == null)
			{
				_Permissions = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACFacebookPermissionsKey");
			}
			return _Permissions;
		}
	}
}
