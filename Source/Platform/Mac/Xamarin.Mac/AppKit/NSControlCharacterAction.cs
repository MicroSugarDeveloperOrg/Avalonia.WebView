using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Mac(10, 11)]
[Native]
public enum NSControlCharacterAction : long
{
	ZeroAdvancement = 1L,
	Whitespace = 2L,
	HorizontalTab = 4L,
	LineBreak = 8L,
	ParagraphBreak = 0x10L,
	ContainerBreak = 0x20L
}
