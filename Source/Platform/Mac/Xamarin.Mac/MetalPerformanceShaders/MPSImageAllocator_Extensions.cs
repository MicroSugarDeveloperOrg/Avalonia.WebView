using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

public static class MPSImageAllocator_Extensions
{
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSArray<MPSImage> GetImageBatch(this IMPSImageAllocator This, IMTLCommandBuffer commandBuffer, MPSImageDescriptor descriptor, MPSKernel kernel, nuint count)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (kernel == null)
		{
			throw new ArgumentNullException("kernel");
		}
		return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint(This.Handle, Selector.GetHandle("imageBatchForCommandBuffer:imageDescriptor:kernel:count:"), commandBuffer.Handle, descriptor.Handle, kernel.Handle, count));
	}
}
