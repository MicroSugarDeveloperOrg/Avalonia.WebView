namespace CoreFoundation;

public enum CFStreamStatus
{
	NotOpen,
	Opening,
	Open,
	Reading,
	Writing,
	AtEnd,
	Closed,
	Error
}
