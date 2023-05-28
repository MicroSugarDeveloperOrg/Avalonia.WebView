using System;

namespace AudioUnit;

[Flags]
public enum ScheduledAudioSliceFlag
{
	Complete = 1,
	BeganToRender = 2,
	BeganToRenderLate = 4,
	[iOS(8, 0)]
	[Mac(10, 10)]
	Loop = 8,
	[iOS(8, 0)]
	[Mac(10, 10)]
	Interrupt = 0x10,
	[iOS(8, 0)]
	[Mac(10, 10)]
	InterruptAtLoop = 0x20
}
