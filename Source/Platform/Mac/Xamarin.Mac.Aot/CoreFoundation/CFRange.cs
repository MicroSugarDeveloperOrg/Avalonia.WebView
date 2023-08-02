using System;

namespace CoreFoundation;

public struct CFRange
{
	private IntPtr loc;

	private IntPtr len;

	public int Location => loc.ToInt32();

	public int Length => len.ToInt32();

	public long LongLocation => loc.ToInt64();

	public long LongLength => len.ToInt64();

	public CFRange(int loc, int len)
		: this((long)loc, (long)len)
	{
	}

	public CFRange(long l, long len)
	{
		loc = new IntPtr(l);
		this.len = new IntPtr(len);
	}

	public override string ToString()
	{
		return $"CFRange [Location: {loc} Length: {len}]";
	}
}
