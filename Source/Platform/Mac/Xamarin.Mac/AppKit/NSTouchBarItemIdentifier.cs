using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
public enum NSTouchBarItemIdentifier
{
	FixedSpaceSmall,
	FixedSpaceLarge,
	FlexibleSpace,
	OtherItemsProxy,
	CharacterPicker,
	TextColorPicker,
	TextStyle,
	TextAlignment,
	TextList,
	TextFormat,
	CandidateList
}
