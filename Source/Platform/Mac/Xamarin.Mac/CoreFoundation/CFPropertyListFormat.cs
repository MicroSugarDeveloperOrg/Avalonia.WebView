using ObjCRuntime;

namespace CoreFoundation;

[Native]
public enum CFPropertyListFormat : long
{
	OpenStep = 1L,
	XmlFormat1 = 100L,
	BinaryFormat1 = 200L
}
