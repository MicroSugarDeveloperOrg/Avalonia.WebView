using System;

namespace WebKit;

[Flags]
public enum DomDocumentPosition : ushort
{
	Disconnected = 1,
	Preceeding = 2,
	Following = 4,
	Contains = 8,
	ContainedBy = 0x10,
	ImplementationSpecific = 0x20
}
