using System;

namespace SearchKit;

[Flags]
public enum SKSearchOptions
{
	Default = 0,
	NoRelevanceScores = 1,
	SpaceMeansOr = 2,
	FindSimilar = 4
}
