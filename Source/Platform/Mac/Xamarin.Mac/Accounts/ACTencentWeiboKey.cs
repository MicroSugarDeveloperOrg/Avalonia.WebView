using Foundation;
using ObjCRuntime;

namespace Accounts;

[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Tencent Weibo SDK instead.")]
[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Tencent Weibo SDK instead.")]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public static class ACTencentWeiboKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppId;

	[Field("ACTencentWeiboAppIdKey", "Accounts")]
	public static NSString AppId
	{
		get
		{
			if (_AppId == null)
			{
				_AppId = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACTencentWeiboAppIdKey");
			}
			return _AppId;
		}
	}
}
