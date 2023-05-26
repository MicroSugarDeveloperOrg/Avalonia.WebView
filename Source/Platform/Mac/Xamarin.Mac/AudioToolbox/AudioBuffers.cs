using System;
using System.Runtime.InteropServices;

namespace AudioToolbox;

public class AudioBuffers : IDisposable
{
	private IntPtr address;

	private readonly bool owns;

	public unsafe int Count => *(int*)(void*)address;

	public unsafe AudioBuffer this[int index]
	{
		get
		{
			if (index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			byte* ptr = (byte*)(void*)address;
			return *(AudioBuffer*)(ptr + 4 + index * sizeof(AudioBuffer));
		}
		set
		{
			if (index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			byte* ptr = (byte*)(void*)address;
			AudioBuffer* ptr2 = (AudioBuffer*)(ptr + 4 + index * sizeof(AudioBuffer));
			*ptr2 = value;
		}
	}

	public AudioBuffers(IntPtr address)
		: this(address, owns: false)
	{
	}

	public AudioBuffers(IntPtr address, bool owns)
	{
		if (address == IntPtr.Zero)
		{
			throw new ArgumentException("address");
		}
		this.address = address;
		this.owns = owns;
	}

	public unsafe AudioBuffers(int count)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		int cb = 4 + count * sizeof(AudioBuffer);
		address = Marshal.AllocHGlobal(cb);
		owns = true;
		Marshal.WriteInt32(address, 0, count);
		AudioBuffer* ptr = (AudioBuffer*)((byte*)(void*)address + 4);
		for (int i = 0; i < count; i++)
		{
			ptr->NumberChannels = 0;
			ptr->DataByteSize = 0;
			ptr->Data = IntPtr.Zero;
			ptr++;
		}
	}

	~AudioBuffers()
	{
		Dispose(disposing: false);
		GC.SuppressFinalize(this);
	}

	public static explicit operator IntPtr(AudioBuffers audioBuffers)
	{
		return audioBuffers.address;
	}

	public unsafe void SetData(int index, IntPtr data)
	{
		if (index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		byte* ptr = (byte*)(void*)address;
		IntPtr* ptr2 = (IntPtr*)(ptr + 4 + index * sizeof(AudioBuffer) + 4 + 4);
		*ptr2 = data;
	}

	public unsafe void SetData(int index, IntPtr data, int dataByteSize)
	{
		if (index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		byte* ptr = (byte*)(void*)address;
		int* ptr2 = (int*)(ptr + 4 + index * sizeof(AudioBuffer) + 4);
		*ptr2 = dataByteSize;
		ptr2++;
		IntPtr* ptr3 = (IntPtr*)ptr2;
		*ptr3 = data;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (owns && address != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(address);
			address = IntPtr.Zero;
		}
	}
}
