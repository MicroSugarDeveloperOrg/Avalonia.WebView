using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public enum CMTimeRoundingMethod : uint
{
	RoundHalfAwayFromZero = 1u,
	RoundTowardZero = 2u,
	RoundAwayFromZero = 3u,
	QuickTime = 4u,
	RoundTowardPositiveInfinity = 5u,
	RoundTowardNegativeInfinity = 6u,
	Default = 1u
}
