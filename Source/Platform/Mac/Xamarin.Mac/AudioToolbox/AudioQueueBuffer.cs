using System;

namespace AudioToolbox;

public struct AudioQueueBuffer
{
	public uint AudioDataBytesCapacity;

	public IntPtr AudioData;

	public uint AudioDataByteSize;

	public IntPtr UserData;

	public uint PacketDescriptionCapacity;

	public IntPtr IntPtrPacketDescriptions;

	public int PacketDescriptionCount;

	public AudioStreamPacketDescription[] PacketDescriptions => AudioFile.PacketDescriptionFrom(PacketDescriptionCount, IntPtrPacketDescriptions);

	public unsafe void CopyToAudioData(IntPtr source, int size)
	{
		byte* target = (byte*)(void*)AudioData;
		byte* source2 = (byte*)(void*)source;
		AudioQueue.memcpy(target, source2, size);
	}
}
