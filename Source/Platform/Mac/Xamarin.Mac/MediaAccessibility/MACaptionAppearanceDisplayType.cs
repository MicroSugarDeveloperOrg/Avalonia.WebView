using ObjCRuntime;

namespace MediaAccessibility;

[Native]
[iOS(7, 0)]
[Mac(10, 9)]
public enum MACaptionAppearanceDisplayType : long
{
	ForcedOnly,
	Automatic,
	AlwaysOn
}
