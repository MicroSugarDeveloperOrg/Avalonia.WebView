using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNConvolutionWeightsAndBiasesState", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnConvolutionWeightsAndBiasesState : MPSState
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBiases = "biases";

	private static readonly IntPtr selBiasesHandle = Selector.GetHandle("biases");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_CnnConvolutionDescriptor_ = "initWithDevice:cnnConvolutionDescriptor:";

	private static readonly IntPtr selInitWithDevice_CnnConvolutionDescriptor_Handle = Selector.GetHandle("initWithDevice:cnnConvolutionDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithWeights_Biases_ = "initWithWeights:biases:";

	private static readonly IntPtr selInitWithWeights_Biases_Handle = Selector.GetHandle("initWithWeights:biases:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryCNNConvolutionWeightsAndBiasesStateWithCommandBuffer_CnnConvolutionDescriptor_ = "temporaryCNNConvolutionWeightsAndBiasesStateWithCommandBuffer:cnnConvolutionDescriptor:";

	private static readonly IntPtr selTemporaryCNNConvolutionWeightsAndBiasesStateWithCommandBuffer_CnnConvolutionDescriptor_Handle = Selector.GetHandle("temporaryCNNConvolutionWeightsAndBiasesStateWithCommandBuffer:cnnConvolutionDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeights = "weights";

	private static readonly IntPtr selWeightsHandle = Selector.GetHandle("weights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNConvolutionWeightsAndBiasesState");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer? Biases
	{
		[Export("biases")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selBiasesHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBiasesHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer Weights
	{
		[Export("weights")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWeightsHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnConvolutionWeightsAndBiasesState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnConvolutionWeightsAndBiasesState(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithWeights:biases:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnConvolutionWeightsAndBiasesState(IMTLBuffer weights, IMTLBuffer? biases)
		: base(NSObjectFlag.Empty)
	{
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithWeights_Biases_Handle, weights.Handle, biases?.Handle ?? IntPtr.Zero), "initWithWeights:biases:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithWeights_Biases_Handle, weights.Handle, biases?.Handle ?? IntPtr.Zero), "initWithWeights:biases:");
		}
	}

	[Export("initWithDevice:cnnConvolutionDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnConvolutionWeightsAndBiasesState(IMTLDevice device, MPSCnnConvolutionDescriptor descriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_CnnConvolutionDescriptor_Handle, device.Handle, descriptor.Handle), "initWithDevice:cnnConvolutionDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_CnnConvolutionDescriptor_Handle, device.Handle, descriptor.Handle), "initWithDevice:cnnConvolutionDescriptor:");
		}
	}

	[Export("temporaryCNNConvolutionWeightsAndBiasesStateWithCommandBuffer:cnnConvolutionDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnConvolutionWeightsAndBiasesState GetTemporaryCnnConvolutionWeightsAndBiasesState(IMTLCommandBuffer commandBuffer, MPSCnnConvolutionDescriptor descriptor)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetNSObject<MPSCnnConvolutionWeightsAndBiasesState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemporaryCNNConvolutionWeightsAndBiasesStateWithCommandBuffer_CnnConvolutionDescriptor_Handle, commandBuffer.Handle, descriptor.Handle));
	}
}
