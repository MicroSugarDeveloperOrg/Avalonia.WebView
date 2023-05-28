using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNConvolution", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSCnnConvolution : MPSCnnKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccumulatorPrecisionOption = "accumulatorPrecisionOption";

	private static readonly IntPtr selAccumulatorPrecisionOptionHandle = Selector.GetHandle("accumulatorPrecisionOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelMultiplier = "channelMultiplier";

	private static readonly IntPtr selChannelMultiplierHandle = Selector.GetHandle("channelMultiplier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateX = "dilationRateX";

	private static readonly IntPtr selDilationRateXHandle = Selector.GetHandle("dilationRateX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateY = "dilationRateY";

	private static readonly IntPtr selDilationRateYHandle = Selector.GetHandle("dilationRateY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_SourceImage_DestinationImage_State_ = "encodeToCommandBuffer:sourceImage:destinationImage:state:";

	private static readonly IntPtr selEncodeToCommandBuffer_SourceImage_DestinationImage_State_Handle = Selector.GetHandle("encodeToCommandBuffer:sourceImage:destinationImage:state:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportWeightsAndBiasesWithCommandBuffer_ResultStateCanBeTemporary_ = "exportWeightsAndBiasesWithCommandBuffer:resultStateCanBeTemporary:";

	private static readonly IntPtr selExportWeightsAndBiasesWithCommandBuffer_ResultStateCanBeTemporary_Handle = Selector.GetHandle("exportWeightsAndBiasesWithCommandBuffer:resultStateCanBeTemporary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFusedNeuronDescriptor = "fusedNeuronDescriptor";

	private static readonly IntPtr selFusedNeuronDescriptorHandle = Selector.GetHandle("fusedNeuronDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroups = "groups";

	private static readonly IntPtr selGroupsHandle = Selector.GetHandle("groups");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_ = "initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:";

	private static readonly IntPtr selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_Handle = Selector.GetHandle("initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Weights_ = "initWithDevice:weights:";

	private static readonly IntPtr selInitWithDevice_Weights_Handle = Selector.GetHandle("initWithDevice:weights:");

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
	private const string selNeuronParameterC = "neuronParameterC";

	private static readonly IntPtr selNeuronParameterCHandle = Selector.GetHandle("neuronParameterC");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronType = "neuronType";

	private static readonly IntPtr selNeuronTypeHandle = Selector.GetHandle("neuronType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFeatureChannels = "outputFeatureChannels";

	private static readonly IntPtr selOutputFeatureChannelsHandle = Selector.GetHandle("outputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadWeightsAndBiasesFromDataSource = "reloadWeightsAndBiasesFromDataSource";

	private static readonly IntPtr selReloadWeightsAndBiasesFromDataSourceHandle = Selector.GetHandle("reloadWeightsAndBiasesFromDataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadWeightsAndBiasesWithCommandBuffer_State_ = "reloadWeightsAndBiasesWithCommandBuffer:state:";

	private static readonly IntPtr selReloadWeightsAndBiasesWithCommandBuffer_State_Handle = Selector.GetHandle("reloadWeightsAndBiasesWithCommandBuffer:state:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadWeightsAndBiasesWithDataSource_ = "reloadWeightsAndBiasesWithDataSource:";

	private static readonly IntPtr selReloadWeightsAndBiasesWithDataSource_Handle = Selector.GetHandle("reloadWeightsAndBiasesWithDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultStateBatchForSourceImage_SourceStates_DestinationImage_ = "resultStateBatchForSourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selResultStateBatchForSourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("resultStateBatchForSourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultStateForSourceImage_SourceStates_DestinationImage_ = "resultStateForSourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selResultStateForSourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("resultStateForSourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccumulatorPrecisionOption_ = "setAccumulatorPrecisionOption:";

	private static readonly IntPtr selSetAccumulatorPrecisionOption_Handle = Selector.GetHandle("setAccumulatorPrecisionOption:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrideInPixelsX = "strideInPixelsX";

	private static readonly IntPtr selStrideInPixelsXHandle = Selector.GetHandle("strideInPixelsX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrideInPixelsY = "strideInPixelsY";

	private static readonly IntPtr selStrideInPixelsYHandle = Selector.GetHandle("strideInPixelsY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubPixelScaleFactor = "subPixelScaleFactor";

	private static readonly IntPtr selSubPixelScaleFactorHandle = Selector.GetHandle("subPixelScaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_ = "temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_ = "temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNConvolution");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual MPSNNConvolutionAccumulatorPrecisionOption AccumulatorPrecisionOption
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("accumulatorPrecisionOption", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSNNConvolutionAccumulatorPrecisionOption)Messaging.UInt64_objc_msgSend(base.Handle, selAccumulatorPrecisionOptionHandle);
			}
			return (MPSNNConvolutionAccumulatorPrecisionOption)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAccumulatorPrecisionOptionHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setAccumulatorPrecisionOption:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAccumulatorPrecisionOption_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAccumulatorPrecisionOption_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint ChannelMultiplier
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("channelMultiplier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selChannelMultiplierHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selChannelMultiplierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual IMPSCnnConvolutionDataSource DataSource
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("dataSource", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public new virtual nuint DilationRateX
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public new virtual nuint DilationRateY
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual MPSNNNeuronDescriptor? FusedNeuronDescriptor
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("fusedNeuronDescriptor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSNNNeuronDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selFusedNeuronDescriptorHandle));
			}
			return Runtime.GetNSObject<MPSNNNeuronDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFusedNeuronDescriptorHandle));
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
	public override nuint KernelHeight
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nuint KernelWidth
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "A 'MPSCnnNeuron' is much too heavy for this purpose. Please set 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "A 'MPSCnnNeuron' is much too heavy for this purpose. Please set 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	public virtual MPSCnnNeuron? Neuron
	{
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "A 'MPSCnnNeuron' is much too heavy for this purpose. Please set 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "A 'MPSCnnNeuron' is much too heavy for this purpose. Please set 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[Export("neuron")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnNeuron>(Messaging.IntPtr_objc_msgSend(base.Handle, selNeuronHandle));
			}
			return Runtime.GetNSObject<MPSCnnNeuron>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNeuronHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	public virtual float NeuronParameterA
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
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
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	public virtual float NeuronParameterB
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
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
	[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	public virtual float NeuronParameterC
	{
		[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
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
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
	public virtual MPSCnnNeuronType NeuronType
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'FusedNeuronDescriptor' property of convolution descriptor instead.")]
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nuint StrideInPixelsX
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nuint StrideInPixelsY
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint SubPixelScaleFactor
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("subPixelScaleFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSubPixelScaleFactorHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSubPixelScaleFactorHandle);
		}
	}

	[DesignatedInitializer]
	public unsafe MPSCnnConvolution(IMTLDevice device, MPSCnnConvolutionDescriptor convolutionDescriptor, float[] kernelWeights, float[] biasTerms, MPSCnnConvolutionFlags flags)
		: base(NSObjectFlag.Empty)
	{
		if (kernelWeights == null)
		{
			throw new ArgumentNullException("kernelWeights");
		}
		fixed (float* ptr = kernelWeights)
		{
			fixed (float* ptr2 = biasTerms)
			{
				InitializeHandle(InitWithDevice(device, convolutionDescriptor, (IntPtr)ptr, (IntPtr)ptr2, flags), "initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:");
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnConvolution(NSCoder coder)
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
	protected MPSCnnConvolution(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnConvolution(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:weights:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnConvolution(IMTLDevice device, IMPSCnnConvolutionDataSource weights)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_Weights_Handle, device.Handle, weights.Handle), "initWithDevice:weights:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_Weights_Handle, device.Handle, weights.Handle), "initWithDevice:weights:");
		}
	}

	[Export("initWithCoder:device:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnConvolution(NSCoder aDecoder, IMTLDevice device)
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

	[Export("encodeToCommandBuffer:sourceImage:destinationImage:state:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSImage destinationImage, out MPSCnnConvolutionState state)
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
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selEncodeToCommandBuffer_SourceImage_DestinationImage_State_Handle, commandBuffer.Handle, sourceImage.Handle, destinationImage.Handle, ref arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_SourceImage_DestinationImage_State_Handle, commandBuffer.Handle, sourceImage.Handle, destinationImage.Handle, ref arg);
		}
		state = Runtime.GetNSObject<MPSCnnConvolutionState>(arg);
	}

	[Export("exportWeightsAndBiasesWithCommandBuffer:resultStateCanBeTemporary:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnConvolutionWeightsAndBiasesState ExportWeightsAndBiases(IMTLCommandBuffer commandBuffer, bool resultStateCanBeTemporary)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSCnnConvolutionWeightsAndBiasesState>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selExportWeightsAndBiasesWithCommandBuffer_ResultStateCanBeTemporary_Handle, commandBuffer.Handle, resultStateCanBeTemporary));
		}
		return Runtime.GetNSObject<MPSCnnConvolutionWeightsAndBiasesState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selExportWeightsAndBiasesWithCommandBuffer_ResultStateCanBeTemporary_Handle, commandBuffer.Handle, resultStateCanBeTemporary));
	}

	[Export("resultStateForSourceImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSCnnConvolutionGradientState? GetResultState(MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
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
			return Runtime.GetNSObject<MPSCnnConvolutionGradientState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selResultStateForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
		}
		return Runtime.GetNSObject<MPSCnnConvolutionGradientState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selResultStateForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
	}

	[Export("resultStateBatchForSourceImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSCnnConvolutionGradientState[]? GetResultStateBatch(NSArray<MPSImage> sourceImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
	{
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		NSArray nSArray = ((sourceStates == null) ? null : NSArray.FromNSObjects(sourceStates));
		MPSCnnConvolutionGradientState[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<MPSCnnConvolutionGradientState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selResultStateBatchForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)) : NSArray.ArrayFromHandle<MPSCnnConvolutionGradientState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selResultStateBatchForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)));
		nSArray?.Dispose();
		return result;
	}

	[Export("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSCnnConvolutionGradientState? GetTemporaryResultState(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
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
			return Runtime.GetNSObject<MPSCnnConvolutionGradientState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
		}
		return Runtime.GetNSObject<MPSCnnConvolutionGradientState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
	}

	[Export("temporaryResultStateBatchForCommandBuffer:sourceImage:sourceStates:destinationImage:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSCnnConvolutionGradientState[]? GetTemporaryResultStateBatch(IMTLCommandBuffer commandBuffer, NSArray<MPSImage> sourceImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
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
		NSArray nSArray = ((sourceStates == null) ? null : NSArray.FromNSObjects(sourceStates));
		MPSCnnConvolutionGradientState[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<MPSCnnConvolutionGradientState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)) : NSArray.ArrayFromHandle<MPSCnnConvolutionGradientState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTemporaryResultStateBatchForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, nSArray?.Handle ?? IntPtr.Zero, destinationImage.Handle)));
		nSArray?.Dispose();
		return result;
	}

	[Export("initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithDevice(IMTLDevice device, MPSCnnConvolutionDescriptor convolutionDescriptor, IntPtr kernelWeights, IntPtr biasTerms, MPSCnnConvolutionFlags flags)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (convolutionDescriptor == null)
		{
			throw new ArgumentNullException("convolutionDescriptor");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(base.Handle, selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_Handle, device.Handle, convolutionDescriptor.Handle, kernelWeights, biasTerms, (ulong)flags);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithDevice_ConvolutionDescriptor_KernelWeights_BiasTerms_Flags_Handle, device.Handle, convolutionDescriptor.Handle, kernelWeights, biasTerms, (ulong)flags);
	}

	[Export("reloadWeightsAndBiasesWithDataSource:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Please use 'ReloadWeightsAndBiasesFromDataSource' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Please use 'ReloadWeightsAndBiasesFromDataSource' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Please use 'ReloadWeightsAndBiasesFromDataSource' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadWeightsAndBiases(IMPSCnnConvolutionDataSource dataSource)
	{
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReloadWeightsAndBiasesWithDataSource_Handle, dataSource.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReloadWeightsAndBiasesWithDataSource_Handle, dataSource.Handle);
		}
	}

	[Export("reloadWeightsAndBiasesWithCommandBuffer:state:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadWeightsAndBiases(IMTLCommandBuffer commandBuffer, MPSCnnConvolutionWeightsAndBiasesState state)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (state == null)
		{
			throw new ArgumentNullException("state");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReloadWeightsAndBiasesWithCommandBuffer_State_Handle, commandBuffer.Handle, state.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReloadWeightsAndBiasesWithCommandBuffer_State_Handle, commandBuffer.Handle, state.Handle);
		}
	}

	[Export("reloadWeightsAndBiasesFromDataSource")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadWeightsAndBiasesFromDataSource()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadWeightsAndBiasesFromDataSourceHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadWeightsAndBiasesFromDataSourceHandle);
		}
	}
}
