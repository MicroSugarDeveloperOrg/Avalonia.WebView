using System.Collections.Generic;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public class VTCompressionProperties : DictionaryContainer
{
	public VTProfileLevel ProfileLevel
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTCompressionPropertyKey.ProfileLevel);
			if (nSStringValue == null)
			{
				return VTProfileLevel.Unset;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Baseline_1_3)
			{
				return VTProfileLevel.H264Baseline13;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Baseline_3_0)
			{
				return VTProfileLevel.H264Baseline30;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Baseline_3_1)
			{
				return VTProfileLevel.H264Baseline31;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Baseline_3_2)
			{
				return VTProfileLevel.H264Baseline32;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Baseline_4_0)
			{
				return VTProfileLevel.H264Baseline40;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Baseline_4_1)
			{
				return VTProfileLevel.H264Baseline41;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Baseline_4_2)
			{
				return VTProfileLevel.H264Baseline42;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Baseline_5_0)
			{
				return VTProfileLevel.H264Baseline50;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Baseline_5_1)
			{
				return VTProfileLevel.H264Baseline51;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Baseline_5_2)
			{
				return VTProfileLevel.H264Baseline52;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Baseline_AutoLevel)
			{
				return VTProfileLevel.H264BaselineAutoLevel;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Main_3_0)
			{
				return VTProfileLevel.H264Main30;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Main_3_1)
			{
				return VTProfileLevel.H264Main31;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Main_3_2)
			{
				return VTProfileLevel.H264Main32;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Main_4_0)
			{
				return VTProfileLevel.H264Main40;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Main_4_1)
			{
				return VTProfileLevel.H264Main41;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Main_4_2)
			{
				return VTProfileLevel.H264Main42;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Main_5_0)
			{
				return VTProfileLevel.H264Main50;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Main_5_1)
			{
				return VTProfileLevel.H264Main51;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Main_5_2)
			{
				return VTProfileLevel.H264Main52;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Main_AutoLevel)
			{
				return VTProfileLevel.H264MainAutoLevel;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Extended_5_0)
			{
				return VTProfileLevel.H264Extended50;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_Extended_AutoLevel)
			{
				return VTProfileLevel.H264ExtendedAutoLevel;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_High_3_0)
			{
				return VTProfileLevel.H264High30;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_High_3_1)
			{
				return VTProfileLevel.H264High31;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_High_3_2)
			{
				return VTProfileLevel.H264High32;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_High_4_0)
			{
				return VTProfileLevel.H264High40;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_High_4_1)
			{
				return VTProfileLevel.H264High41;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_High_4_2)
			{
				return VTProfileLevel.H264High42;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_High_5_0)
			{
				return VTProfileLevel.H264High50;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_High_5_1)
			{
				return VTProfileLevel.H264High51;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_High_5_2)
			{
				return VTProfileLevel.H264High52;
			}
			if (nSStringValue == VTProfileLevelKeys.H264_High_AutoLevel)
			{
				return VTProfileLevel.H264HighAutoLevel;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_Simple_L0)
			{
				return VTProfileLevel.MP4VSimpleL0;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_Simple_L1)
			{
				return VTProfileLevel.MP4VSimpleL1;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_Simple_L2)
			{
				return VTProfileLevel.MP4VSimpleL2;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_Simple_L3)
			{
				return VTProfileLevel.MP4VSimpleL3;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_Main_L2)
			{
				return VTProfileLevel.MP4VMainL2;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_Main_L3)
			{
				return VTProfileLevel.MP4VMainL3;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_Main_L4)
			{
				return VTProfileLevel.MP4VMainL4;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_AdvancedSimple_L0)
			{
				return VTProfileLevel.MP4VAdvancedSimpleL0;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_AdvancedSimple_L1)
			{
				return VTProfileLevel.MP4VAdvancedSimpleL1;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_AdvancedSimple_L2)
			{
				return VTProfileLevel.MP4VAdvancedSimpleL2;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_AdvancedSimple_L3)
			{
				return VTProfileLevel.MP4VAdvancedSimpleL3;
			}
			if (nSStringValue == VTProfileLevelKeys.MP4V_AdvancedSimple_L4)
			{
				return VTProfileLevel.MP4VAdvancedSimpleL4;
			}
			if (nSStringValue == VTProfileLevelKeys.H263_Profile0_Level10)
			{
				return VTProfileLevel.H263Profile0Level10;
			}
			if (nSStringValue == VTProfileLevelKeys.H263_Profile0_Level45)
			{
				return VTProfileLevel.H263Profile0Level45;
			}
			if (nSStringValue == VTProfileLevelKeys.H263_Profile3_Level45)
			{
				return VTProfileLevel.H263Profile3Level45;
			}
			if (nSStringValue == VTProfileLevelKeys.Hevc_Main_AutoLevel)
			{
				return VTProfileLevel.HevcMainAutoLevel;
			}
			if (nSStringValue == VTProfileLevelKeys.Hevc_Main10_AutoLevel)
			{
				return VTProfileLevel.HevcMain10AutoLevel;
			}
			return VTProfileLevel.Unset;
		}
		set
		{
			switch (value)
			{
			case VTProfileLevel.H264Baseline13:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Baseline_1_3);
				break;
			case VTProfileLevel.H264Baseline30:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Baseline_3_0);
				break;
			case VTProfileLevel.H264Baseline31:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Baseline_3_1);
				break;
			case VTProfileLevel.H264Baseline32:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Baseline_3_2);
				break;
			case VTProfileLevel.H264Baseline40:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Baseline_4_0);
				break;
			case VTProfileLevel.H264Baseline41:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Baseline_4_1);
				break;
			case VTProfileLevel.H264Baseline42:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Baseline_4_2);
				break;
			case VTProfileLevel.H264Baseline50:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Baseline_5_0);
				break;
			case VTProfileLevel.H264Baseline51:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Baseline_5_1);
				break;
			case VTProfileLevel.H264Baseline52:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Baseline_5_2);
				break;
			case VTProfileLevel.H264BaselineAutoLevel:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Baseline_AutoLevel);
				break;
			case VTProfileLevel.H264Main30:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Main_3_0);
				break;
			case VTProfileLevel.H264Main31:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Main_3_1);
				break;
			case VTProfileLevel.H264Main32:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Main_3_2);
				break;
			case VTProfileLevel.H264Main40:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Main_4_0);
				break;
			case VTProfileLevel.H264Main41:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Main_4_1);
				break;
			case VTProfileLevel.H264Main42:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Main_4_2);
				break;
			case VTProfileLevel.H264Main50:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Main_5_0);
				break;
			case VTProfileLevel.H264Main51:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Main_5_1);
				break;
			case VTProfileLevel.H264Main52:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Main_5_2);
				break;
			case VTProfileLevel.H264MainAutoLevel:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Main_AutoLevel);
				break;
			case VTProfileLevel.H264Extended50:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Extended_5_0);
				break;
			case VTProfileLevel.H264ExtendedAutoLevel:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_Extended_AutoLevel);
				break;
			case VTProfileLevel.H264High30:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_High_3_0);
				break;
			case VTProfileLevel.H264High31:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_High_3_1);
				break;
			case VTProfileLevel.H264High32:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_High_3_2);
				break;
			case VTProfileLevel.H264High40:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_High_4_0);
				break;
			case VTProfileLevel.H264High41:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_High_4_1);
				break;
			case VTProfileLevel.H264High42:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_High_4_2);
				break;
			case VTProfileLevel.H264High50:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_High_5_0);
				break;
			case VTProfileLevel.H264High51:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_High_5_1);
				break;
			case VTProfileLevel.H264High52:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_High_5_2);
				break;
			case VTProfileLevel.H264HighAutoLevel:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H264_High_AutoLevel);
				break;
			case VTProfileLevel.MP4VSimpleL0:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_Simple_L0);
				break;
			case VTProfileLevel.MP4VSimpleL1:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_Simple_L1);
				break;
			case VTProfileLevel.MP4VSimpleL2:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_Simple_L2);
				break;
			case VTProfileLevel.MP4VSimpleL3:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_Simple_L3);
				break;
			case VTProfileLevel.MP4VMainL2:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_Main_L2);
				break;
			case VTProfileLevel.MP4VMainL3:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_Main_L3);
				break;
			case VTProfileLevel.MP4VMainL4:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_Main_L4);
				break;
			case VTProfileLevel.MP4VAdvancedSimpleL0:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_AdvancedSimple_L0);
				break;
			case VTProfileLevel.MP4VAdvancedSimpleL1:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_AdvancedSimple_L1);
				break;
			case VTProfileLevel.MP4VAdvancedSimpleL2:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_AdvancedSimple_L2);
				break;
			case VTProfileLevel.MP4VAdvancedSimpleL3:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_AdvancedSimple_L3);
				break;
			case VTProfileLevel.MP4VAdvancedSimpleL4:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.MP4V_AdvancedSimple_L4);
				break;
			case VTProfileLevel.H263Profile0Level10:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H263_Profile0_Level10);
				break;
			case VTProfileLevel.H263Profile0Level45:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H263_Profile0_Level45);
				break;
			case VTProfileLevel.H263Profile3Level45:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.H263_Profile3_Level45);
				break;
			case VTProfileLevel.HevcMainAutoLevel:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.Hevc_Main_AutoLevel);
				break;
			case VTProfileLevel.HevcMain10AutoLevel:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, VTProfileLevelKeys.Hevc_Main10_AutoLevel);
				break;
			default:
				SetStringValue(VTCompressionPropertyKey.ProfileLevel, null);
				break;
			}
		}
	}

	[Mac(10, 9)]
	public VTH264EntropyMode H264EntropyMode
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTCompressionPropertyKey.H264EntropyMode);
			if (nSStringValue == null)
			{
				return VTH264EntropyMode.Unset;
			}
			if (nSStringValue == VTH264EntropyModeKeys.CAVLC)
			{
				return VTH264EntropyMode.Cavlc;
			}
			if (nSStringValue == VTH264EntropyModeKeys.CABAC)
			{
				return VTH264EntropyMode.Cabac;
			}
			return VTH264EntropyMode.Unset;
		}
		set
		{
			switch (value)
			{
			case VTH264EntropyMode.Cavlc:
				SetStringValue(VTCompressionPropertyKey.H264EntropyMode, VTH264EntropyModeKeys.CAVLC);
				break;
			case VTH264EntropyMode.Cabac:
				SetStringValue(VTCompressionPropertyKey.H264EntropyMode, VTH264EntropyModeKeys.CABAC);
				break;
			default:
				SetStringValue(VTCompressionPropertyKey.H264EntropyMode, null);
				break;
			}
		}
	}

	public List<VTDataRateLimit> DataRateLimits
	{
		get
		{
			using NSArray nSArray = GetNativeValue<NSArray>(VTCompressionPropertyKey.DataRateLimits);
			if (nSArray == null)
			{
				return null;
			}
			List<VTDataRateLimit> list = new List<VTDataRateLimit>();
			for (nuint nuint = (byte)0; nuint < nSArray.Count; nuint += (nuint)(byte)2)
			{
				VTDataRateLimit item = new VTDataRateLimit(nSArray.GetItem<NSNumber>(nuint).UInt32Value, nSArray.GetItem<NSNumber>(nuint + (byte)1).DoubleValue);
				list.Add(item);
			}
			return list;
		}
		set
		{
			if (value != null)
			{
				using (NSMutableArray nSMutableArray = new NSMutableArray((nuint)(value.Count * 2)))
				{
					foreach (VTDataRateLimit item in value)
					{
						nSMutableArray.Add(NSNumber.FromUInt32(item.NumberOfBytes));
						nSMutableArray.Add(NSNumber.FromDouble(item.Seconds));
					}
					SetNativeValue(VTCompressionPropertyKey.DataRateLimits, nSMutableArray);
					return;
				}
			}
			SetNativeValue(VTCompressionPropertyKey.DataRateLimits, null);
		}
	}

	public VTFieldDetail FieldDetail
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTCompressionPropertyKey.FieldDetail);
			if (nSStringValue == null)
			{
				return VTFieldDetail.Unset;
			}
			if (nSStringValue == CVImageBuffer.FieldDetailTemporalTopFirst)
			{
				return VTFieldDetail.TemporalTopFirst;
			}
			if (nSStringValue == CVImageBuffer.FieldDetailTemporalBottomFirst)
			{
				return VTFieldDetail.TemporalBottomFirst;
			}
			if (nSStringValue == CVImageBuffer.FieldDetailSpatialFirstLineEarly)
			{
				return VTFieldDetail.SpatialFirstLineEarly;
			}
			if (nSStringValue == CVImageBuffer.FieldDetailSpatialFirstLineLate)
			{
				return VTFieldDetail.SpatialFirstLineLate;
			}
			return VTFieldDetail.Unset;
		}
		set
		{
			switch (value)
			{
			case VTFieldDetail.TemporalTopFirst:
				SetStringValue(VTCompressionPropertyKey.FieldDetail, CVImageBuffer.FieldDetailTemporalTopFirst);
				break;
			case VTFieldDetail.TemporalBottomFirst:
				SetStringValue(VTCompressionPropertyKey.FieldDetail, CVImageBuffer.FieldDetailTemporalBottomFirst);
				break;
			case VTFieldDetail.SpatialFirstLineEarly:
				SetStringValue(VTCompressionPropertyKey.FieldDetail, CVImageBuffer.FieldDetailSpatialFirstLineEarly);
				break;
			case VTFieldDetail.SpatialFirstLineLate:
				SetStringValue(VTCompressionPropertyKey.FieldDetail, CVImageBuffer.FieldDetailSpatialFirstLineLate);
				break;
			default:
				SetStringValue(VTCompressionPropertyKey.FieldDetail, null);
				break;
			}
		}
	}

	public VTColorPrimaries ColorPrimaries
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTCompressionPropertyKey.ColorPrimaries);
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
				SetStringValue(VTCompressionPropertyKey.ColorPrimaries, CVImageBuffer.ColorPrimaries_ITU_R_709_2);
				break;
			case VTColorPrimaries.Ebu3213:
				SetStringValue(VTCompressionPropertyKey.ColorPrimaries, CVImageBuffer.ColorPrimaries_EBU_3213);
				break;
			case VTColorPrimaries.SmpteC:
				SetStringValue(VTCompressionPropertyKey.ColorPrimaries, CVImageBuffer.ColorPrimaries_SMPTE_C);
				break;
			case VTColorPrimaries.P22:
				SetStringValue(VTCompressionPropertyKey.ColorPrimaries, CVImageBuffer.ColorPrimaries_P22);
				break;
			default:
				SetStringValue(VTCompressionPropertyKey.ColorPrimaries, null);
				break;
			}
		}
	}

	public VTTransferFunction TransferFunction
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTCompressionPropertyKey.TransferFunction);
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
				SetStringValue(VTCompressionPropertyKey.TransferFunction, CVImageBuffer.TransferFunction_ITU_R_709_2);
				break;
			case VTTransferFunction.Smpte240M1955:
				SetStringValue(VTCompressionPropertyKey.TransferFunction, CVImageBuffer.TransferFunction_SMPTE_240M_1995);
				break;
			case VTTransferFunction.UseGamma:
				SetStringValue(VTCompressionPropertyKey.TransferFunction, CVImageBuffer.TransferFunction_UseGamma);
				break;
			default:
				SetStringValue(VTCompressionPropertyKey.TransferFunction, null);
				break;
			}
		}
	}

	public VTYCbCrMatrix YCbCrMatrix
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(VTCompressionPropertyKey.YCbCrMatrix);
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
				SetStringValue(VTCompressionPropertyKey.YCbCrMatrix, CVImageBuffer.YCbCrMatrix_ITU_R_709_2);
				break;
			case VTYCbCrMatrix.ItuR6014:
				SetStringValue(VTCompressionPropertyKey.YCbCrMatrix, CVImageBuffer.YCbCrMatrix_ITU_R_601_4);
				break;
			case VTYCbCrMatrix.Smpte240M1955:
				SetStringValue(VTCompressionPropertyKey.YCbCrMatrix, CVImageBuffer.YCbCrMatrix_SMPTE_240M_1995);
				break;
			default:
				SetStringValue(VTCompressionPropertyKey.YCbCrMatrix, null);
				break;
			}
		}
	}

	public VTMultiPassStorage MultiPassStorage
	{
		get
		{
			return GetNativeValue<VTMultiPassStorage>(VTCompressionPropertyKey.MultiPassStorage);
		}
		set
		{
			SetNativeValue(VTCompressionPropertyKey.MultiPassStorage, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, null)]
	public VTAlphaChannelMode AlphaChannelMode
	{
		get
		{
			return VTAlphaChannelModeExtensions.GetValue(GetNSStringValue(VTCompressionPropertyKey.AlphaChannelMode));
		}
		set
		{
			SetStringValue(VTCompressionPropertyKey.AlphaChannelMode, value.GetConstant());
		}
	}

	public int? NumberOfPendingFrames => GetInt32Value(VTCompressionPropertyKey.NumberOfPendingFrames);

	public bool? PixelBufferPoolIsShared => GetBoolValue(VTCompressionPropertyKey.PixelBufferPoolIsShared);

	public NSDictionary? VideoEncoderPixelBufferAttributes => GetNSDictionary(VTCompressionPropertyKey.VideoEncoderPixelBufferAttributes);

	public int? MaxKeyFrameInterval
	{
		get
		{
			return GetInt32Value(VTCompressionPropertyKey.MaxKeyFrameInterval);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.MaxKeyFrameInterval, value);
		}
	}

	public double? MaxKeyFrameIntervalDuration
	{
		get
		{
			return GetDoubleValue(VTCompressionPropertyKey.MaxKeyFrameIntervalDuration);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.MaxKeyFrameIntervalDuration, value);
		}
	}

	public bool? AllowTemporalCompression
	{
		get
		{
			return GetBoolValue(VTCompressionPropertyKey.AllowTemporalCompression);
		}
		set
		{
			SetBooleanValue(VTCompressionPropertyKey.AllowTemporalCompression, value);
		}
	}

	public bool? AllowFrameReordering
	{
		get
		{
			return GetBoolValue(VTCompressionPropertyKey.AllowFrameReordering);
		}
		set
		{
			SetBooleanValue(VTCompressionPropertyKey.AllowFrameReordering, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	public bool? AllowOpenGop
	{
		get
		{
			return GetBoolValue(VTCompressionPropertyKey.AllowOpenGop);
		}
		set
		{
			SetBooleanValue(VTCompressionPropertyKey.AllowOpenGop, value);
		}
	}

	public int? AverageBitRate
	{
		get
		{
			return GetInt32Value(VTCompressionPropertyKey.AverageBitRate);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.AverageBitRate, value);
		}
	}

	public float? Quality
	{
		get
		{
			return GetFloatValue(VTCompressionPropertyKey.Quality);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.Quality, value);
		}
	}

	public bool? MoreFramesBeforeStart
	{
		get
		{
			return GetBoolValue(VTCompressionPropertyKey.MoreFramesBeforeStart);
		}
		set
		{
			SetBooleanValue(VTCompressionPropertyKey.MoreFramesBeforeStart, value);
		}
	}

	public bool? MoreFramesAfterEnd
	{
		get
		{
			return GetBoolValue(VTCompressionPropertyKey.MoreFramesAfterEnd);
		}
		set
		{
			SetBooleanValue(VTCompressionPropertyKey.MoreFramesAfterEnd, value);
		}
	}

	public CMPixelFormat? Depth
	{
		get
		{
			return (CMPixelFormat?)GetUInt32Value(VTCompressionPropertyKey.Depth);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.Depth, (uint?)value);
		}
	}

	public int? MaxFrameDelayCount
	{
		get
		{
			return GetInt32Value(VTCompressionPropertyKey.MaxFrameDelayCount);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.MaxFrameDelayCount, value);
		}
	}

	public int? MaxH264SliceBytes
	{
		get
		{
			return GetInt32Value(VTCompressionPropertyKey.MaxH264SliceBytes);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.MaxH264SliceBytes, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public bool? RealTime
	{
		get
		{
			return GetBoolValue(VTCompressionPropertyKey.RealTime);
		}
		set
		{
			SetBooleanValue(VTCompressionPropertyKey.RealTime, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	public bool? MaximizePowerEfficiency
	{
		get
		{
			return GetBoolValue(VTCompressionPropertyKey.MaximizePowerEfficiency);
		}
		set
		{
			SetBooleanValue(VTCompressionPropertyKey.MaximizePowerEfficiency, value);
		}
	}

	public uint? SourceFrameCount
	{
		get
		{
			return GetUInt32Value(VTCompressionPropertyKey.SourceFrameCount);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.SourceFrameCount, value);
		}
	}

	public double? ExpectedFrameRate
	{
		get
		{
			return GetDoubleValue(VTCompressionPropertyKey.ExpectedFrameRate);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.ExpectedFrameRate, value);
		}
	}

	public double? ExpectedDuration
	{
		get
		{
			return GetDoubleValue(VTCompressionPropertyKey.ExpectedDuration);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.ExpectedDuration, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public double? BaseLayerFrameRate
	{
		get
		{
			return GetDoubleValue(VTCompressionPropertyKey.BaseLayerFrameRate);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.BaseLayerFrameRate, value);
		}
	}

	public bool? UsingHardwareAcceleratedVideoEncoder => GetBoolValue(VTCompressionPropertyKey.UsingHardwareAcceleratedVideoEncoder);

	public NSDictionary? CleanAperture
	{
		get
		{
			return GetNSDictionary(VTCompressionPropertyKey.CleanAperture);
		}
		set
		{
			SetNativeValue(VTCompressionPropertyKey.CleanAperture, value);
		}
	}

	public NSDictionary? PixelAspectRatio
	{
		get
		{
			return GetNSDictionary(VTCompressionPropertyKey.PixelAspectRatio);
		}
		set
		{
			SetNativeValue(VTCompressionPropertyKey.PixelAspectRatio, value);
		}
	}

	public VTFieldCount? FieldCount
	{
		get
		{
			return (VTFieldCount?)GetInt32Value(VTCompressionPropertyKey.FieldCount);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.FieldCount, (int?)value);
		}
	}

	public bool? AspectRatio16x9
	{
		get
		{
			return GetBoolValue(VTCompressionPropertyKey.AspectRatio16x9);
		}
		set
		{
			SetBooleanValue(VTCompressionPropertyKey.AspectRatio16x9, value);
		}
	}

	public bool? ProgressiveScan
	{
		get
		{
			return GetBoolValue(VTCompressionPropertyKey.ProgressiveScan);
		}
		set
		{
			SetBooleanValue(VTCompressionPropertyKey.ProgressiveScan, value);
		}
	}

	public NSData? ICCProfile
	{
		get
		{
			return base.Dictionary[VTCompressionPropertyKey.ICCProfile] as NSData;
		}
		set
		{
			SetNativeValue(VTCompressionPropertyKey.ICCProfile, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public NSData? MasteringDisplayColorVolume
	{
		get
		{
			return base.Dictionary[VTCompressionPropertyKey.MasteringDisplayColorVolume] as NSData;
		}
		set
		{
			SetNativeValue(VTCompressionPropertyKey.MasteringDisplayColorVolume, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public NSData? ContentLightLevelInfo
	{
		get
		{
			return base.Dictionary[VTCompressionPropertyKey.ContentLightLevelInfo] as NSData;
		}
		set
		{
			SetNativeValue(VTCompressionPropertyKey.ContentLightLevelInfo, value);
		}
	}

	public NSDictionary? PixelTransferProperties
	{
		get
		{
			return GetNSDictionary(VTCompressionPropertyKey.PixelTransferProperties);
		}
		set
		{
			SetNativeValue(VTCompressionPropertyKey.PixelTransferProperties, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public string? EncoderId
	{
		get
		{
			return GetStringValue(VTCompressionPropertyKey.EncoderId);
		}
		set
		{
			SetStringValue(VTCompressionPropertyKey.EncoderId, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public float? TargetQualityForAlpha
	{
		get
		{
			return GetFloatValue(VTCompressionPropertyKey.TargetQualityForAlpha);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.TargetQualityForAlpha, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public double? GammaLevel
	{
		get
		{
			return GetDoubleValue(VTCompressionPropertyKey.GammaLevel);
		}
		set
		{
			SetNumberValue(VTCompressionPropertyKey.GammaLevel, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public uint? UsingGpuRegistryId => GetUInt32Value(VTCompressionPropertyKey.UsingGpuRegistryId);

	[Preserve(Conditional = true)]
	public VTCompressionProperties()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VTCompressionProperties(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
