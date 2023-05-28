using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSNetServiceOptions : ulong
{
	NoAutoRename = 1uL,
	ListenForConnections = 2uL
}
