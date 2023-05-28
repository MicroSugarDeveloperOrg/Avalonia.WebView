using System;

namespace CoreMidi;

public struct MidiValueMap
{
	private byte[] map_value;

	public byte[] Value
	{
		get
		{
			return map_value ?? (map_value = new byte[128]);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length != 128)
			{
				throw new ArgumentOutOfRangeException("value", "The length of the Value array must be 128");
			}
			map_value = value;
		}
	}
}
