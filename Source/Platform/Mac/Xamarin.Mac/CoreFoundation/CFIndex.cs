using System;

namespace CoreFoundation;

public struct CFIndex
{
	private IntPtr value;

	private CFIndex(IntPtr value)
	{
		this.value = value;
	}

	public static implicit operator int(CFIndex index)
	{
		return index.value.ToInt32();
	}

	public static implicit operator CFIndex(int value)
	{
		return new CFIndex(new IntPtr(value));
	}

	public static implicit operator long(CFIndex index)
	{
		return index.value.ToInt64();
	}
}
