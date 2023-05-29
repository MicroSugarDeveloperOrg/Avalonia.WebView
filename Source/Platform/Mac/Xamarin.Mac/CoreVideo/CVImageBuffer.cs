using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Since(4, 0)]
public class CVImageBuffer : CVBuffer
{
	public static readonly NSString CGColorSpaceKey;

	public static readonly NSString GammaLevelKey;

	public static readonly NSString CleanApertureKey;

	public static readonly NSString PreferredCleanApertureKey;

	public static readonly NSString CleanApertureWidthKey;

	public static readonly NSString CleanApertureHeightKey;

	public static readonly NSString CleanApertureHorizontalOffsetKey;

	public static readonly NSString CleanApertureVerticalOffsetKey;

	public static readonly NSString FieldCountKey;

	public static readonly NSString FieldDetailKey;

	public static readonly NSString FieldDetailTemporalTopFirst;

	public static readonly NSString FieldDetailTemporalBottomFirst;

	public static readonly NSString FieldDetailSpatialFirstLineEarly;

	public static readonly NSString FieldDetailSpatialFirstLineLate;

	public static readonly NSString PixelAspectRatioKey;

	public static readonly NSString PixelAspectRatioHorizontalSpacingKey;

	public static readonly NSString PixelAspectRatioVerticalSpacingKey;

	public static readonly NSString DisplayDimensionsKey;

	public static readonly NSString DisplayWidthKey;

	public static readonly NSString DisplayHeightKey;

	public static readonly NSString YCbCrMatrixKey;

	public static readonly NSString YCbCrMatrix_ITU_R_709_2;

	public static readonly NSString YCbCrMatrix_ITU_R_601_4;

	public static readonly NSString YCbCrMatrix_SMPTE_240M_1995;

	public static readonly NSString ChromaSubsamplingKey;

	public static readonly NSString ChromaSubsampling_420;

	public static readonly NSString ChromaSubsampling_422;

	public static readonly NSString ChromaSubsampling_411;

	public static readonly NSString TransferFunctionKey;

	public static readonly NSString TransferFunction_ITU_R_709_2;

	public static readonly NSString TransferFunction_SMPTE_240M_1995;

	public static readonly NSString TransferFunction_UseGamma;

	public static readonly NSString ChromaLocationTopFieldKey;

	public static readonly NSString ChromaLocationBottomFieldKey;

	public static readonly NSString ChromaLocation_Left;

	public static readonly NSString ChromaLocation_Center;

	public static readonly NSString ChromaLocation_TopLeft;

	public static readonly NSString ChromaLocation_Top;

	public static readonly NSString ChromaLocation_BottomLeft;

	public static readonly NSString ChromaLocation_Bottom;

	public static readonly NSString ChromaLocation_DV420;

	public CGRect CleanRect => CVImageBufferGetCleanRect(handle);

	public CGSize DisplaySize => CVImageBufferGetDisplaySize(handle);

	public CGSize EncodedSize => CVImageBufferGetDisplaySize(handle);

	public bool IsFlipped => CVImageBufferIsFlipped(handle);

	public CGColorSpace ColorSpace => new CGColorSpace(CVImageBufferGetColorSpace(handle));

	static CVImageBuffer()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			CGColorSpaceKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferCGColorSpaceKey");
			GammaLevelKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferGammaLevelKey");
			CleanApertureKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferCleanApertureKey");
			PreferredCleanApertureKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferPreferredCleanApertureKey");
			CleanApertureWidthKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferCleanApertureWidthKey");
			CleanApertureHeightKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferCleanApertureHeightKey");
			CleanApertureHorizontalOffsetKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferCleanApertureHorizontalOffsetKey");
			CleanApertureVerticalOffsetKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferCleanApertureVerticalOffsetKey");
			FieldCountKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferFieldCountKey");
			FieldDetailKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferFieldDetailKey");
			FieldDetailTemporalTopFirst = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferFieldDetailTemporalTopFirst");
			FieldDetailTemporalBottomFirst = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferFieldDetailTemporalBottomFirst");
			FieldDetailSpatialFirstLineEarly = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferFieldDetailSpatialFirstLineEarly");
			FieldDetailSpatialFirstLineLate = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferFieldDetailSpatialFirstLineLate");
			PixelAspectRatioKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferPixelAspectRatioKey");
			PixelAspectRatioHorizontalSpacingKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferPixelAspectRatioHorizontalSpacingKey");
			PixelAspectRatioVerticalSpacingKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferPixelAspectRatioVerticalSpacingKey");
			DisplayDimensionsKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferDisplayDimensionsKey");
			DisplayWidthKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferDisplayWidthKey");
			DisplayHeightKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferDisplayHeightKey");
			YCbCrMatrixKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferYCbCrMatrixKey");
			YCbCrMatrix_ITU_R_709_2 = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferYCbCrMatrix_ITU_R_709_2");
			YCbCrMatrix_ITU_R_601_4 = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferYCbCrMatrix_ITU_R_601_4");
			YCbCrMatrix_SMPTE_240M_1995 = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferYCbCrMatrix_SMPTE_240M_1995");
			ChromaSubsamplingKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaSubsamplingKey");
			ChromaSubsampling_420 = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaSubsampling_420");
			ChromaSubsampling_422 = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaSubsampling_422");
			ChromaSubsampling_411 = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaSubsampling_411");
			TransferFunctionKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferTransferFunctionKey");
			TransferFunction_ITU_R_709_2 = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferTransferFunction_ITU_R_709_2");
			TransferFunction_SMPTE_240M_1995 = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferTransferFunction_SMPTE_240M_1995");
			TransferFunction_UseGamma = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferTransferFunction_UseGamma");
			ChromaLocationTopFieldKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaLocationTopFieldKey");
			ChromaLocationBottomFieldKey = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaLocationBottomFieldKey");
			ChromaLocation_Left = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaLocation_Left");
			ChromaLocation_Center = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaLocation_Center");
			ChromaLocation_TopLeft = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaLocation_TopLeft");
			ChromaLocation_Top = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaLocation_Top");
			ChromaLocation_BottomLeft = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaLocation_BottomLeft");
			ChromaLocation_Bottom = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaLocation_Bottom");
			ChromaLocation_DV420 = Dlfcn.GetStringConstant(intPtr, "kCVImageBufferChromaLocation_DV420");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	internal CVImageBuffer(IntPtr handle)
		: base(handle)
	{
	}

	internal CVImageBuffer()
	{
	}

	[Preserve(Conditional = true)]
	internal CVImageBuffer(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CGRect CVImageBufferGetCleanRect(IntPtr imageBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CGSize CVImageBufferGetDisplaySize(IntPtr imageBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CGSize CVImageBufferGetEncodedSize(IntPtr imageBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern bool CVImageBufferIsFlipped(IntPtr imageBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVImageBufferGetColorSpace(IntPtr handle);
}
