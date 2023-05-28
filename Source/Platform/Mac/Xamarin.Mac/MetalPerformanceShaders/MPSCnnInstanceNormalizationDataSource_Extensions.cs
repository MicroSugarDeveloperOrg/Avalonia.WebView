using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

public static class MPSCnnInstanceNormalizationDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnNormalizationGammaAndBetaState? UpdateGammaAndBeta(this IMPSCnnInstanceNormalizationDataSource This, IMTLCommandBuffer commandBuffer, MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (instanceNormalizationStateBatch == null)
		{
			throw new ArgumentNullException("instanceNormalizationStateBatch");
		}
		NSArray nSArray = NSArray.FromNSObjects(instanceNormalizationStateBatch);
		MPSCnnNormalizationGammaAndBetaState nSObject = Runtime.GetNSObject<MPSCnnNormalizationGammaAndBetaState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("updateGammaAndBetaWithCommandBuffer:instanceNormalizationStateBatch:"), commandBuffer.Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UpdateGammaAndBeta(this IMPSCnnInstanceNormalizationDataSource This, MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
	{
		if (instanceNormalizationStateBatch == null)
		{
			throw new ArgumentNullException("instanceNormalizationStateBatch");
		}
		NSArray nSArray = NSArray.FromNSObjects(instanceNormalizationStateBatch);
		bool result = Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("updateGammaAndBetaWithInstanceNormalizationStateBatch:"), nSArray.Handle);
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static float GetEpsilon(this IMPSCnnInstanceNormalizationDataSource This)
	{
		return Messaging.float_objc_msgSend(This.Handle, Selector.GetHandle("epsilon"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Encode(this IMPSCnnInstanceNormalizationDataSource This, NSCoder coder)
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
	public static IMPSCnnInstanceNormalizationDataSource Copy(this IMPSCnnInstanceNormalizationDataSource This, NSZone? zone, IMTLDevice? device)
	{
		IMPSCnnInstanceNormalizationDataSource iNativeObject = Runtime.GetINativeObject<IMPSCnnInstanceNormalizationDataSource>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("copyWithZone:device:"), zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}
}
