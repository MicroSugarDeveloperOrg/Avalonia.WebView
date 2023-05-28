using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNConvolutionDescriptor", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSCnnConvolutionDescriptor : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCnnConvolutionDescriptorWithKernelWidth_KernelHeight_InputFeatureChannels_OutputFeatureChannels_ = "cnnConvolutionDescriptorWithKernelWidth:kernelHeight:inputFeatureChannels:outputFeatureChannels:";

	private static readonly IntPtr selCnnConvolutionDescriptorWithKernelWidth_KernelHeight_InputFeatureChannels_OutputFeatureChannels_Handle = Selector.GetHandle("cnnConvolutionDescriptorWithKernelWidth:kernelHeight:inputFeatureChannels:outputFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCnnConvolutionDescriptorWithKernelWidth_KernelHeight_InputFeatureChannels_OutputFeatureChannels_NeuronFilter_ = "cnnConvolutionDescriptorWithKernelWidth:kernelHeight:inputFeatureChannels:outputFeatureChannels:neuronFilter:";

	private static readonly IntPtr selCnnConvolutionDescriptorWithKernelWidth_KernelHeight_InputFeatureChannels_OutputFeatureChannels_NeuronFilter_Handle = Selector.GetHandle("cnnConvolutionDescriptorWithKernelWidth:kernelHeight:inputFeatureChannels:outputFeatureChannels:neuronFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateX = "dilationRateX";

	private static readonly IntPtr selDilationRateXHandle = Selector.GetHandle("dilationRateX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateY = "dilationRateY";

	private static readonly IntPtr selDilationRateYHandle = Selector.GetHandle("dilationRateY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFusedNeuronDescriptor = "fusedNeuronDescriptor";

	private static readonly IntPtr selFusedNeuronDescriptorHandle = Selector.GetHandle("fusedNeuronDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroups = "groups";

	private static readonly IntPtr selGroupsHandle = Selector.GetHandle("groups");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputFeatureChannels = "inputFeatureChannels";

	private static readonly IntPtr selInputFeatureChannelsHandle = Selector.GetHandle("inputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelHeight = "kernelHeight";

	private static readonly IntPtr selKernelHeightHandle = Selector.GetHandle("kernelHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWidth = "kernelWidth";

	private static readonly IntPtr selKernelWidthHandle = Selector.GetHandle("kernelWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuron = "neuron";

	private static readonly IntPtr selNeuronHandle = Selector.GetHandle("neuron");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronParameterA = "neuronParameterA";

	private static readonly IntPtr selNeuronParameterAHandle = Selector.GetHandle("neuronParameterA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronParameterB = "neuronParameterB";

	private static readonly IntPtr selNeuronParameterBHandle = Selector.GetHandle("neuronParameterB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronType = "neuronType";

	private static readonly IntPtr selNeuronTypeHandle = Selector.GetHandle("neuronType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFeatureChannels = "outputFeatureChannels";

	private static readonly IntPtr selOutputFeatureChannelsHandle = Selector.GetHandle("outputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBatchNormalizationParametersForInferenceWithMean_Variance_Gamma_Beta_Epsilon_ = "setBatchNormalizationParametersForInferenceWithMean:variance:gamma:beta:epsilon:";

	private static readonly IntPtr selSetBatchNormalizationParametersForInferenceWithMean_Variance_Gamma_Beta_Epsilon_Handle = Selector.GetHandle("setBatchNormalizationParametersForInferenceWithMean:variance:gamma:beta:epsilon:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDilationRateX_ = "setDilationRateX:";

	private static readonly IntPtr selSetDilationRateX_Handle = Selector.GetHandle("setDilationRateX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDilationRateY_ = "setDilationRateY:";

	private static readonly IntPtr selSetDilationRateY_Handle = Selector.GetHandle("setDilationRateY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFusedNeuronDescriptor_ = "setFusedNeuronDescriptor:";

	private static readonly IntPtr selSetFusedNeuronDescriptor_Handle = Selector.GetHandle("setFusedNeuronDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroups_ = "setGroups:";

	private static readonly IntPtr selSetGroups_Handle = Selector.GetHandle("setGroups:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInputFeatureChannels_ = "setInputFeatureChannels:";

	private static readonly IntPtr selSetInputFeatureChannels_Handle = Selector.GetHandle("setInputFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKernelHeight_ = "setKernelHeight:";

	private static readonly IntPtr selSetKernelHeight_Handle = Selector.GetHandle("setKernelHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKernelWidth_ = "setKernelWidth:";

	private static readonly IntPtr selSetKernelWidth_Handle = Selector.GetHandle("setKernelWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeuron_ = "setNeuron:";

	private static readonly IntPtr selSetNeuron_Handle = Selector.GetHandle("setNeuron:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeuronToPReLUWithParametersA_ = "setNeuronToPReLUWithParametersA:";

	private static readonly IntPtr selSetNeuronToPReLUWithParametersA_Handle = Selector.GetHandle("setNeuronToPReLUWithParametersA:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeuronType_ParameterA_ParameterB_ = "setNeuronType:parameterA:parameterB:";

	private static readonly IntPtr selSetNeuronType_ParameterA_ParameterB_Handle = Selector.GetHandle("setNeuronType:parameterA:parameterB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputFeatureChannels_ = "setOutputFeatureChannels:";

	private static readonly IntPtr selSetOutputFeatureChannels_Handle = Selector.GetHandle("setOutputFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStrideInPixelsX_ = "setStrideInPixelsX:";

	private static readonly IntPtr selSetStrideInPixelsX_Handle = Selector.GetHandle("setStrideInPixelsX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStrideInPixelsY_ = "setStrideInPixelsY:";

	private static readonly IntPtr selSetStrideInPixelsY_Handle = Selector.GetHandle("setStrideInPixelsY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrideInPixelsX = "strideInPixelsX";

	private static readonly IntPtr selStrideInPixelsXHandle = Selector.GetHandle("strideInPixelsX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrideInPixelsY = "strideInPixelsY";

	private static readonly IntPtr selStrideInPixelsYHandle = Selector.GetHandle("strideInPixelsY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsSecureCoding = "supportsSecureCoding";

	private static readonly IntPtr selSupportsSecureCodingHandle = Selector.GetHandle("supportsSecureCoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNConvolutionDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint DilationRateX
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("dilationRateX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDilationRateXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDilationRateXHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setDilationRateX:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetDilationRateX_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetDilationRateX_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint DilationRateY
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("dilationRateY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDilationRateYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDilationRateYHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setDilationRateY:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetDilationRateY_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetDilationRateY_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual MPSNNNeuronDescriptor FusedNeuronDescriptor
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("fusedNeuronDescriptor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSNNNeuronDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selFusedNeuronDescriptorHandle));
			}
			return Runtime.GetNSObject<MPSNNNeuronDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFusedNeuronDescriptorHandle));
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setFusedNeuronDescriptor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFusedNeuronDescriptor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFusedNeuronDescriptor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Groups
	{
		[Export("groups")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selGroupsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selGroupsHandle);
		}
		[Export("setGroups:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetGroups_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetGroups_Handle, value);
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
		[Export("setInputFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetInputFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetInputFeatureChannels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint KernelHeight
	{
		[Export("kernelHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selKernelHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selKernelHeightHandle);
		}
		[Export("setKernelHeight:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetKernelHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetKernelHeight_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint KernelWidth
	{
		[Export("kernelWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selKernelWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selKernelWidthHandle);
		}
		[Export("setKernelWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetKernelWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetKernelWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	public virtual MPSCnnNeuron? Neuron
	{
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
		[Export("neuron", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnNeuron>(Messaging.IntPtr_objc_msgSend(base.Handle, selNeuronHandle));
			}
			return Runtime.GetNSObject<MPSCnnNeuron>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNeuronHandle));
		}
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
		[Export("setNeuron:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNeuron_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNeuron_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[Deprecated(PlatformName.iOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	public virtual float NeuronParameterA
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.TvOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
		[Deprecated(PlatformName.iOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
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
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[Deprecated(PlatformName.iOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	public virtual float NeuronParameterB
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.TvOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
		[Deprecated(PlatformName.iOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
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
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[Deprecated(PlatformName.iOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	public virtual MPSCnnNeuronType NeuronType
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.TvOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
		[Deprecated(PlatformName.iOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
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
		[Export("setOutputFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetOutputFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetOutputFeatureChannels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint StrideInPixelsX
	{
		[Export("strideInPixelsX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStrideInPixelsXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStrideInPixelsXHandle);
		}
		[Export("setStrideInPixelsX:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetStrideInPixelsX_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetStrideInPixelsX_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint StrideInPixelsY
	{
		[Export("strideInPixelsY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStrideInPixelsYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStrideInPixelsYHandle);
		}
		[Export("setStrideInPixelsY:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetStrideInPixelsY_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetStrideInPixelsY_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static bool SupportsSecureCoding
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("supportsSecureCoding")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selSupportsSecureCodingHandle);
		}
	}

	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public unsafe void SetBatchNormalizationParameters(float[] mean, float[] variance, float[] gamma, float[] beta, float epsilon)
	{
		fixed (float* ptr = mean)
		{
			void* ptr2 = ptr;
			fixed (float* ptr3 = variance)
			{
				void* ptr4 = ptr3;
				fixed (float* ptr5 = gamma)
				{
					void* ptr6 = ptr5;
					fixed (float* ptr7 = beta)
					{
						void* ptr8 = ptr7;
						SetBatchNormalizationParameters((IntPtr)ptr2, (IntPtr)ptr4, (IntPtr)ptr6, (IntPtr)ptr8, epsilon);
					}
				}
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnConvolutionDescriptor(NSCoder coder)
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
	protected MPSCnnConvolutionDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnConvolutionDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("cnnConvolutionDescriptorWithKernelWidth:kernelHeight:inputFeatureChannels:outputFeatureChannels:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnConvolutionDescriptor CreateCnnConvolutionDescriptor(nuint kernelWidth, nuint kernelHeight, nuint inputFeatureChannels, nuint outputFeatureChannels)
	{
		return Runtime.GetNSObject<MPSCnnConvolutionDescriptor>(Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint_nuint(class_ptr, selCnnConvolutionDescriptorWithKernelWidth_KernelHeight_InputFeatureChannels_OutputFeatureChannels_Handle, kernelWidth, kernelHeight, inputFeatureChannels, outputFeatureChannels));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("cnnConvolutionDescriptorWithKernelWidth:kernelHeight:inputFeatureChannels:outputFeatureChannels:neuronFilter:")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnConvolutionDescriptor GetConvolutionDescriptor(nuint kernelWidth, nuint kernelHeight, nuint inputFeatureChannels, nuint outputFeatureChannels, MPSCnnNeuron? neuronFilter)
	{
		return Runtime.GetNSObject<MPSCnnConvolutionDescriptor>(Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint_nuint_IntPtr(class_ptr, selCnnConvolutionDescriptorWithKernelWidth_KernelHeight_InputFeatureChannels_OutputFeatureChannels_NeuronFilter_Handle, kernelWidth, kernelHeight, inputFeatureChannels, outputFeatureChannels, neuronFilter?.Handle ?? IntPtr.Zero));
	}

	[Export("setBatchNormalizationParametersForInferenceWithMean:variance:gamma:beta:epsilon:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void SetBatchNormalizationParameters(IntPtr mean, IntPtr variance, IntPtr gamma, IntPtr beta, float epsilon)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_float(base.Handle, selSetBatchNormalizationParametersForInferenceWithMean_Variance_Gamma_Beta_Epsilon_Handle, mean, variance, gamma, beta, epsilon);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_float(base.SuperHandle, selSetBatchNormalizationParametersForInferenceWithMean_Variance_Gamma_Beta_Epsilon_Handle, mean, variance, gamma, beta, epsilon);
		}
	}

	[Export("setNeuronToPReLUWithParametersA:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[Deprecated(PlatformName.iOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeuronToPReLU(NSData A)
	{
		if (A == null)
		{
			throw new ArgumentNullException("A");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNeuronToPReLUWithParametersA_Handle, A.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNeuronToPReLUWithParametersA_Handle, A.Handle);
		}
	}

	[Export("setNeuronType:parameterA:parameterB:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[Deprecated(PlatformName.iOS, 11, 3, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeuronType(MPSCnnNeuronType neuronType, float parameterA, float parameterB)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_float_float(base.Handle, selSetNeuronType_ParameterA_ParameterB_Handle, (int)neuronType, parameterA, parameterB);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_float_float(base.SuperHandle, selSetNeuronType_ParameterA_ParameterB_Handle, (int)neuronType, parameterA, parameterB);
		}
	}
}
