using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSLSTMDescriptor", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSLSTMDescriptor : MPSRnnDescriptor
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellGateInputWeights = "cellGateInputWeights";

	private static readonly IntPtr selCellGateInputWeightsHandle = Selector.GetHandle("cellGateInputWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellGateMemoryWeights = "cellGateMemoryWeights";

	private static readonly IntPtr selCellGateMemoryWeightsHandle = Selector.GetHandle("cellGateMemoryWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellGateRecurrentWeights = "cellGateRecurrentWeights";

	private static readonly IntPtr selCellGateRecurrentWeightsHandle = Selector.GetHandle("cellGateRecurrentWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellToOutputNeuronParamA = "cellToOutputNeuronParamA";

	private static readonly IntPtr selCellToOutputNeuronParamAHandle = Selector.GetHandle("cellToOutputNeuronParamA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellToOutputNeuronParamB = "cellToOutputNeuronParamB";

	private static readonly IntPtr selCellToOutputNeuronParamBHandle = Selector.GetHandle("cellToOutputNeuronParamB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellToOutputNeuronParamC = "cellToOutputNeuronParamC";

	private static readonly IntPtr selCellToOutputNeuronParamCHandle = Selector.GetHandle("cellToOutputNeuronParamC");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellToOutputNeuronType = "cellToOutputNeuronType";

	private static readonly IntPtr selCellToOutputNeuronTypeHandle = Selector.GetHandle("cellToOutputNeuronType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateLSTMDescriptorWithInputFeatureChannels_OutputFeatureChannels_ = "createLSTMDescriptorWithInputFeatureChannels:outputFeatureChannels:";

	private static readonly IntPtr selCreateLSTMDescriptorWithInputFeatureChannels_OutputFeatureChannels_Handle = Selector.GetHandle("createLSTMDescriptorWithInputFeatureChannels:outputFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForgetGateInputWeights = "forgetGateInputWeights";

	private static readonly IntPtr selForgetGateInputWeightsHandle = Selector.GetHandle("forgetGateInputWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForgetGateMemoryWeights = "forgetGateMemoryWeights";

	private static readonly IntPtr selForgetGateMemoryWeightsHandle = Selector.GetHandle("forgetGateMemoryWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForgetGateRecurrentWeights = "forgetGateRecurrentWeights";

	private static readonly IntPtr selForgetGateRecurrentWeightsHandle = Selector.GetHandle("forgetGateRecurrentWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputGateInputWeights = "inputGateInputWeights";

	private static readonly IntPtr selInputGateInputWeightsHandle = Selector.GetHandle("inputGateInputWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputGateMemoryWeights = "inputGateMemoryWeights";

	private static readonly IntPtr selInputGateMemoryWeightsHandle = Selector.GetHandle("inputGateMemoryWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputGateRecurrentWeights = "inputGateRecurrentWeights";

	private static readonly IntPtr selInputGateRecurrentWeightsHandle = Selector.GetHandle("inputGateRecurrentWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMemoryWeightsAreDiagonal = "memoryWeightsAreDiagonal";

	private static readonly IntPtr selMemoryWeightsAreDiagonalHandle = Selector.GetHandle("memoryWeightsAreDiagonal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputGateInputWeights = "outputGateInputWeights";

	private static readonly IntPtr selOutputGateInputWeightsHandle = Selector.GetHandle("outputGateInputWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputGateMemoryWeights = "outputGateMemoryWeights";

	private static readonly IntPtr selOutputGateMemoryWeightsHandle = Selector.GetHandle("outputGateMemoryWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputGateRecurrentWeights = "outputGateRecurrentWeights";

	private static readonly IntPtr selOutputGateRecurrentWeightsHandle = Selector.GetHandle("outputGateRecurrentWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellGateInputWeights_ = "setCellGateInputWeights:";

	private static readonly IntPtr selSetCellGateInputWeights_Handle = Selector.GetHandle("setCellGateInputWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellGateMemoryWeights_ = "setCellGateMemoryWeights:";

	private static readonly IntPtr selSetCellGateMemoryWeights_Handle = Selector.GetHandle("setCellGateMemoryWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellGateRecurrentWeights_ = "setCellGateRecurrentWeights:";

	private static readonly IntPtr selSetCellGateRecurrentWeights_Handle = Selector.GetHandle("setCellGateRecurrentWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellToOutputNeuronParamA_ = "setCellToOutputNeuronParamA:";

	private static readonly IntPtr selSetCellToOutputNeuronParamA_Handle = Selector.GetHandle("setCellToOutputNeuronParamA:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellToOutputNeuronParamB_ = "setCellToOutputNeuronParamB:";

	private static readonly IntPtr selSetCellToOutputNeuronParamB_Handle = Selector.GetHandle("setCellToOutputNeuronParamB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellToOutputNeuronParamC_ = "setCellToOutputNeuronParamC:";

	private static readonly IntPtr selSetCellToOutputNeuronParamC_Handle = Selector.GetHandle("setCellToOutputNeuronParamC:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellToOutputNeuronType_ = "setCellToOutputNeuronType:";

	private static readonly IntPtr selSetCellToOutputNeuronType_Handle = Selector.GetHandle("setCellToOutputNeuronType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetForgetGateInputWeights_ = "setForgetGateInputWeights:";

	private static readonly IntPtr selSetForgetGateInputWeights_Handle = Selector.GetHandle("setForgetGateInputWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetForgetGateMemoryWeights_ = "setForgetGateMemoryWeights:";

	private static readonly IntPtr selSetForgetGateMemoryWeights_Handle = Selector.GetHandle("setForgetGateMemoryWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetForgetGateRecurrentWeights_ = "setForgetGateRecurrentWeights:";

	private static readonly IntPtr selSetForgetGateRecurrentWeights_Handle = Selector.GetHandle("setForgetGateRecurrentWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInputGateInputWeights_ = "setInputGateInputWeights:";

	private static readonly IntPtr selSetInputGateInputWeights_Handle = Selector.GetHandle("setInputGateInputWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInputGateMemoryWeights_ = "setInputGateMemoryWeights:";

	private static readonly IntPtr selSetInputGateMemoryWeights_Handle = Selector.GetHandle("setInputGateMemoryWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInputGateRecurrentWeights_ = "setInputGateRecurrentWeights:";

	private static readonly IntPtr selSetInputGateRecurrentWeights_Handle = Selector.GetHandle("setInputGateRecurrentWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMemoryWeightsAreDiagonal_ = "setMemoryWeightsAreDiagonal:";

	private static readonly IntPtr selSetMemoryWeightsAreDiagonal_Handle = Selector.GetHandle("setMemoryWeightsAreDiagonal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputGateInputWeights_ = "setOutputGateInputWeights:";

	private static readonly IntPtr selSetOutputGateInputWeights_Handle = Selector.GetHandle("setOutputGateInputWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputGateMemoryWeights_ = "setOutputGateMemoryWeights:";

	private static readonly IntPtr selSetOutputGateMemoryWeights_Handle = Selector.GetHandle("setOutputGateMemoryWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputGateRecurrentWeights_ = "setOutputGateRecurrentWeights:";

	private static readonly IntPtr selSetOutputGateRecurrentWeights_Handle = Selector.GetHandle("setOutputGateRecurrentWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSLSTMDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AreMemoryWeightsDiagonal
	{
		[Export("memoryWeightsAreDiagonal")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMemoryWeightsAreDiagonalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMemoryWeightsAreDiagonalHandle);
		}
		[Export("setMemoryWeightsAreDiagonal:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMemoryWeightsAreDiagonal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMemoryWeightsAreDiagonal_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? CellGateInputWeights
	{
		[Export("cellGateInputWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selCellGateInputWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellGateInputWeightsHandle), owns: false);
		}
		[Export("setCellGateInputWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCellGateInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCellGateInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? CellGateMemoryWeights
	{
		[Export("cellGateMemoryWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selCellGateMemoryWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellGateMemoryWeightsHandle), owns: false);
		}
		[Export("setCellGateMemoryWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCellGateMemoryWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCellGateMemoryWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? CellGateRecurrentWeights
	{
		[Export("cellGateRecurrentWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selCellGateRecurrentWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCellGateRecurrentWeightsHandle), owns: false);
		}
		[Export("setCellGateRecurrentWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCellGateRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCellGateRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float CellToOutputNeuronParamA
	{
		[Export("cellToOutputNeuronParamA")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selCellToOutputNeuronParamAHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selCellToOutputNeuronParamAHandle);
		}
		[Export("setCellToOutputNeuronParamA:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetCellToOutputNeuronParamA_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetCellToOutputNeuronParamA_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float CellToOutputNeuronParamB
	{
		[Export("cellToOutputNeuronParamB")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selCellToOutputNeuronParamBHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selCellToOutputNeuronParamBHandle);
		}
		[Export("setCellToOutputNeuronParamB:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetCellToOutputNeuronParamB_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetCellToOutputNeuronParamB_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
	public virtual float CellToOutputNeuronParamC
	{
		[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
		[Export("cellToOutputNeuronParamC")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selCellToOutputNeuronParamCHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selCellToOutputNeuronParamCHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
		[Export("setCellToOutputNeuronParamC:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetCellToOutputNeuronParamC_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetCellToOutputNeuronParamC_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnNeuronType CellToOutputNeuronType
	{
		[Export("cellToOutputNeuronType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSCnnNeuronType)Messaging.int_objc_msgSend(base.Handle, selCellToOutputNeuronTypeHandle);
			}
			return (MPSCnnNeuronType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selCellToOutputNeuronTypeHandle);
		}
		[Export("setCellToOutputNeuronType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetCellToOutputNeuronType_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetCellToOutputNeuronType_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? ForgetGateInputWeights
	{
		[Export("forgetGateInputWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selForgetGateInputWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selForgetGateInputWeightsHandle), owns: false);
		}
		[Export("setForgetGateInputWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetForgetGateInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetForgetGateInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? ForgetGateMemoryWeights
	{
		[Export("forgetGateMemoryWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selForgetGateMemoryWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selForgetGateMemoryWeightsHandle), owns: false);
		}
		[Export("setForgetGateMemoryWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetForgetGateMemoryWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetForgetGateMemoryWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? ForgetGateRecurrentWeights
	{
		[Export("forgetGateRecurrentWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selForgetGateRecurrentWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selForgetGateRecurrentWeightsHandle), owns: false);
		}
		[Export("setForgetGateRecurrentWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetForgetGateRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetForgetGateRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
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
	public virtual IMPSCnnConvolutionDataSource? InputGateMemoryWeights
	{
		[Export("inputGateMemoryWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputGateMemoryWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputGateMemoryWeightsHandle), owns: false);
		}
		[Export("setInputGateMemoryWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInputGateMemoryWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInputGateMemoryWeights_Handle, value?.Handle ?? IntPtr.Zero);
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
	public virtual IMPSCnnConvolutionDataSource? OutputGateMemoryWeights
	{
		[Export("outputGateMemoryWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputGateMemoryWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputGateMemoryWeightsHandle), owns: false);
		}
		[Export("setOutputGateMemoryWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutputGateMemoryWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutputGateMemoryWeights_Handle, value?.Handle ?? IntPtr.Zero);
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MPSLSTMDescriptor()
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
	protected MPSLSTMDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSLSTMDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("createLSTMDescriptorWithInputFeatureChannels:outputFeatureChannels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSLSTMDescriptor Create(nuint inputFeatureChannels, nuint outputFeatureChannels)
	{
		return Runtime.GetNSObject<MPSLSTMDescriptor>(Messaging.IntPtr_objc_msgSend_nuint_nuint(class_ptr, selCreateLSTMDescriptorWithInputFeatureChannels_OutputFeatureChannels_Handle, inputFeatureChannels, outputFeatureChannels));
	}
}
