using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

public static class MTLComputeCommandEncoder_Extensions
{
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public static void SampleCounters(this IMTLComputeCommandEncoder This, IMTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_bool(This.Handle, Selector.GetHandle("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer.Handle, sampleIndex, barrier);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DispatchThreadgroups(this IMTLComputeCommandEncoder This, IMTLBuffer indirectBuffer, nuint indirectBufferOffset, MTLSize threadsPerThreadgroup)
	{
		if (indirectBuffer == null)
		{
			throw new ArgumentNullException("indirectBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_MTLSize(This.Handle, Selector.GetHandle("dispatchThreadgroupsWithIndirectBuffer:indirectBufferOffset:threadsPerThreadgroup:"), indirectBuffer.Handle, indirectBufferOffset, threadsPerThreadgroup);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetStage(this IMTLComputeCommandEncoder This, MTLRegion region)
	{
		Messaging.void_objc_msgSend_MTLRegion(This.Handle, Selector.GetHandle("setStageInRegion:"), region);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetStageInRegion(this IMTLComputeCommandEncoder This, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
	{
		if (indirectBuffer == null)
		{
			throw new ArgumentNullException("indirectBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("setStageInRegionWithIndirectBuffer:indirectBufferOffset:"), indirectBuffer.Handle, indirectBufferOffset);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Update(this IMTLComputeCommandEncoder This, IMTLFence fence)
	{
		if (fence == null)
		{
			throw new ArgumentNullException("fence");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("updateFence:"), fence.Handle);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Wait(this IMTLComputeCommandEncoder This, IMTLFence fence)
	{
		if (fence == null)
		{
			throw new ArgumentNullException("fence");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("waitForFence:"), fence.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DispatchThreads(this IMTLComputeCommandEncoder This, MTLSize threadsPerGrid, MTLSize threadsPerThreadgroup)
	{
		Messaging.void_objc_msgSend_MTLSize_MTLSize(This.Handle, Selector.GetHandle("dispatchThreads:threadsPerThreadgroup:"), threadsPerGrid, threadsPerThreadgroup);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseResource(this IMTLComputeCommandEncoder This, IMTLResource resource, MTLResourceUsage usage)
	{
		if (resource == null)
		{
			throw new ArgumentNullException("resource");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64(This.Handle, Selector.GetHandle("useResource:usage:"), resource.Handle, (ulong)usage);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseResources(this IMTLComputeCommandEncoder This, IMTLResource[] resources, nuint count, MTLResourceUsage usage)
	{
		if (resources == null)
		{
			throw new ArgumentNullException("resources");
		}
		NSArray nSArray = NSArray.FromNSObjects(resources);
		Messaging.void_objc_msgSend_IntPtr_nuint_UInt64(This.Handle, Selector.GetHandle("useResources:count:usage:"), nSArray.Handle, count, (ulong)usage);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseHeap(this IMTLComputeCommandEncoder This, IMTLHeap heap)
	{
		if (heap == null)
		{
			throw new ArgumentNullException("heap");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("useHeap:"), heap.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UseHeaps(this IMTLComputeCommandEncoder This, IMTLHeap[] heaps, nuint count)
	{
		if (heaps == null)
		{
			throw new ArgumentNullException("heaps");
		}
		NSArray nSArray = NSArray.FromNSObjects(heaps);
		Messaging.void_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("useHeaps:count:"), nSArray.Handle, count);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MemoryBarrier(this IMTLComputeCommandEncoder This, MTLBarrierScope scope)
	{
		Messaging.void_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("memoryBarrierWithScope:"), (ulong)scope);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MemoryBarrier(this IMTLComputeCommandEncoder This, IMTLResource[] resources, nuint count)
	{
		if (resources == null)
		{
			throw new ArgumentNullException("resources");
		}
		NSArray nSArray = NSArray.FromNSObjects(resources);
		Messaging.void_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("memoryBarrierWithResources:count:"), nSArray.Handle, count);
		nSArray.Dispose();
	}

	[Obsolete("Use the overload that takes an IMTLCounterSampleBuffer instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SampleCounters(this IMTLComputeCommandEncoder This, MTLCounterSampleBuffer sampleBuffer, nuint sampleIndex, bool barrier)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint_bool(This.Handle, Selector.GetHandle("sampleCountersInBuffer:atSampleIndex:withBarrier:"), sampleBuffer.Handle, sampleIndex, barrier);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLDispatchType GetDispatchType(this IMTLComputeCommandEncoder This)
	{
		return (MTLDispatchType)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("dispatchType"));
	}
}
