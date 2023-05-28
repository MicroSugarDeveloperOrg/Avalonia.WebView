using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNOptimizerAdam", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSNNOptimizerAdam : MPSNNOptimizer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeta1 = "beta1";

	private static readonly IntPtr selBeta1Handle = Selector.GetHandle("beta1");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeta2 = "beta2";

	private static readonly IntPtr selBeta2Handle = Selector.GetHandle("beta2");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputMomentumVectors_InputVelocityVectors_ResultState_ = "encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputMomentumVectors:inputVelocityVectors:resultState:";

	private static readonly IntPtr selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputMomentumVectors_InputVelocityVectors_ResultState_Handle = Selector.GetHandle("encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputMomentumVectors:inputVelocityVectors:resultState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_BatchNormalizationState_InputMomentumVectors_InputVelocityVectors_ResultState_ = "encodeToCommandBuffer:batchNormalizationState:inputMomentumVectors:inputVelocityVectors:resultState:";

	private static readonly IntPtr selEncodeToCommandBuffer_BatchNormalizationState_InputMomentumVectors_InputVelocityVectors_ResultState_Handle = Selector.GetHandle("encodeToCommandBuffer:batchNormalizationState:inputMomentumVectors:inputVelocityVectors:resultState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputMomentumVectors_InputVelocityVectors_ResultState_ = "encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputMomentumVectors:inputVelocityVectors:resultState:";

	private static readonly IntPtr selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputMomentumVectors_InputVelocityVectors_ResultState_Handle = Selector.GetHandle("encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputMomentumVectors:inputVelocityVectors:resultState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputMomentumVector_InputVelocityVector_ResultValuesVector_ = "encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputMomentumVector:inputVelocityVector:resultValuesVector:";

	private static readonly IntPtr selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputMomentumVector_InputVelocityVector_ResultValuesVector_Handle = Selector.GetHandle("encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputMomentumVector:inputVelocityVector:resultValuesVector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEpsilon = "epsilon";

	private static readonly IntPtr selEpsilonHandle = Selector.GetHandle("epsilon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Beta1_Beta2_Epsilon_TimeStep_OptimizerDescriptor_ = "initWithDevice:beta1:beta2:epsilon:timeStep:optimizerDescriptor:";

	private static readonly IntPtr selInitWithDevice_Beta1_Beta2_Epsilon_TimeStep_OptimizerDescriptor_Handle = Selector.GetHandle("initWithDevice:beta1:beta2:epsilon:timeStep:optimizerDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_LearningRate_ = "initWithDevice:learningRate:";

	private static readonly IntPtr selInitWithDevice_LearningRate_Handle = Selector.GetHandle("initWithDevice:learningRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeStep_ = "setTimeStep:";

	private static readonly IntPtr selSetTimeStep_Handle = Selector.GetHandle("setTimeStep:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeStep = "timeStep";

	private static readonly IntPtr selTimeStepHandle = Selector.GetHandle("timeStep");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNOptimizerAdam");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Beta1
	{
		[Export("beta1")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBeta1Handle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBeta1Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Beta2
	{
		[Export("beta2")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBeta2Handle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBeta2Handle);
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
	public virtual nuint TimeStep
	{
		[Export("timeStep")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selTimeStepHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selTimeStepHandle);
		}
		[Export("setTimeStep:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetTimeStep_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetTimeStep_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSNNOptimizerAdam(NSCoder coder)
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
	protected MPSNNOptimizerAdam(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNOptimizerAdam(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:learningRate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNOptimizerAdam(IMTLDevice device, float learningRate)
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

	[Export("initWithDevice:beta1:beta2:epsilon:timeStep:optimizerDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNOptimizerAdam(IMTLDevice device, double beta1, double beta2, float epsilon, nuint timeStep, MPSNNOptimizerDescriptor optimizerDescriptor)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Double_Double_float_nuint_IntPtr(base.Handle, selInitWithDevice_Beta1_Beta2_Epsilon_TimeStep_OptimizerDescriptor_Handle, device.Handle, beta1, beta2, epsilon, timeStep, optimizerDescriptor.Handle), "initWithDevice:beta1:beta2:epsilon:timeStep:optimizerDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double_Double_float_nuint_IntPtr(base.SuperHandle, selInitWithDevice_Beta1_Beta2_Epsilon_TimeStep_OptimizerDescriptor_Handle, device.Handle, beta1, beta2, epsilon, timeStep, optimizerDescriptor.Handle), "initWithDevice:beta1:beta2:epsilon:timeStep:optimizerDescriptor:");
		}
	}

	[Export("encodeToCommandBuffer:inputGradientVector:inputValuesVector:inputMomentumVector:inputVelocityVector:resultValuesVector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSVector inputGradientVector, MPSVector inputValuesVector, MPSVector inputMomentumVector, MPSVector inputVelocityVector, MPSVector resultValuesVector)
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
		if (inputMomentumVector == null)
		{
			throw new ArgumentNullException("inputMomentumVector");
		}
		if (inputVelocityVector == null)
		{
			throw new ArgumentNullException("inputVelocityVector");
		}
		if (resultValuesVector == null)
		{
			throw new ArgumentNullException("resultValuesVector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputMomentumVector_InputVelocityVector_ResultValuesVector_Handle, commandBuffer.Handle, inputGradientVector.Handle, inputValuesVector.Handle, inputMomentumVector.Handle, inputVelocityVector.Handle, resultValuesVector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_InputGradientVector_InputValuesVector_InputMomentumVector_InputVelocityVector_ResultValuesVector_Handle, commandBuffer.Handle, inputGradientVector.Handle, inputValuesVector.Handle, inputMomentumVector.Handle, inputVelocityVector.Handle, resultValuesVector.Handle);
		}
	}

	[Export("encodeToCommandBuffer:convolutionGradientState:convolutionSourceState:inputMomentumVectors:inputVelocityVectors:resultState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSCnnConvolutionGradientState convolutionGradientState, MPSCnnConvolutionWeightsAndBiasesState convolutionSourceState, NSArray<MPSVector>? inputMomentumVectors, NSArray<MPSVector>? inputVelocityVectors, MPSCnnConvolutionWeightsAndBiasesState resultState)
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputMomentumVectors_InputVelocityVectors_ResultState_Handle, commandBuffer.Handle, convolutionGradientState.Handle, convolutionSourceState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, inputVelocityVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_ConvolutionGradientState_ConvolutionSourceState_InputMomentumVectors_InputVelocityVectors_ResultState_Handle, commandBuffer.Handle, convolutionGradientState.Handle, convolutionSourceState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, inputVelocityVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
	}

	[Export("encodeToCommandBuffer:batchNormalizationState:inputMomentumVectors:inputVelocityVectors:resultState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState, NSArray<MPSVector>? inputMomentumVectors, NSArray<MPSVector>? inputVelocityVectors, MPSCnnNormalizationGammaAndBetaState resultState)
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_BatchNormalizationState_InputMomentumVectors_InputVelocityVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, inputVelocityVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_BatchNormalizationState_InputMomentumVectors_InputVelocityVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, inputVelocityVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
	}

	[Export("encodeToCommandBuffer:batchNormalizationGradientState:batchNormalizationSourceState:inputMomentumVectors:inputVelocityVectors:resultState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationGradientState, MPSCnnBatchNormalizationState batchNormalizationSourceState, NSArray<MPSVector>? inputMomentumVectors, NSArray<MPSVector>? inputVelocityVectors, MPSCnnNormalizationGammaAndBetaState resultState)
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputMomentumVectors_InputVelocityVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationGradientState.Handle, batchNormalizationSourceState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, inputVelocityVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_BatchNormalizationGradientState_BatchNormalizationSourceState_InputMomentumVectors_InputVelocityVectors_ResultState_Handle, commandBuffer.Handle, batchNormalizationGradientState.Handle, batchNormalizationSourceState.Handle, inputMomentumVectors?.Handle ?? IntPtr.Zero, inputVelocityVectors?.Handle ?? IntPtr.Zero, resultState.Handle);
		}
	}
}
