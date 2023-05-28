using System;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

public static class MPSHeapProvider_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RetireHeap(this IMPSHeapProvider This, IMTLHeap heap, double seconds)
	{
		if (heap == null)
		{
			throw new ArgumentNullException("heap");
		}
		Messaging.void_objc_msgSend_IntPtr_Double(This.Handle, Selector.GetHandle("retireHeap:cacheDelay:"), heap.Handle, seconds);
	}
}
