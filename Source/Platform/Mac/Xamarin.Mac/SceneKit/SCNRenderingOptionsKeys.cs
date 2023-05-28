using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
internal static class SCNRenderingOptionsKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeviceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LowPowerDeviceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RenderingApiKey;

	[Field("SCNPreferredDeviceKey", "SceneKit")]
	public static NSString DeviceKey
	{
		get
		{
			if (_DeviceKey == null)
			{
				_DeviceKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPreferredDeviceKey");
			}
			return _DeviceKey;
		}
	}

	[Field("SCNPreferLowPowerDeviceKey", "SceneKit")]
	public static NSString LowPowerDeviceKey
	{
		get
		{
			if (_LowPowerDeviceKey == null)
			{
				_LowPowerDeviceKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPreferLowPowerDeviceKey");
			}
			return _LowPowerDeviceKey;
		}
	}

	[Advice("This API is not available when using UIKit on macOS.")]
	[Field("SCNPreferredRenderingAPIKey", "SceneKit")]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	public static NSString RenderingApiKey
	{
		[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
		get
		{
			if (_RenderingApiKey == null)
			{
				_RenderingApiKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNPreferredRenderingAPIKey");
			}
			return _RenderingApiKey;
		}
	}
}
