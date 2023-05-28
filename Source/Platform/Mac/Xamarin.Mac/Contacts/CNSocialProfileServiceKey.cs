using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNSocialProfileServiceKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Facebook;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Flickr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GameCenter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LinkedIn;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MySpace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SinaWeibo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TencentWeibo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Twitter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Yelp;

	[Field("CNSocialProfileServiceFacebook", "Contacts")]
	public static NSString Facebook
	{
		get
		{
			if (_Facebook == null)
			{
				_Facebook = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileServiceFacebook");
			}
			return _Facebook;
		}
	}

	[Field("CNSocialProfileServiceFlickr", "Contacts")]
	public static NSString Flickr
	{
		get
		{
			if (_Flickr == null)
			{
				_Flickr = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileServiceFlickr");
			}
			return _Flickr;
		}
	}

	[Field("CNSocialProfileServiceGameCenter", "Contacts")]
	public static NSString GameCenter
	{
		get
		{
			if (_GameCenter == null)
			{
				_GameCenter = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileServiceGameCenter");
			}
			return _GameCenter;
		}
	}

	[Field("CNSocialProfileServiceLinkedIn", "Contacts")]
	public static NSString LinkedIn
	{
		get
		{
			if (_LinkedIn == null)
			{
				_LinkedIn = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileServiceLinkedIn");
			}
			return _LinkedIn;
		}
	}

	[Field("CNSocialProfileServiceMySpace", "Contacts")]
	public static NSString MySpace
	{
		get
		{
			if (_MySpace == null)
			{
				_MySpace = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileServiceMySpace");
			}
			return _MySpace;
		}
	}

	[Field("CNSocialProfileServiceSinaWeibo", "Contacts")]
	public static NSString SinaWeibo
	{
		get
		{
			if (_SinaWeibo == null)
			{
				_SinaWeibo = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileServiceSinaWeibo");
			}
			return _SinaWeibo;
		}
	}

	[Field("CNSocialProfileServiceTencentWeibo", "Contacts")]
	public static NSString TencentWeibo
	{
		get
		{
			if (_TencentWeibo == null)
			{
				_TencentWeibo = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileServiceTencentWeibo");
			}
			return _TencentWeibo;
		}
	}

	[Field("CNSocialProfileServiceTwitter", "Contacts")]
	public static NSString Twitter
	{
		get
		{
			if (_Twitter == null)
			{
				_Twitter = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileServiceTwitter");
			}
			return _Twitter;
		}
	}

	[Field("CNSocialProfileServiceYelp", "Contacts")]
	public static NSString Yelp
	{
		get
		{
			if (_Yelp == null)
			{
				_Yelp = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNSocialProfileServiceYelp");
			}
			return _Yelp;
		}
	}
}
