using System;
using ObjCRuntime;

namespace AppKit;

public enum NSOpenGLPixelFormatAttribute
{
	AllRenderers = 1,
	DoubleBuffer = 5,
	[Lion]
	TrippleBuffer = 3,
	Stereo = 6,
	AuxBuffers = 7,
	ColorSize = 8,
	AlphaSize = 11,
	DepthSize = 12,
	StencilSize = 13,
	AccumSize = 14,
	MinimumPolicy = 51,
	MaximumPolicy = 52,
	OffScreen = 53,
	FullScreen = 54,
	SampleBuffers = 55,
	Samples = 56,
	AuxDepthStencil = 57,
	ColorFloat = 58,
	Multisample = 59,
	Supersample = 60,
	SampleAlpha = 61,
	RendererID = 70,
	SingleRenderer = 71,
	NoRecovery = 72,
	Accelerated = 73,
	ClosestPolicy = 74,
	BackingStore = 76,
	Window = 80,
	Compliant = 83,
	ScreenMask = 84,
	PixelBuffer = 90,
	RemotePixelBuffer = 91,
	AllowOfflineRenderers = 96,
	AcceleratedCompute = 97,
	[Lion]
	OpenGLProfile = 99,
	VirtualScreenCount = 128,
	[Obsolete]
	Robust = 75,
	[Obsolete]
	MPSafe = 78,
	[Obsolete]
	MultiScreen = 81
}
