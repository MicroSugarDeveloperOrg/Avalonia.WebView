using System;

namespace AudioToolbox;

public abstract class _MidiData
{
	protected int len;

	protected int start;

	protected byte[] data;

	protected IntPtr buffer;

	public void SetData(byte[] Data)
	{
		len = Data.Length;
		start = 0;
		data = Data;
		buffer = IntPtr.Zero;
	}

	public void SetData(int len, int start, byte[] Data)
	{
		if (len + start > Data.Length)
		{
			throw new ArgumentException("len+start go beyond the end of Data");
		}
		if (len < 0 || start < 0)
		{
			throw new ArgumentException("len||start are negative");
		}
		this.len = len;
		this.start = start;
		data = Data;
		buffer = IntPtr.Zero;
	}

	public void SetData(int len, IntPtr buffer)
	{
		this.len = len;
		this.buffer = buffer;
		data = null;
	}

	internal abstract IntPtr ToUnmanaged();
}
