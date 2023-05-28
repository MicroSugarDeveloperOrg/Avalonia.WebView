using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
internal static class CIImageProviderKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TileSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UserInfoKey;

	[Field("kCIImageProviderTileSize", "CoreImage")]
	public static NSString TileSizeKey
	{
		get
		{
			if (_TileSizeKey == null)
			{
				_TileSizeKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageProviderTileSize");
			}
			return _TileSizeKey;
		}
	}

	[Field("kCIImageProviderUserInfo", "CoreImage")]
	public static NSString UserInfoKey
	{
		get
		{
			if (_UserInfoKey == null)
			{
				_UserInfoKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageProviderUserInfo");
			}
			return _UserInfoKey;
		}
	}
}
