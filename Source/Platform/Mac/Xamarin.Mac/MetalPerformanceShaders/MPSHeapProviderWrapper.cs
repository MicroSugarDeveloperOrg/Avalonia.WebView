using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

internal sealed class MPSHeapProviderWrapper : BaseWrapper, IMPSHeapProvider, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MPSHeapProviderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("newHeapWithDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLHeap? GetNewHeap(MTLHeapDescriptor descriptor)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IMTLHeap iNativeObject = Runtime.GetINativeObject<IMTLHeap>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("newHeapWithDescriptor:"), descriptor.Handle), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}
}
