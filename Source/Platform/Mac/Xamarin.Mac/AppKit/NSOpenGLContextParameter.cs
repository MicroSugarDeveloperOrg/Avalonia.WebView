using ObjCRuntime;

namespace AppKit;

[Native]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public enum NSOpenGLContextParameter : ulong
{
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	SwapRectangle = 200uL,
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	SwapRectangleEnable = 201uL,
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	RasterizationEnable = 221uL,
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	StateValidation = 301uL,
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	SurfaceSurfaceVolatile = 306uL,
	SwapInterval = 222uL,
	SurfaceOrder = 235uL,
	SurfaceOpacity = 236uL,
	SurfaceBackingSize = 304uL,
	ReclaimResources = 308uL,
	CurrentRendererID = 309uL,
	GpuVertexProcessing = 310uL,
	GpuFragmentProcessing = 311uL,
	HasDrawable = 314uL,
	MpsSwapsInFlight = 315uL
}
