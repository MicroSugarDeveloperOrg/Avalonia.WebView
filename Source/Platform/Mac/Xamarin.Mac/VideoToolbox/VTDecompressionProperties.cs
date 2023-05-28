using System;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public class VTDecompressionProperties : DictionaryContainer
{
	public CVPixelBufferPool PixelBufferPool => GetNativeValue<CVPixelBufferPool>(VTDecompressionPropertyKey.PixelBufferPool);

	public VTFieldMode FieldMode
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTDecompressionPropertyKey.FieldMode);
			if (nSStringValue == null)
			{
				return VTFieldMode.Unset;
			}
			if (nSStringValue == VTDecompressionPropertyKey.FieldMode_BothFields)
			{
				return VTFieldMode.BothFields;
			}
			if (nSStringValue == VTDecompressionPropertyKey.FieldMode_TopFieldOnly)
			{
				return VTFieldMode.TopFieldOnly;
			}
			if (nSStringValue == VTDecompressionPropertyKey.FieldMode_BottomFieldOnly)
			{
				return VTFieldMode.BottomFieldOnly;
			}
			if (nSStringValue == VTDecompressionPropertyKey.FieldMode_SingleField)
			{
				return VTFieldMode.SingleField;
			}
			if (nSStringValue == VTDecompressionPropertyKey.FieldMode_DeinterlaceFields)
			{
				return VTFieldMode.DeinterlaceFields;
			}
			return VTFieldMode.Unset;
		}
		set
		{
			switch (value)
			{
			case VTFieldMode.BothFields:
				SetStringValue(VTDecompressionPropertyKey.FieldMode, VTDecompressionPropertyKey.FieldMode_BothFields);
				break;
			case VTFieldMode.TopFieldOnly:
				SetStringValue(VTDecompressionPropertyKey.FieldMode, VTDecompressionPropertyKey.FieldMode_TopFieldOnly);
				break;
			case VTFieldMode.BottomFieldOnly:
				SetStringValue(VTDecompressionPropertyKey.FieldMode, VTDecompressionPropertyKey.FieldMode_BottomFieldOnly);
				break;
			case VTFieldMode.SingleField:
				SetStringValue(VTDecompressionPropertyKey.FieldMode, VTDecompressionPropertyKey.FieldMode_SingleField);
				break;
			case VTFieldMode.DeinterlaceFields:
				SetStringValue(VTDecompressionPropertyKey.FieldMode, VTDecompressionPropertyKey.FieldMode_DeinterlaceFields);
				break;
			default:
				SetStringValue(VTDecompressionPropertyKey.FieldMode, null);
				break;
			}
		}
	}

	public VTDeinterlaceMode DeinterlaceMode
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTDecompressionPropertyKey.DeinterlaceMode);
			if (nSStringValue == null)
			{
				return VTDeinterlaceMode.Unset;
			}
			if (nSStringValue == VTDecompressionPropertyKey.DeinterlaceMode_VerticalFilter)
			{
				return VTDeinterlaceMode.VerticalFilter;
			}
			if (nSStringValue == VTDecompressionPropertyKey.DeinterlaceMode_Temporal)
			{
				return VTDeinterlaceMode.Temporal;
			}
			return VTDeinterlaceMode.Unset;
		}
		set
		{
			switch (value)
			{
			case VTDeinterlaceMode.VerticalFilter:
				SetStringValue(VTDecompressionPropertyKey.DeinterlaceMode, VTDecompressionPropertyKey.DeinterlaceMode_VerticalFilter);
				break;
			case VTDeinterlaceMode.Temporal:
				SetStringValue(VTDecompressionPropertyKey.DeinterlaceMode, VTDecompressionPropertyKey.DeinterlaceMode_Temporal);
				break;
			default:
				SetStringValue(VTDecompressionPropertyKey.DeinterlaceMode, null);
				break;
			}
		}
	}

	public VTOnlyTheseFrames OnlyTheseFrames
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTDecompressionPropertyKey.OnlyTheseFrames);
			if (nSStringValue == null)
			{
				return VTOnlyTheseFrames.Unset;
			}
			if (nSStringValue == VTDecompressionPropertyKey.OnlyTheseFrames_AllFrames)
			{
				return VTOnlyTheseFrames.AllFrames;
			}
			if (nSStringValue == VTDecompressionPropertyKey.OnlyTheseFrames_NonDroppableFrames)
			{
				return VTOnlyTheseFrames.NonDroppableFrames;
			}
			if (nSStringValue == VTDecompressionPropertyKey.OnlyTheseFrames_IFrames)
			{
				return VTOnlyTheseFrames.IFrames;
			}
			if (nSStringValue == VTDecompressionPropertyKey.OnlyTheseFrames_KeyFrames)
			{
				return VTOnlyTheseFrames.KeyFrames;
			}
			return VTOnlyTheseFrames.Unset;
		}
		set
		{
			switch (value)
			{
			case VTOnlyTheseFrames.AllFrames:
				SetStringValue(VTDecompressionPropertyKey.OnlyTheseFrames, VTDecompressionPropertyKey.OnlyTheseFrames_AllFrames);
				break;
			case VTOnlyTheseFrames.NonDroppableFrames:
				SetStringValue(VTDecompressionPropertyKey.OnlyTheseFrames, VTDecompressionPropertyKey.OnlyTheseFrames_NonDroppableFrames);
				break;
			case VTOnlyTheseFrames.IFrames:
				SetStringValue(VTDecompressionPropertyKey.OnlyTheseFrames, VTDecompressionPropertyKey.OnlyTheseFrames_IFrames);
				break;
			case VTOnlyTheseFrames.KeyFrames:
				SetStringValue(VTDecompressionPropertyKey.OnlyTheseFrames, VTDecompressionPropertyKey.OnlyTheseFrames_KeyFrames);
				break;
			default:
				SetStringValue(VTDecompressionPropertyKey.OnlyTheseFrames, null);
				break;
			}
		}
	}

	public bool? PixelBufferPoolIsShared => GetBoolValue(VTDecompressionPropertyKey.PixelBufferPoolIsShared);

	public uint? OutputPoolRequestedMinimumBufferCount
	{
		get
		{
			return GetUInt32Value(VTDecompressionPropertyKey.OutputPoolRequestedMinimumBufferCount);
		}
		set
		{
			SetNumberValue(VTDecompressionPropertyKey.OutputPoolRequestedMinimumBufferCount, value);
		}
	}

	public uint? NumberOfFramesBeingDecoded => GetUInt32Value(VTDecompressionPropertyKey.NumberOfFramesBeingDecoded);

	public NSDictionary? MinOutputPresentationTimeStampOfFramesBeingDecoded => GetNSDictionary(VTDecompressionPropertyKey.MinOutputPresentationTimeStampOfFramesBeingDecoded);

	public NSDictionary? MaxOutputPresentationTimeStampOfFramesBeingDecoded => GetNSDictionary(VTDecompressionPropertyKey.MaxOutputPresentationTimeStampOfFramesBeingDecoded);

	public bool? ContentHasInterframeDependencies => GetBoolValue(VTDecompressionPropertyKey.ContentHasInterframeDependencies);

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public bool? UsingHardwareAcceleratedVideoDecoder => GetBoolValue(VTDecompressionPropertyKey.UsingHardwareAcceleratedVideoDecoder);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool? RealTime
	{
		get
		{
			return GetBoolValue(VTDecompressionPropertyKey.RealTime);
		}
		set
		{
			SetBooleanValue(VTDecompressionPropertyKey.RealTime, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	public bool? MaximizePowerEfficiency
	{
		get
		{
			return GetBoolValue(VTDecompressionPropertyKey.MaximizePowerEfficiency);
		}
		set
		{
			SetBooleanValue(VTDecompressionPropertyKey.MaximizePowerEfficiency, value);
		}
	}

	public uint? ThreadCount
	{
		get
		{
			return GetUInt32Value(VTDecompressionPropertyKey.ThreadCount);
		}
		set
		{
			SetNumberValue(VTDecompressionPropertyKey.ThreadCount, value);
		}
	}

	public VTDecompressionResolutionOptions? ReducedResolutionDecode
	{
		get
		{
			return GetStrongDictionary<VTDecompressionResolutionOptions>(VTDecompressionPropertyKey.ReducedResolutionDecode);
		}
		set
		{
			SetNativeValue(VTDecompressionPropertyKey.ReducedResolutionDecode, value.GetDictionary());
		}
	}

	public uint? ReducedCoefficientDecode
	{
		get
		{
			return GetUInt32Value(VTDecompressionPropertyKey.ReducedCoefficientDecode);
		}
		set
		{
			SetNumberValue(VTDecompressionPropertyKey.ReducedCoefficientDecode, value);
		}
	}

	public float? ReducedFrameDelivery
	{
		get
		{
			return GetFloatValue(VTDecompressionPropertyKey.ReducedFrameDelivery);
		}
		set
		{
			SetNumberValue(VTDecompressionPropertyKey.ReducedFrameDelivery, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public int? TemporalLevelLimit
	{
		get
		{
			return GetInt32Value(VTDecompressionPropertyKey.TemporalLevelLimit);
		}
		set
		{
			SetNumberValue(VTDecompressionPropertyKey.TemporalLevelLimit, value);
		}
	}

	public NSDictionary[]? SuggestedQualityOfServiceTiers => GetArray<NSDictionary>(VTDecompressionPropertyKey.SuggestedQualityOfServiceTiers);

	public CMPixelFormat[]? SupportedPixelFormatsOrderedByQuality => GetArray(VTDecompressionPropertyKey.SupportedPixelFormatsOrderedByQuality, delegate(IntPtr ptr)
	{
		using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(ptr);
		return (CMPixelFormat)nSNumber.Int32Value;
	});

	public CMPixelFormat[]? SupportedPixelFormatsOrderedByPerformance => GetArray(VTDecompressionPropertyKey.SupportedPixelFormatsOrderedByPerformance, delegate(IntPtr ptr)
	{
		using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(ptr);
		return (CMPixelFormat)nSNumber.Int32Value;
	});

	public CMPixelFormat[]? PixelFormatsWithReducedResolutionSupport => GetArray(VTDecompressionPropertyKey.PixelFormatsWithReducedResolutionSupport, delegate(IntPtr ptr)
	{
		using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(ptr);
		return (CMPixelFormat)nSNumber.Int32Value;
	});

	public NSDictionary? PixelTransferProperties
	{
		get
		{
			return GetNSDictionary(VTDecompressionPropertyKey.PixelTransferProperties);
		}
		set
		{
			SetNativeValue(VTDecompressionPropertyKey.PixelTransferProperties, value);
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public VTPixelTransferProperties? PixelTransferSettings
	{
		get
		{
			return GetStrongDictionary<VTPixelTransferProperties>(VTDecompressionPropertyKey.PixelTransferProperties);
		}
		set
		{
			SetNativeValue(VTDecompressionPropertyKey.PixelTransferProperties, value.GetDictionary());
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public uint? UsingGpuRegistryId => GetUInt32Value(VTDecompressionPropertyKey.UsingGpuRegistryId);

	[Preserve(Conditional = true)]
	public VTDecompressionProperties()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VTDecompressionProperties(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
