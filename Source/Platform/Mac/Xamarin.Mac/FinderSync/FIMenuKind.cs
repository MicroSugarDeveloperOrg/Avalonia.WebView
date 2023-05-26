using ObjCRuntime;

namespace FinderSync;

[Native]
public enum FIMenuKind : ulong
{
	ContextualMenuForItems,
	ContextualMenuForContainer,
	ContextualMenuForSidebar,
	ToolbarItemMenu
}
