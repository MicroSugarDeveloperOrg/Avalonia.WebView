using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSRNNMatrixTrainingLayer", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSRnnMatrixTrainingLayer : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccumulateWeightGradients = "accumulateWeightGradients";

	private static readonly IntPtr selAccumulateWeightGradientsHandle = Selector.GetHandle("accumulateWeightGradients");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_Device_ = "copyWithZone:device:";

	private static readonly IntPtr selCopyWithZone_Device_Handle = Selector.GetHandle("copyWithZone:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateTemporaryWeightGradientMatrices_DataType_CommandBuffer_ = "createTemporaryWeightGradientMatrices:dataType:commandBuffer:";

	private static readonly IntPtr selCreateTemporaryWeightGradientMatrices_DataType_CommandBuffer_Handle = Selector.GetHandle("createTemporaryWeightGradientMatrices:dataType:commandBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateWeightGradientMatrices_DataType_ = "createWeightGradientMatrices:dataType:";

	private static readonly IntPtr selCreateWeightGradientMatrices_DataType_Handle = Selector.GetHandle("createWeightGradientMatrices:dataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateWeightMatrices_ = "createWeightMatrices:";

	private static readonly IntPtr selCreateWeightMatrices_Handle = Selector.GetHandle("createWeightMatrices:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeCopyWeightsToCommandBuffer_Weights_MatrixId_Matrix_CopyFromWeightsToMatrix_MatrixOffset_ = "encodeCopyWeightsToCommandBuffer:weights:matrixId:matrix:copyFromWeightsToMatrix:matrixOffset:";

	private static readonly IntPtr selEncodeCopyWeightsToCommandBuffer_Weights_MatrixId_Matrix_CopyFromWeightsToMatrix_MatrixOffset_Handle = Selector.GetHandle("encodeCopyWeightsToCommandBuffer:weights:matrixId:matrix:copyFromWeightsToMatrix:matrixOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeForwardSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_TrainingStates_Weights_ = "encodeForwardSequenceToCommandBuffer:sourceMatrices:destinationMatrices:trainingStates:weights:";

	private static readonly IntPtr selEncodeForwardSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_TrainingStates_Weights_Handle = Selector.GetHandle("encodeForwardSequenceToCommandBuffer:sourceMatrices:destinationMatrices:trainingStates:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeForwardSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_ = "encodeForwardSequenceToCommandBuffer:sourceMatrices:sourceOffsets:destinationMatrices:destinationOffsets:trainingStates:recurrentInputState:recurrentOutputStates:weights:";

	private static readonly IntPtr selEncodeForwardSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_Handle = Selector.GetHandle("encodeForwardSequenceToCommandBuffer:sourceMatrices:sourceOffsets:destinationMatrices:destinationOffsets:trainingStates:recurrentInputState:recurrentOutputStates:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeGradientSequenceToCommandBuffer_ForwardSources_ForwardSourceOffsets_SourceGradients_SourceGradientOffsets_DestinationGradients_DestinationOffsets_WeightGradients_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_ = "encodeGradientSequenceToCommandBuffer:forwardSources:forwardSourceOffsets:sourceGradients:sourceGradientOffsets:destinationGradients:destinationOffsets:weightGradients:trainingStates:recurrentInputState:recurrentOutputStates:weights:";

	private static readonly IntPtr selEncodeGradientSequenceToCommandBuffer_ForwardSources_ForwardSourceOffsets_SourceGradients_SourceGradientOffsets_DestinationGradients_DestinationOffsets_WeightGradients_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_Handle = Selector.GetHandle("encodeGradientSequenceToCommandBuffer:forwardSources:forwardSourceOffsets:sourceGradients:sourceGradientOffsets:destinationGradients:destinationOffsets:weightGradients:trainingStates:recurrentInputState:recurrentOutputStates:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeGradientSequenceToCommandBuffer_ForwardSources_SourceGradients_DestinationGradients_WeightGradients_TrainingStates_Weights_ = "encodeGradientSequenceToCommandBuffer:forwardSources:sourceGradients:destinationGradients:weightGradients:trainingStates:weights:";

	private static readonly IntPtr selEncodeGradientSequenceToCommandBuffer_ForwardSources_SourceGradients_DestinationGradients_WeightGradients_TrainingStates_Weights_Handle = Selector.GetHandle("encodeGradientSequenceToCommandBuffer:forwardSources:sourceGradients:destinationGradients:weightGradients:trainingStates:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_RnnDescriptor_TrainableWeights_ = "initWithDevice:rnnDescriptor:trainableWeights:";

	private static readonly IntPtr selInitWithDevice_RnnDescriptor_TrainableWeights_Handle = Selector.GetHandle("initWithDevice:rnnDescriptor:trainableWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputFeatureChannels = "inputFeatureChannels";

	private static readonly IntPtr selInputFeatureChannelsHandle = Selector.GetHandle("inputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFeatureChannels = "outputFeatureChannels";

	private static readonly IntPtr selOutputFeatureChannelsHandle = Selector.GetHandle("outputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecurrentOutputIsTemporary = "recurrentOutputIsTemporary";

	private static readonly IntPtr selRecurrentOutputIsTemporaryHandle = Selector.GetHandle("recurrentOutputIsTemporary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccumulateWeightGradients_ = "setAccumulateWeightGradients:";

	private static readonly IntPtr selSetAccumulateWeightGradients_Handle = Selector.GetHandle("setAccumulateWeightGradients:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecurrentOutputIsTemporary_ = "setRecurrentOutputIsTemporary:";

	private static readonly IntPtr selSetRecurrentOutputIsTemporary_Handle = Selector.GetHandle("setRecurrentOutputIsTemporary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStoreAllIntermediateStates_ = "setStoreAllIntermediateStates:";

	private static readonly IntPtr selSetStoreAllIntermediateStates_Handle = Selector.GetHandle("setStoreAllIntermediateStates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTrainingStateIsTemporary_ = "setTrainingStateIsTemporary:";

	private static readonly IntPtr selSetTrainingStateIsTemporary_Handle = Selector.GetHandle("setTrainingStateIsTemporary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStoreAllIntermediateStates = "storeAllIntermediateStates";

	private static readonly IntPtr selStoreAllIntermediateStatesHandle = Selector.GetHandle("storeAllIntermediateStates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrainingStateIsTemporary = "trainingStateIsTemporary";

	private static readonly IntPtr selTrainingStateIsTemporaryHandle = Selector.GetHandle("trainingStateIsTemporary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSRNNMatrixTrainingLayer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccumulateWeightGradients
	{
		[Export("accumulateWeightGradients")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAccumulateWeightGradientsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccumulateWeightGradientsHandle);
		}
		[Export("setAccumulateWeightGradients:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccumulateWeightGradients_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccumulateWeightGradients_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint InputFeatureChannels
	{
		[Export("inputFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selInputFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selInputFeatureChannelsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint OutputFeatureChannels
	{
		[Export("outputFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selOutputFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selOutputFeatureChannelsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RecurrentOutputIsTemporary
	{
		[Export("recurrentOutputIsTemporary")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRecurrentOutputIsTemporaryHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRecurrentOutputIsTemporaryHandle);
		}
		[Export("setRecurrentOutputIsTemporary:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRecurrentOutputIsTemporary_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRecurrentOutputIsTemporary_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StoreAllIntermediateStates
	{
		[Export("storeAllIntermediateStates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selStoreAllIntermediateStatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStoreAllIntermediateStatesHandle);
		}
		[Export("setStoreAllIntermediateStates:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetStoreAllIntermediateStates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetStoreAllIntermediateStates_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TrainingStateIsTemporary
	{
		[Export("trainingStateIsTemporary")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTrainingStateIsTemporaryHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTrainingStateIsTemporaryHandle);
		}
		[Export("setTrainingStateIsTemporary:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTrainingStateIsTemporary_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTrainingStateIsTemporary_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSRnnMatrixTrainingLayer(NSCoder coder)
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
	protected MPSRnnMatrixTrainingLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSRnnMatrixTrainingLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:rnnDescriptor:trainableWeights:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRnnMatrixTrainingLayer(IMTLDevice device, MPSRnnDescriptor rnnDescriptor, NSMutableArray<MPSMatrix> trainableWeights)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (rnnDescriptor == null)
		{
			throw new ArgumentNullException("rnnDescriptor");
		}
		if (trainableWeights == null)
		{
			throw new ArgumentNullException("trainableWeights");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithDevice_RnnDescriptor_TrainableWeights_Handle, device.Handle, rnnDescriptor.Handle, trainableWeights.Handle), "initWithDevice:rnnDescriptor:trainableWeights:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_RnnDescriptor_TrainableWeights_Handle, device.Handle, rnnDescriptor.Handle, trainableWeights.Handle), "initWithDevice:rnnDescriptor:trainableWeights:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRnnMatrixTrainingLayer(NSCoder decoder, IMTLDevice device)
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

	[Export("copyWithZone:device:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual MPSRnnMatrixTrainingLayer Copy(NSZone? zone, IMTLDevice? device)
	{
		MPSRnnMatrixTrainingLayer mPSRnnMatrixTrainingLayer = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSRnnMatrixTrainingLayer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<MPSRnnMatrixTrainingLayer>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)));
		if (mPSRnnMatrixTrainingLayer != null)
		{
			Messaging.void_objc_msgSend(mPSRnnMatrixTrainingLayer.Handle, Selector.GetHandle("release"));
		}
		return mPSRnnMatrixTrainingLayer;
	}

	[Export("createTemporaryWeightGradientMatrices:dataType:commandBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CreateTemporaryWeightGradientMatrices(NSMutableArray<MPSMatrix> matrices, MPSDataType dataType, IMTLCommandBuffer commandBuffer)
	{
		if (matrices == null)
		{
			throw new ArgumentNullException("matrices");
		}
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr(base.Handle, selCreateTemporaryWeightGradientMatrices_DataType_CommandBuffer_Handle, matrices.Handle, (uint)dataType, commandBuffer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32_IntPtr(base.SuperHandle, selCreateTemporaryWeightGradientMatrices_DataType_CommandBuffer_Handle, matrices.Handle, (uint)dataType, commandBuffer.Handle);
		}
	}

	[Export("createWeightGradientMatrices:dataType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CreateWeightGradientMatrices(NSMutableArray<MPSMatrix> matrices, MPSDataType dataType)
	{
		if (matrices == null)
		{
			throw new ArgumentNullException("matrices");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32(base.Handle, selCreateWeightGradientMatrices_DataType_Handle, matrices.Handle, (uint)dataType);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selCreateWeightGradientMatrices_DataType_Handle, matrices.Handle, (uint)dataType);
		}
	}

	[Export("createWeightMatrices:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CreateWeightMatrices(NSMutableArray<MPSMatrix> matrices)
	{
		if (matrices == null)
		{
			throw new ArgumentNullException("matrices");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCreateWeightMatrices_Handle, matrices.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateWeightMatrices_Handle, matrices.Handle);
		}
	}

	[Export("encodeCopyWeightsToCommandBuffer:weights:matrixId:matrix:copyFromWeightsToMatrix:matrixOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeCopyWeights(IMTLCommandBuffer commandBuffer, MPSMatrix[] weights, MPSRnnMatrixId matrixId, MPSMatrix matrix, bool copyFromWeightsToMatrix, MTLOrigin matrixOffset)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		if (matrix == null)
		{
			throw new ArgumentNullException("matrix");
		}
		NSArray nSArray = NSArray.FromNSObjects(weights);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_bool_MTLOrigin(base.Handle, selEncodeCopyWeightsToCommandBuffer_Weights_MatrixId_Matrix_CopyFromWeightsToMatrix_MatrixOffset_Handle, commandBuffer.Handle, nSArray.Handle, (ulong)matrixId, matrix.Handle, copyFromWeightsToMatrix, matrixOffset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_bool_MTLOrigin(base.SuperHandle, selEncodeCopyWeightsToCommandBuffer_Weights_MatrixId_Matrix_CopyFromWeightsToMatrix_MatrixOffset_Handle, commandBuffer.Handle, nSArray.Handle, (ulong)matrixId, matrix.Handle, copyFromWeightsToMatrix, matrixOffset);
		}
		nSArray.Dispose();
	}

	[Export("encodeForwardSequenceToCommandBuffer:sourceMatrices:sourceOffsets:destinationMatrices:destinationOffsets:trainingStates:recurrentInputState:recurrentOutputStates:weights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeForwardSequence(IMTLCommandBuffer commandBuffer, MPSMatrix[] sourceMatrices, IntPtr sourceOffsets, MPSMatrix[] destinationMatrices, IntPtr destinationOffsets, NSMutableArray<MPSRnnMatrixTrainingState> trainingStates, MPSRnnRecurrentMatrixState? recurrentInputState, NSMutableArray<MPSRnnRecurrentMatrixState>? recurrentOutputStates, MPSMatrix[] weights)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceMatrices == null)
		{
			throw new ArgumentNullException("sourceMatrices");
		}
		if (destinationMatrices == null)
		{
			throw new ArgumentNullException("destinationMatrices");
		}
		if (trainingStates == null)
		{
			throw new ArgumentNullException("trainingStates");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceMatrices);
		NSArray nSArray2 = NSArray.FromNSObjects(destinationMatrices);
		NSArray nSArray3 = NSArray.FromNSObjects(weights);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeForwardSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_Handle, commandBuffer.Handle, nSArray.Handle, sourceOffsets, nSArray2.Handle, destinationOffsets, trainingStates.Handle, recurrentInputState?.Handle ?? IntPtr.Zero, recurrentOutputStates?.Handle ?? IntPtr.Zero, nSArray3.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeForwardSequenceToCommandBuffer_SourceMatrices_SourceOffsets_DestinationMatrices_DestinationOffsets_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_Handle, commandBuffer.Handle, nSArray.Handle, sourceOffsets, nSArray2.Handle, destinationOffsets, trainingStates.Handle, recurrentInputState?.Handle ?? IntPtr.Zero, recurrentOutputStates?.Handle ?? IntPtr.Zero, nSArray3.Handle);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		nSArray3.Dispose();
	}

	[Export("encodeForwardSequenceToCommandBuffer:sourceMatrices:destinationMatrices:trainingStates:weights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeForwardSequence(IMTLCommandBuffer commandBuffer, MPSMatrix[] sourceMatrices, MPSMatrix[] destinationMatrices, NSMutableArray<MPSRnnMatrixTrainingState> trainingStates, MPSMatrix[] weights)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceMatrices == null)
		{
			throw new ArgumentNullException("sourceMatrices");
		}
		if (destinationMatrices == null)
		{
			throw new ArgumentNullException("destinationMatrices");
		}
		if (trainingStates == null)
		{
			throw new ArgumentNullException("trainingStates");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceMatrices);
		NSArray nSArray2 = NSArray.FromNSObjects(destinationMatrices);
		NSArray nSArray3 = NSArray.FromNSObjects(weights);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeForwardSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_TrainingStates_Weights_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2.Handle, trainingStates.Handle, nSArray3.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeForwardSequenceToCommandBuffer_SourceMatrices_DestinationMatrices_TrainingStates_Weights_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2.Handle, trainingStates.Handle, nSArray3.Handle);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		nSArray3.Dispose();
	}

	[Export("encodeGradientSequenceToCommandBuffer:forwardSources:forwardSourceOffsets:sourceGradients:sourceGradientOffsets:destinationGradients:destinationOffsets:weightGradients:trainingStates:recurrentInputState:recurrentOutputStates:weights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeGradientSequence(IMTLCommandBuffer commandBuffer, MPSMatrix[] forwardSources, IntPtr forwardSourceOffsets, MPSMatrix[] sourceGradients, IntPtr sourceGradientOffsets, MPSMatrix[]? destinationGradients, IntPtr destinationOffsets, MPSMatrix[]? weightGradients, MPSRnnMatrixTrainingState[] trainingStates, MPSRnnRecurrentMatrixState? recurrentInputState, NSMutableArray<MPSRnnRecurrentMatrixState>? recurrentOutputStates, MPSMatrix[] weights)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (forwardSources == null)
		{
			throw new ArgumentNullException("forwardSources");
		}
		if (sourceGradients == null)
		{
			throw new ArgumentNullException("sourceGradients");
		}
		if (trainingStates == null)
		{
			throw new ArgumentNullException("trainingStates");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		NSArray nSArray = NSArray.FromNSObjects(forwardSources);
		NSArray nSArray2 = NSArray.FromNSObjects(sourceGradients);
		NSArray nSArray3 = ((destinationGradients == null) ? null : NSArray.FromNSObjects(destinationGradients));
		NSArray nSArray4 = ((weightGradients == null) ? null : NSArray.FromNSObjects(weightGradients));
		NSArray nSArray5 = NSArray.FromNSObjects(trainingStates);
		NSArray nSArray6 = NSArray.FromNSObjects(weights);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeGradientSequenceToCommandBuffer_ForwardSources_ForwardSourceOffsets_SourceGradients_SourceGradientOffsets_DestinationGradients_DestinationOffsets_WeightGradients_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_Handle, commandBuffer.Handle, nSArray.Handle, forwardSourceOffsets, nSArray2.Handle, sourceGradientOffsets, nSArray3?.Handle ?? IntPtr.Zero, destinationOffsets, nSArray4?.Handle ?? IntPtr.Zero, nSArray5.Handle, recurrentInputState?.Handle ?? IntPtr.Zero, recurrentOutputStates?.Handle ?? IntPtr.Zero, nSArray6.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeGradientSequenceToCommandBuffer_ForwardSources_ForwardSourceOffsets_SourceGradients_SourceGradientOffsets_DestinationGradients_DestinationOffsets_WeightGradients_TrainingStates_RecurrentInputState_RecurrentOutputStates_Weights_Handle, commandBuffer.Handle, nSArray.Handle, forwardSourceOffsets, nSArray2.Handle, sourceGradientOffsets, nSArray3?.Handle ?? IntPtr.Zero, destinationOffsets, nSArray4?.Handle ?? IntPtr.Zero, nSArray5.Handle, recurrentInputState?.Handle ?? IntPtr.Zero, recurrentOutputStates?.Handle ?? IntPtr.Zero, nSArray6.Handle);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		nSArray3?.Dispose();
		nSArray4?.Dispose();
		nSArray5.Dispose();
		nSArray6.Dispose();
	}

	[Export("encodeGradientSequenceToCommandBuffer:forwardSources:sourceGradients:destinationGradients:weightGradients:trainingStates:weights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeGradientSequence(IMTLCommandBuffer commandBuffer, MPSMatrix[] forwardSources, MPSMatrix[] sourceGradients, MPSMatrix[]? destinationGradients, MPSMatrix[]? weightGradients, MPSRnnMatrixTrainingState[] trainingStates, MPSMatrix[] weights)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (forwardSources == null)
		{
			throw new ArgumentNullException("forwardSources");
		}
		if (sourceGradients == null)
		{
			throw new ArgumentNullException("sourceGradients");
		}
		if (trainingStates == null)
		{
			throw new ArgumentNullException("trainingStates");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		NSArray nSArray = NSArray.FromNSObjects(forwardSources);
		NSArray nSArray2 = NSArray.FromNSObjects(sourceGradients);
		NSArray nSArray3 = ((destinationGradients == null) ? null : NSArray.FromNSObjects(destinationGradients));
		NSArray nSArray4 = ((weightGradients == null) ? null : NSArray.FromNSObjects(weightGradients));
		NSArray nSArray5 = NSArray.FromNSObjects(trainingStates);
		NSArray nSArray6 = NSArray.FromNSObjects(weights);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeGradientSequenceToCommandBuffer_ForwardSources_SourceGradients_DestinationGradients_WeightGradients_TrainingStates_Weights_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2.Handle, nSArray3?.Handle ?? IntPtr.Zero, nSArray4?.Handle ?? IntPtr.Zero, nSArray5.Handle, nSArray6.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeGradientSequenceToCommandBuffer_ForwardSources_SourceGradients_DestinationGradients_WeightGradients_TrainingStates_Weights_Handle, commandBuffer.Handle, nSArray.Handle, nSArray2.Handle, nSArray3?.Handle ?? IntPtr.Zero, nSArray4?.Handle ?? IntPtr.Zero, nSArray5.Handle, nSArray6.Handle);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		nSArray3?.Dispose();
		nSArray4?.Dispose();
		nSArray5.Dispose();
		nSArray6.Dispose();
	}
}
