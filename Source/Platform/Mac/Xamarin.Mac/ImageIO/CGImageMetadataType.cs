using ObjCRuntime;

namespace ImageIO;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public enum CGImageMetadataType
{
	Invalid = -1,
	Default,
	String,
	ArrayUnordered,
	ArrayOrdered,
	AlternateArray,
	AlternateText,
	Structure
}
