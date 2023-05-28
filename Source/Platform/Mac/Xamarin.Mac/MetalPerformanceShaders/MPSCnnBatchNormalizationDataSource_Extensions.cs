using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

public static class MPSCnnBatchNormalizationDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnNormalizationGammaAndBetaState? UpdateGammaAndBeta(this IMPSCnnBatchNormalizationDataSource This, IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (batchNormalizationState == null)
		{
			throw new ArgumentNullException("batchNormalizationState");
		}
		return Runtime.GetNSObject<MPSCnnNormalizationGammaAndBetaState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("updateGammaAndBetaWithCommandBuffer:batchNormalizationState:"), commandBuffer.Handle, batchNormalizationState.Handle));
	}

	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnNormalizationMeanAndVarianceState? UpdateMeanAndVariance(this IMPSCnnBatchNormalizationDataSource This, IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (batchNormalizationState == null)
		{
			throw new ArgumentNullException("batchNormalizationState");
		}
		return Runtime.GetNSObject<MPSCnnNormalizationMeanAndVarianceState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("updateMeanAndVarianceWithCommandBuffer:batchNormalizationState:"), commandBuffer.Handle, batchNormalizationState.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UpdateGammaAndBeta(this IMPSCnnBatchNormalizationDataSource This, MPSCnnBatchNormalizationState batchNormalizationState)
	{
		if (batchNormalizationState == null)
		{
			throw new ArgumentNullException("batchNormalizationState");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("updateGammaAndBetaWithBatchNormalizationState:"), batchNormalizationState.Handle);
	}

	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UpdateMeanAndVariance(this IMPSCnnBatchNormalizationDataSource This, MPSCnnBatchNormalizationState batchNormalizationState)
	{
		if (batchNormalizationState == null)
		{
			throw new ArgumentNullException("batchNormalizationState");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("updateMeanAndVarianceWithBatchNormalizationState:"), batchNormalizationState.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Encode(this IMPSCnnBatchNormalizationDataSource This, NSCoder coder)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("encodeWithCoder:"), coder.Handle);
	}

	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMPSCnnBatchNormalizationDataSource Copy(this IMPSCnnBatchNormalizationDataSource This, NSZone? zone, IMTLDevice? device)
	{
		IMPSCnnBatchNormalizationDataSource iNativeObject = Runtime.GetINativeObject<IMPSCnnBatchNormalizationDataSource>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("copyWithZone:device:"), zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static float GetEpsilon(this IMPSCnnBatchNormalizationDataSource This)
	{
		return Messaging.float_objc_msgSend(This.Handle, Selector.GetHandle("epsilon"));
	}
}
