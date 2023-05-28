using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSGRUDescriptor", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSGRUDescriptor : MPSRnnDescriptor
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateGRUDescriptorWithInputFeatureChannels_OutputFeatureChannels_ = "createGRUDescriptorWithInputFeatureChannels:outputFeatureChannels:";

	private static readonly IntPtr selCreateGRUDescriptorWithInputFeatureChannels_OutputFeatureChannels_Handle = Selector.GetHandle("createGRUDescriptorWithInputFeatureChannels:outputFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlipOutputGates = "flipOutputGates";

	private static readonly IntPtr selFlipOutputGatesHandle = Selector.GetHandle("flipOutputGates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGatePnormValue = "gatePnormValue";

	private static readonly IntPtr selGatePnormValueHandle = Selector.GetHandle("gatePnormValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputGateInputWeights = "inputGateInputWeights";

	private static readonly IntPtr selInputGateInputWeightsHandle = Selector.GetHandle("inputGateInputWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputGateRecurrentWeights = "inputGateRecurrentWeights";

	private static readonly IntPtr selInputGateRecurrentWeightsHandle = Selector.GetHandle("inputGateRecurrentWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputGateInputGateWeights = "outputGateInputGateWeights";

	private static readonly IntPtr selOutputGateInputGateWeightsHandle = Selector.GetHandle("outputGateInputGateWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputGateInputWeights = "outputGateInputWeights";

	private static readonly IntPtr selOutputGateInputWeightsHandle = Selector.GetHandle("outputGateInputWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputGateRecurrentWeights = "outputGateRecurrentWeights";

	private static readonly IntPtr selOutputGateRecurrentWeightsHandle = Selector.GetHandle("outputGateRecurrentWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecurrentGateInputWeights = "recurrentGateInputWeights";

	private static readonly IntPtr selRecurrentGateInputWeightsHandle = Selector.GetHandle("recurrentGateInputWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecurrentGateRecurrentWeights = "recurrentGateRecurrentWeights";

	private static readonly IntPtr selRecurrentGateRecurrentWeightsHandle = Selector.GetHandle("recurrentGateRecurrentWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFlipOutputGates_ = "setFlipOutputGates:";

	private static readonly IntPtr selSetFlipOutputGates_Handle = Selector.GetHandle("setFlipOutputGates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGatePnormValue_ = "setGatePnormValue:";

	private static readonly IntPtr selSetGatePnormValue_Handle = Selector.GetHandle("setGatePnormValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInputGateInputWeights_ = "setInputGateInputWeights:";

	private static readonly IntPtr selSetInputGateInputWeights_Handle = Selector.GetHandle("setInputGateInputWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInputGateRecurrentWeights_ = "setInputGateRecurrentWeights:";

	private static readonly IntPtr selSetInputGateRecurrentWeights_Handle = Selector.GetHandle("setInputGateRecurrentWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputGateInputGateWeights_ = "setOutputGateInputGateWeights:";

	private static readonly IntPtr selSetOutputGateInputGateWeights_Handle = Selector.GetHandle("setOutputGateInputGateWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputGateInputWeights_ = "setOutputGateInputWeights:";

	private static readonly IntPtr selSetOutputGateInputWeights_Handle = Selector.GetHandle("setOutputGateInputWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputGateRecurrentWeights_ = "setOutputGateRecurrentWeights:";

	private static readonly IntPtr selSetOutputGateRecurrentWeights_Handle = Selector.GetHandle("setOutputGateRecurrentWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecurrentGateInputWeights_ = "setRecurrentGateInputWeights:";

	private static readonly IntPtr selSetRecurrentGateInputWeights_Handle = Selector.GetHandle("setRecurrentGateInputWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecurrentGateRecurrentWeights_ = "setRecurrentGateRecurrentWeights:";

	private static readonly IntPtr selSetRecurrentGateRecurrentWeights_Handle = Selector.GetHandle("setRecurrentGateRecurrentWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSGRUDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FlipOutputGates
	{
		[Export("flipOutputGates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFlipOutputGatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFlipOutputGatesHandle);
		}
		[Export("setFlipOutputGates:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFlipOutputGates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFlipOutputGates_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GatePnormValue
	{
		[Export("gatePnormValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGatePnormValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGatePnormValueHandle);
		}
		[Export("setGatePnormValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetGatePnormValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetGatePnormValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? InputGateInputWeights
	{
		[Export("inputGateInputWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputGateInputWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputGateInputWeightsHandle), owns: false);
		}
		[Export("setInputGateInputWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInputGateInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInputGateInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? InputGateRecurrentWeights
	{
		[Export("inputGateRecurrentWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputGateRecurrentWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputGateRecurrentWeightsHandle), owns: false);
		}
		[Export("setInputGateRecurrentWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInputGateRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInputGateRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? OutputGateInputGateWeights
	{
		[Export("outputGateInputGateWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputGateInputGateWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputGateInputGateWeightsHandle), owns: false);
		}
		[Export("setOutputGateInputGateWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutputGateInputGateWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutputGateInputGateWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? OutputGateInputWeights
	{
		[Export("outputGateInputWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputGateInputWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputGateInputWeightsHandle), owns: false);
		}
		[Export("setOutputGateInputWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutputGateInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutputGateInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? OutputGateRecurrentWeights
	{
		[Export("outputGateRecurrentWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputGateRecurrentWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputGateRecurrentWeightsHandle), owns: false);
		}
		[Export("setOutputGateRecurrentWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutputGateRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutputGateRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? RecurrentGateInputWeights
	{
		[Export("recurrentGateInputWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecurrentGateInputWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecurrentGateInputWeightsHandle), owns: false);
		}
		[Export("setRecurrentGateInputWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecurrentGateInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecurrentGateInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? RecurrentGateRecurrentWeights
	{
		[Export("recurrentGateRecurrentWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecurrentGateRecurrentWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecurrentGateRecurrentWeightsHandle), owns: false);
		}
		[Export("setRecurrentGateRecurrentWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecurrentGateRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecurrentGateRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MPSGRUDescriptor()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSGRUDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSGRUDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("createGRUDescriptorWithInputFeatureChannels:outputFeatureChannels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSGRUDescriptor Create(nuint inputFeatureChannels, nuint outputFeatureChannels)
	{
		return Runtime.GetNSObject<MPSGRUDescriptor>(Messaging.IntPtr_objc_msgSend_nuint_nuint(class_ptr, selCreateGRUDescriptorWithInputFeatureChannels_OutputFeatureChannels_Handle, inputFeatureChannels, outputFeatureChannels));
	}
}
