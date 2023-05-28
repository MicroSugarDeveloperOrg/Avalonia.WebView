using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public class VTVideoDecoderSpecification : DictionaryContainer
{
	public bool? EnableHardwareAcceleratedVideoDecoder
	{
		get
		{
			return GetBoolValue(VTVideoDecoderSpecificationKeys.EnableHardwareAcceleratedVideoDecoder);
		}
		set
		{
			SetBooleanValue(VTVideoDecoderSpecificationKeys.EnableHardwareAcceleratedVideoDecoder, value);
		}
	}

	public bool? RequireHardwareAcceleratedVideoDecoder
	{
		get
		{
			return GetBoolValue(VTVideoDecoderSpecificationKeys.RequireHardwareAcceleratedVideoDecoder);
		}
		set
		{
			SetBooleanValue(VTVideoDecoderSpecificationKeys.RequireHardwareAcceleratedVideoDecoder, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public NSNumber? RequiredDecoderGpuRegistryId => base.Dictionary[VTVideoDecoderSpecificationKeys.RequiredDecoderGpuRegistryId] as NSNumber;

	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public NSNumber? PreferredDecoderGpuRegistryId => base.Dictionary[VTVideoDecoderSpecificationKeys.PreferredDecoderGpuRegistryId] as NSNumber;

	[Preserve(Conditional = true)]
	public VTVideoDecoderSpecification()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VTVideoDecoderSpecification(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
