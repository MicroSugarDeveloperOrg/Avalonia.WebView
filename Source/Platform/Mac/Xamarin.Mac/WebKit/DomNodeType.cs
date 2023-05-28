using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public enum DomNodeType : ushort
{
	Element = 1,
	Attribute,
	Text,
	CData,
	EntityReference,
	Entity,
	ProcessingInstruction,
	Comment,
	Document,
	DocumentType,
	DocumentFragment,
	Notation
}
