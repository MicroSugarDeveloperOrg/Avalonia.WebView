namespace WebKit;

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
