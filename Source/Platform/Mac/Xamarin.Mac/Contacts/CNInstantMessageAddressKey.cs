using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNInstantMessageAddressKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Service;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Username;

	[Field("CNInstantMessageAddressServiceKey", "Contacts")]
	public static NSString Service
	{
		get
		{
			if (_Service == null)
			{
				_Service = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageAddressServiceKey");
			}
			return _Service;
		}
	}

	[Field("CNInstantMessageAddressUsernameKey", "Contacts")]
	public static NSString Username
	{
		get
		{
			if (_Username == null)
			{
				_Username = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageAddressUsernameKey");
			}
			return _Username;
		}
	}
}
