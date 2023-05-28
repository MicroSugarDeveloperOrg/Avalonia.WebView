using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Watch(4, 0)]
public class CVPixelBufferPool : INativeObject, IDisposable
{
	private IntPtr handle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlphaChannelIsOpaque;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlphaChannelModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CGColorSpaceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaLocationBottomFieldKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaLocationTopFieldKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaLocation_Bottom;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaLocation_BottomLeft;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaLocation_Center;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaLocation_DV420;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaLocation_Left;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaLocation_Top;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaLocation_TopLeft;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaSubsamplingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaSubsampling_411;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaSubsampling_420;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChromaSubsampling_422;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanApertureHeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanApertureHorizontalOffsetKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanApertureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanApertureVerticalOffsetKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanApertureWidthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorPrimariesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentLightLevelInfoKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayDimensionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayHeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayWidthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldCountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldDetailKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldDetailSpatialFirstLineEarly;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldDetailSpatialFirstLineLate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldDetailTemporalBottomFirst;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldDetailTemporalTopFirst;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GammaLevelKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MasteringDisplayColorVolumeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaximumBufferAgeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MinimumBufferCountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MovieTimeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NonPropagatedAttachmentsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelAspectRatioHorizontalSpacingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelAspectRatioKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelAspectRatioVerticalSpacingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreferredCleanApertureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropagatedAttachmentsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeScaleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeValueKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TransferFunctionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _YCbCrMatrixKey;

	public IntPtr Handle => handle;

	public nint TypeID => CVPixelBufferPoolGetTypeID();

	public NSDictionary PixelBufferAttributes => Runtime.GetNSObject<NSDictionary>(CVPixelBufferPoolGetPixelBufferAttributes(handle));

	public NSDictionary Attributes => Runtime.GetNSObject<NSDictionary>(CVPixelBufferPoolGetAttributes(handle));

	public CVPixelBufferPoolSettings Settings
	{
		get
		{
			NSDictionary attributes = Attributes;
			return (attributes == null) ? null : new CVPixelBufferPoolSettings(attributes);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString ColorPrimaries_DCI_P3
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return CVImageBufferColorPrimaries.DciP3.GetConstant();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString ColorPrimaries_EBU_3213 => CVImageBufferColorPrimaries.Ebu3213.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString ColorPrimaries_ITU_R_2020
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return CVImageBufferColorPrimaries.ItuR2020.GetConstant();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString ColorPrimaries_ITU_R_709_2 => CVImageBufferColorPrimaries.ItuR709_2.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString ColorPrimaries_P22 => CVImageBufferColorPrimaries.P22.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString ColorPrimaries_P3_D65
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return CVImageBufferColorPrimaries.P3D65.GetConstant();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString ColorPrimaries_SMPTE_C => CVImageBufferColorPrimaries.SmpteC.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString TransferFunction_ITU_R_2020
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			return CVImageBufferTransferFunction.ItuR2020.GetConstant();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString TransferFunction_ITU_R_2100_HLG
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			return CVImageBufferTransferFunction.ItuR2100Hlg.GetConstant();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString TransferFunction_ITU_R_709_2 => CVImageBufferTransferFunction.ItuR709_2.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString TransferFunction_SMPTE_240M_1995 => CVImageBufferTransferFunction.Smpte240M1995.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString TransferFunction_SMPTE_ST_2084_PQ
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			return CVImageBufferTransferFunction.SmpteST2084PQ.GetConstant();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString TransferFunction_SMPTE_ST_428_1
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			return CVImageBufferTransferFunction.SmpteST428_1.GetConstant();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString TransferFunction_UseGamma => CVImageBufferTransferFunction.UseGamma.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString TransferFunction_sRGB
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			return CVImageBufferTransferFunction.SRgb.GetConstant();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString YCbCrMatrix_DCI_P3
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return CVImageBufferYCbCrMatrix.DciP3.GetConstant();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString YCbCrMatrix_ITU_R_2020
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return CVImageBufferYCbCrMatrix.ItuR2020.GetConstant();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString YCbCrMatrix_ITU_R_601_4 => CVImageBufferYCbCrMatrix.ItuR601_4.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString YCbCrMatrix_ITU_R_709_2 => CVImageBufferYCbCrMatrix.ItuR709_2.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString YCbCrMatrix_P3_D65
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return CVImageBufferYCbCrMatrix.P3D65.GetConstant();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString YCbCrMatrix_SMPTE_240M_1995 => CVImageBufferYCbCrMatrix.Smpte240M1995.GetConstant();

	[Field("kCVImageBufferAlphaChannelIsOpaque", "CoreVideo")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString AlphaChannelIsOpaque
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_AlphaChannelIsOpaque == null)
			{
				_AlphaChannelIsOpaque = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferAlphaChannelIsOpaque");
			}
			return _AlphaChannelIsOpaque;
		}
	}

	[Field("kCVImageBufferAlphaChannelModeKey", "CoreVideo")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString AlphaChannelModeKey
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AlphaChannelModeKey == null)
			{
				_AlphaChannelModeKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferAlphaChannelModeKey");
			}
			return _AlphaChannelModeKey;
		}
	}

	[Field("kCVImageBufferCGColorSpaceKey", "CoreVideo")]
	public static NSString CGColorSpaceKey
	{
		get
		{
			if (_CGColorSpaceKey == null)
			{
				_CGColorSpaceKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferCGColorSpaceKey");
			}
			return _CGColorSpaceKey;
		}
	}

	[Field("kCVImageBufferChromaLocationBottomFieldKey", "CoreVideo")]
	public static NSString ChromaLocationBottomFieldKey
	{
		get
		{
			if (_ChromaLocationBottomFieldKey == null)
			{
				_ChromaLocationBottomFieldKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocationBottomFieldKey");
			}
			return _ChromaLocationBottomFieldKey;
		}
	}

	[Field("kCVImageBufferChromaLocationTopFieldKey", "CoreVideo")]
	public static NSString ChromaLocationTopFieldKey
	{
		get
		{
			if (_ChromaLocationTopFieldKey == null)
			{
				_ChromaLocationTopFieldKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocationTopFieldKey");
			}
			return _ChromaLocationTopFieldKey;
		}
	}

	[Field("kCVImageBufferChromaLocation_Bottom", "CoreVideo")]
	public static NSString ChromaLocation_Bottom
	{
		get
		{
			if (_ChromaLocation_Bottom == null)
			{
				_ChromaLocation_Bottom = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_Bottom");
			}
			return _ChromaLocation_Bottom;
		}
	}

	[Field("kCVImageBufferChromaLocation_BottomLeft", "CoreVideo")]
	public static NSString ChromaLocation_BottomLeft
	{
		get
		{
			if (_ChromaLocation_BottomLeft == null)
			{
				_ChromaLocation_BottomLeft = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_BottomLeft");
			}
			return _ChromaLocation_BottomLeft;
		}
	}

	[Field("kCVImageBufferChromaLocation_Center", "CoreVideo")]
	public static NSString ChromaLocation_Center
	{
		get
		{
			if (_ChromaLocation_Center == null)
			{
				_ChromaLocation_Center = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_Center");
			}
			return _ChromaLocation_Center;
		}
	}

	[Field("kCVImageBufferChromaLocation_DV420", "CoreVideo")]
	public static NSString ChromaLocation_DV420
	{
		get
		{
			if (_ChromaLocation_DV420 == null)
			{
				_ChromaLocation_DV420 = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_DV420");
			}
			return _ChromaLocation_DV420;
		}
	}

	[Field("kCVImageBufferChromaLocation_Left", "CoreVideo")]
	public static NSString ChromaLocation_Left
	{
		get
		{
			if (_ChromaLocation_Left == null)
			{
				_ChromaLocation_Left = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_Left");
			}
			return _ChromaLocation_Left;
		}
	}

	[Field("kCVImageBufferChromaLocation_Top", "CoreVideo")]
	public static NSString ChromaLocation_Top
	{
		get
		{
			if (_ChromaLocation_Top == null)
			{
				_ChromaLocation_Top = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_Top");
			}
			return _ChromaLocation_Top;
		}
	}

	[Field("kCVImageBufferChromaLocation_TopLeft", "CoreVideo")]
	public static NSString ChromaLocation_TopLeft
	{
		get
		{
			if (_ChromaLocation_TopLeft == null)
			{
				_ChromaLocation_TopLeft = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_TopLeft");
			}
			return _ChromaLocation_TopLeft;
		}
	}

	[Field("kCVImageBufferChromaSubsamplingKey", "CoreVideo")]
	public static NSString ChromaSubsamplingKey
	{
		get
		{
			if (_ChromaSubsamplingKey == null)
			{
				_ChromaSubsamplingKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaSubsamplingKey");
			}
			return _ChromaSubsamplingKey;
		}
	}

	[Field("kCVImageBufferChromaSubsampling_411", "CoreVideo")]
	public static NSString ChromaSubsampling_411
	{
		get
		{
			if (_ChromaSubsampling_411 == null)
			{
				_ChromaSubsampling_411 = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaSubsampling_411");
			}
			return _ChromaSubsampling_411;
		}
	}

	[Field("kCVImageBufferChromaSubsampling_420", "CoreVideo")]
	public static NSString ChromaSubsampling_420
	{
		get
		{
			if (_ChromaSubsampling_420 == null)
			{
				_ChromaSubsampling_420 = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaSubsampling_420");
			}
			return _ChromaSubsampling_420;
		}
	}

	[Field("kCVImageBufferChromaSubsampling_422", "CoreVideo")]
	public static NSString ChromaSubsampling_422
	{
		get
		{
			if (_ChromaSubsampling_422 == null)
			{
				_ChromaSubsampling_422 = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferChromaSubsampling_422");
			}
			return _ChromaSubsampling_422;
		}
	}

	[Field("kCVImageBufferCleanApertureHeightKey", "CoreVideo")]
	public static NSString CleanApertureHeightKey
	{
		get
		{
			if (_CleanApertureHeightKey == null)
			{
				_CleanApertureHeightKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferCleanApertureHeightKey");
			}
			return _CleanApertureHeightKey;
		}
	}

	[Field("kCVImageBufferCleanApertureHorizontalOffsetKey", "CoreVideo")]
	public static NSString CleanApertureHorizontalOffsetKey
	{
		get
		{
			if (_CleanApertureHorizontalOffsetKey == null)
			{
				_CleanApertureHorizontalOffsetKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferCleanApertureHorizontalOffsetKey");
			}
			return _CleanApertureHorizontalOffsetKey;
		}
	}

	[Field("kCVImageBufferCleanApertureKey", "CoreVideo")]
	public static NSString CleanApertureKey
	{
		get
		{
			if (_CleanApertureKey == null)
			{
				_CleanApertureKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferCleanApertureKey");
			}
			return _CleanApertureKey;
		}
	}

	[Field("kCVImageBufferCleanApertureVerticalOffsetKey", "CoreVideo")]
	public static NSString CleanApertureVerticalOffsetKey
	{
		get
		{
			if (_CleanApertureVerticalOffsetKey == null)
			{
				_CleanApertureVerticalOffsetKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferCleanApertureVerticalOffsetKey");
			}
			return _CleanApertureVerticalOffsetKey;
		}
	}

	[Field("kCVImageBufferCleanApertureWidthKey", "CoreVideo")]
	public static NSString CleanApertureWidthKey
	{
		get
		{
			if (_CleanApertureWidthKey == null)
			{
				_CleanApertureWidthKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferCleanApertureWidthKey");
			}
			return _CleanApertureWidthKey;
		}
	}

	[Field("kCVImageBufferColorPrimariesKey", "CoreVideo")]
	public static NSString ColorPrimariesKey
	{
		get
		{
			if (_ColorPrimariesKey == null)
			{
				_ColorPrimariesKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimariesKey");
			}
			return _ColorPrimariesKey;
		}
	}

	[Field("kCVImageBufferContentLightLevelInfoKey", "CoreVideo")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString ContentLightLevelInfoKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ContentLightLevelInfoKey == null)
			{
				_ContentLightLevelInfoKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferContentLightLevelInfoKey");
			}
			return _ContentLightLevelInfoKey;
		}
	}

	[Field("kCVImageBufferDisplayDimensionsKey", "CoreVideo")]
	public static NSString DisplayDimensionsKey
	{
		get
		{
			if (_DisplayDimensionsKey == null)
			{
				_DisplayDimensionsKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferDisplayDimensionsKey");
			}
			return _DisplayDimensionsKey;
		}
	}

	[Field("kCVImageBufferDisplayHeightKey", "CoreVideo")]
	public static NSString DisplayHeightKey
	{
		get
		{
			if (_DisplayHeightKey == null)
			{
				_DisplayHeightKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferDisplayHeightKey");
			}
			return _DisplayHeightKey;
		}
	}

	[Field("kCVImageBufferDisplayWidthKey", "CoreVideo")]
	public static NSString DisplayWidthKey
	{
		get
		{
			if (_DisplayWidthKey == null)
			{
				_DisplayWidthKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferDisplayWidthKey");
			}
			return _DisplayWidthKey;
		}
	}

	[Field("kCVImageBufferFieldCountKey", "CoreVideo")]
	public static NSString FieldCountKey
	{
		get
		{
			if (_FieldCountKey == null)
			{
				_FieldCountKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferFieldCountKey");
			}
			return _FieldCountKey;
		}
	}

	[Field("kCVImageBufferFieldDetailKey", "CoreVideo")]
	public static NSString FieldDetailKey
	{
		get
		{
			if (_FieldDetailKey == null)
			{
				_FieldDetailKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferFieldDetailKey");
			}
			return _FieldDetailKey;
		}
	}

	[Field("kCVImageBufferFieldDetailSpatialFirstLineEarly", "CoreVideo")]
	public static NSString FieldDetailSpatialFirstLineEarly
	{
		get
		{
			if (_FieldDetailSpatialFirstLineEarly == null)
			{
				_FieldDetailSpatialFirstLineEarly = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferFieldDetailSpatialFirstLineEarly");
			}
			return _FieldDetailSpatialFirstLineEarly;
		}
	}

	[Field("kCVImageBufferFieldDetailSpatialFirstLineLate", "CoreVideo")]
	public static NSString FieldDetailSpatialFirstLineLate
	{
		get
		{
			if (_FieldDetailSpatialFirstLineLate == null)
			{
				_FieldDetailSpatialFirstLineLate = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferFieldDetailSpatialFirstLineLate");
			}
			return _FieldDetailSpatialFirstLineLate;
		}
	}

	[Field("kCVImageBufferFieldDetailTemporalBottomFirst", "CoreVideo")]
	public static NSString FieldDetailTemporalBottomFirst
	{
		get
		{
			if (_FieldDetailTemporalBottomFirst == null)
			{
				_FieldDetailTemporalBottomFirst = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferFieldDetailTemporalBottomFirst");
			}
			return _FieldDetailTemporalBottomFirst;
		}
	}

	[Field("kCVImageBufferFieldDetailTemporalTopFirst", "CoreVideo")]
	public static NSString FieldDetailTemporalTopFirst
	{
		get
		{
			if (_FieldDetailTemporalTopFirst == null)
			{
				_FieldDetailTemporalTopFirst = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferFieldDetailTemporalTopFirst");
			}
			return _FieldDetailTemporalTopFirst;
		}
	}

	[Field("kCVImageBufferGammaLevelKey", "CoreVideo")]
	public static NSString GammaLevelKey
	{
		get
		{
			if (_GammaLevelKey == null)
			{
				_GammaLevelKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferGammaLevelKey");
			}
			return _GammaLevelKey;
		}
	}

	[Field("kCVImageBufferMasteringDisplayColorVolumeKey", "CoreVideo")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString MasteringDisplayColorVolumeKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MasteringDisplayColorVolumeKey == null)
			{
				_MasteringDisplayColorVolumeKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferMasteringDisplayColorVolumeKey");
			}
			return _MasteringDisplayColorVolumeKey;
		}
	}

	[Field("kCVPixelBufferPoolMaximumBufferAgeKey", "CoreVideo")]
	public static NSString MaximumBufferAgeKey
	{
		get
		{
			if (_MaximumBufferAgeKey == null)
			{
				_MaximumBufferAgeKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferPoolMaximumBufferAgeKey");
			}
			return _MaximumBufferAgeKey;
		}
	}

	[Field("kCVPixelBufferPoolMinimumBufferCountKey", "CoreVideo")]
	public static NSString MinimumBufferCountKey
	{
		get
		{
			if (_MinimumBufferCountKey == null)
			{
				_MinimumBufferCountKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferPoolMinimumBufferCountKey");
			}
			return _MinimumBufferCountKey;
		}
	}

	[Field("kCVBufferMovieTimeKey", "CoreVideo")]
	public static NSString MovieTimeKey
	{
		get
		{
			if (_MovieTimeKey == null)
			{
				_MovieTimeKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVBufferMovieTimeKey");
			}
			return _MovieTimeKey;
		}
	}

	[Field("kCVBufferNonPropagatedAttachmentsKey", "CoreVideo")]
	public static NSString NonPropagatedAttachmentsKey
	{
		get
		{
			if (_NonPropagatedAttachmentsKey == null)
			{
				_NonPropagatedAttachmentsKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVBufferNonPropagatedAttachmentsKey");
			}
			return _NonPropagatedAttachmentsKey;
		}
	}

	[Field("kCVImageBufferPixelAspectRatioHorizontalSpacingKey", "CoreVideo")]
	public static NSString PixelAspectRatioHorizontalSpacingKey
	{
		get
		{
			if (_PixelAspectRatioHorizontalSpacingKey == null)
			{
				_PixelAspectRatioHorizontalSpacingKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferPixelAspectRatioHorizontalSpacingKey");
			}
			return _PixelAspectRatioHorizontalSpacingKey;
		}
	}

	[Field("kCVImageBufferPixelAspectRatioKey", "CoreVideo")]
	public static NSString PixelAspectRatioKey
	{
		get
		{
			if (_PixelAspectRatioKey == null)
			{
				_PixelAspectRatioKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferPixelAspectRatioKey");
			}
			return _PixelAspectRatioKey;
		}
	}

	[Field("kCVImageBufferPixelAspectRatioVerticalSpacingKey", "CoreVideo")]
	public static NSString PixelAspectRatioVerticalSpacingKey
	{
		get
		{
			if (_PixelAspectRatioVerticalSpacingKey == null)
			{
				_PixelAspectRatioVerticalSpacingKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferPixelAspectRatioVerticalSpacingKey");
			}
			return _PixelAspectRatioVerticalSpacingKey;
		}
	}

	[Field("kCVImageBufferPreferredCleanApertureKey", "CoreVideo")]
	public static NSString PreferredCleanApertureKey
	{
		get
		{
			if (_PreferredCleanApertureKey == null)
			{
				_PreferredCleanApertureKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferPreferredCleanApertureKey");
			}
			return _PreferredCleanApertureKey;
		}
	}

	[Field("kCVBufferPropagatedAttachmentsKey", "CoreVideo")]
	public static NSString PropagatedAttachmentsKey
	{
		get
		{
			if (_PropagatedAttachmentsKey == null)
			{
				_PropagatedAttachmentsKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVBufferPropagatedAttachmentsKey");
			}
			return _PropagatedAttachmentsKey;
		}
	}

	[Field("kCVBufferTimeScaleKey", "CoreVideo")]
	public static NSString TimeScaleKey
	{
		get
		{
			if (_TimeScaleKey == null)
			{
				_TimeScaleKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVBufferTimeScaleKey");
			}
			return _TimeScaleKey;
		}
	}

	[Field("kCVBufferTimeValueKey", "CoreVideo")]
	public static NSString TimeValueKey
	{
		get
		{
			if (_TimeValueKey == null)
			{
				_TimeValueKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVBufferTimeValueKey");
			}
			return _TimeValueKey;
		}
	}

	[Field("kCVImageBufferTransferFunctionKey", "CoreVideo")]
	public static NSString TransferFunctionKey
	{
		get
		{
			if (_TransferFunctionKey == null)
			{
				_TransferFunctionKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunctionKey");
			}
			return _TransferFunctionKey;
		}
	}

	[Field("kCVImageBufferYCbCrMatrixKey", "CoreVideo")]
	public static NSString YCbCrMatrixKey
	{
		get
		{
			if (_YCbCrMatrixKey == null)
			{
				_YCbCrMatrixKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrixKey");
			}
			return _YCbCrMatrixKey;
		}
	}

	internal CVPixelBufferPool(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException("Invalid parameters to context creation");
		}
		this.handle = CVPixelBufferPoolRetain(handle);
	}

	[Preserve(Conditional = true)]
	internal CVPixelBufferPool(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CVPixelBufferPoolRetain(handle);
		}
		this.handle = handle;
	}

	~CVPixelBufferPool()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVPixelBufferPoolRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferPoolRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CVPixelBufferPoolRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern nint CVPixelBufferPoolGetTypeID();

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferPoolGetPixelBufferAttributes(IntPtr pool);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferPoolGetAttributes(IntPtr pool);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferPoolCreatePixelBuffer(IntPtr allocator, IntPtr pixelBufferPool, out IntPtr pixelBufferOut);

	public CVPixelBuffer CreatePixelBuffer()
	{
		IntPtr pixelBufferOut;
		CVReturn cVReturn = CVPixelBufferPoolCreatePixelBuffer(IntPtr.Zero, handle, out pixelBufferOut);
		if (cVReturn != 0)
		{
			throw new Exception("CVPixelBufferPoolCreatePixelBuffer returned " + cVReturn);
		}
		return new CVPixelBuffer(pixelBufferOut, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferPoolCreatePixelBufferWithAuxAttributes(IntPtr allocator, IntPtr pixelBufferPool, IntPtr auxAttributes, out IntPtr pixelBufferOut);

	public CVPixelBuffer CreatePixelBuffer(CVPixelBufferPoolAllocationSettings allocationSettings, out CVReturn error)
	{
		error = CVPixelBufferPoolCreatePixelBufferWithAuxAttributes(IntPtr.Zero, handle, allocationSettings.GetHandle(), out var pixelBufferOut);
		if (error != 0)
		{
			return null;
		}
		return new CVPixelBuffer(pixelBufferOut, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferPoolCreate(IntPtr allocator, IntPtr poolAttributes, IntPtr pixelBufferAttributes, out IntPtr poolOut);

	[Advice("Use overload with CVPixelBufferPoolSettings")]
	public CVPixelBufferPool(NSDictionary poolAttributes, NSDictionary pixelBufferAttributes)
	{
		CVReturn cVReturn = CVPixelBufferPoolCreate(IntPtr.Zero, poolAttributes.GetHandle(), pixelBufferAttributes.GetHandle(), out handle);
		if (cVReturn != 0)
		{
			throw new Exception("CVPixelBufferPoolCreate returned " + cVReturn);
		}
	}

	public CVPixelBufferPool(CVPixelBufferPoolSettings settings, CVPixelBufferAttributes pixelBufferAttributes)
		: this(settings.GetDictionary(), pixelBufferAttributes.GetDictionary())
	{
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern void CVPixelBufferPoolFlush(IntPtr pool, CVPixelBufferPoolFlushFlags options);

	[iOS(9, 0)]
	[Mac(10, 11)]
	public void Flush(CVPixelBufferPoolFlushFlags options)
	{
		CVPixelBufferPoolFlush(handle, options);
	}
}
