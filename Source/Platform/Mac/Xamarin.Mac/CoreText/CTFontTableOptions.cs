using System;

namespace CoreText;

[Flags]
public enum CTFontTableOptions : uint
{
	None = 0u,
	ExcludeSynthetic = 1u
}
