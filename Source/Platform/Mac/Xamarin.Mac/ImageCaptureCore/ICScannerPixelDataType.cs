using ObjCRuntime;

namespace ImageCaptureCore;

[Native]
public enum ICScannerPixelDataType : ulong
{
	BW,
	Gray,
	Rgb,
	Palette,
	Cmy,
	Cmyk,
	Yuv,
	Yuvk,
	Ciexyz
}
