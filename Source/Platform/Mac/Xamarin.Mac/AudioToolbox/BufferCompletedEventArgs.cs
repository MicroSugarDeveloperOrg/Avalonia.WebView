using System;

namespace AudioToolbox;

public class BufferCompletedEventArgs : EventArgs
{
	public IntPtr IntPtrBuffer { get; private set; }

	public unsafe AudioQueueBuffer* UnsafeBuffer
	{
		get
		{
			return (AudioQueueBuffer*)(void*)IntPtrBuffer;
		}
		set
		{
			IntPtrBuffer = (IntPtr)value;
		}
	}

	public BufferCompletedEventArgs(IntPtr audioQueueBuffer)
	{
		IntPtrBuffer = audioQueueBuffer;
	}

	public unsafe BufferCompletedEventArgs(AudioQueueBuffer* audioQueueBuffer)
	{
		IntPtrBuffer = (IntPtr)audioQueueBuffer;
	}
}
