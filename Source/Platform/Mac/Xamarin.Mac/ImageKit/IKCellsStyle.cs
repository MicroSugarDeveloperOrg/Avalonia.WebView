using System;
using ObjCRuntime;

namespace ImageKit;

[Flags]
[Native]
public enum IKCellsStyle : ulong
{
	None = 0uL,
	Shadowed = 1uL,
	Outlined = 2uL,
	Titled = 4uL,
	Subtitled = 8uL
}
