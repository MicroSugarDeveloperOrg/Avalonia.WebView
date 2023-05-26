using Foundation;
using ObjCRuntime;

namespace Accounts;

[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Facebook SDK instead.")]
[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Facebook SDK instead.")]
public static class ACFacebookAudienceValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Everyone;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Friends;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OnlyMe;

	[Field("ACFacebookAudienceEveryone", "Accounts")]
	public static NSString Everyone
	{
		get
		{
			if (_Everyone == null)
			{
				_Everyone = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACFacebookAudienceEveryone");
			}
			return _Everyone;
		}
	}

	[Field("ACFacebookAudienceFriends", "Accounts")]
	public static NSString Friends
	{
		get
		{
			if (_Friends == null)
			{
				_Friends = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACFacebookAudienceFriends");
			}
			return _Friends;
		}
	}

	[Field("ACFacebookAudienceOnlyMe", "Accounts")]
	public static NSString OnlyMe
	{
		get
		{
			if (_OnlyMe == null)
			{
				_OnlyMe = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACFacebookAudienceOnlyMe");
			}
			return _OnlyMe;
		}
	}
}
