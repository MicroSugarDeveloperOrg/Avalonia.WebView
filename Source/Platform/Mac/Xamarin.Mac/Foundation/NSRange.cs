using System;

namespace Foundation;

public struct NSRange
{
	public nint Location;

	public nint Length;

	public static readonly nint NotFound = nint.MaxValue;

	public NSRange(nint start, nint len)
	{
		Location = start;
		Length = len;
	}

	public override string ToString()
	{
		return $"[Location={Location},Length={Length}]";
	}
}
