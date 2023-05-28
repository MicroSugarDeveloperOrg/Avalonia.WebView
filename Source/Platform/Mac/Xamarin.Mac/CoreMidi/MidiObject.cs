using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreMidi;

public class MidiObject : IDisposable
{
	internal const int InvalidRef = 0;

	internal int handle;

	internal bool owns;

	internal static IntPtr kMIDIPropertyAdvanceScheduleTimeMuSec;

	internal static IntPtr kMIDIPropertyCanRoute;

	internal static IntPtr kMIDIPropertyConnectionUniqueID;

	internal static IntPtr kMIDIPropertyDeviceID;

	internal static IntPtr kMIDIPropertyDisplayName;

	internal static IntPtr kMIDIPropertyDriverDeviceEditorApp;

	internal static IntPtr kMIDIPropertyDriverOwner;

	internal static IntPtr kMIDIPropertyDriverVersion;

	internal static IntPtr kMIDIPropertyImage;

	internal static IntPtr kMIDIPropertyIsBroadcast;

	internal static IntPtr kMIDIPropertyIsDrumMachine;

	internal static IntPtr kMIDIPropertyIsEffectUnit;

	internal static IntPtr kMIDIPropertyIsEmbeddedEntity;

	internal static IntPtr kMIDIPropertyIsMixer;

	internal static IntPtr kMIDIPropertyIsSampler;

	internal static IntPtr kMIDIPropertyManufacturer;

	internal static IntPtr kMIDIPropertyMaxReceiveChannels;

	internal static IntPtr kMIDIPropertyMaxSysExSpeed;

	internal static IntPtr kMIDIPropertyMaxTransmitChannels;

	internal static IntPtr kMIDIPropertyModel;

	internal static IntPtr kMIDIPropertyName;

	internal static IntPtr kMIDIPropertyNameConfiguration;

	internal static IntPtr kMIDIPropertyOffline;

	internal static IntPtr kMIDIPropertyPanDisruptsStereo;

	internal static IntPtr kMIDIPropertyPrivate;

	internal static IntPtr kMIDIPropertyReceiveChannels;

	internal static IntPtr kMIDIPropertyReceivesBankSelectLSB;

	internal static IntPtr kMIDIPropertyReceivesBankSelectMSB;

	internal static IntPtr kMIDIPropertyReceivesClock;

	internal static IntPtr kMIDIPropertyReceivesMTC;

	internal static IntPtr kMIDIPropertyReceivesNotes;

	internal static IntPtr kMIDIPropertyReceivesProgramChanges;

	internal static IntPtr kMIDIPropertySingleRealtimeEntity;

	internal static IntPtr kMIDIPropertySupportsGeneralMIDI;

	internal static IntPtr kMIDIPropertySupportsMMC;

	internal static IntPtr kMIDIPropertySupportsShowControl;

	internal static IntPtr kMIDIPropertyTransmitChannels;

	internal static IntPtr kMIDIPropertyTransmitsBankSelectLSB;

	internal static IntPtr kMIDIPropertyTransmitsBankSelectMSB;

	internal static IntPtr kMIDIPropertyTransmitsClock;

	internal static IntPtr kMIDIPropertyTransmitsMTC;

	internal static IntPtr kMIDIPropertyTransmitsNotes;

	internal static IntPtr kMIDIPropertyTransmitsProgramChanges;

	internal static IntPtr kMIDIPropertyUniqueID;

	internal static IntPtr kMIDIDriverPropertyUsesSerial;

	internal static IntPtr kMIDIPropertyFactoryPatchNameFile;

	internal static IntPtr kMIDIPropertyUserPatchNameFile;

	internal static IntPtr kMIDIPropertyNameConfigurationDictionary;

	public int Handle => handle;

	internal int MidiHandle => handle;

	static MidiObject()
	{
		IntPtr intPtr = Libraries.CoreMidi.Handle;
		kMIDIPropertyAdvanceScheduleTimeMuSec = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyAdvanceScheduleTimeMuSec");
		kMIDIPropertyCanRoute = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyCanRoute");
		kMIDIPropertyConnectionUniqueID = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyConnectionUniqueID");
		kMIDIPropertyDeviceID = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyDeviceID");
		kMIDIPropertyDisplayName = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyDisplayName");
		kMIDIPropertyDriverDeviceEditorApp = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyDriverDeviceEditorApp");
		kMIDIPropertyDriverOwner = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyDriverOwner");
		kMIDIPropertyDriverVersion = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyDriverVersion");
		kMIDIPropertyImage = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyImage");
		kMIDIPropertyIsBroadcast = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyIsBroadcast");
		kMIDIPropertyIsDrumMachine = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyIsDrumMachine");
		kMIDIPropertyIsEffectUnit = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyIsEffectUnit");
		kMIDIPropertyIsEmbeddedEntity = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyIsEmbeddedEntity");
		kMIDIPropertyIsMixer = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyIsMixer");
		kMIDIPropertyIsSampler = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyIsSampler");
		kMIDIPropertyManufacturer = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyManufacturer");
		kMIDIPropertyMaxReceiveChannels = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyMaxReceiveChannels");
		kMIDIPropertyMaxSysExSpeed = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyMaxSysExSpeed");
		kMIDIPropertyMaxTransmitChannels = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyMaxTransmitChannels");
		kMIDIPropertyModel = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyModel");
		kMIDIPropertyName = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyName");
		kMIDIPropertyNameConfiguration = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyNameConfiguration");
		kMIDIPropertyOffline = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyOffline");
		kMIDIPropertyPanDisruptsStereo = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyPanDisruptsStereo");
		kMIDIPropertyPrivate = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyPrivate");
		kMIDIPropertyReceiveChannels = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyReceiveChannels");
		kMIDIPropertyReceivesBankSelectLSB = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyReceivesBankSelectLSB");
		kMIDIPropertyReceivesBankSelectMSB = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyReceivesBankSelectMSB");
		kMIDIPropertyReceivesClock = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyReceivesClock");
		kMIDIPropertyReceivesMTC = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyReceivesMTC");
		kMIDIPropertyReceivesNotes = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyReceivesNotes");
		kMIDIPropertyReceivesProgramChanges = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyReceivesProgramChanges");
		kMIDIPropertySingleRealtimeEntity = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertySingleRealtimeEntity");
		kMIDIPropertySupportsGeneralMIDI = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertySupportsGeneralMIDI");
		kMIDIPropertySupportsMMC = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertySupportsMMC");
		kMIDIPropertySupportsShowControl = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertySupportsShowControl");
		kMIDIPropertyTransmitChannels = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyTransmitChannels");
		kMIDIPropertyTransmitsBankSelectLSB = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyTransmitsBankSelectLSB");
		kMIDIPropertyTransmitsBankSelectMSB = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyTransmitsBankSelectMSB");
		kMIDIPropertyTransmitsClock = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyTransmitsClock");
		kMIDIPropertyTransmitsMTC = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyTransmitsMTC");
		kMIDIPropertyTransmitsNotes = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyTransmitsNotes");
		kMIDIPropertyTransmitsProgramChanges = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyTransmitsProgramChanges");
		kMIDIPropertyUniqueID = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyUniqueID");
		kMIDIDriverPropertyUsesSerial = Dlfcn.GetIntPtr(intPtr, "kMIDIDriverPropertyUsesSerial");
		kMIDIPropertyFactoryPatchNameFile = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyFactoryPatchNameFile");
		kMIDIPropertyUserPatchNameFile = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyUserPatchNameFile");
		kMIDIPropertyNameConfigurationDictionary = Dlfcn.GetIntPtr(intPtr, "kMIDIPropertyNameConfigurationDictionary");
	}

	internal MidiObject()
	{
		owns = true;
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectGetIntegerProperty(int obj, IntPtr str, out int ret);

	internal int GetInt(IntPtr property)
	{
		int ret;
		int num = MIDIObjectGetIntegerProperty(handle, property, out ret);
		if (num == 0)
		{
			return ret;
		}
		throw new MidiException((MidiError)num);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectSetIntegerProperty(int obj, IntPtr str, int val);

	internal void SetInt(IntPtr property, int value)
	{
		MIDIObjectSetIntegerProperty(handle, property, value);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectGetDictionaryProperty(int obj, IntPtr str, out IntPtr dict);

	internal NSDictionary GetDictionary(IntPtr property)
	{
		IntPtr dict;
		int num = MIDIObjectGetDictionaryProperty(handle, property, out dict);
		if (num == 0)
		{
			NSDictionary result = (NSDictionary)Runtime.GetNSObject(dict);
			if (dict != IntPtr.Zero)
			{
				CFObject.CFRelease(dict);
			}
			return result;
		}
		throw new MidiException((MidiError)num);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectSetDictionaryProperty(int obj, IntPtr str, IntPtr dict);

	internal void SetDictionary(IntPtr property, NSDictionary dict)
	{
		MIDIObjectSetDictionaryProperty(handle, property, dict.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectGetDataProperty(int obj, IntPtr str, out IntPtr data);

	public NSData GetData(IntPtr property)
	{
		IntPtr data;
		int num = MIDIObjectGetDataProperty(handle, property, out data);
		if (num == 0)
		{
			NSData result = (NSData)Runtime.GetNSObject(data);
			if (data != IntPtr.Zero)
			{
				CFObject.CFRelease(data);
			}
			return result;
		}
		throw new MidiException((MidiError)num);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectSetDataProperty(int obj, IntPtr str, IntPtr data);

	public void SetData(IntPtr property, NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		MIDIObjectSetDataProperty(handle, property, data.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectGetStringProperty(int obj, IntPtr str, out IntPtr data);

	public string GetString(IntPtr property)
	{
		if (MIDIObjectGetStringProperty(handle, property, out var data) == 0)
		{
			string result = NSString.FromHandle(data);
			if (data != IntPtr.Zero)
			{
				CFObject.CFRelease(data);
			}
			return result;
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectSetStringProperty(int obj, IntPtr str, IntPtr nstr);

	public void SetString(IntPtr property, string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		using NSString nSString = new NSString(value);
		MIDIObjectSetDictionaryProperty(handle, property, nSString.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDIObjectRemoveProperty(int obj, IntPtr str);

	public MidiError RemoveProperty(string property)
	{
		using NSString nSString = new NSString(property);
		return MIDIObjectRemoveProperty(handle, nSString.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectGetProperties(int obj, out IntPtr dict, [MarshalAs(UnmanagedType.U1)] bool deep);

	public NSDictionary GetDictionaryProperties(bool deep)
	{
		if (MIDIObjectGetProperties(handle, out var dict, deep) != 0 || dict == IntPtr.Zero)
		{
			return null;
		}
		NSDictionary result = (NSDictionary)Runtime.GetNSObject(dict);
		CFObject.CFRelease(dict);
		return result;
	}

	public MidiObject(int handle)
		: this(handle, owns: true)
	{
	}

	internal MidiObject(int handle, bool owns)
	{
		if (handle == 0)
		{
			throw new Exception("Invalid parameters to context creation");
		}
		this.handle = handle;
		this.owns = owns;
	}

	~MidiObject()
	{
		Dispose(disposing: false);
	}

	internal virtual void DisposeHandle()
	{
		handle = 0;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		DisposeHandle();
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDIObjectFindByUniqueID(int uniqueId, out int obj, out MidiObjectType objectType);

	internal static MidiObject MidiObjectFromType(MidiObjectType type, int handle)
	{
		if (handle == 0)
		{
			return null;
		}
		if (type == MidiObjectType.Other)
		{
			return new MidiObject(handle, owns: false);
		}
		switch (type)
		{
		case MidiObjectType.Device:
		case MidiObjectType.ExternalMask:
			return new MidiDevice(handle, owns: false);
		case MidiObjectType.Entity:
		case MidiObjectType.ExternalEntity:
			return new MidiEntity(handle, owns: false);
		case MidiObjectType.Source:
		case MidiObjectType.ExternalSource:
			return new MidiEndpoint(handle, owns: false);
		case MidiObjectType.Destination:
		case MidiObjectType.ExternalDestination:
			return new MidiEndpoint(handle, owns: false);
		default:
		{
			int num = (int)type;
			throw new Exception("Unknown MidiObjectType " + num);
		}
		}
	}

	public static MidiError FindByUniqueId(int uniqueId, out MidiObject result)
	{
		int obj;
		MidiObjectType objectType;
		MidiError midiError = MIDIObjectFindByUniqueID(uniqueId, out obj, out objectType);
		result = null;
		if (midiError != 0)
		{
			return midiError;
		}
		result = MidiObjectFromType(objectType, obj);
		return midiError;
	}
}
