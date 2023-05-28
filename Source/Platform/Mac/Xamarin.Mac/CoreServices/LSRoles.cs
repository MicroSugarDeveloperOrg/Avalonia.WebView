using System;

namespace CoreServices;

[Flags]
public enum LSRoles : uint
{
	None = 1u,
	Viewer = 2u,
	Editor = 4u,
	Shell = 8u,
	All = uint.MaxValue
}
