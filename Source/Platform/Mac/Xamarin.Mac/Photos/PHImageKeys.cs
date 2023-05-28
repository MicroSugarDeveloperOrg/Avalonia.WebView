using Foundation;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public static class PHImageKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Cancelled;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Error;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResultIsDegraded;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResultIsInCloud;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResultRequestID;

	[Field("PHImageCancelledKey", "Photos")]
	public static NSString Cancelled
	{
		get
		{
			if (_Cancelled == null)
			{
				_Cancelled = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHImageCancelledKey");
			}
			return _Cancelled;
		}
	}

	[Field("PHImageErrorKey", "Photos")]
	public static NSString Error
	{
		get
		{
			if (_Error == null)
			{
				_Error = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHImageErrorKey");
			}
			return _Error;
		}
	}

	[Field("PHImageResultIsDegradedKey", "Photos")]
	public static NSString ResultIsDegraded
	{
		get
		{
			if (_ResultIsDegraded == null)
			{
				_ResultIsDegraded = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHImageResultIsDegradedKey");
			}
			return _ResultIsDegraded;
		}
	}

	[Field("PHImageResultIsInCloudKey", "Photos")]
	public static NSString ResultIsInCloud
	{
		get
		{
			if (_ResultIsInCloud == null)
			{
				_ResultIsInCloud = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHImageResultIsInCloudKey");
			}
			return _ResultIsInCloud;
		}
	}

	[Field("PHImageResultRequestIDKey", "Photos")]
	public static NSString ResultRequestID
	{
		get
		{
			if (_ResultRequestID == null)
			{
				_ResultRequestID = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHImageResultRequestIDKey");
			}
			return _ResultRequestID;
		}
	}
}
