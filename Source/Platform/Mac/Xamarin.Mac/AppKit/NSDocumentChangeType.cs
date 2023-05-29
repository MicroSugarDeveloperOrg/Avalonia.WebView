namespace AppKit;

public enum NSDocumentChangeType : ulong
{
	Done = 0uL,
	Undone = 1uL,
	Cleared = 2uL,
	ReadOtherContents = 3uL,
	Autosaved = 4uL,
	Redone = 5uL,
	Discardable = 256uL
}
