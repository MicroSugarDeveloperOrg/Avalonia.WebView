using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSWindowButton : ulong
{
	CloseButton = 0uL,
	MiniaturizeButton = 1uL,
	ZoomButton = 2uL,
	ToolbarButton = 3uL,
	DocumentIconButton = 4uL,
	DocumentVersionsButton = 6uL,
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "The standard window button for FullScreenButton is always null; use ZoomButton instead.")]
	FullScreenButton = 7uL
}
