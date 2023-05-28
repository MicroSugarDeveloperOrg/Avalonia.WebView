using ObjCRuntime;

namespace CoreText;

internal enum CTParagraphStyleSpecifier : uint
{
	Alignment,
	FirstLineHeadIndent,
	HeadIndent,
	TailIndent,
	TabStops,
	DefaultTabInterval,
	LineBreakMode,
	LineHeightMultiple,
	MaximumLineHeight,
	MinimumLineHeight,
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Please use MaximumLineSpacing")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Please use MaximumLineSpacing")]
	LineSpacing,
	ParagraphSpacing,
	ParagraphSpacingBefore,
	BaseWritingDirection,
	MaximumLineSpacing,
	MinimumLineSpacing,
	LineSpacingAdjustment,
	LineBoundsOptions,
	Count
}
