using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public static class AVStreamingKeyDelivery
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentKeyType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PersistentContentKeyType;

	[Field("AVStreamingKeyDeliveryContentKeyType", "AVFoundation")]
	public static NSString ContentKeyType
	{
		get
		{
			if (_ContentKeyType == null)
			{
				_ContentKeyType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVStreamingKeyDeliveryContentKeyType");
			}
			return _ContentKeyType;
		}
	}

	[Field("AVStreamingKeyDeliveryPersistentContentKeyType", "AVFoundation")]
	public static NSString PersistentContentKeyType
	{
		get
		{
			if (_PersistentContentKeyType == null)
			{
				_PersistentContentKeyType = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVStreamingKeyDeliveryPersistentContentKeyType");
			}
			return _PersistentContentKeyType;
		}
	}
}
