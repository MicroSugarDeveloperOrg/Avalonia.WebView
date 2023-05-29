namespace Foundation;

public struct NSRange
{
	public ulong Location;

	public ulong Length;

	public const ulong NotFound = ulong.MaxValue;

	public NSRange(ulong start, ulong len)
	{
		Location = start;
		Length = len;
	}

	public NSRange(int start, int len)
	{
		Location = (ulong)start;
		Length = (ulong)len;
	}

	public override string ToString()
	{
		return $"[Location={Location},Length={Length}]";
	}
}
