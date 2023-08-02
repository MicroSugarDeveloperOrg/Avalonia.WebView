namespace ImageIO;

public enum CGImageSourceStatus
{
	Complete = 0,
	Incomplete = -1,
	ReadingHeader = -2,
	UnknownType = -3,
	InvalidData = -4,
	UnexpectedEOF = -5
}
