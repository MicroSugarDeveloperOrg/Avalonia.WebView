namespace CoreMedia;

public enum CMTimeRoundingMethod
{
	RoundHalfAwayFromZero = 1,
	RoundTowardZero = 2,
	RoundAwayFromZero = 3,
	QuickTime = 4,
	RoundTowardPositiveInfinity = 5,
	RoundTowardNegativeInfinity = 6,
	Default = 1
}
