using System.Runtime.InteropServices;
using Foundation;
using Xamarin.Mac.System.Mac;

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

	public bool IsBroadcast
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyIsBroadcast) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyIsBroadcast, value ? 1 : 0);
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
	private static extern int MIDIEndpointDispose(int handle);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDIDestinationCreate(int client, IntPtr name, MidiReadProc readProc, IntPtr context, out int midiEndpoint);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIFlushOutput(int handle);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDIReceived(int handle, IntPtr packetList);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIGetSource(nint sourceIndex);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIGetDestination(nint destinationIndex);

	internal override void DisposeHandle()
	{
		if (handle != 0)
		{
			if (owns)
			{
				MIDIEndpointDispose(handle);
			}
			handle = 0;
		}
		if (gch.IsAllocated)
		{
			gch.Free();
		}
	}

	internal MidiEndpoint(int handle)
		: base(handle, owns: false)
	{
		EndpointName = "Endpoint from Lookup";
	}

	internal MidiEndpoint(int handle, bool owns)
		: base(handle, owns)
	{
		EndpointName = "Endpoint from Lookup";
	}

	internal MidiEndpoint(int handle, string endpointName, bool owns)
		: base(handle, owns)
	{
		EndpointName = endpointName;
	}

	public static MidiEndpoint GetSource(nint sourceIndex)
	{
		int num = MIDIGetSource(sourceIndex);
		if (num == 0)
		{
			return null;
		}
		nint nint = sourceIndex;
		return new MidiEndpoint(num, "Source" + nint.ToString(), owns: false);
	}

	public static MidiEndpoint GetDestination(nint destinationIndex)
	{
		int num = MIDIGetDestination(destinationIndex);
		if (num == 0)
		{
			return null;
		}
		nint nint = destinationIndex;
		return new MidiEndpoint(num, "Destination" + nint.ToString(), owns: false);
	}

	internal MidiEndpoint(MidiClient client, string name, out MidiError code)
	{
		using NSString nSString = new NSString(name);
		GCHandle value = GCHandle.Alloc(this);
		code = MIDIDestinationCreate(client.handle, nSString.Handle, Read, GCHandle.ToIntPtr(value), out handle);
		EndpointName = name;
	}

	protected override void Dispose(bool disposing)
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
		IntPtr intPtr = MidiPacket.CreatePacketList(packets);
		MidiError result = MIDIReceived(handle, intPtr);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIEndpointGetEntity(int endpoint, out int entity);
}
