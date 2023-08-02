namespace CoreGraphics;

internal struct CGPatternCallbacks
{
	internal uint version;

	internal DrawPatternCallback draw;

	internal ReleaseInfoCallback release;
}
