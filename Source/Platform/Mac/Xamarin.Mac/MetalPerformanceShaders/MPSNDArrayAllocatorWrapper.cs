using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

internal sealed class MPSNDArrayAllocatorWrapper : BaseWrapper, IMPSNDArrayAllocator, INativeObject, IDisposable, INSCoding, INSCopying, INSSecureCoding
{
	[Preserve(Conditional = true)]
	public MPSNDArrayAllocatorWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("arrayForCommandBuffer:arrayDescriptor:kernel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNDArray AllocateArray(IMTLCommandBuffer cmdBuf, MPSNDArrayDescriptor descriptor, MPSKernel kernel)
	{
		if (cmdBuf == null)
		{
			throw new ArgumentNullException("cmdBuf");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (kernel == null)
		{
			throw new ArgumentNullException("kernel");
		}
		return Runtime.GetNSObject<MPSNDArray>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("arrayForCommandBuffer:arrayDescriptor:kernel:"), cmdBuf.Handle, descriptor.Handle, kernel.Handle));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("encodeWithCoder:"), encoder.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("copyWithZone:"), zone?.Handle ?? IntPtr.Zero));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
