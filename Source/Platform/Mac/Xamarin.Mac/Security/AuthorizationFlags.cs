using System;

namespace Security;

[Flags]
public enum AuthorizationFlags
{
	Defaults = 0,
	InteractionAllowed = 1,
	ExtendRights = 2,
	PartialRights = 4,
	DestroyRights = 8,
	PreAuthorize = 0x10
}
