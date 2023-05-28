using System;
using System.Runtime.InteropServices;

namespace AudioUnit;

public struct AUParameterEvent
{
	public unsafe AURenderEvent* UnsafeNext;

	public long EventSampleTime;

	public AURenderEventType EventType;

	internal byte reserved1;

	internal byte reserved2;

	internal byte reserved3;

	public uint RampDurationSampleFrames;

	public ulong ParameterAddress;

	public float Value;

	public unsafe AURenderEvent? Next
	{
		get
		{
			if (UnsafeNext != null)
			{
				return (AURenderEvent?)Marshal.PtrToStructure((IntPtr)UnsafeNext, typeof(AURenderEvent));
			}
			return null;
		}
	}
}
