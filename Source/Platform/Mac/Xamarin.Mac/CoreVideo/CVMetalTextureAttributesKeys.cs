using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
internal static class CVMetalTextureAttributesKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UsageKey;

	[Field("kCVMetalTextureUsage", "CoreVideo")]
	public static NSString UsageKey
	{
		get
		{
			if (_UsageKey == null)
			{
				_UsageKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVMetalTextureUsage");
			}
			return _UsageKey;
		}
	}
}
