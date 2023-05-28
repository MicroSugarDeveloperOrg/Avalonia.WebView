using Foundation;
using ObjCRuntime;

namespace Social;

public static class SLServiceType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Facebook;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LinkedIn;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SinaWeibo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TencentWeibo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Twitter;

	[Field("SLServiceTypeFacebook", "Social")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Facebook SDK instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Facebook SDK instead.")]
	public static NSString Facebook
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Facebook SDK instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Facebook SDK instead.")]
		get
		{
			if (_Facebook == null)
			{
				_Facebook = Dlfcn.GetStringConstant(Libraries.Social.Handle, "SLServiceTypeFacebook");
			}
			return _Facebook;
		}
	}

	[Field("SLServiceTypeLinkedIn", "Social")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use LinkedIn SDK instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString LinkedIn
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use LinkedIn SDK instead.")]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LinkedIn == null)
			{
				_LinkedIn = Dlfcn.GetStringConstant(Libraries.Social.Handle, "SLServiceTypeLinkedIn");
			}
			return _LinkedIn;
		}
	}

	[Field("SLServiceTypeSinaWeibo", "Social")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Sina Weibo SDK instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Sina Weibo SDK instead.")]
	public static NSString SinaWeibo
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Sina Weibo SDK instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Sina Weibo SDK instead.")]
		get
		{
			if (_SinaWeibo == null)
			{
				_SinaWeibo = Dlfcn.GetStringConstant(Libraries.Social.Handle, "SLServiceTypeSinaWeibo");
			}
			return _SinaWeibo;
		}
	}

	[Field("SLServiceTypeTencentWeibo", "Social")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Tencent Weibo SDK instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Tencent Weibo SDK instead.")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString TencentWeibo
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Tencent Weibo SDK instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Tencent Weibo SDK instead.")]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_TencentWeibo == null)
			{
				_TencentWeibo = Dlfcn.GetStringConstant(Libraries.Social.Handle, "SLServiceTypeTencentWeibo");
			}
			return _TencentWeibo;
		}
	}

	[Field("SLServiceTypeTwitter", "Social")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Twitter SDK instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Twitter SDK instead.")]
	public static NSString Twitter
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Twitter SDK instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Twitter SDK instead.")]
		get
		{
			if (_Twitter == null)
			{
				_Twitter = Dlfcn.GetStringConstant(Libraries.Social.Handle, "SLServiceTypeTwitter");
			}
			return _Twitter;
		}
	}
}
