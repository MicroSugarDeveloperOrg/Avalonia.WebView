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
	private static extern int MIDIInputPortCreate(int client, IntPtr portName, MidiReadProc readProc, IntPtr context, out int midiPort);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIOutputPortCreate(int client, IntPtr portName, out int midiPort);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIPortDispose(int port);

	internal MidiPort(MidiClient client, string portName, bool input)
	{
		using NSString nSString = new NSString(portName);
		GCHandle value = GCHandle.Alloc(this);
		int num = ((!input) ? MIDIOutputPortCreate(client.handle, nSString.Handle, out handle) : MIDIInputPortCreate(client.handle, nSString.Handle, Read, GCHandle.ToIntPtr(value), out handle));
		if (num != 0)
		{
			value.Free();
			handle = 0;
			throw new MidiException((MidiError)num);
		}
		Client = client;
		PortName = portName;
		this.input = input;
	}

	internal override void DisposeHandle()
	{
		if (handle != 0)
		{
			if (owns)
			{
				MIDIPortDispose(handle);
			}
			handle = 0;
		}
		if (gch.IsAllocated)
		{
			gch.Free();
		}
	}

	protected override void Dispose(bool disposing)
	{
		this.MessageReceived = null;
		base.Dispose(disposing);
	}

	private static void Read(IntPtr packetList, IntPtr context, IntPtr srcPtr)
	{
		MidiPort midiPort = (MidiPort)GCHandle.FromIntPtr(context).Target;
		EventHandler<MidiPacketsEventArgs> messageReceived = midiPort.MessageReceived;
		if (messageReceived != null)
		{
			using (MidiPacketsEventArgs e = new MidiPacketsEventArgs(packetList))
			{
				messageReceived(midiPort, e);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIPortConnectSource(int port, int endpoint, IntPtr context);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIPortDisconnectSource(int port, int endpoint);

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
		return (input ? "[input:" : "[output:") + Client?.ToString() + ":" + PortName + "]";
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDISend(int port, int endpoint, IntPtr packets);

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
		IntPtr intPtr = MidiPacket.CreatePacketList(packets);
		MidiError result = MIDISend(handle, endpoint.handle, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}
}
