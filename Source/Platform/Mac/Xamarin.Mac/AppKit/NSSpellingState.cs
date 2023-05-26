using System;

namespace AppKit;

[Flags]
public enum NSSpellingState
{
	None = 0,
	Spelling = 1,
	Grammar = 2
}
