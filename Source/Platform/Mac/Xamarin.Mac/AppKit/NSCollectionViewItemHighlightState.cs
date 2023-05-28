using ObjCRuntime;

namespace AppKit;

[Mac(10, 11)]
[Native]
public enum NSCollectionViewItemHighlightState : long
{
	None,
	ForSelection,
	ForDeselection,
	AsDropTarget
}
