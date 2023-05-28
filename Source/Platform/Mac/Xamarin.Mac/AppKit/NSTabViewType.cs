using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSTabViewType : ulong
{
	NSTopTabsBezelBorder,
	NSLeftTabsBezelBorder,
	NSBottomTabsBezelBorder,
	NSRightTabsBezelBorder,
	NSNoTabsBezelBorder,
	NSNoTabsLineBorder,
	NSNoTabsNoBorder
}
