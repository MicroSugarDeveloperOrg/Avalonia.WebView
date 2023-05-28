using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNBatchNormalizationStatisticsGradient", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnBatchNormalizationStatisticsGradient : MPSCnnGradientKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_ = "encodeBatchToCommandBuffer:sourceGradients:sourceImages:batchNormalizationState:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceGradients:sourceImages:batchNormalizationState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_FusedNeuronDescriptor_ = "initWithDevice:fusedNeuronDescriptor:";

	private static readonly IntPtr selInitWithDevice_FusedNeuronDescriptor_Handle = Selector.GetHandle("initWithDevice:fusedNeuronDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNBatchNormalizationStatisticsGradient");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnBatchNormalizationStatisticsGradient(NSCoder coder)
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
	protected MPSCnnBatchNormalizationStatisticsGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnBatchNormalizationStatisticsGradient(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:fusedNeuronDescriptor:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBatchNormalizationStatisticsGradient(IMTLDevice device, MPSNNNeuronDescriptor? fusedNeuronDescriptor)
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
	public MPSCnnBatchNormalizationStatisticsGradient(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeBatchToCommandBuffer:sourceGradients:sourceImages:batchNormalizationState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceGradients, NSArray<MPSImage> sourceImages, MPSCnnBatchNormalizationState batchNormalizationState)
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_Handle, commandBuffer.Handle, sourceGradients.Handle, sourceImages.Handle, batchNormalizationState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceGradients_SourceImages_BatchNormalizationState_Handle, commandBuffer.Handle, sourceGradients.Handle, sourceImages.Handle, batchNormalizationState.Handle);
		}
	}
}
