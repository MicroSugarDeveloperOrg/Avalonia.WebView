using Foundation;
using ObjCRuntime;

namespace Accounts;

[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use LinkedIn SDK instead.")]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public static class ACLinkedInKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Permissions;

	[Field("ACLinkedInAppIdKey", "Accounts")]
	public static NSString AppId
	{
		get
		{
			if (_AppId == null)
			{
				_AppId = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACLinkedInAppIdKey");
			}
			return _AppId;
		}
	}

	[Field("ACLinkedInPermissionsKey", "Accounts")]
	public static NSString Permissions
	{
		get
		{
			if (_Permissions == null)
			{
				_Permissions = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACLinkedInPermissionsKey");
			}
			return _Permissions;
		}
	}
}
