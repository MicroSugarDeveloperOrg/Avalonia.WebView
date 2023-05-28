using ObjCRuntime;

namespace AppKit;

[Mac(10, 11)]
[Native]
public enum NSCollectionUpdateAction : long
{
	Insert,
	Delete,
	Reload,
	Move,
	None
}
