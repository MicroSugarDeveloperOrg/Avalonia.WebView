using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
internal static class VTVideoEncoderList
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CodecName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CodecType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EncoderID;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EncoderName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GpuRegistryId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InstanceLimit;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsHardwareAccelerated;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PerformanceRating;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QualityRating;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SupportedSelectionProperties;

	[Field("kVTVideoEncoderList_CodecName", "VideoToolbox")]
	public static NSString CodecName
	{
		get
		{
			if (_CodecName == null)
			{
				_CodecName = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_CodecName");
			}
			return _CodecName;
		}
	}

	[Field("kVTVideoEncoderList_CodecType", "VideoToolbox")]
	public static NSString CodecType
	{
		get
		{
			if (_CodecType == null)
			{
				_CodecType = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_CodecType");
			}
			return _CodecType;
		}
	}

	[Field("kVTVideoEncoderList_DisplayName", "VideoToolbox")]
	public static NSString DisplayName
	{
		get
		{
			if (_DisplayName == null)
			{
				_DisplayName = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_DisplayName");
			}
			return _DisplayName;
		}
	}

	[Field("kVTVideoEncoderList_EncoderID", "VideoToolbox")]
	public static NSString EncoderID
	{
		get
		{
			if (_EncoderID == null)
			{
				_EncoderID = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_EncoderID");
			}
			return _EncoderID;
		}
	}

	[Field("kVTVideoEncoderList_EncoderName", "VideoToolbox")]
	public static NSString EncoderName
	{
		get
		{
			if (_EncoderName == null)
			{
				_EncoderName = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_EncoderName");
			}
			return _EncoderName;
		}
	}

	[Field("kVTVideoEncoderList_GPURegistryID", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString GpuRegistryId
	{
		[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_GpuRegistryId == null)
			{
				_GpuRegistryId = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_GPURegistryID");
			}
			return _GpuRegistryId;
		}
	}

	[Field("kVTVideoEncoderList_InstanceLimit", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString InstanceLimit
	{
		[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_InstanceLimit == null)
			{
				_InstanceLimit = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_InstanceLimit");
			}
			return _InstanceLimit;
		}
	}

	[Field("kVTVideoEncoderList_IsHardwareAccelerated", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString IsHardwareAccelerated
	{
		[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_IsHardwareAccelerated == null)
			{
				_IsHardwareAccelerated = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_IsHardwareAccelerated");
			}
			return _IsHardwareAccelerated;
		}
	}

	[Field("kVTVideoEncoderList_PerformanceRating", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString PerformanceRating
	{
		[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PerformanceRating == null)
			{
				_PerformanceRating = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_PerformanceRating");
			}
			return _PerformanceRating;
		}
	}

	[Field("kVTVideoEncoderList_QualityRating", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString QualityRating
	{
		[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_QualityRating == null)
			{
				_QualityRating = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_QualityRating");
			}
			return _QualityRating;
		}
	}

	[Field("kVTVideoEncoderList_SupportedSelectionProperties", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString SupportedSelectionProperties
	{
		[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_SupportedSelectionProperties == null)
			{
				_SupportedSelectionProperties = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_SupportedSelectionProperties");
			}
			return _SupportedSelectionProperties;
		}
	}
}
