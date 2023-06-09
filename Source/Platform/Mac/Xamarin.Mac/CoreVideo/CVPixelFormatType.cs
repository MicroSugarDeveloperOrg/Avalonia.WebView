namespace CoreVideo;

public enum CVPixelFormatType : uint
{
	CV1Monochrome = 1u,
	CV2Indexed = 2u,
	CV4Indexed = 4u,
	CV8Indexed = 8u,
	CV1IndexedGray_WhiteIsZero = 33u,
	CV2IndexedGray_WhiteIsZero = 34u,
	CV4IndexedGray_WhiteIsZero = 36u,
	CV8IndexedGray_WhiteIsZero = 40u,
	CV16BE555 = 16u,
	CV24RGB = 24u,
	CV32ARGB = 32u,
	CV16LE555 = 1278555445u,
	CV16LE5551 = 892679473u,
	CV16BE565 = 1110783541u,
	CV16LE565 = 1278555701u,
	CV24BGR = 842285639u,
	CV32BGRA = 1111970369u,
	CV32ABGR = 1094862674u,
	CV32RGBA = 1380401729u,
	CV64ARGB = 1647719521u,
	CV48RGB = 1647589490u,
	CV32AlphaGray = 1647522401u,
	CV16Gray = 1647392359u,
	CV422YpCbCr8 = 846624121u,
	CV4444YpCbCrA8 = 1983131704u,
	CV4444YpCbCrA8R = 1916022840u,
	CV444YpCbCr8 = 1983066168u,
	CV422YpCbCr16 = 1983000886u,
	CV422YpCbCr10 = 1983000880u,
	CV444YpCbCr10 = 1983131952u,
	CV420YpCbCr8Planar = 2033463856u,
	CV420YpCbCr8PlanarFullRange = 1714696752u,
	CV422YpCbCr_4A_8BiPlanar = 1630697081u,
	CV420YpCbCr8BiPlanarVideoRange = 875704438u,
	CV420YpCbCr8BiPlanarFullRange = 875704422u,
	CV422YpCbCr8_yuvs = 2037741171u,
	CV422YpCbCr8FullRange = 2037741158u,
	CV30RGB = 1378955371u,
	CV4444AYpCbCr8 = 2033463352u,
	CV4444AYpCbCr16 = 2033463606u,
	OneComponent8 = 1278226488u,
	TwoComponent8 = 843264056u,
	OneComponent16Half = 1278226536u,
	OneComponent32Float = 1278226534u,
	TwoComponent16Half = 843264104u,
	TwoComponent32Float = 843264102u,
	CV64RGBAHalf = 1380411457u,
	CV128RGBAFloat = 1380410945u
}
