using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNSocialProfileKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Service;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UrlString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UserIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Username;

	[Field("CNSocialProfileServiceKey", "Contacts")]
	public static NSString Service
	{
		get
		{
			if (_Service == null)
			{
				_Service = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileServiceKey");
			}
			return _Service;
		}
	}

	[Field("CNSocialProfileURLStringKey", "Contacts")]
	public static NSString UrlString
	{
		get
		{
			if (_UrlString == null)
			{
				_UrlString = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileURLStringKey");
			}
			return _UrlString;
		}
	}

	[Field("CNSocialProfileUserIdentifierKey", "Contacts")]
	public static NSString UserIdentifier
	{
		get
		{
			if (_UserIdentifier == null)
			{
				_UserIdentifier = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileUserIdentifierKey");
			}
			return _UserIdentifier;
		}
	}

	[Field("CNSocialProfileUsernameKey", "Contacts")]
	public static NSString Username
	{
		get
		{
			if (_Username == null)
			{
				_Username = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileUsernameKey");
			}
			return _Username;
		}
	}
}
