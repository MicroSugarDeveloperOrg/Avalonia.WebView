using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNInstantMessageServiceKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Aim;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Facebook;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GaduGadu;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GoogleTalk;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Icq;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Jabber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Msn;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QQ;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Skype;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Yahoo;

	[Field("CNInstantMessageServiceAIM", "Contacts")]
	public static NSString Aim
	{
		get
		{
			if (_Aim == null)
			{
				_Aim = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageServiceAIM");
			}
			return _Aim;
		}
	}

	[Field("CNInstantMessageServiceFacebook", "Contacts")]
	public static NSString Facebook
	{
		get
		{
			if (_Facebook == null)
			{
				_Facebook = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageServiceFacebook");
			}
			return _Facebook;
		}
	}

	[Field("CNInstantMessageServiceGaduGadu", "Contacts")]
	public static NSString GaduGadu
	{
		get
		{
			if (_GaduGadu == null)
			{
				_GaduGadu = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageServiceGaduGadu");
			}
			return _GaduGadu;
		}
	}

	[Field("CNInstantMessageServiceGoogleTalk", "Contacts")]
	public static NSString GoogleTalk
	{
		get
		{
			if (_GoogleTalk == null)
			{
				_GoogleTalk = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageServiceGoogleTalk");
			}
			return _GoogleTalk;
		}
	}

	[Field("CNInstantMessageServiceICQ", "Contacts")]
	public static NSString Icq
	{
		get
		{
			if (_Icq == null)
			{
				_Icq = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageServiceICQ");
			}
			return _Icq;
		}
	}

	[Field("CNInstantMessageServiceJabber", "Contacts")]
	public static NSString Jabber
	{
		get
		{
			if (_Jabber == null)
			{
				_Jabber = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageServiceJabber");
			}
			return _Jabber;
		}
	}

	[Field("CNInstantMessageServiceMSN", "Contacts")]
	public static NSString Msn
	{
		get
		{
			if (_Msn == null)
			{
				_Msn = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageServiceMSN");
			}
			return _Msn;
		}
	}

	[Field("CNInstantMessageServiceQQ", "Contacts")]
	public static NSString QQ
	{
		get
		{
			if (_QQ == null)
			{
				_QQ = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageServiceQQ");
			}
			return _QQ;
		}
	}

	[Field("CNInstantMessageServiceSkype", "Contacts")]
	public static NSString Skype
	{
		get
		{
			if (_Skype == null)
			{
				_Skype = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageServiceSkype");
			}
			return _Skype;
		}
	}

	[Field("CNInstantMessageServiceYahoo", "Contacts")]
	public static NSString Yahoo
	{
		get
		{
			if (_Yahoo == null)
			{
				_Yahoo = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNInstantMessageServiceYahoo");
			}
			return _Yahoo;
		}
	}
}
