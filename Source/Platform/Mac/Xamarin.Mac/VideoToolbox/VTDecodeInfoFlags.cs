using System;

namespace VideoToolbox;

[Flags]
public enum VTDecodeInfoFlags : uint
{
	Asynchronous = 1u,
	FrameDropped = 2u,
	ImageBufferModifiable = 4u
}
