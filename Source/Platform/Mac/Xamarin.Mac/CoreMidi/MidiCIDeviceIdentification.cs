using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreMidi;

[NoWatch]
[NoTV]
[Mac(10, 14)]
[iOS(12, 0)]
public struct MidiCIDeviceIdentification
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public byte[] Manufacturer;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public byte[] Family;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public byte[] ModelNumber;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public byte[] RevisionLevel;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
	public byte[] Reserved;
}
