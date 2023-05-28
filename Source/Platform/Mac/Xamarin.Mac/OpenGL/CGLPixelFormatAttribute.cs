using ObjCRuntime;

namespace OpenGL;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public enum CGLPixelFormatAttribute : uint
{
	AllRenderers = 1u,
	DoubleBuffer = 5u,
	Stereo = 6u,
	AuxBuffers = 7u,
	ColorSize = 8u,
	AlphaSize = 11u,
	DepthSize = 12u,
	StencilSize = 13u,
	AccumSize = 14u,
	MinimumPolicy = 51u,
	MaximumPolicy = 52u,
	OffScreen = 53u,
	FullScreen = 54u,
	SampleBuffers = 55u,
	Samples = 56u,
	AuxDepthStencil = 57u,
	ColorFloat = 58u,
	Multisample = 59u,
	Supersample = 60u,
	SampleAlpha = 61u,
	RendererID = 70u,
	SingleRenderer = 71u,
	NoRecovery = 72u,
	Accelerated = 73u,
	ClosestPolicy = 74u,
	Robust = 75u,
	BackingStore = 76u,
	MPSafe = 78u,
	Window = 80u,
	MultiScreen = 81u,
	Compliant = 83u,
	ScreenMask = 84u,
	PixelBuffer = 90u,
	RemotePixelBuffer = 91u,
	AllowOfflineRenderers = 96u,
	AcceleratedCompute = 97u,
	VirtualScreenCount = 128u
}
