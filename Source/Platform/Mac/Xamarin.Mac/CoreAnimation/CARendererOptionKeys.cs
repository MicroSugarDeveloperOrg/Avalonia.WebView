using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
internal static class CARendererOptionKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorSpace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MetalCommandQueue;

	[Field("kCARendererColorSpace", "CoreAnimation")]
	public static NSString ColorSpace
	{
		get
		{
			if (_ColorSpace == null)
			{
				_ColorSpace = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCARendererColorSpace");
			}
			return _ColorSpace;
		}
	}

	[Field("kCARendererMetalCommandQueue", "CoreAnimation")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSString MetalCommandQueue
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_MetalCommandQueue == null)
			{
				_MetalCommandQueue = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCARendererMetalCommandQueue");
			}
			return _MetalCommandQueue;
		}
	}
}
