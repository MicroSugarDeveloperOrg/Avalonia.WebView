using System;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
[Flags]
public enum CTFontTableOptions : uint
{
	None = 0u,
	ExcludeSynthetic = 1u
}
