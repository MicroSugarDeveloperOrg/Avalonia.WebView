using System;

namespace AudioToolbox;

public class PacketReceivedEventArgs : EventArgs
{
	public int Bytes { get; private set; }

	public IntPtr InputData { get; private set; }

	public AudioStreamPacketDescription[] PacketDescriptions { get; private set; }

	public PacketReceivedEventArgs(int numberOfBytes, IntPtr inputData, AudioStreamPacketDescription[] packetDescriptions)
	{
		Bytes = numberOfBytes;
		InputData = inputData;
		PacketDescriptions = packetDescriptions;
	}

	public override string ToString()
	{
		return $"Packet (Bytes={Bytes} InputData={InputData} PacketDescriptions={PacketDescriptions.Length}";
	}
}
