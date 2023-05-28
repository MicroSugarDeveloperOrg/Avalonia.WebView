using System.Runtime.InteropServices;

namespace CoreMidi;

internal struct MidiThruConnectionParamsStruct
{
	public uint Version;

	public uint NumSources;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public MidiThruConnectionEndpoint[] Sources;

	public uint NumDestinations;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public MidiThruConnectionEndpoint[] Destinations;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public byte[] ChannelMap;

	public byte LowVelocity;

	public byte HighVelocity;

	public byte LowNote;

	public byte HighNote;

	public MidiTransform NoteNumber;

	public MidiTransform Velocity;

	public MidiTransform KeyPressure;

	public MidiTransform ChannelPressure;

	public MidiTransform ProgramChange;

	public MidiTransform PitchBend;

	public byte FilterOutSysEx;

	public byte FilterOutMtc;

	public byte FilterOutBeatClock;

	public byte FilterOutTuneRequest;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public byte[] Reserved2;

	public byte FilterOutAllControls;

	public ushort NumControlTransforms;

	public ushort NumMaps;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public ushort[] Reserved3;
}
