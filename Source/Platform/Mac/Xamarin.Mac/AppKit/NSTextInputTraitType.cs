using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum NSTextInputTraitType : long
{
	Default,
	No,
	Yes
}
