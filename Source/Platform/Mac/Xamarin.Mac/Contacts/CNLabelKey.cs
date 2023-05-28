using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNLabelKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DateAnniversary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EmailiCloud;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Home;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Other;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _School;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UrlAddressHomePage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Work;

	[Field("CNLabelDateAnniversary", "Contacts")]
	public static NSString DateAnniversary
	{
		get
		{
			if (_DateAnniversary == null)
			{
				_DateAnniversary = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelDateAnniversary");
			}
			return _DateAnniversary;
		}
	}

	[Field("CNLabelEmailiCloud", "Contacts")]
	public static NSString EmailiCloud
	{
		get
		{
			if (_EmailiCloud == null)
			{
				_EmailiCloud = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelEmailiCloud");
			}
			return _EmailiCloud;
		}
	}

	[Field("CNLabelHome", "Contacts")]
	public static NSString Home
	{
		get
		{
			if (_Home == null)
			{
				_Home = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelHome");
			}
			return _Home;
		}
	}

	[Field("CNLabelOther", "Contacts")]
	public static NSString Other
	{
		get
		{
			if (_Other == null)
			{
				_Other = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelOther");
			}
			return _Other;
		}
	}

	[Field("CNLabelSchool", "Contacts")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public static NSString School
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_School == null)
			{
				_School = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelSchool");
			}
			return _School;
		}
	}

	[Field("CNLabelURLAddressHomePage", "Contacts")]
	public static NSString UrlAddressHomePage
	{
		get
		{
			if (_UrlAddressHomePage == null)
			{
				_UrlAddressHomePage = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelURLAddressHomePage");
			}
			return _UrlAddressHomePage;
		}
	}

	[Field("CNLabelWork", "Contacts")]
	public static NSString Work
	{
		get
		{
			if (_Work == null)
			{
				_Work = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelWork");
			}
			return _Work;
		}
	}
}
