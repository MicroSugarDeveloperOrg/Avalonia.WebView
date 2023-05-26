using System;
using System.Runtime.InteropServices;

namespace AudioUnit;

public struct AURenderEventHeader
{
	public unsafe AURenderEvent* UnsafeNext;

	public long EventSampleTime;

	public AURenderEventType EventType;

	public byte Reserved;

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
