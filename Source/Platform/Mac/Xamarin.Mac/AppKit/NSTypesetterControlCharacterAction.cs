using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSTypesetterControlCharacterAction : ulong
{
	ZeroAdvancement = 1uL,
	Whitespace = 2uL,
	HorizontalTab = 4uL,
	LineBreak = 8uL,
	ParagraphBreak = 0x10uL,
	ContainerBreak = 0x20uL
}
