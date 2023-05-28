using System.Runtime.InteropServices;

namespace AudioUnit;

public struct AudioUnitParameterEvent
{
	[StructLayout(LayoutKind.Explicit)]
	public struct EventValuesStruct
	{
		public struct RampStruct
		{
			public int StartBufferOffset;

			public uint DurationInFrames;

			public float StartValue;

			public float EndValue;
		}

		public struct ImmediateStruct
		{
			public uint BufferOffset;

			public float Value;
		}

		[FieldOffset(0)]
		public RampStruct Ramp;

		[FieldOffset(0)]
		public ImmediateStruct Immediate;
	}

	public uint Scope;

	public uint Element;

	public uint Parameter;

	public AUParameterEventType EventType;

	public EventValuesStruct EventValues;
}
