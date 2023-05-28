using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

public static class MTLArgumentEncoder_Extensions
{
	public unsafe static void SetBuffers(this IMTLArgumentEncoder This, IMTLBuffer[] buffers, nint[] offsets, NSRange range)
	{
		fixed (nint* ptr = offsets)
		{
			void* ptr2 = ptr;
			This.SetBuffers(buffers, (IntPtr)ptr2, range);
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetRenderPipelineState(this IMTLArgumentEncoder This, IMTLRenderPipelineState? pipeline, nuint index)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("setRenderPipelineState:atIndex:"), pipeline?.Handle ?? IntPtr.Zero, index);
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetRenderPipelineStates(this IMTLArgumentEncoder This, IMTLRenderPipelineState[] pipelines, NSRange range)
	{
		if (pipelines == null)
		{
			throw new ArgumentNullException("pipelines");
		}
		NSArray nSArray = NSArray.FromNSObjects(pipelines);
		Messaging.void_objc_msgSend_IntPtr_NSRange(This.Handle, Selector.GetHandle("setRenderPipelineStates:withRange:"), nSArray.Handle, range);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetIndirectCommandBuffer(this IMTLArgumentEncoder This, IMTLIndirectCommandBuffer? indirectCommandBuffer, nuint index)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("setIndirectCommandBuffer:atIndex:"), indirectCommandBuffer?.Handle ?? IntPtr.Zero, index);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetIndirectCommandBuffers(this IMTLArgumentEncoder This, IMTLIndirectCommandBuffer[] buffers, NSRange range)
	{
		if (buffers == null)
		{
			throw new ArgumentNullException("buffers");
		}
		NSArray nSArray = NSArray.FromNSObjects(buffers);
		Messaging.void_objc_msgSend_IntPtr_NSRange(This.Handle, Selector.GetHandle("setIndirectCommandBuffers:withRange:"), nSArray.Handle, range);
		nSArray.Dispose();
	}
}
