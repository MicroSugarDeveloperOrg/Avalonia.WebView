using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNBatchNormalizationGradient", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnBatchNormalizationGradient : MPSCnnGradientKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_ = "encodeBatchToCommandBuffer:sourceGradients:sourceImages:batchNormalizationState:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceGradients:sourceImages:batchNormalizationState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_DestinationGradients_ = "encodeBatchToCommandBuffer:sourceGradients:sourceImages:batchNormalizationState:destinationGradients:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_DestinationGradients_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceGradients:sourceImages:batchNormalizationState:destinationGradients:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceGradient_SourceImage_BatchNormalizationState_ = "encodeToCommandBuffer:sourceGradient:sourceImage:batchNormalizationState:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceGradient_SourceImage_BatchNormalizationState_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceGradient:sourceImage:batchNormalizationState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceGradient_SourceImage_BatchNormalizationState_DestinationGradient_ = "encodeToCommandBuffer:sourceGradient:sourceImage:batchNormalizationState:destinationGradient:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceGradient_SourceImage_BatchNormalizationState_DestinationGradient_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceGradient:sourceImage:batchNormalizationState:destinationGradient:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_FusedNeuronDescriptor_ = "initWithDevice:fusedNeuronDescriptor:";

	private static readonly IntPtr selInitWithDevice_FusedNeuronDescriptor_Handle = Selector.GetHandle("initWithDevice:fusedNeuronDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNBatchNormalizationGradient");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnBatchNormalizationGradient(NSCoder coder)
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
	protected MPSCnnBatchNormalizationGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnBatchNormalizationGradient(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:fusedNeuronDescriptor:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBatchNormalizationGradient(IMTLDevice device, MPSNNNeuronDescriptor? fusedNeuronDescriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_FusedNeuronDescriptor_Handle, device.Handle, fusedNeuronDescriptor?.Handle ?? IntPtr.Zero), "initWithDevice:fusedNeuronDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_FusedNeuronDescriptor_Handle, device.Handle, fusedNeuronDescriptor?.Handle ?? IntPtr.Zero), "initWithDevice:fusedNeuronDescriptor:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBatchNormalizationGradient(NSCoder decoder, IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (decoder == null)
		{
			throw new ArgumentNullException("decoder");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Device_Handle, decoder.Handle, device.Handle), "initWithCoder:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Device_Handle, decoder.Handle, device.Handle), "initWithCoder:device:");
		}
	}

	[Export("encodeToCommandBuffer:sourceGradient:sourceImage:batchNormalizationState:destinationGradient:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSImage sourceGradient, MPSImage sourceImage, MPSCnnBatchNormalizationState batchNormalizationState, MPSImage destinationGradient)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (batchNormalizationState == null)
		{
			throw new ArgumentNullException("batchNormalizationState");
		}
		if (destinationGradient == null)
		{
			throw new ArgumentNullException("destinationGradient");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceGradient_SourceImage_BatchNormalizationState_DestinationGradient_Handle, commandBuffer.Handle, sourceGradient.Handle, sourceImage.Handle, batchNormalizationState.Handle, destinationGradient.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceGradient_SourceImage_BatchNormalizationState_DestinationGradient_Handle, commandBuffer.Handle, sourceGradient.Handle, sourceImage.Handle, batchNormalizationState.Handle, destinationGradient.Handle);
		}
	}

	[Export("encodeToCommandBuffer:sourceGradient:sourceImage:batchNormalizationState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage Encode(IMTLCommandBuffer commandBuffer, MPSImage sourceGradient, MPSImage sourceImage, MPSCnnBatchNormalizationState batchNormalizationState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (batchNormalizationState == null)
		{
			throw new ArgumentNullException("batchNormalizationState");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceGradient_SourceImage_BatchNormalizationState_Handle, commandBuffer.Handle, sourceGradient.Handle, sourceImage.Handle, batchNormalizationState.Handle));
		}
		return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceGradient_SourceImage_BatchNormalizationState_Handle, commandBuffer.Handle, sourceGradient.Handle, sourceImage.Handle, batchNormalizationState.Handle));
	}

	[Export("encodeBatchToCommandBuffer:sourceGradients:sourceImages:batchNormalizationState:destinationGradients:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceGradients, NSArray<MPSImage> sourceImages, MPSCnnBatchNormalizationState batchNormalizationState, NSArray<MPSImage> destinationGradients)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceGradients == null)
		{
			throw new ArgumentNullException("sourceGradients");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (batchNormalizationState == null)
		{
			throw new ArgumentNullException("batchNormalizationState");
		}
		if (destinationGradients == null)
		{
			throw new ArgumentNullException("destinationGradients");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_DestinationGradients_Handle, commandBuffer.Handle, sourceGradients.Handle, sourceImages.Handle, batchNormalizationState.Handle, destinationGradients.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_DestinationGradients_Handle, commandBuffer.Handle, sourceGradients.Handle, sourceImages.Handle, batchNormalizationState.Handle, destinationGradients.Handle);
		}
	}

	[Export("encodeBatchToCommandBuffer:sourceGradients:sourceImages:batchNormalizationState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray<MPSImage> EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceGradients, NSArray<MPSImage> sourceImages, MPSCnnBatchNormalizationState batchNormalizationState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceGradients == null)
		{
			throw new ArgumentNullException("sourceGradients");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (batchNormalizationState == null)
		{
			throw new ArgumentNullException("batchNormalizationState");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_Handle, commandBuffer.Handle, sourceGradients.Handle, sourceImages.Handle, batchNormalizationState.Handle));
		}
		return Runtime.GetNSObject<NSArray<MPSImage>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_Handle, commandBuffer.Handle, sourceGradients.Handle, sourceImages.Handle, batchNormalizationState.Handle));
	}
}
