using ObjCRuntime;

namespace AppKit;

[Mac(10, 13)]
[Native]
public enum NSColorType : long
{
	ComponentBased,
	Pattern,
	Catalog
}
