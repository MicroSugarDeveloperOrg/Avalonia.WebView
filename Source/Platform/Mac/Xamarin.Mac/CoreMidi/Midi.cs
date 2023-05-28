using System.Runtime.InteropServices;
using Xamarin.Mac.System.Mac;

namespace CoreMidi;

public static class Midi
{
	public static nint DestinationCount => MIDIGetNumberOfDestinations();

	public static nint SourceCount => MIDIGetNumberOfSources();

	public static nint ExternalDeviceCount => MIDIGetNumberOfExternalDevices();

	public static nint DeviceCount => MIDIGetNumberOfDevices();

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern void MIDIRestart();

	public static void Restart()
	{
		MIDIRestart();
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern nint MIDIGetNumberOfDestinations();

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern nint MIDIGetNumberOfSources();

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern nint MIDIGetNumberOfExternalDevices();

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern nint MIDIGetNumberOfDevices();

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIGetExternalDevice(nint item);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIGetDevice(nint item);

	public static MidiDevice GetDevice(nint deviceIndex)
	{
		int num = MIDIGetDevice(deviceIndex);
		if (num == 0)
		{
			return null;
		}
		return new MidiDevice(num);
	}

	public static MidiDevice GetExternalDevice(nint deviceIndex)
	{
		int num = MIDIGetExternalDevice(deviceIndex);
		if (num == 0)
		{
			return null;
		}
		return new MidiDevice(num);
	}
}
