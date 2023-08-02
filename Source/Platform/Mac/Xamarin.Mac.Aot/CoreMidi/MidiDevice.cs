using System;
using System.Runtime.InteropServices;
using Foundation;

namespace CoreMidi;

public class MidiDevice : MidiObject
{
	public int EntityCount => MIDIDeviceGetNumberOfEntities(handle);

	public string Image
	{
		get
		{
			return GetString(MidiObject.kMIDIPropertyImage);
		}
		set
		{
			SetString(MidiObject.kMIDIPropertyImage, value);
		}
	}

	public string DriverDeviceEditorApp
	{
		get
		{
			return GetString(MidiObject.kMIDIPropertyDriverDeviceEditorApp);
		}
		set
		{
			SetString(MidiObject.kMIDIPropertyDriverDeviceEditorApp, value);
		}
	}

	public int SingleRealtimeEntity
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertySingleRealtimeEntity);
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertySingleRealtimeEntity, value);
		}
	}

	public int UniqueID
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyUniqueID);
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyUniqueID, value);
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

	public bool CanRoute
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyCanRoute) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyCanRoute, value ? 1 : 0);
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

	public int DeviceID
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyDeviceID);
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyDeviceID, value);
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

	public bool IsDrumMachine => GetInt(MidiObject.kMIDIPropertyIsDrumMachine) != 0;

	public bool IsEffectUnit => GetInt(MidiObject.kMIDIPropertyIsEffectUnit) != 0;

	public bool IsEmbeddedEntity => GetInt(MidiObject.kMIDIPropertyIsEmbeddedEntity) != 0;

	public bool IsMixer => GetInt(MidiObject.kMIDIPropertyIsMixer) != 0;

	public bool IsSampler => GetInt(MidiObject.kMIDIPropertyIsSampler) != 0;

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

	public int MaxReceiveChannels => GetInt(MidiObject.kMIDIPropertyMaxReceiveChannels);

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

	public int MaxTransmitChannels
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyMaxTransmitChannels);
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyMaxTransmitChannels, value);
		}
	}

	public string Model
	{
		get
		{
			return GetString(MidiObject.kMIDIPropertyModel);
		}
		set
		{
			SetString(MidiObject.kMIDIPropertyModel, value);
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

	public bool PanDisruptsStereo
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyPanDisruptsStereo) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyPanDisruptsStereo, value ? 1 : 0);
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

	public bool ReceivesBankSelectLSB
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyReceivesBankSelectLSB) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyReceivesBankSelectLSB, value ? 1 : 0);
		}
	}

	public bool ReceivesBankSelectMSB
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyReceivesBankSelectMSB) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyReceivesBankSelectMSB, value ? 1 : 0);
		}
	}

	public bool ReceivesClock
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyReceivesClock) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyReceivesClock, value ? 1 : 0);
		}
	}

	public bool ReceivesMTC
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyReceivesMTC) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyReceivesMTC, value ? 1 : 0);
		}
	}

	public bool ReceivesNotes
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyReceivesNotes) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyReceivesNotes, value ? 1 : 0);
		}
	}

	public bool ReceivesProgramChanges
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyReceivesProgramChanges) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyReceivesProgramChanges, value ? 1 : 0);
		}
	}

	public bool SupportsGeneralMidi
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertySupportsGeneralMIDI) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertySupportsGeneralMIDI, value ? 1 : 0);
		}
	}

	public bool SupportsMMC
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertySupportsMMC) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertySupportsMMC, value ? 1 : 0);
		}
	}

	public bool SupportsShowControl
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertySupportsShowControl) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertySupportsShowControl, value ? 1 : 0);
		}
	}

	public bool TransmitsBankSelectLSB
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyTransmitsBankSelectLSB) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyTransmitsBankSelectLSB, value ? 1 : 0);
		}
	}

	public bool TransmitsBankSelectMSB
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyTransmitsBankSelectMSB) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyTransmitsBankSelectMSB, value ? 1 : 0);
		}
	}

	public bool TransmitsClock
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyTransmitsClock) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyTransmitsClock, value ? 1 : 0);
		}
	}

	public bool TransmitsMTC
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyTransmitsMTC) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyTransmitsMTC, value ? 1 : 0);
		}
	}

	public bool TransmitsNotes
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyTransmitsNotes) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyTransmitsNotes, value ? 1 : 0);
		}
	}

	public bool TransmitsProgramChanges
	{
		get
		{
			return GetInt(MidiObject.kMIDIPropertyTransmitsProgramChanges) != 0;
		}
		set
		{
			SetInt(MidiObject.kMIDIPropertyTransmitsProgramChanges, value ? 1 : 0);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIDeviceGetNumberOfEntities(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern IntPtr MIDIDeviceGetEntity(IntPtr handle, int item);

	public MidiEntity GetEntity(int entityIndex)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("handle");
		}
		IntPtr intPtr = MIDIDeviceGetEntity(handle, entityIndex);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new MidiEntity(intPtr);
	}

	internal MidiDevice(IntPtr handle)
		: base(handle)
	{
	}
}
