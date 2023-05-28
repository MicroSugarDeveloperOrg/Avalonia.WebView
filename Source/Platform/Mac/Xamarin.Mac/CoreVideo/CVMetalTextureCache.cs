using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class CVMetalTextureCache
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StorageMode;

	[Field("kCVMetalTextureStorageMode", "CoreVideo")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString StorageMode
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_StorageMode == null)
			{
				_StorageMode = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVMetalTextureStorageMode");
			}
			return _StorageMode;
		}
	}
}
