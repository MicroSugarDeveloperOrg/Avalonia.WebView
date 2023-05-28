using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNOptimizerStochasticGradientDescent", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSNNOptimizerStochasticGradientDescent : MPSNNOptimizer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputMomentumVectors_ResultState_ = "encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputMomentumVectors:resultState:";

	private static readonly IntPtr selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputMomentumVectors_ResultState_Handle = Selector.GetHandle("encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputMomentumVectors:resultState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_BatchNormalizationState_InputMomentumVectors_ResultState_ = "encodeToCommandBuffer:batchNormalizationState:inputMomentumVectors:resultState:";

	private static readonly IntPtr selEncodeToCommandBuffer_BatchNormalizationState_InputMomentumVectors_ResultState_Handle = Selector.GetHandle("encodeToCommandBuffer:batchNormalizationState:inputMomentumVectors:resultState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputMomentumVectors_ResultState_ = "encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputMomentumVectors:resultState:";

	private static readonly IntPtr selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputMomentumVectors_ResultState_Handle = Selector.GetHandle("encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputMomentumVectors:resultState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputMomentumVector_ResultValuesVector_ = "encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputMomentumVector:resultValuesVector:";

	private static readonly IntPtr selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputMomentumVector_ResultValuesVector_Handle = Selector.GetHandle("encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputMomentumVector:resultValuesVector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_LearningRate_ = "initWithDevice:learningRate:";

	private static readonly IntPtr selInitWithDevice_LearningRate_Handle = Selector.GetHandle("initWithDevice:learningRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_MomentumScale_UseNestrovMomentum_OptimizerDescriptor_ = "initWithDevice:momentumScale:useNestrovMomentum:optimizerDescriptor:";

	private static readonly IntPtr selInitWithDevice_MomentumScale_UseNestrovMomentum_OptimizerDescriptor_Handle = Selector.GetHandle("initWithDevice:momentumScale:useNestrovMomentum:optimizerDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMomentumScale = "momentumScale";

	private static readonly IntPtr selMomentumScaleHandle = Selector.GetHandle("momentumScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUseNestrovMomentum = "useNestrovMomentum";

	private static readonly IntPtr selUseNestrovMomentumHandle = Selector.GetHandle("useNestrovMomentum");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNOptimizerStochasticGradientDescent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MomentumScale
	{
		[Export("momentumScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMomentumScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMomentumScaleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UseNestrovMomentum
	{
		[Export("useNestrovMomentum")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUseNestrovMomentumHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUseNestrovMomentumHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSNNOptimizerStochasticGradientDescent(NSCoder coder)
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
	protected MPSNNOptimizerStochasticGradientDescent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNOptimizerStochasticGradientDescent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:learningRate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNOptimizerStochasticGradientDescent(IMTLDevice device, float learningRate)
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

	[Export("initWithDevice:momentumScale:useNestrovMomentum:optimizerDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNOptimizerStochasticGradientDescent(IMTLDevice device, float momentumScale, bool useNestrovMomentum, MPSNNOptimizerDescriptor optimizerDescriptor)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float_bool_IntPtr(base.Handle, selInitWithDevice_MomentumScale_UseNestrovMomentum_OptimizerDescriptor_Handle, device.Handle, momentumScale, useNestrovMomentum, optimizerDescriptor.Handle), "initWithDevice:momentumScale:useNestrovMomentum:optimizerDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float_bool_IntPtr(base.SuperHandle, selInitWithDevice_MomentumScale_UseNestrovMomentum_OptimizerDescriptor_Handle, device.Handle, momentumScale, useNestrovMomentum, optimizerDescriptor.Handle), "initWithDevice:momentumScale:useNestrovMomentum:optimizerDescriptor:");
		}
	}

	[Export("encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputMomentumVector:resultValuesVector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSVector inputGradientVector, MPSVector inputValuesVector, MPSVector? inputMomentumVector, MPSVector resultValuesVector)
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
		if (resultValuesVector == null)
		{
			throw new ArgumentNullException("resultValuesVector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputMomentumVector_ResultValuesVector_Handle, commandBuffer.Handle, inputGradientVector.Handle, inputValuesVector.Handle, inputMomentumVector?.Handle ?? IntPtr.Zero, resultValuesVector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputMomentumVector_ResultValuesVector_Handle, commandBuffer.Handle, inputGradientVector.Handle, inputValuesVector.Handle, inputMomentumVector?.Handle ?? IntPtr.Zero, resultValuesVector.Handle);
		}
	}

	[Export("encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputMomentumVectors:resultState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSCnnConvolutionGradientState convolutionGradientState, MPSCnnConvolutionWeightsAndBiasesState convolutionSourceState, NSArray<MPSVector>? inputMomentumVectors, MPSCnnConvolutionWeightsAndBiasesState resultState)
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputMomentumVectors_ResultState_Handle, commandBuffer.Handle, convolutionGradientState.Handle, convolutionSourceState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputMomentumVectors_ResultState_Handle, commandBuffer.Handle, convolutionGradientState.Handle, convolutionSourceState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
	}

	[Export("encodeToCommandBuffer:batchNormalizationState:inputMomentumVectors:resultState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState, NSArray<MPSVector>? inputMomentumVectors, MPSCnnNormalizationGammaAndBetaState resultState)
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_BatchNormalizationState_InputMomentumVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_BatchNormalizationState_InputMomentumVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
	}

	[Export("encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputMomentumVectors:resultState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationGradientState, MPSCnnBatchNormalizationState batchNormalizationSourceState, NSArray<MPSVector>? inputMomentumVectors, MPSCnnNormalizationGammaAndBetaState resultState)
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputMomentumVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationGradientState.Handle, batchNormalizationSourceState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputMomentumVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationGradientState.Handle, batchNormalizationSourceState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
	}
}
