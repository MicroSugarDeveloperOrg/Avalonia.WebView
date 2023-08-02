using System;
using System.Runtime.InteropServices;

namespace AudioToolbox;

[StructLayout(LayoutKind.Sequential)]
[Obsolete("Use AudioBuffers")]
public class AudioBufferList
{
	internal int bufferCount;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	internal AudioBuffer[] buffers;

	public int BufferCount => bufferCount;

	public AudioBuffer[] Buffers => buffers;

	public AudioBufferList()
	{
	}

	public AudioBufferList(int count)
	{
		bufferCount = count;
		buffers = new AudioBuffer[count];
	}

	public override string ToString()
	{
		if (buffers != null && bufferCount > 0)
		{
			return $"[buffers={buffers[0]},bufferSize={buffers[0].DataByteSize}]";
		}
		return "[empty]";
	}
}
