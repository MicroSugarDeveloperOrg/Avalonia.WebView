using System;

namespace CoreMedia;

public struct CMTimeScale
{
	public static readonly CMTimeScale MaxValue = new CMTimeScale(int.MaxValue);

	public int Value;

	public CMTimeScale(int value)
	{
		if (value < 0 || value > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		Value = value;
	}
}
