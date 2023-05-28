using System;

namespace VideoToolbox;

[Flags]
public enum VTDecodeFrameFlags : uint
{
	EnableAsynchronousDecompression = 1u,
	DoNotOutputFrame = 2u,
	OneTimeRealTimePlayback = 4u,
	EnableTemporalProcessing = 8u
}
