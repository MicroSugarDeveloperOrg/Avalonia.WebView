using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

public static class MPSNNPadding_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetLabel(this IMPSNNPadding This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("label")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSImageDescriptor GetDestinationImageDescriptor(this IMPSNNPadding This, MPSImage[] sourceImages, MPSState[]? sourceStates, MPSKernel kernel, MPSImageDescriptor inDescriptor)
	{
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (kernel == null)
		{
			throw new ArgumentNullException("kernel");
		}
		if (inDescriptor == null)
		{
			throw new ArgumentNullException("inDescriptor");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceImages);
		NSArray nSArray2 = ((sourceStates == null) ? null : NSArray.FromNSObjects(sourceStates));
		MPSImageDescriptor nSObject = Runtime.GetNSObject<MPSImageDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:"), nSArray.Handle, nSArray2?.Handle ?? IntPtr.Zero, kernel.Handle, inDescriptor.Handle));
		nSArray.Dispose();
		nSArray2?.Dispose();
		return nSObject;
	}

	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMPSNNPadding? GetInverse(this IMPSNNPadding This)
	{
		return Runtime.GetINativeObject<IMPSNNPadding>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("inverse")), owns: false);
	}
}
