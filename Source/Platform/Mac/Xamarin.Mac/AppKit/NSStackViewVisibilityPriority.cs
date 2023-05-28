using System;

namespace AppKit;

public enum NSStackViewVisibilityPriority
{
	MustHold = 1000,
	[Obsolete("Use 'MustHold' instead.")]
	Musthold = 1000,
	DetachOnlyIfNecessary = 900,
	NotVisible = 0
}
