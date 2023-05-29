using System;

namespace OpenGL;

[Flags]
public enum AttribMask
{
	CurrentBit = 1,
	PointBit = 2,
	LineBit = 4,
	PolygonBit = 8,
	PolygonStippleBit = 0x10,
	PixelModeBit = 0x20,
	LightingBit = 0x40,
	FogBit = 0x80,
	DepthBufferBit = 0x100,
	AccumBufferBit = 0x200,
	StencilBufferBit = 0x400,
	ViewportBit = 0x800,
	TransformBit = 0x1000,
	EnableBit = 0x2000,
	ColorBufferBit = 0x4000,
	HintBit = 0x8000,
	EvalBit = 0x10000,
	ListBit = 0x20000,
	TextureBit = 0x40000,
	ScissorBit = 0x80000,
	MultisampleBit = 0x20000000,
	AllAttribBits = -1
}
