using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSMatrixBatchNormalizationGradient", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSMatrixBatchNormalizationGradient : MPSMatrixBinaryKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_Device_ = "copyWithZone:device:";

	private static readonly IntPtr selCopyWithZone_Device_Handle = Selector.GetHandle("copyWithZone:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_GradientMatrix_InputMatrix_MeanVector_VarianceVector_GammaVector_BetaVector_ResultGradientForDataMatrix_ResultGradientForGammaVector_ResultGradientForBetaVector_ = "encodeToCommandBuffer:gradientMatrix:inputMatrix:meanVector:varianceVector:gammaVector:betaVector:resultGradientForDataMatrix:resultGradientForGammaVector:resultGradientForBetaVector:";

	private static readonly IntPtr selEncodeToCommandBuffer_GradientMatrix_InputMatrix_MeanVector_VarianceVector_GammaVector_BetaVector_ResultGradientForDataMatrix_ResultGradientForGammaVector_ResultGradientForBetaVector_Handle = Selector.GetHandle("encodeToCommandBuffer:gradientMatrix:inputMatrix:meanVector:varianceVector:gammaVector:betaVector:resultGradientForDataMatrix:resultGradientForGammaVector:resultGradientForBetaVector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEpsilon = "epsilon";

	private static readonly IntPtr selEpsilonHandle = Selector.GetHandle("epsilon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronParameterA = "neuronParameterA";

	private static readonly IntPtr selNeuronParameterAHandle = Selector.GetHandle("neuronParameterA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronParameterB = "neuronParameterB";

	private static readonly IntPtr selNeuronParameterBHandle = Selector.GetHandle("neuronParameterB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronParameterC = "neuronParameterC";

	private static readonly IntPtr selNeuronParameterCHandle = Selector.GetHandle("neuronParameterC");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronType = "neuronType";

	private static readonly IntPtr selNeuronTypeHandle = Selector.GetHandle("neuronType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEpsilon_ = "setEpsilon:";

	private static readonly IntPtr selSetEpsilon_Handle = Selector.GetHandle("setEpsilon:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeuronType_ParameterA_ParameterB_ParameterC_ = "setNeuronType:parameterA:parameterB:parameterC:";

	private static readonly IntPtr selSetNeuronType_ParameterA_ParameterB_ParameterC_Handle = Selector.GetHandle("setNeuronType:parameterA:parameterB:parameterC:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceInputFeatureChannels_ = "setSourceInputFeatureChannels:";

	private static readonly IntPtr selSetSourceInputFeatureChannels_Handle = Selector.GetHandle("setSourceInputFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceNumberOfFeatureVectors_ = "setSourceNumberOfFeatureVectors:";

	private static readonly IntPtr selSetSourceNumberOfFeatureVectors_Handle = Selector.GetHandle("setSourceNumberOfFeatureVectors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceInputFeatureChannels = "sourceInputFeatureChannels";

	private static readonly IntPtr selSourceInputFeatureChannelsHandle = Selector.GetHandle("sourceInputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceNumberOfFeatureVectors = "sourceNumberOfFeatureVectors";

	private static readonly IntPtr selSourceNumberOfFeatureVectorsHandle = Selector.GetHandle("sourceNumberOfFeatureVectors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixBatchNormalizationGradient");

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
	public virtual float NeuronParameterA
	{
		[Export("neuronParameterA")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selNeuronParameterAHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selNeuronParameterAHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float NeuronParameterB
	{
		[Export("neuronParameterB")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selNeuronParameterBHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selNeuronParameterBHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float NeuronParameterC
	{
		[Export("neuronParameterC")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selNeuronParameterCHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selNeuronParameterCHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnNeuronType NeuronType
	{
		[Export("neuronType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSCnnNeuronType)Messaging.int_objc_msgSend(base.Handle, selNeuronTypeHandle);
			}
			return (MPSCnnNeuronType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selNeuronTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SourceInputFeatureChannels
	{
		[Export("sourceInputFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceInputFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceInputFeatureChannelsHandle);
		}
		[Export("setSourceInputFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSourceInputFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSourceInputFeatureChannels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SourceNumberOfFeatureVectors
	{
		[Export("sourceNumberOfFeatureVectors")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceNumberOfFeatureVectorsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceNumberOfFeatureVectorsHandle);
		}
		[Export("setSourceNumberOfFeatureVectors:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSourceNumberOfFeatureVectors_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSourceNumberOfFeatureVectors_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSMatrixBatchNormalizationGradient(NSCoder coder)
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
	protected MPSMatrixBatchNormalizationGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixBatchNormalizationGradient(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixBatchNormalizationGradient(IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixBatchNormalizationGradient(NSCoder decoder, IMTLDevice device)
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
	public virtual MPSMatrixBatchNormalizationGradient Copy(NSZone? zone, IMTLDevice? device)
	{
		MPSMatrixBatchNormalizationGradient mPSMatrixBatchNormalizationGradient = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSMatrixBatchNormalizationGradient>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<MPSMatrixBatchNormalizationGradient>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)));
		if (mPSMatrixBatchNormalizationGradient != null)
		{
			Messaging.void_objc_msgSend(mPSMatrixBatchNormalizationGradient.Handle, Selector.GetHandle("release"));
		}
		return mPSMatrixBatchNormalizationGradient;
	}

	[Export("encodeToCommandBuffer:gradientMatrix:inputMatrix:meanVector:varianceVector:gammaVector:betaVector:resultGradientForDataMatrix:resultGradientForGammaVector:resultGradientForBetaVector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSMatrix gradientMatrix, MPSMatrix inputMatrix, MPSVector meanVector, MPSVector varianceVector, MPSVector? gammaVector, MPSVector? betaVector, MPSMatrix resultGradientForDataMatrix, MPSVector? resultGradientForGammaVector, MPSVector? resultGradientForBetaVector)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (gradientMatrix == null)
		{
			throw new ArgumentNullException("gradientMatrix");
		}
		if (inputMatrix == null)
		{
			throw new ArgumentNullException("inputMatrix");
		}
		if (meanVector == null)
		{
			throw new ArgumentNullException("meanVector");
		}
		if (varianceVector == null)
		{
			throw new ArgumentNullException("varianceVector");
		}
		if (resultGradientForDataMatrix == null)
		{
			throw new ArgumentNullException("resultGradientForDataMatrix");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_GradientMatrix_InputMatrix_MeanVector_VarianceVector_GammaVector_BetaVector_ResultGradientForDataMatrix_ResultGradientForGammaVector_ResultGradientForBetaVector_Handle, commandBuffer.Handle, gradientMatrix.Handle, inputMatrix.Handle, meanVector.Handle, varianceVector.Handle, gammaVector?.Handle ?? IntPtr.Zero, betaVector?.Handle ?? IntPtr.Zero, resultGradientForDataMatrix.Handle, resultGradientForGammaVector?.Handle ?? IntPtr.Zero, resultGradientForBetaVector?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_GradientMatrix_InputMatrix_MeanVector_VarianceVector_GammaVector_BetaVector_ResultGradientForDataMatrix_ResultGradientForGammaVector_ResultGradientForBetaVector_Handle, commandBuffer.Handle, gradientMatrix.Handle, inputMatrix.Handle, meanVector.Handle, varianceVector.Handle, gammaVector?.Handle ?? IntPtr.Zero, betaVector?.Handle ?? IntPtr.Zero, resultGradientForDataMatrix.Handle, resultGradientForGammaVector?.Handle ?? IntPtr.Zero, resultGradientForBetaVector?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("setNeuronType:parameterA:parameterB:parameterC:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeuronType(MPSCnnNeuronType neuronType, float parameterA, float parameterB, float parameterC)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_float_float_float(base.Handle, selSetNeuronType_ParameterA_ParameterB_ParameterC_Handle, (int)neuronType, parameterA, parameterB, parameterC);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_float_float_float(base.SuperHandle, selSetNeuronType_ParameterA_ParameterB_ParameterC_Handle, (int)neuronType, parameterA, parameterB, parameterC);
		}
	}
}
