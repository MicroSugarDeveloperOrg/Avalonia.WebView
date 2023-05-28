using AVFoundation;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public class VTPixelTransferProperties : DictionaryContainer
{
	public VTScalingMode ScalingMode
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTPixelTransferPropertyKeys.ScalingMode);
			if (nSStringValue == null)
			{
				return VTScalingMode.Unset;
			}
			if (nSStringValue == VTPixelTransferPropertyKeys.ScalingMode_Normal)
			{
				return VTScalingMode.Normal;
			}
			if (nSStringValue == VTPixelTransferPropertyKeys.ScalingMode_CropSourceToCleanAperture)
			{
				return VTScalingMode.CropSourceToCleanAperture;
			}
			if (nSStringValue == VTPixelTransferPropertyKeys.ScalingMode_Letterbox)
			{
				return VTScalingMode.Letterbox;
			}
			if (nSStringValue == VTPixelTransferPropertyKeys.ScalingMode_Trim)
			{
				return VTScalingMode.Trim;
			}
			return VTScalingMode.Unset;
		}
		set
		{
			switch (value)
			{
			case VTScalingMode.Normal:
				SetStringValue(VTPixelTransferPropertyKeys.ScalingMode, VTPixelTransferPropertyKeys.ScalingMode_Normal);
				break;
			case VTScalingMode.CropSourceToCleanAperture:
				SetStringValue(VTPixelTransferPropertyKeys.ScalingMode, VTPixelTransferPropertyKeys.ScalingMode_CropSourceToCleanAperture);
				break;
			case VTScalingMode.Letterbox:
				SetStringValue(VTPixelTransferPropertyKeys.ScalingMode, VTPixelTransferPropertyKeys.ScalingMode_Letterbox);
				break;
			case VTScalingMode.Trim:
				SetStringValue(VTPixelTransferPropertyKeys.ScalingMode, VTPixelTransferPropertyKeys.ScalingMode_Trim);
				break;
			default:
				SetStringValue(VTPixelTransferPropertyKeys.ScalingMode, null);
				break;
			}
		}
	}

	public VTDownsamplingMode DownsamplingMode
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTPixelTransferPropertyKeys.DownsamplingMode);
			if (nSStringValue == null)
			{
				return VTDownsamplingMode.Unset;
			}
			if (nSStringValue == VTPixelTransferPropertyKeys.DownsamplingMode_Decimate)
			{
				return VTDownsamplingMode.Decimate;
			}
			if (nSStringValue == VTPixelTransferPropertyKeys.DownsamplingMode_Average)
			{
				return VTDownsamplingMode.Average;
			}
			return VTDownsamplingMode.Unset;
		}
		set
		{
			switch (value)
			{
			case VTDownsamplingMode.Decimate:
				SetStringValue(VTPixelTransferPropertyKeys.DownsamplingMode, VTPixelTransferPropertyKeys.DownsamplingMode_Decimate);
				break;
			case VTDownsamplingMode.Average:
				SetStringValue(VTPixelTransferPropertyKeys.DownsamplingMode, VTPixelTransferPropertyKeys.DownsamplingMode_Average);
				break;
			default:
				SetStringValue(VTPixelTransferPropertyKeys.DownsamplingMode, null);
				break;
			}
		}
	}

	[iOS(10, 0)]
	public VTColorPrimaries DestinationColorPrimaries
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTPixelTransferPropertyKeys.DestinationColorPrimaries);
			if (nSStringValue == null)
			{
				return VTColorPrimaries.Unset;
			}
			if (nSStringValue == CVImageBuffer.ColorPrimaries_ITU_R_709_2)
			{
				return VTColorPrimaries.ItuR7092;
			}
			if (nSStringValue == CVImageBuffer.ColorPrimaries_EBU_3213)
			{
				return VTColorPrimaries.Ebu3213;
			}
			if (nSStringValue == CVImageBuffer.ColorPrimaries_SMPTE_C)
			{
				return VTColorPrimaries.SmpteC;
			}
			if (nSStringValue == CVImageBuffer.ColorPrimaries_P22)
			{
				return VTColorPrimaries.P22;
			}
			return VTColorPrimaries.Unset;
		}
		set
		{
			switch (value)
			{
			case VTColorPrimaries.ItuR7092:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationColorPrimaries, CVImageBuffer.ColorPrimaries_ITU_R_709_2);
				break;
			case VTColorPrimaries.Ebu3213:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationColorPrimaries, CVImageBuffer.ColorPrimaries_EBU_3213);
				break;
			case VTColorPrimaries.SmpteC:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationColorPrimaries, CVImageBuffer.ColorPrimaries_SMPTE_C);
				break;
			case VTColorPrimaries.P22:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationColorPrimaries, CVImageBuffer.ColorPrimaries_P22);
				break;
			default:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationColorPrimaries, null);
				break;
			}
		}
	}

	[iOS(10, 0)]
	public VTTransferFunction DestinationTransferFunction
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTPixelTransferPropertyKeys.DestinationTransferFunction);
			if (nSStringValue == null)
			{
				return VTTransferFunction.Unset;
			}
			if (nSStringValue == CVImageBuffer.TransferFunction_ITU_R_709_2)
			{
				return VTTransferFunction.ItuR7092;
			}
			if (nSStringValue == CVImageBuffer.TransferFunction_SMPTE_240M_1995)
			{
				return VTTransferFunction.Smpte240M1955;
			}
			if (nSStringValue == CVImageBuffer.TransferFunction_UseGamma)
			{
				return VTTransferFunction.UseGamma;
			}
			return VTTransferFunction.Unset;
		}
		set
		{
			switch (value)
			{
			case VTTransferFunction.ItuR7092:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationTransferFunction, CVImageBuffer.TransferFunction_ITU_R_709_2);
				break;
			case VTTransferFunction.Smpte240M1955:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationTransferFunction, CVImageBuffer.TransferFunction_SMPTE_240M_1995);
				break;
			case VTTransferFunction.UseGamma:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationTransferFunction, CVImageBuffer.TransferFunction_UseGamma);
				break;
			default:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationTransferFunction, null);
				break;
			}
		}
	}

	public VTYCbCrMatrix DestinationYCbCrMatrix
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTPixelTransferPropertyKeys.DestinationYCbCrMatrix);
			if (nSStringValue == null)
			{
				return VTYCbCrMatrix.Unset;
			}
			if (nSStringValue == CVImageBuffer.YCbCrMatrix_ITU_R_709_2)
			{
				return VTYCbCrMatrix.ItuR7092;
			}
			if (nSStringValue == CVImageBuffer.YCbCrMatrix_ITU_R_601_4)
			{
				return VTYCbCrMatrix.ItuR6014;
			}
			if (nSStringValue == CVImageBuffer.YCbCrMatrix_SMPTE_240M_1995)
			{
				return VTYCbCrMatrix.Smpte240M1955;
			}
			return VTYCbCrMatrix.Unset;
		}
		set
		{
			switch (value)
			{
			case VTYCbCrMatrix.ItuR7092:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationYCbCrMatrix, CVImageBuffer.YCbCrMatrix_ITU_R_709_2);
				break;
			case VTYCbCrMatrix.ItuR6014:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationYCbCrMatrix, CVImageBuffer.YCbCrMatrix_ITU_R_601_4);
				break;
			case VTYCbCrMatrix.Smpte240M1955:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationYCbCrMatrix, CVImageBuffer.YCbCrMatrix_SMPTE_240M_1995);
				break;
			default:
				SetStringValue(VTPixelTransferPropertyKeys.DestinationYCbCrMatrix, null);
				break;
			}
		}
	}

	public AVVideoCleanApertureSettings? DestinationCleanAperture
	{
		get
		{
			return GetStrongDictionary<AVVideoCleanApertureSettings>(VTPixelTransferPropertyKeys.DestinationCleanAperture);
		}
		set
		{
			SetNativeValue(VTPixelTransferPropertyKeys.DestinationCleanAperture, value.GetDictionary());
		}
	}

	public AVVideoPixelAspectRatioSettings? DestinationPixelAspectRatio
	{
		get
		{
			return GetStrongDictionary<AVVideoPixelAspectRatioSettings>(VTPixelTransferPropertyKeys.DestinationPixelAspectRatio);
		}
		set
		{
			SetNativeValue(VTPixelTransferPropertyKeys.DestinationPixelAspectRatio, value.GetDictionary());
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public NSData? DestinationICCProfile
	{
		get
		{
			return base.Dictionary[VTPixelTransferPropertyKeys.DestinationICCProfile] as NSData;
		}
		set
		{
			SetNativeValue(VTPixelTransferPropertyKeys.DestinationICCProfile, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public bool? RealTime
	{
		get
		{
			return GetBoolValue(VTPixelTransferPropertyKeys.RealTime);
		}
		set
		{
			SetBooleanValue(VTPixelTransferPropertyKeys.RealTime, value);
		}
	}

	[Preserve(Conditional = true)]
	public VTPixelTransferProperties()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VTPixelTransferProperties(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
