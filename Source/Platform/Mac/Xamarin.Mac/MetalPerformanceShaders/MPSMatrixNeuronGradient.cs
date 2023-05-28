using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSMatrixNeuronGradient", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSMatrixNeuronGradient : MPSMatrixBinaryKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlpha = "alpha";

	private static readonly IntPtr selAlphaHandle = Selector.GetHandle("alpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_Device_ = "copyWithZone:device:";

	private static readonly IntPtr selCopyWithZone_Device_Handle = Selector.GetHandle("copyWithZone:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_GradientMatrix_InputMatrix_BiasVector_ResultGradientForDataMatrix_ResultGradientForBiasVector_ = "encodeToCommandBuffer:gradientMatrix:inputMatrix:biasVector:resultGradientForDataMatrix:resultGradientForBiasVector:";

	private static readonly IntPtr selEncodeToCommandBuffer_GradientMatrix_InputMatrix_BiasVector_ResultGradientForDataMatrix_ResultGradientForBiasVector_Handle = Selector.GetHandle("encodeToCommandBuffer:gradientMatrix:inputMatrix:biasVector:resultGradientForDataMatrix:resultGradientForBiasVector:");

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
	private const string selSetAlpha_ = "setAlpha:";

	private static readonly IntPtr selSetAlpha_Handle = Selector.GetHandle("setAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeuronToPReLUWithParametersA_ = "setNeuronToPReLUWithParametersA:";

	private static readonly IntPtr selSetNeuronToPReLUWithParametersA_Handle = Selector.GetHandle("setNeuronToPReLUWithParametersA:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixNeuronGradient");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Alpha
	{
		[Export("alpha")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAlphaHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAlphaHandle);
		}
		[Export("setAlpha:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAlpha_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAlpha_Handle, value);
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
	public MPSMatrixNeuronGradient(NSCoder coder)
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
	protected MPSMatrixNeuronGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixNeuronGradient(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixNeuronGradient(IMTLDevice device)
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
	public MPSMatrixNeuronGradient(NSCoder decoder, IMTLDevice device)
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
	public virtual MPSMatrixNeuronGradient Copy(NSZone? zone, IMTLDevice? device)
	{
		MPSMatrixNeuronGradient mPSMatrixNeuronGradient = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSMatrixNeuronGradient>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<MPSMatrixNeuronGradient>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)));
		if (mPSMatrixNeuronGradient != null)
		{
			Messaging.void_objc_msgSend(mPSMatrixNeuronGradient.Handle, Selector.GetHandle("release"));
		}
		return mPSMatrixNeuronGradient;
	}

	[Export("encodeToCommandBuffer:gradientMatrix:inputMatrix:biasVector:resultGradientForDataMatrix:resultGradientForBiasVector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(IMTLCommandBuffer commandBuffer, MPSMatrix gradientMatrix, MPSMatrix inputMatrix, MPSVector? biasVector, MPSMatrix resultGradientForDataMatrix, MPSVector? resultGradientForBiasVector)
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
		if (resultGradientForDataMatrix == null)
		{
			throw new ArgumentNullException("resultGradientForDataMatrix");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_GradientMatrix_InputMatrix_BiasVector_ResultGradientForDataMatrix_ResultGradientForBiasVector_Handle, commandBuffer.Handle, gradientMatrix.Handle, inputMatrix.Handle, biasVector?.Handle ?? IntPtr.Zero, resultGradientForDataMatrix.Handle, resultGradientForBiasVector?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_GradientMatrix_InputMatrix_BiasVector_ResultGradientForDataMatrix_ResultGradientForBiasVector_Handle, commandBuffer.Handle, gradientMatrix.Handle, inputMatrix.Handle, biasVector?.Handle ?? IntPtr.Zero, resultGradientForDataMatrix.Handle, resultGradientForBiasVector?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("setNeuronToPReLUWithParametersA:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeuronToPReLU(NSData a)
	{
		if (a == null)
		{
			throw new ArgumentNullException("a");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNeuronToPReLUWithParametersA_Handle, a.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNeuronToPReLUWithParametersA_Handle, a.Handle);
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
