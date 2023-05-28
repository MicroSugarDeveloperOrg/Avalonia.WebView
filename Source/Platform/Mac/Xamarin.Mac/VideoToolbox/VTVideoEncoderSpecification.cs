using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public class VTVideoEncoderSpecification : DictionaryContainer
{
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public bool? EnableHardwareAcceleratedVideoEncoder
	{
		get
		{
			return GetBoolValue(VTVideoEncoderSpecificationKeys.EnableHardwareAcceleratedVideoEncoder);
		}
		set
		{
			SetBooleanValue(VTVideoEncoderSpecificationKeys.EnableHardwareAcceleratedVideoEncoder, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public bool? RequireHardwareAcceleratedVideoEncoder
	{
		get
		{
			return GetBoolValue(VTVideoEncoderSpecificationKeys.RequireHardwareAcceleratedVideoEncoder);
		}
		set
		{
			SetBooleanValue(VTVideoEncoderSpecificationKeys.RequireHardwareAcceleratedVideoEncoder, value);
		}
	}

	public string? EncoderID
	{
		get
		{
			return GetStringValue(VTVideoEncoderSpecificationKeys.EncoderID);
		}
		set
		{
			SetStringValue(VTVideoEncoderSpecificationKeys.EncoderID, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public uint? RequiredEncoderGpuRegistryId
	{
		get
		{
			return GetUInt32Value(VTVideoEncoderSpecificationKeys.RequiredEncoderGpuRegistryId);
		}
		set
		{
			SetNumberValue(VTVideoEncoderSpecificationKeys.RequiredEncoderGpuRegistryId, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public uint? PreferredEncoderGpuRegistryId
	{
		get
		{
			return GetUInt32Value(VTVideoEncoderSpecificationKeys.PreferredEncoderGpuRegistryId);
		}
		set
		{
			SetNumberValue(VTVideoEncoderSpecificationKeys.PreferredEncoderGpuRegistryId, value);
		}
	}

	[Preserve(Conditional = true)]
	public VTVideoEncoderSpecification()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VTVideoEncoderSpecification(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
