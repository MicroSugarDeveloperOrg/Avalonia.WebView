using System;
using ObjCRuntime;

namespace Foundation;

[iOS(7, 0)]
[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'NSWritingDirectionFormatType'.")]
[Flags]
[Native]
public enum NSTextWritingDirection : long
{
	Embedding = 0L,
	Override = 2L
}
