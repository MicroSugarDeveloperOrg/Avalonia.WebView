using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public static class AVMetadataExtraAttribute
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BaseUriKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InfoKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ValueUriKey;

	[Field("AVMetadataExtraAttributeBaseURIKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString BaseUriKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_BaseUriKey == null)
			{
				_BaseUriKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataExtraAttributeBaseURIKey");
			}
			return _BaseUriKey;
		}
	}

	[Field("AVMetadataExtraAttributeInfoKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString InfoKey
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_InfoKey == null)
			{
				_InfoKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataExtraAttributeInfoKey");
			}
			return _InfoKey;
		}
	}

	[Field("AVMetadataExtraAttributeValueURIKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString ValueUriKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_ValueUriKey == null)
			{
				_ValueUriKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataExtraAttributeValueURIKey");
			}
			return _ValueUriKey;
		}
	}
}
