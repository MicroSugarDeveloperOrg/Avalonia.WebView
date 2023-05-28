using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreMidi;

public class MidiPacket : IDisposable
{
	public long TimeStamp;

	private IntPtr byteptr;

	private byte[] bytes;

	private int start;

	public ushort Length;

	internal byte[] ByteArray => bytes;

	internal IntPtr BytePointer => byteptr;

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
			throw new ArgumentException("length is bigger than 64k");
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

	~MidiPacket()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		byteptr = IntPtr.Zero;
	}

	internal static int GetPacketLength(int payload_length)
	{
		return 10 + payload_length;
	}

	internal static MidiPacket ReadPacket(IntPtr ptr, out int length)
	{
		long timestamp = Marshal.ReadInt64(ptr);
		ushort num = (ushort)Marshal.ReadInt16(ptr, 8);
		length = GetPacketLength(num);
		return new MidiPacket(timestamp, num, ptr + 10);
	}

	internal static MidiPacket[] ReadPacketList(IntPtr packetList)
	{
		int num = Marshal.ReadInt32(packetList);
		MidiPacket[] array = new MidiPacket[num];
		packetList += 4;
		for (int i = 0; i < num; i++)
		{
			array[i] = ReadPacket(packetList, out var length);
			packetList += length;
		}
		return array;
	}

	internal static IntPtr CreatePacketList(MidiPacket[] packets)
	{
		int num = 4;
		for (int i = 0; i < packets.Length; i++)
		{
			num += GetPacketLength(packets[i].Length);
		}
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.WriteInt32(intPtr, 0, packets.Length);
		int num2 = 4;
		for (int j = 0; j < packets.Length; j++)
		{
			Marshal.WriteInt64(intPtr, num2, packets[j].TimeStamp);
			num2 += 8;
			Marshal.WriteInt16(intPtr, num2, (short)packets[j].Length);
			num2 += 2;
			if (packets[j].ByteArray == null)
			{
				Runtime.memcpy(intPtr + num2, packets[j].BytePointer, packets[j].Length);
			}
			else
			{
				Marshal.Copy(packets[j].ByteArray, packets[j].start, intPtr + num2, packets[j].Length);
			}
			num2 += GetPacketLength(packets[j].Length) - 10;
		}
		return intPtr;
	}
}
