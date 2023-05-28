using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSImageGuidedFilter", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSImageGuidedFilter : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeReconstructionToCommandBuffer_GuidanceTexture_CoefficientsTexture_DestinationTexture_ = "encodeReconstructionToCommandBuffer:guidanceTexture:coefficientsTexture:destinationTexture:";

	private static readonly IntPtr selEncodeReconstructionToCommandBuffer_GuidanceTexture_CoefficientsTexture_DestinationTexture_Handle = Selector.GetHandle("encodeReconstructionToCommandBuffer:guidanceTexture:coefficientsTexture:destinationTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeRegressionToCommandBuffer_SourceTexture_GuidanceTexture_WeightsTexture_DestinationCoefficientsTexture_ = "encodeRegressionToCommandBuffer:sourceTexture:guidanceTexture:weightsTexture:destinationCoefficientsTexture:";

	private static readonly IntPtr selEncodeRegressionToCommandBuffer_SourceTexture_GuidanceTexture_WeightsTexture_DestinationCoefficientsTexture_Handle = Selector.GetHandle("encodeRegressionToCommandBuffer:sourceTexture:guidanceTexture:weightsTexture:destinationCoefficientsTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEpsilon = "epsilon";

	private static readonly IntPtr selEpsilonHandle = Selector.GetHandle("epsilon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_KernelDiameter_ = "initWithDevice:kernelDiameter:";

	private static readonly IntPtr selInitWithDevice_KernelDiameter_Handle = Selector.GetHandle("initWithDevice:kernelDiameter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelDiameter = "kernelDiameter";

	private static readonly IntPtr selKernelDiameterHandle = Selector.GetHandle("kernelDiameter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReconstructOffset = "reconstructOffset";

	private static readonly IntPtr selReconstructOffsetHandle = Selector.GetHandle("reconstructOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReconstructScale = "reconstructScale";

	private static readonly IntPtr selReconstructScaleHandle = Selector.GetHandle("reconstructScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEpsilon_ = "setEpsilon:";

	private static readonly IntPtr selSetEpsilon_Handle = Selector.GetHandle("setEpsilon:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReconstructOffset_ = "setReconstructOffset:";

	private static readonly IntPtr selSetReconstructOffset_Handle = Selector.GetHandle("setReconstructOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReconstructScale_ = "setReconstructScale:";

	private static readonly IntPtr selSetReconstructScale_Handle = Selector.GetHandle("setReconstructScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageGuidedFilter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Epsilon
	{
		[Export("epsilon")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selEpsilonHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selEpsilonHandle);
		}
		[Export("setEpsilon:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetEpsilon_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetEpsilon_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint KernelDiameter
	{
		[Export("kernelDiameter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selKernelDiameterHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selKernelDiameterHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ReconstructOffset
	{
		[Export("reconstructOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selReconstructOffsetHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selReconstructOffsetHandle);
		}
		[Export("setReconstructOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetReconstructOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetReconstructOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ReconstructScale
	{
		[Export("reconstructScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selReconstructScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selReconstructScaleHandle);
		}
		[Export("setReconstructScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetReconstructScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetReconstructScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSImageGuidedFilter(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSImageGuidedFilter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageGuidedFilter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:kernelDiameter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageGuidedFilter(IMTLDevice device, nuint kernelDiameter)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selInitWithDevice_KernelDiameter_Handle, device.Handle, kernelDiameter), "initWithDevice:kernelDiameter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selInitWithDevice_KernelDiameter_Handle, device.Handle, kernelDiameter), "initWithDevice:kernelDiameter:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageGuidedFilter(NSCoder aDecoder, IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (aDecoder == null)
		{
			throw new ArgumentNullException("aDecoder");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
	}

	[Export("encodeReconstructionToCommandBuffer:guidanceTexture:coefficientsTexture:destinationTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeReconstruction(IMTLCommandBuffer commandBuffer, IMTLTexture guidanceTexture, IMTLTexture coefficientsTexture, IMTLTexture destinationTexture)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (guidanceTexture == null)
		{
			throw new ArgumentNullException("guidanceTexture");
		}
		if (coefficientsTexture == null)
		{
			throw new ArgumentNullException("coefficientsTexture");
		}
		if (destinationTexture == null)
		{
			throw new ArgumentNullException("destinationTexture");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeReconstructionToCommandBuffer_GuidanceTexture_CoefficientsTexture_DestinationTexture_Handle, commandBuffer.Handle, guidanceTexture.Handle, coefficientsTexture.Handle, destinationTexture.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeReconstructionToCommandBuffer_GuidanceTexture_CoefficientsTexture_DestinationTexture_Handle, commandBuffer.Handle, guidanceTexture.Handle, coefficientsTexture.Handle, destinationTexture.Handle);
		}
	}

	[Export("encodeRegressionToCommandBuffer:sourceTexture:guidanceTexture:weightsTexture:destinationCoefficientsTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeRegression(IMTLCommandBuffer commandBuffer, IMTLTexture sourceTexture, IMTLTexture guidanceTexture, IMTLTexture? weightsTexture, IMTLTexture destinationCoefficientsTexture)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceTexture == null)
		{
			throw new ArgumentNullException("sourceTexture");
		}
		if (guidanceTexture == null)
		{
			throw new ArgumentNullException("guidanceTexture");
		}
		if (destinationCoefficientsTexture == null)
		{
			throw new ArgumentNullException("destinationCoefficientsTexture");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeRegressionToCommandBuffer_SourceTexture_GuidanceTexture_WeightsTexture_DestinationCoefficientsTexture_Handle, commandBuffer.Handle, sourceTexture.Handle, guidanceTexture.Handle, weightsTexture?.Handle ?? IntPtr.Zero, destinationCoefficientsTexture.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeRegressionToCommandBuffer_SourceTexture_GuidanceTexture_WeightsTexture_DestinationCoefficientsTexture_Handle, commandBuffer.Handle, sourceTexture.Handle, guidanceTexture.Handle, weightsTexture?.Handle ?? IntPtr.Zero, destinationCoefficientsTexture.Handle);
		}
	}
}
