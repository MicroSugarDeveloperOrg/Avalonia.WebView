using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSImageCacheMode : ulong
{
	Default,
	Always,
	BySize,
	Never
}
