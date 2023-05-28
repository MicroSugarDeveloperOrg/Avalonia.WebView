using Foundation;
using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSVisualEffectMaterial : long
{
	[Advice("Use a specific material instead.")]
	AppearanceBased = 0L,
	[Advice("Use a semantic material instead.")]
	Light = 1L,
	[Advice("Use a semantic material instead.")]
	Dark = 2L,
	Titlebar = 3L,
	Selection = 4L,
	[Mac(10, 11)]
	Menu = 5L,
	[Mac(10, 11)]
	Popover = 6L,
	[Mac(10, 11)]
	Sidebar = 7L,
	[Mac(10, 11)]
	[Advice("Use a semantic material instead.")]
	MediumLight = 8L,
	[Mac(10, 11)]
	[Advice("Use a semantic material instead.")]
	UltraDark = 9L,
	[Mac(10, 14)]
	HeaderView = 10L,
	[Mac(10, 14)]
	Sheet = 11L,
	[Mac(10, 14)]
	WindowBackground = 12L,
	[Mac(10, 14)]
	HudWindow = 13L,
	[Mac(10, 14)]
	FullScreenUI = 15L,
	[Mac(10, 14)]
	ToolTip = 17L,
	[Mac(10, 14)]
	ContentBackground = 18L,
	[Mac(10, 14)]
	UnderWindowBackground = 21L,
	[Mac(10, 14)]
	UnderPageBackground = 22L
}
