using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSBackgroundStyle : long
{
	Normal = 0L,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Normal' instead.")]
	Light = 0L,
	Emphasized = 1L,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Emphasized' instead.")]
	Dark = 1L,
	Raised = 2L,
	Lowered = 3L
}
