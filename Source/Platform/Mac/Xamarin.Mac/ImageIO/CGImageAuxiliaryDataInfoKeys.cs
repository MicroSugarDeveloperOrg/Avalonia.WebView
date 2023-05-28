using Foundation;
using ObjCRuntime;

namespace ImageIO;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
internal static class CGImageAuxiliaryDataInfoKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataDescriptionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MetadataKey;

	[Field("kCGImageAuxiliaryDataInfoDataDescription", "ImageIO")]
	public static NSString DataDescriptionKey
	{
		get
		{
			if (_DataDescriptionKey == null)
			{
				_DataDescriptionKey = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataInfoDataDescription");
			}
			return _DataDescriptionKey;
		}
	}

	[Field("kCGImageAuxiliaryDataInfoData", "ImageIO")]
	public static NSString DataKey
	{
		get
		{
			if (_DataKey == null)
			{
				_DataKey = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataInfoData");
			}
			return _DataKey;
		}
	}

	[Field("kCGImageAuxiliaryDataInfoMetadata", "ImageIO")]
	public static NSString MetadataKey
	{
		get
		{
			if (_MetadataKey == null)
			{
				_MetadataKey = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataInfoMetadata");
			}
			return _MetadataKey;
		}
	}
}
