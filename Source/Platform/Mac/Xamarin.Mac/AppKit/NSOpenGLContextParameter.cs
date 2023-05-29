using System;
using ObjCRuntime;

namespace AppKit;

public enum NSOpenGLContextParameter : long
{
	[Obsolete]
	SwapRectangle = 200L,
	[Obsolete]
	SwapRectangleEnable = 201L,
	[Obsolete]
	RasterizationEnable = 221L,
	[Obsolete]
	StateValidation = 301L,
	[Obsolete]
	SurfaceSurfaceVolatile = 306L,
	SwapInterval = 222L,
	SurfaceOrder = 235L,
	SurfaceOpacity = 236L,
	[Lion]
	SurfaceBackingSize = 304L,
	[Lion]
	ReclaimResources = 308L,
	[Lion]
	CurrentRendererID = 309L,
	[Lion]
	GpuVertexProcessing = 310L,
	[Lion]
	GpuFragmentProcessing = 311L,
	[Lion]
	HasDrawable = 314L,
	[Lion]
	MpsSwapsInFlight = 315L
}
