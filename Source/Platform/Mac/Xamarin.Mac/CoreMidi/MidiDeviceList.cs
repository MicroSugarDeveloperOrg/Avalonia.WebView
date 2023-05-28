using System.Runtime.InteropServices;
using Xamarin.Mac.System.Mac;

namespace CoreMidi;

public class MidiDeviceList : MidiObject
{
	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern nuint MIDIDeviceListGetNumberOfDevices(int devList);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIDeviceListGetDevice(int devList, nuint index);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIDeviceListAddDevice(int devList, int dev);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIDeviceListDispose(int devList);

	internal MidiDeviceList(int handle)
		: base(handle)
	{
	}

	internal MidiDeviceList(int handle, bool owns)
		: base(handle, owns)
	{
	}

	public nuint GetNumberOfDevices()
	{
		if (handle == 0)
		{
			throw new ObjectDisposedException("handle");
		}
		return MIDIDeviceListGetNumberOfDevices(handle);
	}

	public MidiDevice Get(nuint index)
	{
		if (handle == 0)
		{
			throw new ObjectDisposedException("handle");
		}
		int num = MIDIDeviceListGetDevice(handle, index);
		if (num == 0)
		{
			return null;
		}
		return new MidiDevice(num);
	}

	public int Add(MidiDevice device)
	{
		if (handle == 0)
		{
			throw new ObjectDisposedException("handle");
		}
		return MIDIDeviceListAddDevice(handle, device.Handle);
	}

	internal override void DisposeHandle()
	{
		if (handle != 0)
		{
			if (owns)
			{
				MIDIDeviceListDispose(handle);
			}
			handle = 0;
		}
	}
}
