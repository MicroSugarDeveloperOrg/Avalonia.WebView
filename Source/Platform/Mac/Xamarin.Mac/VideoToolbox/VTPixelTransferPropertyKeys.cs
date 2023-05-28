using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTPixelTransferPropertyKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DestinationCleanAperture;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DestinationColorPrimaries;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DestinationICCProfile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DestinationPixelAspectRatio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DestinationTransferFunction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DestinationYCbCrMatrix;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DownsamplingMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DownsamplingMode_Average;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DownsamplingMode_Decimate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RealTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScalingMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScalingMode_CropSourceToCleanAperture;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScalingMode_Letterbox;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScalingMode_Normal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScalingMode_Trim;

	[Field("kVTPixelTransferPropertyKey_DestinationCleanAperture", "VideoToolbox")]
	public static NSString DestinationCleanAperture
	{
		get
		{
			if (_DestinationCleanAperture == null)
			{
				_DestinationCleanAperture = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationCleanAperture");
			}
			return _DestinationCleanAperture;
		}
	}

	[Field("kVTPixelTransferPropertyKey_DestinationColorPrimaries", "VideoToolbox")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DestinationColorPrimaries
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DestinationColorPrimaries == null)
			{
				_DestinationColorPrimaries = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationColorPrimaries");
			}
			return _DestinationColorPrimaries;
		}
	}

	[Field("kVTPixelTransferPropertyKey_DestinationICCProfile", "VideoToolbox")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DestinationICCProfile
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DestinationICCProfile == null)
			{
				_DestinationICCProfile = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationICCProfile");
			}
			return _DestinationICCProfile;
		}
	}

	[Field("kVTPixelTransferPropertyKey_DestinationPixelAspectRatio", "VideoToolbox")]
	public static NSString DestinationPixelAspectRatio
	{
		get
		{
			if (_DestinationPixelAspectRatio == null)
			{
				_DestinationPixelAspectRatio = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationPixelAspectRatio");
			}
			return _DestinationPixelAspectRatio;
		}
	}

	[Field("kVTPixelTransferPropertyKey_DestinationTransferFunction", "VideoToolbox")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DestinationTransferFunction
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DestinationTransferFunction == null)
			{
				_DestinationTransferFunction = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationTransferFunction");
			}
			return _DestinationTransferFunction;
		}
	}

	[Field("kVTPixelTransferPropertyKey_DestinationYCbCrMatrix", "VideoToolbox")]
	public static NSString DestinationYCbCrMatrix
	{
		get
		{
			if (_DestinationYCbCrMatrix == null)
			{
				_DestinationYCbCrMatrix = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DestinationYCbCrMatrix");
			}
			return _DestinationYCbCrMatrix;
		}
	}

	[Field("kVTPixelTransferPropertyKey_DownsamplingMode", "VideoToolbox")]
	public static NSString DownsamplingMode
	{
		get
		{
			if (_DownsamplingMode == null)
			{
				_DownsamplingMode = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_DownsamplingMode");
			}
			return _DownsamplingMode;
		}
	}

	[Field("kVTDownsamplingMode_Average", "VideoToolbox")]
	public static NSString DownsamplingMode_Average
	{
		get
		{
			if (_DownsamplingMode_Average == null)
			{
				_DownsamplingMode_Average = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDownsamplingMode_Average");
			}
			return _DownsamplingMode_Average;
		}
	}

	[Field("kVTDownsamplingMode_Decimate", "VideoToolbox")]
	public static NSString DownsamplingMode_Decimate
	{
		get
		{
			if (_DownsamplingMode_Decimate == null)
			{
				_DownsamplingMode_Decimate = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDownsamplingMode_Decimate");
			}
			return _DownsamplingMode_Decimate;
		}
	}

	[Field("kVTPixelTransferPropertyKey_RealTime", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString RealTime
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RealTime == null)
			{
				_RealTime = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_RealTime");
			}
			return _RealTime;
		}
	}

	[Field("kVTPixelTransferPropertyKey_ScalingMode", "VideoToolbox")]
	public static NSString ScalingMode
	{
		get
		{
			if (_ScalingMode == null)
			{
				_ScalingMode = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPixelTransferPropertyKey_ScalingMode");
			}
			return _ScalingMode;
		}
	}

	[Field("kVTScalingMode_CropSourceToCleanAperture", "VideoToolbox")]
	public static NSString ScalingMode_CropSourceToCleanAperture
	{
		get
		{
			if (_ScalingMode_CropSourceToCleanAperture == null)
			{
				_ScalingMode_CropSourceToCleanAperture = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTScalingMode_CropSourceToCleanAperture");
			}
			return _ScalingMode_CropSourceToCleanAperture;
		}
	}

	[Field("kVTScalingMode_Letterbox", "VideoToolbox")]
	public static NSString ScalingMode_Letterbox
	{
		get
		{
			if (_ScalingMode_Letterbox == null)
			{
				_ScalingMode_Letterbox = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTScalingMode_Letterbox");
			}
			return _ScalingMode_Letterbox;
		}
	}

	[Field("kVTScalingMode_Normal", "VideoToolbox")]
	public static NSString ScalingMode_Normal
	{
		get
		{
			if (_ScalingMode_Normal == null)
			{
				_ScalingMode_Normal = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTScalingMode_Normal");
			}
			return _ScalingMode_Normal;
		}
	}

	[Field("kVTScalingMode_Trim", "VideoToolbox")]
	public static NSString ScalingMode_Trim
	{
		get
		{
			if (_ScalingMode_Trim == null)
			{
				_ScalingMode_Trim = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTScalingMode_Trim");
			}
			return _ScalingMode_Trim;
		}
	}
}
