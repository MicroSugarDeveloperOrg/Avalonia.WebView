using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreMidi;

public class MidiThruConnectionParams
{
	private MidiThruConnectionParamsStruct connectionParams;

	public MidiThruConnectionEndpoint[] Sources
	{
		get
		{
			return connectionParams.Sources;
		}
		set
		{
			if (value != null && value.Length > 8)
			{
				throw new ArgumentOutOfRangeException("value", "A maximum of 8 endpoints are allowed");
			}
			connectionParams.Sources = value;
		}
	}

	public MidiThruConnectionEndpoint[] Destinations
	{
		get
		{
			return connectionParams.Destinations;
		}
		set
		{
			if (value != null && value.Length > 8)
			{
				throw new ArgumentOutOfRangeException("value", "A maximum of 8 endpoints are allowed");
			}
			connectionParams.Destinations = value;
		}
	}

	public byte[] ChannelMap
	{
		get
		{
			return connectionParams.ChannelMap;
		}
		set
		{
			if (value != null && value.Length > 16)
			{
				throw new ArgumentOutOfRangeException("value", "A maximum of 16 channels are allowed");
			}
			connectionParams.ChannelMap = value;
		}
	}

	public byte LowVelocity
	{
		get
		{
			return connectionParams.LowVelocity;
		}
		set
		{
			connectionParams.LowVelocity = value;
		}
	}

	public byte HighVelocity
	{
		get
		{
			return connectionParams.HighVelocity;
		}
		set
		{
			connectionParams.HighVelocity = value;
		}
	}

	public byte LowNote
	{
		get
		{
			return connectionParams.LowNote;
		}
		set
		{
			connectionParams.LowNote = value;
		}
	}

	public byte HighNote
	{
		get
		{
			return connectionParams.HighNote;
		}
		set
		{
			connectionParams.HighNote = value;
		}
	}

	public MidiTransform NoteNumber
	{
		get
		{
			return connectionParams.NoteNumber;
		}
		set
		{
			connectionParams.NoteNumber = value;
		}
	}

	public MidiTransform Velocity
	{
		get
		{
			return connectionParams.Velocity;
		}
		set
		{
			connectionParams.Velocity = value;
		}
	}

	public MidiTransform KeyPressure
	{
		get
		{
			return connectionParams.KeyPressure;
		}
		set
		{
			connectionParams.KeyPressure = value;
		}
	}

	public MidiTransform ChannelPressure
	{
		get
		{
			return connectionParams.ChannelPressure;
		}
		set
		{
			connectionParams.ChannelPressure = value;
		}
	}

	public MidiTransform ProgramChange
	{
		get
		{
			return connectionParams.ProgramChange;
		}
		set
		{
			connectionParams.ProgramChange = value;
		}
	}

	public MidiTransform PitchBend
	{
		get
		{
			return connectionParams.PitchBend;
		}
		set
		{
			connectionParams.PitchBend = value;
		}
	}

	public bool FilterOutSysEx
	{
		get
		{
			return connectionParams.FilterOutSysEx == 1;
		}
		set
		{
			connectionParams.FilterOutSysEx = (byte)(value ? 1 : 0);
		}
	}

	public bool FilterOutMtc
	{
		get
		{
			return connectionParams.FilterOutMtc == 1;
		}
		set
		{
			connectionParams.FilterOutMtc = (byte)(value ? 1 : 0);
		}
	}

	public bool FilterOutBeatClock
	{
		get
		{
			return connectionParams.FilterOutBeatClock == 1;
		}
		set
		{
			connectionParams.FilterOutBeatClock = (byte)(value ? 1 : 0);
		}
	}

	public bool FilterOutTuneRequest
	{
		get
		{
			return connectionParams.FilterOutTuneRequest == 1;
		}
		set
		{
			connectionParams.FilterOutTuneRequest = (byte)(value ? 1 : 0);
		}
	}

	public bool FilterOutAllControls
	{
		get
		{
			return connectionParams.FilterOutAllControls == 1;
		}
		set
		{
			connectionParams.FilterOutAllControls = (byte)(value ? 1 : 0);
		}
	}

	public MidiControlTransform[] Controls { get; set; }

	public MidiValueMap[] Maps { get; set; }

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern void MIDIThruConnectionParamsInitialize(out MidiThruConnectionParamsStruct inConnectionParams);

	public MidiThruConnectionParams()
	{
		MIDIThruConnectionParamsInitialize(out connectionParams);
	}

	internal unsafe void ReadStruct(NSData data)
	{
		IntPtr bytes = data.Bytes;
		connectionParams = (MidiThruConnectionParamsStruct)Marshal.PtrToStructure(bytes, typeof(MidiThruConnectionParamsStruct));
		IntPtr intPtr = IntPtr.Add(bytes, Marshal.SizeOf(typeof(MidiThruConnectionParamsStruct)));
		int num = Marshal.SizeOf(typeof(MidiControlTransform));
		if (connectionParams.NumControlTransforms == 0)
		{
			Controls = null;
		}
		else
		{
			Controls = new MidiControlTransform[connectionParams.NumControlTransforms];
			fixed (MidiControlTransform* ptr = &Controls[0])
			{
				Runtime.memcpy((IntPtr)ptr, intPtr, num * connectionParams.NumControlTransforms);
			}
		}
		if (connectionParams.NumMaps == 0)
		{
			Maps = null;
			return;
		}
		Maps = new MidiValueMap[connectionParams.NumMaps];
		intPtr = IntPtr.Add(intPtr, num * connectionParams.NumControlTransforms);
		for (int i = 0; i < connectionParams.NumMaps; i++)
		{
			Maps[i].Value = new byte[128];
			fixed (byte* ptr2 = &Maps[i].Value[0])
			{
				Runtime.memcpy((IntPtr)ptr2, intPtr, 128);
			}
		}
	}

	internal unsafe NSData WriteStruct()
	{
		MidiThruConnectionEndpoint[] sources = Sources;
		if (sources != null && sources.Length != 0)
		{
			connectionParams.NumSources = (uint)Sources.Length;
			for (int i = 0; i < Sources.Length; i++)
			{
				connectionParams.Sources[i] = Sources[i];
			}
		}
		MidiThruConnectionEndpoint[] destinations = Destinations;
		if (destinations != null && destinations.Length != 0)
		{
			connectionParams.NumDestinations = (uint)Destinations.Length;
			for (int j = 0; j < Destinations.Length; j++)
			{
				connectionParams.Destinations[j] = Destinations[j];
			}
		}
		byte[] channelMap = ChannelMap;
		if (channelMap != null && channelMap.Length != 0)
		{
			for (int k = 0; k < ChannelMap.Length; k++)
			{
				connectionParams.ChannelMap[k] = ChannelMap[k];
			}
		}
		connectionParams.NumControlTransforms = (ushort)((Controls != null) ? ((ushort)Controls.Length) : 0);
		connectionParams.NumMaps = (ushort)((Maps != null) ? ((ushort)Maps.Length) : 0);
		int num = Marshal.SizeOf(typeof(MidiThruConnectionParamsStruct));
		int num2 = Marshal.SizeOf(typeof(MidiControlTransform));
		int num3 = num + ((Controls != null) ? (num2 * Controls.Length) : 0) + ((Maps != null) ? (128 * Maps.Length) : 0);
		IntPtr intPtr = Marshal.AllocHGlobal(num3);
		IntPtr intPtr2 = IntPtr.Add(intPtr, Marshal.SizeOf(typeof(MidiThruConnectionParamsStruct)));
		try
		{
			Marshal.StructureToPtr(connectionParams, intPtr, fDeleteOld: false);
			if (connectionParams.NumControlTransforms > 0)
			{
				try
				{
					fixed (MidiControlTransform* ptr = &Controls[0])
					{
						Runtime.memcpy(intPtr2, (IntPtr)ptr, num2 * connectionParams.NumControlTransforms);
					}
				}
				finally
				{
				}
			}
			if (connectionParams.NumMaps > 0)
			{
				intPtr2 = IntPtr.Add(intPtr2, num2 * connectionParams.NumControlTransforms);
				for (int l = 0; l < connectionParams.NumMaps; l++)
				{
					try
					{
						fixed (byte* ptr2 = &Maps[l].Value[0])
						{
							Runtime.memcpy(intPtr2, (IntPtr)ptr2, 128);
						}
					}
					finally
					{
					}
					intPtr2 += 128;
				}
			}
			return NSData.FromBytes(intPtr, (nuint)num3);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}
}
