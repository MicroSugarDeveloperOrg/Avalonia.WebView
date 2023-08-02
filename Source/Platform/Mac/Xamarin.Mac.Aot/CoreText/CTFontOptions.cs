using System;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
[Flags]
public enum CTFontOptions
{
	Default = 0,
	PreventAutoActivation = 1,
	PreferSystemFont = 4,
	IncludeDisabled = 0x80
}
