using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreMidi;

public class MidiThruConnection : IDisposable
{
	private uint handle;

	private const uint InvalidRef = 0u;

	public uint Handle => handle;

	protected internal MidiThruConnection(uint handle)
	{
		this.handle = handle;
	}

	~MidiThruConnection()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDIThruConnectionDispose(uint connection);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != 0)
		{
			MIDIThruConnectionDispose(handle);
			handle = 0u;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDIThruConnectionCreate(IntPtr inPersistentOwnerID, IntPtr inConnectionParams, out uint outConnection);

	public static MidiThruConnection Create(string persistentOwnerID, MidiThruConnectionParams connectionParams, out MidiError error)
	{
		uint outConnection;
		using (NSData nSData = connectionParams.WriteStruct())
		{
			IntPtr inPersistentOwnerID = NSString.CreateNative(persistentOwnerID);
			error = MIDIThruConnectionCreate(inPersistentOwnerID, nSData.Handle, out outConnection);
			NSString.ReleaseNative(inPersistentOwnerID);
		}
		if (error != 0)
		{
			return null;
		}
		return new MidiThruConnection(outConnection);
	}

	public static MidiThruConnection Create(string persistentOwnerID, MidiThruConnectionParams connectionParams)
	{
		MidiError error;
		return Create(persistentOwnerID, connectionParams, out error);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDIThruConnectionGetParams(uint connection, out IntPtr outConnectionParams);

	public MidiThruConnectionParams GetParams(out MidiError error)
	{
		if (Handle == 0)
		{
			throw new ObjectDisposedException("MidiThruConnection");
		}
		error = MIDIThruConnectionGetParams(Handle, out var outConnectionParams);
		if (error != 0 || outConnectionParams == IntPtr.Zero)
		{
			return null;
		}
		using NSData nSData = Runtime.GetNSObject<NSData>(outConnectionParams, owns: true);
		if (nSData == null)
		{
			return null;
		}
		MidiThruConnectionParams midiThruConnectionParams = new MidiThruConnectionParams();
		midiThruConnectionParams.ReadStruct(nSData);
		return midiThruConnectionParams;
	}

	public MidiThruConnectionParams GetParams()
	{
		MidiError error;
		return GetParams(out error);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDIThruConnectionSetParams(uint connection, IntPtr inConnectionParams);

	public MidiError SetParams(MidiThruConnectionParams connectionParams)
	{
		if (Handle == 0)
		{
			throw new ObjectDisposedException("MidiThruConnection");
		}
		if (connectionParams == null)
		{
			throw new ArgumentNullException("connectionParams");
		}
		using NSData nSData = connectionParams.WriteStruct();
		return MIDIThruConnectionSetParams(Handle, nSData.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern MidiError MIDIThruConnectionFind(IntPtr inPersistentOwnerID, out IntPtr outConnectionList);

	public static MidiThruConnection[] Find(string persistentOwnerID, out MidiError error)
	{
		if (persistentOwnerID == null)
		{
			throw new ArgumentNullException("persistentOwnerID");
		}
		IntPtr outConnectionList;
		using (NSString nSString = new NSString(persistentOwnerID))
		{
			error = MIDIThruConnectionFind(nSString.Handle, out outConnectionList);
		}
		using NSData nSData = Runtime.GetNSObject<NSData>(outConnectionList);
		int num = Marshal.SizeOf(typeof(uint));
		int num2 = (int)nSData.Length / num;
		if (num2 == 0)
		{
			return null;
		}
		int num3 = nSData.Bytes.ToInt32();
		MidiThruConnection[] array = new MidiThruConnection[num2];
		for (int i = 0; i < num2; i++)
		{
			array[i] = new MidiThruConnection((uint)(num3 + i * num));
		}
		return array;
	}

	public static MidiThruConnection[] Find(string persistentOwnerID)
	{
		MidiError error;
		return Find(persistentOwnerID, out error);
	}
}
