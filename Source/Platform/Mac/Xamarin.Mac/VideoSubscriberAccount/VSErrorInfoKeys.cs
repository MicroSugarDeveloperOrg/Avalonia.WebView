using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
internal static class VSErrorInfoKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AccountProviderResponseKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SamlResponseKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SamlResponseStatusKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnsupportedProviderIdentifierKey;

	[Field("VSErrorInfoKeyAccountProviderResponse", "VideoSubscriberAccount")]
	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	public static NSString AccountProviderResponseKey
	{
		[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
		get
		{
			if (_AccountProviderResponseKey == null)
			{
				_AccountProviderResponseKey = Dlfcn.GetStringConstant(Libraries.VideoSubscriberAccount.Handle, "VSErrorInfoKeyAccountProviderResponse");
			}
			return _AccountProviderResponseKey;
		}
	}

	[Field("VSErrorInfoKeySAMLResponse", "VideoSubscriberAccount")]
	public static NSString SamlResponseKey
	{
		get
		{
			if (_SamlResponseKey == null)
			{
				_SamlResponseKey = Dlfcn.GetStringConstant(Libraries.VideoSubscriberAccount.Handle, "VSErrorInfoKeySAMLResponse");
			}
			return _SamlResponseKey;
		}
	}

	[Field("VSErrorInfoKeySAMLResponseStatus", "VideoSubscriberAccount")]
	public static NSString SamlResponseStatusKey
	{
		get
		{
			if (_SamlResponseStatusKey == null)
			{
				_SamlResponseStatusKey = Dlfcn.GetStringConstant(Libraries.VideoSubscriberAccount.Handle, "VSErrorInfoKeySAMLResponseStatus");
			}
			return _SamlResponseStatusKey;
		}
	}

	[Field("VSErrorInfoKeyUnsupportedProviderIdentifier", "VideoSubscriberAccount")]
	public static NSString UnsupportedProviderIdentifierKey
	{
		get
		{
			if (_UnsupportedProviderIdentifierKey == null)
			{
				_UnsupportedProviderIdentifierKey = Dlfcn.GetStringConstant(Libraries.VideoSubscriberAccount.Handle, "VSErrorInfoKeyUnsupportedProviderIdentifier");
			}
			return _UnsupportedProviderIdentifierKey;
		}
	}
}
