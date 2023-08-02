using System;

namespace CoreMidi;

public class MidiPacketsEventArgs : EventArgs
{
	private IntPtr packetList;

	public IntPtr PacketListRaw => packetList;

	public MidiPacket[] Packets => MidiPort.ToPackets(packetList);

	internal MidiPacketsEventArgs(IntPtr packetList)
	{
		this.packetList = packetList;
	}
}
