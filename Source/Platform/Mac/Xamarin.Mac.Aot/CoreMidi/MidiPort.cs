using System;
using System.Runtime.InteropServices;
using Foundation;

namespace CoreMidi;

public class MidiPort : MidiObject
{
	private GCHandle gch;

	private bool input;

	public MidiClient Client { get; private set; }

	public string PortName { get; private set; }

	public event EventHandler<MidiPacketsEventArgs> MessageReceived;

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIInputPortCreate(IntPtr client, IntPtr portName, MidiReadProc readProc, IntPtr context, out IntPtr midiPort);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIOutputPortCreate(IntPtr client, IntPtr portName, out IntPtr midiPort);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIPortDispose(IntPtr port);

	internal MidiPort(MidiClient client, string portName, bool input)
	{
		using NSString nSString = new NSString(portName);
		GCHandle value = GCHandle.Alloc(this);
		int num = ((!input) ? MIDIOutputPortCreate(client.handle, nSString.Handle, out handle) : MIDIInputPortCreate(client.handle, nSString.Handle, Read, GCHandle.ToIntPtr(value), out handle));
		if (num != 0)
		{
			value.Free();
			handle = IntPtr.Zero;
			throw new MidiException((MidiError)num);
		}
		Client = client;
		PortName = portName;
		this.input = input;
	}

	internal override void DisposeHandle()
	{
		if (handle != IntPtr.Zero)
		{
			if (owns)
			{
				MIDIPortDispose(handle);
			}
			handle = IntPtr.Zero;
			gch.Free();
		}
	}

	internal static MidiPacket[] ToPackets(IntPtr packetList)
	{
		int num = Marshal.ReadInt32(packetList);
		int num2 = 4;
		MidiPacket[] array = new MidiPacket[num];
		for (int i = 0; i < num; i++)
		{
			ushort num3 = (ushort)Marshal.ReadInt16(packetList, num2 + 8);
			array[i] = new MidiPacket(Marshal.ReadInt64(packetList, num2), num3, (IntPtr)((long)packetList + num2 + 10));
			num2 += 10 + num3;
		}
		return array;
	}

	public override void Dispose(bool disposing)
	{
		this.MessageReceived = null;
		base.Dispose(disposing);
	}

	private static void Read(IntPtr packetList, IntPtr context, IntPtr srcPtr)
	{
		MidiPort midiPort = (MidiPort)GCHandle.FromIntPtr(context).Target;
		midiPort.MessageReceived?.Invoke(midiPort, new MidiPacketsEventArgs(packetList));
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIPortConnectSource(IntPtr port, IntPtr endpoint, IntPtr context);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIPortDisconnectSource(IntPtr port, IntPtr endpoint);

	public MidiError ConnectSource(MidiEndpoint endpoint)
	{
		if (endpoint == null)
		{
			throw new ArgumentNullException("endpoint");
		}
		return (MidiError)MIDIPortConnectSource(handle, endpoint.handle, GCHandle.ToIntPtr(gch));
	}

	public MidiError Disconnect(MidiEndpoint endpoint)
	{
		if (endpoint == null)
		{
			throw new ArgumentNullException("endpoint");
		}
		return (MidiError)MIDIPortDisconnectSource(handle, endpoint.handle);
	}

	public override string ToString()
	{
		return string.Concat(input ? "[input:" : "[output:", Client, ":", PortName, "]");
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDISend(IntPtr port, IntPtr endpoint, IntPtr packets);

	public MidiError Send(MidiEndpoint endpoint, MidiPacket[] packets)
	{
		if (endpoint == null)
		{
			throw new ArgumentNullException("endpoint");
		}
		if (packets == null)
		{
			throw new ArgumentNullException("packets");
		}
		IntPtr intPtr = Midi.EncodePackets(packets);
		MidiError result = MIDISend(handle, endpoint.handle, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}
}
