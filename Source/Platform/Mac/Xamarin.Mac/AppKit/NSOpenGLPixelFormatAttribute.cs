using System;
using ObjCRuntime;

namespace AppKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public enum NSOpenGLPixelFormatAttribute : uint
{
	AllRenderers = 1u,
	DoubleBuffer = 5u,
	TripleBuffer = 3u,
	[Obsolete("Use 'TripleBuffer' instead.")]
	TrippleBuffer = 3u,
	Stereo = 6u,
	AuxBuffers = 7u,
	ColorSize = 8u,
	AlphaSize = 11u,
	DepthSize = 12u,
	StencilSize = 13u,
	AccumSize = 14u,
	MinimumPolicy = 51u,
	MaximumPolicy = 52u,
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	OffScreen = 53u,
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.None, null)]
	FullScreen = 54u,
	SampleBuffers = 55u,
	Samples = 56u,
	AuxDepthStencil = 57u,
	ColorFloat = 58u,
	Multisample = 59u,
	Supersample = 60u,
	SampleAlpha = 61u,
	RendererID = 70u,
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	SingleRenderer = 71u,
	NoRecovery = 72u,
	Accelerated = 73u,
	ClosestPolicy = 74u,
	BackingStore = 76u,
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	Window = 80u,
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	Compliant = 83u,
	ScreenMask = 84u,
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	PixelBuffer = 90u,
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	RemotePixelBuffer = 91u,
	AllowOfflineRenderers = 96u,
	AcceleratedCompute = 97u,
	OpenGLProfile = 99u,
	VirtualScreenCount = 128u,
	[Deprecated(PlatformName.MacOSX, 10, 5, PlatformArchitecture.None, null)]
	Robust = 75u,
	[Deprecated(PlatformName.MacOSX, 10, 5, PlatformArchitecture.None, null)]
	MPSafe = 78u,
	[Deprecated(PlatformName.MacOSX, 10, 5, PlatformArchitecture.None, null)]
	MultiScreen = 81u
}
