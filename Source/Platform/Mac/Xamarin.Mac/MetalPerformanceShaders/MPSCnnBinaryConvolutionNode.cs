using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNBinaryConvolutionNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnBinaryConvolutionNode : MPSCnnConvolutionNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_Weights_OutputBiasTerms_OutputScaleTerms_InputBiasTerms_InputScaleTerms_Type_Flags_ = "initWithSource:weights:outputBiasTerms:outputScaleTerms:inputBiasTerms:inputScaleTerms:type:flags:";

	private static readonly IntPtr selInitWithSource_Weights_OutputBiasTerms_OutputScaleTerms_InputBiasTerms_InputScaleTerms_Type_Flags_Handle = Selector.GetHandle("initWithSource:weights:outputBiasTerms:outputScaleTerms:inputBiasTerms:inputScaleTerms:type:flags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_Weights_ScaleValue_Type_Flags_ = "initWithSource:weights:scaleValue:type:flags:";

	private static readonly IntPtr selInitWithSource_Weights_ScaleValue_Type_Flags_Handle = Selector.GetHandle("initWithSource:weights:scaleValue:type:flags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_Weights_OutputBiasTerms_OutputScaleTerms_InputBiasTerms_InputScaleTerms_Type_Flags_ = "nodeWithSource:weights:outputBiasTerms:outputScaleTerms:inputBiasTerms:inputScaleTerms:type:flags:";

	private static readonly IntPtr selNodeWithSource_Weights_OutputBiasTerms_OutputScaleTerms_InputBiasTerms_InputScaleTerms_Type_Flags_Handle = Selector.GetHandle("nodeWithSource:weights:outputBiasTerms:outputScaleTerms:inputBiasTerms:inputScaleTerms:type:flags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_Weights_ScaleValue_Type_Flags_ = "nodeWithSource:weights:scaleValue:type:flags:";

	private static readonly IntPtr selNodeWithSource_Weights_ScaleValue_Type_Flags_Handle = Selector.GetHandle("nodeWithSource:weights:scaleValue:type:flags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNBinaryConvolutionNode");

	public override IntPtr ClassHandle => class_ptr;

	[TV(11, 3)]
	[Mac(10, 13, 4)]
	[iOS(11, 3)]
	public unsafe static MPSCnnBinaryConvolutionNode Create(MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights, float[] outputBiasTerms, float[] outputScaleTerms, float[] inputBiasTerms, float[] inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
	{
		fixed (float* ptr = outputBiasTerms)
		{
			void* ptr2 = ptr;
			fixed (float* ptr3 = outputScaleTerms)
			{
				void* ptr4 = ptr3;
				fixed (float* ptr5 = inputBiasTerms)
				{
					void* ptr6 = ptr5;
					fixed (float* ptr7 = inputScaleTerms)
					{
						void* ptr8 = ptr7;
						return Create(sourceNode, weights, (IntPtr)ptr2, (IntPtr)ptr4, (IntPtr)ptr6, (IntPtr)ptr8, type, flags);
					}
				}
			}
		}
	}

	[TV(11, 3)]
	[Mac(10, 13, 4)]
	[iOS(11, 3)]
	public unsafe MPSCnnBinaryConvolutionNode(MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights, float[] outputBiasTerms, float[] outputScaleTerms, float[] inputBiasTerms, float[] inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
		: base(NSObjectFlag.Empty)
	{
		fixed (float* ptr = outputBiasTerms)
		{
			void* ptr2 = ptr;
			fixed (float* ptr3 = outputScaleTerms)
			{
				void* ptr4 = ptr3;
				fixed (float* ptr5 = inputBiasTerms)
				{
					void* ptr6 = ptr5;
					fixed (float* ptr7 = inputScaleTerms)
					{
						void* ptr8 = ptr7;
						InitializeHandle(InitWithSource(sourceNode, weights, (IntPtr)ptr2, (IntPtr)ptr4, (IntPtr)ptr6, (IntPtr)ptr8, type, flags));
					}
				}
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnBinaryConvolutionNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnBinaryConvolutionNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:weights:scaleValue:type:flags:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBinaryConvolutionNode(MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights, float scaleValue, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_float_UInt64_UInt64(base.Handle, selInitWithSource_Weights_ScaleValue_Type_Flags_Handle, sourceNode.Handle, weights.Handle, scaleValue, (ulong)type, (ulong)flags), "initWithSource:weights:scaleValue:type:flags:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_float_UInt64_UInt64(base.SuperHandle, selInitWithSource_Weights_ScaleValue_Type_Flags_Handle, sourceNode.Handle, weights.Handle, scaleValue, (ulong)type, (ulong)flags), "initWithSource:weights:scaleValue:type:flags:");
		}
	}

	[Export("nodeWithSource:weights:scaleValue:type:flags:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnBinaryConvolutionNode Create(MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights, float scaleValue, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		return Runtime.GetNSObject<MPSCnnBinaryConvolutionNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_float_UInt64_UInt64(class_ptr, selNodeWithSource_Weights_ScaleValue_Type_Flags_Handle, sourceNode.Handle, weights.Handle, scaleValue, (ulong)type, (ulong)flags));
	}

	[Export("nodeWithSource:weights:outputBiasTerms:outputScaleTerms:inputBiasTerms:inputScaleTerms:type:flags:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static MPSCnnBinaryConvolutionNode Create(MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights, IntPtr outputBiasTerms, IntPtr outputScaleTerms, IntPtr inputBiasTerms, IntPtr inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		return Runtime.GetNSObject<MPSCnnBinaryConvolutionNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_UInt64_UInt64(class_ptr, selNodeWithSource_Weights_OutputBiasTerms_OutputScaleTerms_InputBiasTerms_InputScaleTerms_Type_Flags_Handle, sourceNode.Handle, weights.Handle, outputBiasTerms, outputScaleTerms, inputBiasTerms, inputScaleTerms, (ulong)type, (ulong)flags));
	}

	[Export("initWithSource:weights:outputBiasTerms:outputScaleTerms:inputBiasTerms:inputScaleTerms:type:flags:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithSource(MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights, IntPtr outputBiasTerms, IntPtr outputScaleTerms, IntPtr inputBiasTerms, IntPtr inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_UInt64_UInt64(base.Handle, selInitWithSource_Weights_OutputBiasTerms_OutputScaleTerms_InputBiasTerms_InputScaleTerms_Type_Flags_Handle, sourceNode.Handle, weights.Handle, outputBiasTerms, outputScaleTerms, inputBiasTerms, inputScaleTerms, (ulong)type, (ulong)flags);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_UInt64_UInt64(base.SuperHandle, selInitWithSource_Weights_OutputBiasTerms_OutputScaleTerms_InputBiasTerms_InputScaleTerms_Type_Flags_Handle, sourceNode.Handle, weights.Handle, outputBiasTerms, outputScaleTerms, inputBiasTerms, inputScaleTerms, (ulong)type, (ulong)flags);
	}
}
