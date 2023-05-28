using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNLabelPhoneNumberKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HomeFax;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Main;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Mobile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OtherFax;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Pager;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WorkFax;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _iPhone;

	[Field("CNLabelPhoneNumberHomeFax", "Contacts")]
	public static NSString HomeFax
	{
		get
		{
			if (_HomeFax == null)
			{
				_HomeFax = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelPhoneNumberHomeFax");
			}
			return _HomeFax;
		}
	}

	[Field("CNLabelPhoneNumberMain", "Contacts")]
	public static NSString Main
	{
		get
		{
			if (_Main == null)
			{
				_Main = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelPhoneNumberMain");
			}
			return _Main;
		}
	}

	[Field("CNLabelPhoneNumberMobile", "Contacts")]
	public static NSString Mobile
	{
		get
		{
			if (_Mobile == null)
			{
				_Mobile = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelPhoneNumberMobile");
			}
			return _Mobile;
		}
	}

	[Field("CNLabelPhoneNumberOtherFax", "Contacts")]
	public static NSString OtherFax
	{
		get
		{
			if (_OtherFax == null)
			{
				_OtherFax = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelPhoneNumberOtherFax");
			}
			return _OtherFax;
		}
	}

	[Field("CNLabelPhoneNumberPager", "Contacts")]
	public static NSString Pager
	{
		get
		{
			if (_Pager == null)
			{
				_Pager = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelPhoneNumberPager");
			}
			return _Pager;
		}
	}

	[Field("CNLabelPhoneNumberWorkFax", "Contacts")]
	public static NSString WorkFax
	{
		get
		{
			if (_WorkFax == null)
			{
				_WorkFax = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelPhoneNumberWorkFax");
			}
			return _WorkFax;
		}
	}

	[Field("CNLabelPhoneNumberiPhone", "Contacts")]
	public static NSString iPhone
	{
		get
		{
			if (_iPhone == null)
			{
				_iPhone = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNLabelPhoneNumberiPhone");
			}
			return _iPhone;
		}
	}
}
