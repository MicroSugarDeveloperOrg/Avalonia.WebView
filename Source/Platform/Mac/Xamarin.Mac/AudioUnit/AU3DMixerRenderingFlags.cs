namespace AudioUnit;

public enum AU3DMixerRenderingFlags : uint
{
	InterAuralDelay = 1u,
	DopplerShift = 2u,
	DistanceAttenuation = 4u,
	DistanceFilter = 8u,
	DistanceDiffusion = 0x10u,
	LinearDistanceAttenuation = 0x20u,
	ConstantReverbBlend = 0x40u
}
