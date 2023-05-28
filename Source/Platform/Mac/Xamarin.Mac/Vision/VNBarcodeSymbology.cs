using ObjCRuntime;

namespace Vision;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public enum VNBarcodeSymbology
{
	Aztec,
	Code39,
	Code39Checksum,
	Code39FullAscii,
	Code39FullAsciiChecksum,
	Code93,
	Code93i,
	Code128,
	DataMatrix,
	Ean8,
	Ean13,
	I2OF5,
	I2OF5Checksum,
	Itf14,
	Pdf417,
	QR,
	Upce
}
