using System;
using System.Runtime.InteropServices;

namespace CoreMidi;

public static class Midi
{
	public static int DestinationCount => MIDIGetNumberOfDestinations();

	public static int SourceCount => MIDIGetNumberOfSources();

	public static int ExternalDeviceCount => MIDIGetNumberOfExternalDevices();

	public static int DeviceCount => MIDIGetNumberOfDevices();

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern void MIDIRestart();

	[DllImport("/usr/lib/libSystem.dylib")]
	internal static extern void memcpy(IntPtr target, IntPtr source, int n);

	public static void Restart()
	{
		MIDIRestart();
	}

	internal static IntPtr EncodePackets(MidiPacket[] packets)
	{
		int num = 4;
		for (int num2 = packets.Length; num2 > 0; num2--)
		{
			int length = packets[num2 - 1].Length;
			length = (length + 3) & -4;
			num += 12 + length;
		}
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.WriteInt32(intPtr, 0, packets.Length);
		int num3 = 4;
		for (int i = 0; i < packets.Length; i++)
		{
			Marshal.WriteInt64(intPtr, num3, packets[i].TimeStamp);
			num3 += 8;
			Marshal.WriteInt16(intPtr, num3, (short)packets[i].Length);
			num3 += 2;
			memcpy((IntPtr)((long)intPtr + num3), packets[i].Bytes, packets[i].Length);
			num3 += (packets[i].Length + 3) & -4;
		}
		return intPtr;
	}

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIGetNumberOfDestinations();

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIGetNumberOfSources();

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIGetNumberOfExternalDevices();

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIGetNumberOfDevices();

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern IntPtr MIDIGetExternalDevice(int item);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern IntPtr MIDIGetDevice(int item);

	public static MidiDevice GetDevice(int deviceIndex)
	{
		IntPtr intPtr = MIDIGetDevice(deviceIndex);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new MidiDevice(intPtr);
	}

	public static MidiDevice GetExternalDevice(int deviceIndex)
	{
		IntPtr intPtr = MIDIGetExternalDevice(deviceIndex);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new MidiDevice(intPtr);
	}
}
