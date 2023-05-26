using System;

namespace AudioToolbox;

public class InputCompletedEventArgs : EventArgs
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

	public AudioTimeStamp TimeStamp { get; private set; }

	public AudioStreamPacketDescription[] PacketDescriptions { get; private set; }

	public InputCompletedEventArgs(IntPtr audioQueueBuffer, AudioTimeStamp timeStamp, AudioStreamPacketDescription[] pdec)
	{
		IntPtrBuffer = audioQueueBuffer;
		TimeStamp = timeStamp;
		PacketDescriptions = pdec;
	}
}
