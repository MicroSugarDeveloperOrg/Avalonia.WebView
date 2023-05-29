using System;

namespace CoreMidi;

public class MidiPacket
{
	public long TimeStamp;

	private IntPtr byteptr;

	private byte[] bytes;

	private int start;

	public ushort Length;

	public unsafe IntPtr Bytes
	{
		get
		{
			if (bytes == null)
			{
				return byteptr;
			}
			fixed (byte* ptr = &bytes[start])
			{
				return (IntPtr)ptr;
			}
		}
	}

	public MidiPacket(long timestamp, ushort length, IntPtr bytes)
	{
		TimeStamp = timestamp;
		Length = length;
		byteptr = bytes;
	}

	public MidiPacket(long timestamp, byte[] bytes)
		: this(timestamp, bytes, 0, bytes.Length, check: false)
	{
	}

	public MidiPacket(long timestamp, byte[] bytes, int start, int len)
		: this(timestamp, bytes, start, len, check: true)
	{
	}

	private MidiPacket(long timestamp, byte[] bytes, int start, int length, bool check)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		if (length > 65535)
		{
			throw new ArgumentException("lenght is bigger than 64k");
		}
		if (check)
		{
			if (start < 0 || start >= bytes.Length)
			{
				throw new ArgumentException("range is not within bytes");
			}
			if (start + length > bytes.Length)
			{
				throw new ArgumentException("range is not within bytes");
			}
		}
		TimeStamp = timestamp;
		Length = (ushort)length;
		this.start = start;
		this.bytes = bytes;
	}
}
