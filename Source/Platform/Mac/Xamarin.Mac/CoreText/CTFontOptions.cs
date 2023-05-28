using System;
using ObjCRuntime;

namespace CoreText;

[Flags]
[Native]
public enum CTFontOptions : ulong
{
	Default = 0uL,
	PreventAutoActivation = 1uL,
	PreferSystemFont = 4uL,
	IncludeDisabled = 0x80uL
}
