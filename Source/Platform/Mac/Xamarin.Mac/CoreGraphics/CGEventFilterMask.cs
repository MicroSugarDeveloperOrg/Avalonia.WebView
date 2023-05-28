using System;

namespace CoreGraphics;

[Flags]
public enum CGEventFilterMask : uint
{
	PermitLocalMouseEvents = 1u,
	PermitLocalKeyboardEvents = 2u,
	PermitSystemDefinedEvents = 4u
}
