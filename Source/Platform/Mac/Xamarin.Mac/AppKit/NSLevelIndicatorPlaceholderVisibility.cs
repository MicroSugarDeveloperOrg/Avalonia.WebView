using ObjCRuntime;

namespace AppKit;

[Mac(10, 13)]
[Native]
public enum NSLevelIndicatorPlaceholderVisibility : long
{
	Automatic,
	Always,
	WhileEditing
}
