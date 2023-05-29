using System;
using System.Runtime.InteropServices;

namespace AudioToolbox;

[Obsolete("Use AudioBuffers")]
public class MutableAudioBufferList : AudioBufferList, IDisposable
{
	public MutableAudioBufferList(int nubuffers, int bufferSize)
		: base(nubuffers)
	{
		for (int i = 0; i < bufferCount; i++)
		{
			buffers[i].NumberChannels = 1;
			buffers[i].DataByteSize = bufferSize;
			buffers[i].Data = Marshal.AllocHGlobal(bufferSize);
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public virtual void Dispose(bool disposing)
	{
		if (buffers != null)
		{
			AudioBuffer[] array = buffers;
			for (int i = 0; i < array.Length; i++)
			{
				Marshal.FreeHGlobal(array[i].Data);
			}
			buffers = null;
		}
	}

	~MutableAudioBufferList()
	{
		Dispose(disposing: false);
	}
}
