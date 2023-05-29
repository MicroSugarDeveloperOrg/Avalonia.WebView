namespace AppKit;

public enum NSLayoutFormatOptions : ulong
{
	None = 0uL,
	AlignAllLeft = 2uL,
	AlignAllRight = 4uL,
	AlignAllTop = 8uL,
	AlignAllBottom = 16uL,
	AlignAllLeading = 32uL,
	AlignAllTrailing = 64uL,
	AlignAllCenterX = 512uL,
	AlignAllCenterY = 1024uL,
	AlignAllBaseline = 2048uL,
	AlignmentMask = 65535uL,
	DirectionLeadingToTrailing = 0uL,
	DirectionLeftToRight = 65536uL,
	DirectionRightToLeft = 131072uL,
	DirectionMask = 196608uL
}
