using System;
using System.Runtime.InteropServices;
using Foundation;

namespace CoreMidi;

public class MidiEndpoint : MidiObject
{
	private GCHandle gch;

	public string EndpointName { get; private set; }

	public MidiEntity Entity
	{
		get
		{
			if (MIDIEndpointGetEntity(handle, out var entity) == 0)
			{
				return new MidiEntity(entity);
			}
			return null;
		}
	}

	public bool IsNetworkSession
	{
		get
		{
			using NSDictionary nSDictionary = GetDictionaryProperties(deep: true);
			if (nSDictionary == null)
			{
				return false;
			}
			using NSString key = new NSString("apple.midirtp.session");
			return nSDictionary.ContainsKey(key);
		}
	}

	public int AdvanceScheduleTimeMuSec
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyAdvanceScheduleTimeMuSec);
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyAdvanceScheduleTimeMuSec, value);
		}
	}

	public int ConnectionUniqueIDInt
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyConnectionUniqueID);
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyConnectionUniqueID, value);
		}
	}

	public NSData ConnectionUniqueIDData
	{
		get
		{
			return GetData(MidiObject.kMIDIPropertyConnectionUniqueID);
		}
		set
		{
			SetData(MidiObject.kMIDIPropertyConnectionUniqueID, value);
		}
	}

	public string DisplayName
	{
		get
		{
			return GetString(MidiObject.kMIDIPropertyDisplayName);
		}
		set
		{
			SetString(MidiObject.kMIDIPropertyDisplayName, value);
		}
	}

	public string DriverOwner
	{
		get
		{
			return GetString(MidiObject.kMIDIPropertyDriverOwner);
		}
		set
		{
			SetString(MidiObject.kMIDIPropertyDriverOwner, value);
		}
	}

	public int DriverVersion
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyDriverVersion);
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyDriverVersion, value);
		}
	}

	public int IsBroadcast
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyIsBroadcast);
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyIsBroadcast, value);
		}
	}

	public string Manufacturer
	{
		get
		{
			return GetString(MidiObject.kMIDIPropertyManufacturer);
		}
		set
		{
			SetString(MidiObject.kMIDIPropertyManufacturer, value);
		}
	}

	public int MaxSysExSpeed
	{
		get
		{
			try
			{
				return GetInt(MidiObject.kMIDIPropertyMaxSysExSpeed);
			}
			catch
			{
				return 3125;
			}
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyMaxSysExSpeed, value);
		}
	}

	public string Name
	{
		get
		{
			return GetString(MidiObject.kMIDIPropertyName);
		}
		set
		{
			SetString(MidiObject.kMIDIPropertyName, value);
		}
	}

	public NSDictionary NameConfiguration
	{
		get
		{
			return GetDictionary(MidiObject.kMIDIPropertyNameConfiguration);
		}
		set
		{
			SetDictionary(MidiObject.kMIDIPropertyNameConfiguration, value);
		}
	}

	public bool Offline
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyOffline) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyOffline, value ? 1 : 0);
		}
	}

	public bool Private
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyPrivate) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyPrivate, value ? 1 : 0);
		}
	}

	public int ReceiveChannels
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyReceiveChannels);
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyReceiveChannels, value);
		}
	}

	public int TransmitChannels
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyTransmitChannels);
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyTransmitChannels, value);
		}
	}

	public event EventHandler<MidiPacketsEventArgs> MessageReceived;

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIEndpointDispose(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIDestinationCreate(IntPtr client, IntPtr name, MidiReadProc readProc, IntPtr context, out IntPtr midiEndpoint);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIFlushOutput(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDIReceived(IntPtr handle, IntPtr packetList);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern IntPtr MIDIGetSource(int sourceIndex);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern IntPtr MIDIGetDestination(int destinationIndex);

	internal override void DisposeHandle()
	{
		if (handle != IntPtr.Zero)
		{
			if (owns)
			{
				MIDIEndpointDispose(handle);
			}
			handle = IntPtr.Zero;
			gch.Free();
		}
	}

	internal MidiEndpoint(IntPtr handle)
		: base(handle, owns: false)
	{
		EndpointName = "Endpoint from Lookup";
	}

	internal MidiEndpoint(IntPtr handle, bool owns)
		: base(handle, owns)
	{
		EndpointName = "Endpoint from Lookup";
	}

	internal MidiEndpoint(IntPtr handle, string endpointName, bool owns)
		: base(handle, owns)
	{
		EndpointName = endpointName;
	}

	public static MidiEndpoint GetSource(int sourceIndex)
	{
		IntPtr intPtr = MIDIGetSource(sourceIndex);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new MidiEndpoint(intPtr, "Source" + sourceIndex, owns: false);
	}

	public static MidiEndpoint GetDestination(int destinationIndex)
	{
		IntPtr intPtr = MIDIGetDestination(destinationIndex);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new MidiEndpoint(intPtr, "Destination" + destinationIndex, owns: false);
	}

	internal MidiEndpoint(MidiClient client, string name)
	{
		using NSString nSString = new NSString(name);
		GCHandle value = GCHandle.Alloc(this);
		int num = MIDIDestinationCreate(client.handle, nSString.Handle, Read, GCHandle.ToIntPtr(value), out handle);
		if (num != 0)
		{
			value.Free();
			handle = IntPtr.Zero;
			throw new MidiException((MidiError)num);
		}
		EndpointName = name;
	}

	public override void Dispose(bool disposing)
	{
		this.MessageReceived = null;
		base.Dispose(disposing);
	}

	private static void Read(IntPtr packetList, IntPtr context, IntPtr srcPtr)
	{
		MidiEndpoint midiEndpoint = (MidiEndpoint)GCHandle.FromIntPtr(context).Target;
		midiEndpoint.MessageReceived?.Invoke(midiEndpoint, new MidiPacketsEventArgs(packetList));
	}

	public void FlushOutput()
	{
		MIDIFlushOutput(handle);
	}

	public MidiError Received(MidiPacket[] packets)
	{
		if (packets == null)
		{
			throw new ArgumentNullException("packets");
		}
		IntPtr intPtr = Midi.EncodePackets(packets);
		MidiError result = MIDIReceived(handle, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIEndpointGetEntity(IntPtr endpoint, out IntPtr entity);
}
