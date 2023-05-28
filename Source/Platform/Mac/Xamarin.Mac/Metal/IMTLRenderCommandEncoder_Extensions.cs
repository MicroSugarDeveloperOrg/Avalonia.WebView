using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

public static class IMTLRenderCommandEncoder_Extensions
{
	[Mac(10, 13)]
	[NoiOS]
	[NoTV]
	[NoWatch]
	public unsafe static void SetViewports(this IMTLRenderCommandEncoder This, MTLViewport[] viewports)
	{
		fixed (MTLViewport* ptr = viewports)
		{
			void* ptr2 = ptr;
			This.SetViewports((IntPtr)ptr2, (nuint)((viewports != null) ? viewports.Length : 0));
		}
	}

	[Mac(10, 13)]
	[NoiOS]
	[NoTV]
	[NoWatch]
	public unsafe static void SetScissorRects(this IMTLRenderCommandEncoder This, MTLScissorRect[] scissorRects)
	{
		fixed (MTLScissorRect* ptr = scissorRects)
		{
			void* ptr2 = ptr;
			This.SetScissorRects((IntPtr)ptr2, (nuint)((scissorRects != null) ? scissorRects.Length : 0));
		}
	}
}
