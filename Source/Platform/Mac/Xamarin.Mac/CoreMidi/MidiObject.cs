using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreMidi;

public class MidiObject : INativeObject, IDisposable
{
	internal IntPtr handle;

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

	public IntPtr Handle => handle;

	static MidiObject()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI", 0);
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
	}

	internal MidiObject()
	{
		owns = true;
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectGetIntegerProperty(IntPtr obj, IntPtr str, out int ret);

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
	private static extern int MIDIObjectSetIntegerProperty(IntPtr obj, IntPtr str, int val);

	internal void SetInt(IntPtr property, int value)
	{
		MIDIObjectSetIntegerProperty(handle, property, value);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectGetDictionaryProperty(IntPtr obj, IntPtr str, out IntPtr dict);

	internal NSDictionary GetDictionary(IntPtr property)
	{
		IntPtr dict;
		int num = MIDIObjectGetDictionaryProperty(handle, property, out dict);
		if (num == 0)
		{
			return (NSDictionary)Runtime.GetNSObject(dict);
		}
		throw new MidiException((MidiError)num);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectSetDictionaryProperty(IntPtr obj, IntPtr str, IntPtr dict);

	internal void SetDictionary(IntPtr property, NSDictionary dict)
	{
		MIDIObjectSetDictionaryProperty(handle, property, dict.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectGetDataProperty(IntPtr obj, IntPtr str, out IntPtr data);

	public NSData GetData(IntPtr property)
	{
		IntPtr data;
		int num = MIDIObjectGetDataProperty(handle, property, out data);
		if (num == 0)
		{
			return (NSData)Runtime.GetNSObject(data);
		}
		throw new MidiException((MidiError)num);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectSetDataProperty(IntPtr obj, IntPtr str, IntPtr data);

	public void SetData(IntPtr property, NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		MIDIObjectSetDataProperty(handle, property, data.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectGetStringProperty(IntPtr obj, IntPtr str, out IntPtr data);

	public string GetString(IntPtr property)
	{
		if (MIDIObjectGetStringProperty(handle, property, out var data) == 0)
		{
			string result = NSString.FromHandle(data);
			CFObject.CFRelease(data);
			return result;
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectSetStringProperty(IntPtr obj, IntPtr str, IntPtr nstr);

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
	private static extern MidiError MIDIObjectRemoveProperty(IntPtr obj, IntPtr str);

	public MidiError RemoveProperty(string property)
	{
		using NSString nSString = new NSString(property);
		return MIDIObjectRemoveProperty(handle, nSString.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIObjectGetProperties(IntPtr obj, out IntPtr dict, bool deep);

	public NSDictionary GetDictionaryProperties(bool deep)
	{
		if (MIDIObjectGetProperties(handle, out var dict, deep) != 0)
		{
			return null;
		}
		return (NSDictionary)Runtime.GetNSObject(dict);
	}

	public MidiObject(IntPtr handle)
		: this(handle, owns: true)
	{
	}

	internal MidiObject(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
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
		handle = IntPtr.Zero;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public virtual void Dispose(bool disposing)
	{
		DisposeHandle();
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDIObjectFindByUniqueID(int uniqueId, out IntPtr obj, out MidiObjectType objectType);

	internal static MidiObject MidiObjectFromType(MidiObjectType type, IntPtr handle)
	{
		return (type & ~MidiObjectType.ExternalMask) switch
		{
			MidiObjectType.Other => new MidiObject(handle), 
			MidiObjectType.Device => new MidiDevice(handle), 
			MidiObjectType.Entity => new MidiEntity(handle), 
			MidiObjectType.Source => new MidiEndpoint(handle, owns: false), 
			MidiObjectType.Destination => new MidiEndpoint(handle, owns: false), 
			_ => throw new Exception("Unknown MidiObjectType " + (int)type), 
		};
	}

	private static MidiError FindByUniqueId(int uniqueId, out MidiObject result)
	{
		IntPtr obj;
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
