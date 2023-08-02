using System;

namespace AudioToolbox;

public class OutputCompletedEventArgs : EventArgs
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

	public OutputCompletedEventArgs(IntPtr audioQueueBuffer)
	{
		IntPtrBuffer = audioQueueBuffer;
	}

	public unsafe OutputCompletedEventArgs(AudioQueueBuffer* audioQueueBuffer)
	{
		IntPtrBuffer = (IntPtr)audioQueueBuffer;
	}
}
