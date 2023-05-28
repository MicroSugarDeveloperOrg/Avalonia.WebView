using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
[Obsolete("Use NSFileWrapperReadingOptions in Foundation instead.")]
public enum NSFileWrapperReadingOptions : ulong
{
	Immediate = 1uL,
	WithoutMapping = 2uL
}
