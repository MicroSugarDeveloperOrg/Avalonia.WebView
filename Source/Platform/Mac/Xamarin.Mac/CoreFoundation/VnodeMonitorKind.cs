using System;

namespace CoreFoundation;

[Flags]
public enum VnodeMonitorKind : uint
{
	Delete = 1u,
	Write = 2u,
	Extend = 4u,
	Attrib = 8u,
	Link = 0x10u,
	Rename = 0x20u,
	Revoke = 0x40u
}
