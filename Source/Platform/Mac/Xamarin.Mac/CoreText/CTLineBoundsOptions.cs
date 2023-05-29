namespace CoreText;

public enum CTLineBoundsOptions
{
	ExcludeTypographicLeading = 1,
	ExcludeTypographicShifts = 2,
	UseHangingPunctuation = 4,
	UseGlyphPathBounds = 8,
	UseOpticalBounds = 0x10
}
