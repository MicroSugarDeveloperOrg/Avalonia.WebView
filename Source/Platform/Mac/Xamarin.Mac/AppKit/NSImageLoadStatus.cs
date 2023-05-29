namespace AppKit;

public enum NSImageLoadStatus : ulong
{
	Completed,
	Cancelled,
	InvalidData,
	UnexpectedEOF,
	ReadError
}
