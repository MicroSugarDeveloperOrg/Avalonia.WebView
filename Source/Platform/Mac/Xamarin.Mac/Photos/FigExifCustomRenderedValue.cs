using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public enum FigExifCustomRenderedValue : short
{
	NotCustom = 0,
	Custom = 1,
	HdrImage = 2,
	HdrPlusEV0_HdrImage = 3,
	HdrPlusEV0_EV0Image = 4,
	PanoramaImage = 6,
	SdofImage = 7,
	SdofPlusOriginal_SdofImage = 8,
	SdofPlusOriginal_OriginalImage = 9
}
