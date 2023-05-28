using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
internal static class NEVpnConnectionStartOptionInternal
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Password;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Username;

	[Field("NEVPNConnectionStartOptionPassword", "NetworkExtension")]
	public static NSString Password
	{
		get
		{
			if (_Password == null)
			{
				_Password = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEVPNConnectionStartOptionPassword");
			}
			return _Password;
		}
	}

	[Field("NEVPNConnectionStartOptionUsername", "NetworkExtension")]
	public static NSString Username
	{
		get
		{
			if (_Username == null)
			{
				_Username = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEVPNConnectionStartOptionUsername");
			}
			return _Username;
		}
	}
}
