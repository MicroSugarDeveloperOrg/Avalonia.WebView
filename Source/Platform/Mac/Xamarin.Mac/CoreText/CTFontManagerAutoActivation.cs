using ObjCRuntime;

namespace CoreText;

public enum CTFontManagerAutoActivation : uint
{
	Default,
	Disabled,
	Enabled,
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "It's now treated as 'Default'.")]
	PromptUser
}
