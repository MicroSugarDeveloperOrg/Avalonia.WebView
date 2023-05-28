namespace AudioUnit;

public enum AUScheduledAudioSliceFlags : uint
{
	Complete = 1u,
	BeganToRender = 2u,
	BeganToRenderLate = 4u,
	Loop = 8u,
	Interrupt = 0x10u,
	InterruptAtLoop = 0x20u
}
