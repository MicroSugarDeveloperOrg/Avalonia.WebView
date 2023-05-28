using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

internal sealed class MPSImageAllocatorWrapper : BaseWrapper, IMPSImageAllocator, INativeObject, IDisposable, INSCoding, INSSecureCoding
{
	[Preserve(Conditional = true)]
	public MPSImageAllocatorWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("imageForCommandBuffer:imageDescriptor:kernel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImage GetImage(IMTLCommandBuffer cmdBuf, MPSImageDescriptor descriptor, MPSKernel kernel)
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
		return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("imageForCommandBuffer:imageDescriptor:kernel:"), cmdBuf.Handle, descriptor.Handle, kernel.Handle));
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
}
