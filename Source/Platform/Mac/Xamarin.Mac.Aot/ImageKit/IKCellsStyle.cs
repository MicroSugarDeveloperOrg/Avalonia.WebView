using System;

namespace ImageKit;

[Flags]
public enum IKCellsStyle : uint
{
	None = 0u,
	Shadowed = 1u,
	Outlined = 2u,
	Titled = 4u,
	Subtitled = 8u
}
