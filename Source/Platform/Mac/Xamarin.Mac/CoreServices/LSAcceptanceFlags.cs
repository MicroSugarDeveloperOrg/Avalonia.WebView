using System;

namespace CoreServices;

[Flags]
public enum LSAcceptanceFlags : uint
{
	Default = 1u,
	AllowLoginUI = 2u
}
