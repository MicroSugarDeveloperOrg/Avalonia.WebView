using System;

namespace CoreImage;

public enum CIFormat
{
	ARGB8 = 0,
	RGBAh = 1,
	RGBA16 = 2,
	[Obsolete("This value can not be shared across Mac/iOS binaries, future proof with kRGBAf instead.")]
	RGBAf = 3,
	kRGBAf = 4,
	kBGRA8 = 5,
	kRGBA8 = 6,
	ABGR8 = 7,
	A8 = 11,
	A16 = 12,
	Ah = 13,
	Af = 14,
	R8 = 15,
	R16 = 16,
	Rh = 17,
	Rf = 18,
	RG8 = 19,
	RG16 = 20,
	RGh = 21,
	RGf = 22
}
