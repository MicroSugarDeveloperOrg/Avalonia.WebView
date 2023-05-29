using System;

namespace OpenGL;

[Flags]
public enum ClearBufferMask
{
	DepthBufferBit = 0x100,
	AccumBufferBit = 0x200,
	StencilBufferBit = 0x400,
	ColorBufferBit = 0x4000,
	CoverageBufferBitNv = 0x8000
}
