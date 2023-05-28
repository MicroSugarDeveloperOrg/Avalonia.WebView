using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTVideoEncoderSpecificationKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EnableHardwareAcceleratedVideoEncoder;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EncoderID;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreferredEncoderGpuRegistryId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RequireHardwareAcceleratedVideoEncoder;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RequiredEncoderGpuRegistryId;

	[Field("kVTVideoEncoderSpecification_EnableHardwareAcceleratedVideoEncoder", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString EnableHardwareAcceleratedVideoEncoder
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_EnableHardwareAcceleratedVideoEncoder == null)
			{
				_EnableHardwareAcceleratedVideoEncoder = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderSpecification_EnableHardwareAcceleratedVideoEncoder");
			}
			return _EnableHardwareAcceleratedVideoEncoder;
		}
	}

	[Field("kVTVideoEncoderSpecification_EncoderID", "VideoToolbox")]
	public static NSString EncoderID
	{
		get
		{
			if (_EncoderID == null)
			{
				_EncoderID = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderSpecification_EncoderID");
			}
			return _EncoderID;
		}
	}

	[Field("kVTVideoEncoderSpecification_PreferredEncoderGPURegistryID", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString PreferredEncoderGpuRegistryId
	{
		[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PreferredEncoderGpuRegistryId == null)
			{
				_PreferredEncoderGpuRegistryId = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderSpecification_PreferredEncoderGPURegistryID");
			}
			return _PreferredEncoderGpuRegistryId;
		}
	}

	[Field("kVTVideoEncoderSpecification_RequireHardwareAcceleratedVideoEncoder", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString RequireHardwareAcceleratedVideoEncoder
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_RequireHardwareAcceleratedVideoEncoder == null)
			{
				_RequireHardwareAcceleratedVideoEncoder = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderSpecification_RequireHardwareAcceleratedVideoEncoder");
			}
			return _RequireHardwareAcceleratedVideoEncoder;
		}
	}

	[Field("kVTVideoEncoderSpecification_RequiredEncoderGPURegistryID", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString RequiredEncoderGpuRegistryId
	{
		[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RequiredEncoderGpuRegistryId == null)
			{
				_RequiredEncoderGpuRegistryId = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoEncoderSpecification_RequiredEncoderGPURegistryID");
			}
			return _RequiredEncoderGpuRegistryId;
		}
	}
}
