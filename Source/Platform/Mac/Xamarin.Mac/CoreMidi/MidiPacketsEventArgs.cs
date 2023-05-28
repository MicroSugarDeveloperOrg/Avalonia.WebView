using System;

namespace CoreMidi;

public class MidiPacketsEventArgs : EventArgs, IDisposable
{
	private IntPtr packetList;

	private MidiPacket[] list;

	public IntPtr PacketListRaw => packetList;

	public MidiPacket[] Packets
	{
		get
		{
			if (list == null)
			{
				list = MidiPacket.ReadPacketList(packetList);
			}
			return list;
		}
	}

	internal MidiPacketsEventArgs(IntPtr packetList)
	{
		this.packetList = packetList;
	}

	~MidiPacketsEventArgs()
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
		if (list != null)
		{
			MidiPacket[] array = list;
			foreach (MidiPacket midiPacket in array)
			{
				midiPacket.Dispose();
			}
		}
	}
}
