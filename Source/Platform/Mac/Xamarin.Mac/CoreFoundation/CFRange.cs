using System;

namespace CoreFoundation;

public struct CFRange
{
	private nint loc;

	private nint len;

	public int Location => (int)loc;

	public int Length => (int)len;

	public long LongLocation => loc;

	public long LongLength => len;

	public CFRange(int loc, int len)
		: this((long)loc, (long)len)
	{
	}

	public CFRange(long l, long len)
	{
		loc = (nint)l;
		this.len = (nint)len;
	}

	public CFRange(nint l, nint len)
	{
		loc = l;
		this.len = len;
	}

	public override string ToString()
	{
		return $"CFRange [Location: {loc} Length: {len}]";
	}
}
