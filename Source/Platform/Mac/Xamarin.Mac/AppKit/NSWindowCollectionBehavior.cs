using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSWindowCollectionBehavior : ulong
{
	Default = 0uL,
	CanJoinAllSpaces = 1uL,
	MoveToActiveSpace = 2uL,
	Managed = 4uL,
	Transient = 8uL,
	Stationary = 0x10uL,
	ParticipatesInCycle = 0x20uL,
	IgnoresCycle = 0x40uL,
	FullScreenPrimary = 0x80uL,
	FullScreenAuxiliary = 0x100uL,
	FullScreenNone = 0x200uL,
	[Mac(10, 11)]
	FullScreenAllowsTiling = 0x800uL,
	[Mac(10, 11)]
	FullScreenDisallowsTiling = 0x1000uL
}
