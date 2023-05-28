using System;
using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
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
