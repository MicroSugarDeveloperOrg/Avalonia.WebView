using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNOptimizerRMSProp", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSNNOptimizerRmsProp : MPSNNOptimizer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecay = "decay";

	private static readonly IntPtr selDecayHandle = Selector.GetHandle("decay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputSumOfSquaresVectors_ResultState_ = "encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputSumOfSquaresVectors:resultState:";

	private static readonly IntPtr selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputSumOfSquaresVectors_ResultState_Handle = Selector.GetHandle("encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputSumOfSquaresVectors:resultState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_BatchNormalizationState_InputSumOfSquaresVectors_ResultState_ = "encodeToCommandBuffer:batchNormalizationState:inputSumOfSquaresVectors:resultState:";

	private static readonly IntPtr selEncodeToCommandBuffer_BatchNormalizationState_InputSumOfSquaresVectors_ResultState_Handle = Selector.GetHandle("encodeToCommandBuffer:batchNormalizationState:inputSumOfSquaresVectors:resultState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputSumOfSquaresVectors_ResultState_ = "encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputSumOfSquaresVectors:resultState:";

	private static readonly IntPtr selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputSumOfSquaresVectors_ResultState_Handle = Selector.GetHandle("encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputSumOfSquaresVectors:resultState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputSumOfSquaresVector_ResultValuesVector_ = "encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputSumOfSquaresVector:resultValuesVector:";

	private static readonly IntPtr selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputSumOfSquaresVector_ResultValuesVector_Handle = Selector.GetHandle("encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputSumOfSquaresVector:resultValuesVector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEpsilon = "epsilon";

	private static readonly IntPtr selEpsilonHandle = Selector.GetHandle("epsilon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Decay_Epsilon_OptimizerDescriptor_ = "initWithDevice:decay:epsilon:optimizerDescriptor:";

	private static readonly IntPtr selInitWithDevice_Decay_Epsilon_OptimizerDescriptor_Handle = Selector.GetHandle("initWithDevice:decay:epsilon:optimizerDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_LearningRate_ = "initWithDevice:learningRate:";

	private static readonly IntPtr selInitWithDevice_LearningRate_Handle = Selector.GetHandle("initWithDevice:learningRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNOptimizerRMSProp");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Decay
	{
		[Export("decay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDecayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDecayHandle);
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSNNOptimizerRmsProp(NSCoder coder)
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
	protected MPSNNOptimizerRmsProp(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNOptimizerRmsProp(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:learningRate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNOptimizerRmsProp(IMTLDevice device, float learningRate)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float(base.Handle, selInitWithDevice_LearningRate_Handle, device.Handle, learningRate), "initWithDevice:learningRate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selInitWithDevice_LearningRate_Handle, device.Handle, learningRate), "initWithDevice:learningRate:");
		}
	}

	[Export("initWithDevice:decay:epsilon:optimizerDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNOptimizerRmsProp(IMTLDevice device, double decay, float epsilon, MPSNNOptimizerDescriptor optimizerDescriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (optimizerDescriptor == null)
		{
			throw new ArgumentNullException("optimizerDescriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Double_float_IntPtr(base.Handle, selInitWithDevice_Decay_Epsilon_OptimizerDescriptor_Handle, device.Handle, decay, epsilon, optimizerDescriptor.Handle), "initWithDevice:decay:epsilon:optimizerDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double_float_IntPtr(base.SuperHandle, selInitWithDevice_Decay_Epsilon_OptimizerDescriptor_Handle, device.Handle, decay, epsilon, optimizerDescriptor.Handle), "initWithDevice:decay:epsilon:optimizerDescriptor:");
		}
	}

	[Export("encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputSumOfSquaresVector:resultValuesVector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSVector inputGradientVector, MPSVector inputValuesVector, MPSVector inputSumOfSquaresVector, MPSVector resultValuesVector)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (inputGradientVector == null)
		{
			throw new ArgumentNullException("inputGradientVector");
		}
		if (inputValuesVector == null)
		{
			throw new ArgumentNullException("inputValuesVector");
		}
		if (inputSumOfSquaresVector == null)
		{
			throw new ArgumentNullException("inputSumOfSquaresVector");
		}
		if (resultValuesVector == null)
		{
			throw new ArgumentNullException("resultValuesVector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputSumOfSquaresVector_ResultValuesVector_Handle, commandBuffer.Handle, inputGradientVector.Handle, inputValuesVector.Handle, inputSumOfSquaresVector.Handle, resultValuesVector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputSumOfSquaresVector_ResultValuesVector_Handle, commandBuffer.Handle, inputGradientVector.Handle, inputValuesVector.Handle, inputSumOfSquaresVector.Handle, resultValuesVector.Handle);
		}
	}

	[Export("encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputSumOfSquaresVectors:resultState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSCnnConvolutionGradientState convolutionGradientState, MPSCnnConvolutionWeightsAndBiasesState convolutionSourceState, NSArray<MPSVector>? inputSumOfSquaresVectors, MPSCnnConvolutionWeightsAndBiasesState resultState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (convolutionGradientState == null)
		{
			throw new ArgumentNullException("convolutionGradientState");
		}
		if (convolutionSourceState == null)
		{
			throw new ArgumentNullException("convolutionSourceState");
		}
		if (resultState == null)
		{
			throw new ArgumentNullException("resultState");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputSumOfSquaresVectors_ResultState_Handle, commandBuffer.Handle, convolutionGradientState.Handle, convolutionSourceState.Handle, inputSumOfSquaresVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputSumOfSquaresVectors_ResultState_Handle, commandBuffer.Handle, convolutionGradientState.Handle, convolutionSourceState.Handle, inputSumOfSquaresVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
	}

	[Export("encodeToCommandBuffer:batchNormalizationState:inputSumOfSquaresVectors:resultState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState, NSArray<MPSVector>? inputSumOfSquaresVectors, MPSCnnNormalizationGammaAndBetaState resultState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (batchNormalizationState == null)
		{
			throw new ArgumentNullException("batchNormalizationState");
		}
		if (resultState == null)
		{
			throw new ArgumentNullException("resultState");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_BatchNormalizationState_InputSumOfSquaresVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationState.Handle, inputSumOfSquaresVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_BatchNormalizationState_InputSumOfSquaresVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationState.Handle, inputSumOfSquaresVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
	}

	[Export("encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputSumOfSquaresVectors:resultState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationGradientState, MPSCnnBatchNormalizationState batchNormalizationSourceState, NSArray<MPSVector>? inputSumOfSquaresVectors, MPSCnnNormalizationGammaAndBetaState resultState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (batchNormalizationGradientState == null)
		{
			throw new ArgumentNullException("batchNormalizationGradientState");
		}
		if (batchNormalizationSourceState == null)
		{
			throw new ArgumentNullException("batchNormalizationSourceState");
		}
		if (resultState == null)
		{
			throw new ArgumentNullException("resultState");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputSumOfSquaresVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationGradientState.Handle, batchNormalizationSourceState.Handle, inputSumOfSquaresVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputSumOfSquaresVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationGradientState.Handle, batchNormalizationSourceState.Handle, inputSumOfSquaresVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
	}
}
