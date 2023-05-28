using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public enum CMPixelFormat : uint
{
	AlphaRedGreenBlue32bits = 32u,
	BlueGreenRedAlpha32bits = 1111970369u,
	RedGreenBlue24bits = 24u,
	BigEndian555_16bits = 16u,
	BigEndian565_16bits = 1110783541u,
	LittleEndian555_16bits = 1278555445u,
	LittleEndian565_16bits = 1278555701u,
	LittleEndian5551_16bits = 892679473u,
	YpCbCr422_8bits = 846624121u,
	YpCbCr422yuvs_8bits = 2037741171u,
	YpCbCr444_8bits = 1983066168u,
	YpCbCrA4444_8bits = 1983131704u,
	YpCbCr422_16bits = 1983000886u,
	YpCbCr422_10bits = 1983000880u,
	YpCbCr444_10bits = 1983131952u,
	IndexedGrayWhiteIsZero_8bits = 40u
}
