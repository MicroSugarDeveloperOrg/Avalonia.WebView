using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

public static class MPSCnnConvolutionDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IntPtr GetRangesForUInt8Kernel(this IMPSCnnConvolutionDataSource This)
	{
		return Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("rangesForUInt8Kernel"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IntPtr GetLookupTableForUInt8Kernel(this IMPSCnnConvolutionDataSource This)
	{
		return Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("lookupTableForUInt8Kernel"));
	}

	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnWeightsQuantizationType GetWeightsQuantizationType(this IMPSCnnConvolutionDataSource This)
	{
		return (MPSCnnWeightsQuantizationType)Messaging.UInt32_objc_msgSend(This.Handle, Selector.GetHandle("weightsQuantizationType"));
	}

	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnConvolutionWeightsAndBiasesState? Update(this IMPSCnnConvolutionDataSource This, IMTLCommandBuffer commandBuffer, MPSCnnConvolutionGradientState gradientState, MPSCnnConvolutionWeightsAndBiasesState sourceState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		if (sourceState == null)
		{
			throw new ArgumentNullException("sourceState");
		}
		return Runtime.GetNSObject<MPSCnnConvolutionWeightsAndBiasesState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("updateWithCommandBuffer:gradientState:sourceState:"), commandBuffer.Handle, gradientState.Handle, sourceState.Handle));
	}

	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool Update(this IMPSCnnConvolutionDataSource This, MPSCnnConvolutionGradientState gradientState, MPSCnnConvolutionWeightsAndBiasesState sourceState)
	{
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		if (sourceState == null)
		{
			throw new ArgumentNullException("sourceState");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("updateWithGradientState:sourceState:"), gradientState.Handle, sourceState.Handle);
	}

	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMPSCnnConvolutionDataSource Copy(this IMPSCnnConvolutionDataSource This, NSZone? zone, IMTLDevice? device)
	{
		IMPSCnnConvolutionDataSource iNativeObject = Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("copyWithZone:device:"), zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}
}
