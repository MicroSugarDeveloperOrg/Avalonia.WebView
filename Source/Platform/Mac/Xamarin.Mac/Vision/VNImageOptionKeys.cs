using Foundation;
using ObjCRuntime;

namespace Vision;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
internal static class VNImageOptionKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIContextKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CameraIntrinsicsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertiesKey;

	[Field("VNImageOptionCIContext", "Vision")]
	public static NSString CIContextKey
	{
		get
		{
			if (_CIContextKey == null)
			{
				_CIContextKey = Dlfcn.GetStringConstant(Libraries.Vision.Handle, "VNImageOptionCIContext");
			}
			return _CIContextKey;
		}
	}

	[Field("VNImageOptionCameraIntrinsics", "Vision")]
	public static NSString CameraIntrinsicsKey
	{
		get
		{
			if (_CameraIntrinsicsKey == null)
			{
				_CameraIntrinsicsKey = Dlfcn.GetStringConstant(Libraries.Vision.Handle, "VNImageOptionCameraIntrinsics");
			}
			return _CameraIntrinsicsKey;
		}
	}

	[Field("VNImageOptionProperties", "Vision")]
	public static NSString PropertiesKey
	{
		get
		{
			if (_PropertiesKey == null)
			{
				_PropertiesKey = Dlfcn.GetStringConstant(Libraries.Vision.Handle, "VNImageOptionProperties");
			}
			return _PropertiesKey;
		}
	}
}
