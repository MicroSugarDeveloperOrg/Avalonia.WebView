using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNBatchNormalization", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnBatchNormalization : MPSCnnKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBatchToCommandBuffer_SourceImages_BatchNormalizationState_DestinationImages_ = "encodeBatchToCommandBuffer:sourceImages:batchNormalizationState:destinationImages:";

	private static readonly IntPtr selEncodeBatchToCommandBuffer_SourceImages_BatchNormalizationState_DestinationImages_Handle = Selector.GetHandle("encodeBatchToCommandBuffer:sourceImages:batchNormalizationState:destinationImages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_BatchNormalizationState_DestinationImage_ = "encodeToCommandBuffer:sourceImage:batchNormalizationState:destinationImage:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_BatchNormalizationState_DestinationImage_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:batchNormalizationState:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEpsilon = "epsilon";

	private static readonly IntPtr selEpsilonHandle = Selector.GetHandle("epsilon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_DataSource_ = "initWithDevice:dataSource:";

	private static readonly IntPtr selInitWithDevice_DataSource_Handle = Selector.GetHandle("initWithDevice:dataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_DataSource_FusedNeuronDescriptor_ = "initWithDevice:dataSource:fusedNeuronDescriptor:";

	private static readonly IntPtr selInitWithDevice_DataSource_FusedNeuronDescriptor_Handle = Selector.GetHandle("initWithDevice:dataSource:fusedNeuronDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfFeatureChannels = "numberOfFeatureChannels";

	private static readonly IntPtr selNumberOfFeatureChannelsHandle = Selector.GetHandle("numberOfFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadGammaAndBetaFromDataSource = "reloadGammaAndBetaFromDataSource";

	private static readonly IntPtr selReloadGammaAndBetaFromDataSourceHandle = Selector.GetHandle("reloadGammaAndBetaFromDataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadGammaAndBetaWithCommandBuffer_GammaAndBetaState_ = "reloadGammaAndBetaWithCommandBuffer:gammaAndBetaState:";

	private static readonly IntPtr selReloadGammaAndBetaWithCommandBuffer_GammaAndBetaState_Handle = Selector.GetHandle("reloadGammaAndBetaWithCommandBuffer:gammaAndBetaState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadMeanAndVarianceFromDataSource = "reloadMeanAndVarianceFromDataSource";

	private static readonly IntPtr selReloadMeanAndVarianceFromDataSourceHandle = Selector.GetHandle("reloadMeanAndVarianceFromDataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadMeanAndVarianceWithCommandBuffer_MeanAndVarianceState_ = "reloadMeanAndVarianceWithCommandBuffer:meanAndVarianceState:";

	private static readonly IntPtr selReloadMeanAndVarianceWithCommandBuffer_MeanAndVarianceState_Handle = Selector.GetHandle("reloadMeanAndVarianceWithCommandBuffer:meanAndVarianceState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultStateForSourceImage_SourceStates_DestinationImage_ = "resultStateForSourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selResultStateForSourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("resultStateForSourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEpsilon_ = "setEpsilon:";

	private static readonly IntPtr selSetEpsilon_Handle = Selector.GetHandle("setEpsilon:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_ = "temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNBatchNormalization");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnBatchNormalizationDataSource DataSource
	{
		[Export("dataSource", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnBatchNormalizationDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnBatchNormalizationDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle), owns: false);
		}
	}

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
	public virtual nuint NumberOfFeatureChannels
	{
		[Export("numberOfFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfFeatureChannelsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnBatchNormalization(NSCoder coder)
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
	protected MPSCnnBatchNormalization(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnBatchNormalization(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:dataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBatchNormalization(IMTLDevice device, IMPSCnnBatchNormalizationDataSource dataSource)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_DataSource_Handle, device.Handle, dataSource.Handle), "initWithDevice:dataSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_DataSource_Handle, device.Handle, dataSource.Handle), "initWithDevice:dataSource:");
		}
	}

	[Export("initWithDevice:dataSource:fusedNeuronDescriptor:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBatchNormalization(IMTLDevice device, IMPSCnnBatchNormalizationDataSource dataSource, MPSNNNeuronDescriptor? fusedNeuronDescriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithDevice_DataSource_FusedNeuronDescriptor_Handle, device.Handle, dataSource.Handle, fusedNeuronDescriptor?.Handle ?? IntPtr.Zero), "initWithDevice:dataSource:fusedNeuronDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_DataSource_FusedNeuronDescriptor_Handle, device.Handle, dataSource.Handle, fusedNeuronDescriptor?.Handle ?? IntPtr.Zero), "initWithDevice:dataSource:fusedNeuronDescriptor:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBatchNormalization(NSCoder decoder, IMTLDevice device)
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

	[Export("encodeToCommandBuffer:sourceImage:batchNormalizationState:destinationImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnBatchNormalizationState batchNormalizationState, MPSImage destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (batchNormalizationState == null)
		{
			throw new ArgumentNullException("batchNormalizationState");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_BatchNormalizationState_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, batchNormalizationState.Handle, destinationImage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_BatchNormalizationState_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, batchNormalizationState.Handle, destinationImage.Handle);
		}
	}

	[Export("encodeBatchToCommandBuffer:sourceImages:batchNormalizationState:destinationImages:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImages, MPSCnnBatchNormalizationState batchNormalizationState, NSArray<MPSImage> destinationImages)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (batchNormalizationState == null)
		{
			throw new ArgumentNullException("batchNormalizationState");
		}
		if (destinationImages == null)
		{
			throw new ArgumentNullException("destinationImages");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeBatchToCommandBuffer_SourceImages_BatchNormalizationState_DestinationImages_Handle, commandBuffer.Handle, sourceImages.Handle, batchNormalizationState.Handle, destinationImages.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeBatchToCommandBuffer_SourceImages_BatchNormalizationState_DestinationImages_Handle, commandBuffer.Handle, sourceImages.Handle, batchNormalizationState.Handle, destinationImages.Handle);
		}
	}

	[Export("resultStateForSourceImage:sourceStates:destinationImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSCnnBatchNormalizationState? GetResultState(MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
	{
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSCnnBatchNormalizationState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selResultStateForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
		}
		return Runtime.GetNSObject<MPSCnnBatchNormalizationState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selResultStateForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
	}

	[Export("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSCnnBatchNormalizationState? GetTemporaryResultState(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSCnnBatchNormalizationState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
		}
		return Runtime.GetNSObject<MPSCnnBatchNormalizationState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
	}

	[Export("reloadGammaAndBetaWithCommandBuffer:gammaAndBetaState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadGammaAndBeta(IMTLCommandBuffer commandBuffer, MPSCnnNormalizationGammaAndBetaState gammaAndBetaState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (gammaAndBetaState == null)
		{
			throw new ArgumentNullException("gammaAndBetaState");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReloadGammaAndBetaWithCommandBuffer_GammaAndBetaState_Handle, commandBuffer.Handle, gammaAndBetaState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReloadGammaAndBetaWithCommandBuffer_GammaAndBetaState_Handle, commandBuffer.Handle, gammaAndBetaState.Handle);
		}
	}

	[Export("reloadGammaAndBetaFromDataSource")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadGammaAndBetaFromDataSource()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadGammaAndBetaFromDataSourceHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadGammaAndBetaFromDataSourceHandle);
		}
	}

	[Export("reloadMeanAndVarianceWithCommandBuffer:meanAndVarianceState:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadMeanAndVariance(IMTLCommandBuffer commandBuffer, MPSCnnNormalizationMeanAndVarianceState meanAndVarianceState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (meanAndVarianceState == null)
		{
			throw new ArgumentNullException("meanAndVarianceState");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReloadMeanAndVarianceWithCommandBuffer_MeanAndVarianceState_Handle, commandBuffer.Handle, meanAndVarianceState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReloadMeanAndVarianceWithCommandBuffer_MeanAndVarianceState_Handle, commandBuffer.Handle, meanAndVarianceState.Handle);
		}
	}

	[Export("reloadMeanAndVarianceFromDataSource")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadMeanAndVarianceFromDataSource()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadMeanAndVarianceFromDataSourceHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadMeanAndVarianceFromDataSourceHandle);
		}
	}
}
