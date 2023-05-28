using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTVideoDecoderSpecificationKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EnableHardwareAcceleratedVideoDecoder;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreferredDecoderGpuRegistryId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RequireHardwareAcceleratedVideoDecoder;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RequiredDecoderGpuRegistryId;

	[Field("kVTVideoDecoderSpecification_EnableHardwareAcceleratedVideoDecoder", "VideoToolbox")]
	public static NSString EnableHardwareAcceleratedVideoDecoder
	{
		get
		{
			if (_EnableHardwareAcceleratedVideoDecoder == null)
			{
				_EnableHardwareAcceleratedVideoDecoder = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoDecoderSpecification_EnableHardwareAcceleratedVideoDecoder");
			}
			return _EnableHardwareAcceleratedVideoDecoder;
		}
	}

	[Field("kVTVideoDecoderSpecification_PreferredDecoderGPURegistryID", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString PreferredDecoderGpuRegistryId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_PreferredDecoderGpuRegistryId == null)
			{
				_PreferredDecoderGpuRegistryId = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoDecoderSpecification_PreferredDecoderGPURegistryID");
			}
			return _PreferredDecoderGpuRegistryId;
		}
	}

	[Field("kVTVideoDecoderSpecification_RequireHardwareAcceleratedVideoDecoder", "VideoToolbox")]
	public static NSString RequireHardwareAcceleratedVideoDecoder
	{
		get
		{
			if (_RequireHardwareAcceleratedVideoDecoder == null)
			{
				_RequireHardwareAcceleratedVideoDecoder = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoDecoderSpecification_RequireHardwareAcceleratedVideoDecoder");
			}
			return _RequireHardwareAcceleratedVideoDecoder;
		}
	}

	[Field("kVTVideoDecoderSpecification_RequiredDecoderGPURegistryID", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString RequiredDecoderGpuRegistryId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_RequiredDecoderGpuRegistryId == null)
			{
				_RequiredDecoderGpuRegistryId = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTVideoDecoderSpecification_RequiredDecoderGPURegistryID");
			}
			return _RequiredDecoderGpuRegistryId;
		}
	}
}
