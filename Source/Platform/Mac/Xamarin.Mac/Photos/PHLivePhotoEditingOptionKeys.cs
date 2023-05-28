using Foundation;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
internal static class PHLivePhotoEditingOptionKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShouldRenderAtPlaybackTimeKey;

	[Field("PHLivePhotoShouldRenderAtPlaybackTime", "Photos")]
	public static NSString ShouldRenderAtPlaybackTimeKey
	{
		get
		{
			if (_ShouldRenderAtPlaybackTimeKey == null)
			{
				_ShouldRenderAtPlaybackTimeKey = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHLivePhotoShouldRenderAtPlaybackTime");
			}
			return _ShouldRenderAtPlaybackTimeKey;
		}
	}
}
