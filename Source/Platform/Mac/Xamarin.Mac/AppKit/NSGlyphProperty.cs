using ObjCRuntime;

namespace AppKit;

[Mac(10, 11)]
[Native]
public enum NSGlyphProperty : long
{
	Null = 1L,
	ControlCharacter = 2L,
	Elastic = 4L,
	NonBaseCharacter = 8L
}
