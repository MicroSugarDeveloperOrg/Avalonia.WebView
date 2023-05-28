using Foundation;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public static class PHLivePhotoInfo
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CancelledKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsDegradedKey;

	[Field("PHLivePhotoInfoCancelledKey", "Photos")]
	public static NSString CancelledKey
	{
		get
		{
			if (_CancelledKey == null)
			{
				_CancelledKey = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHLivePhotoInfoCancelledKey");
			}
			return _CancelledKey;
		}
	}

	[Field("PHLivePhotoInfoErrorKey", "Photos")]
	public static NSString ErrorKey
	{
		get
		{
			if (_ErrorKey == null)
			{
				_ErrorKey = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHLivePhotoInfoErrorKey");
			}
			return _ErrorKey;
		}
	}

	[Field("PHLivePhotoInfoIsDegradedKey", "Photos")]
	public static NSString IsDegradedKey
	{
		get
		{
			if (_IsDegradedKey == null)
			{
				_IsDegradedKey = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHLivePhotoInfoIsDegradedKey");
			}
			return _IsDegradedKey;
		}
	}
}
