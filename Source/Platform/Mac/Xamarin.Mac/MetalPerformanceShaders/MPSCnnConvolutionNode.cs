using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNConvolutionNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnConvolutionNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccumulatorPrecision = "accumulatorPrecision";

	private static readonly IntPtr selAccumulatorPrecisionHandle = Selector.GetHandle("accumulatorPrecision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvolutionGradientState = "convolutionGradientState";

	private static readonly IntPtr selConvolutionGradientStateHandle = Selector.GetHandle("convolutionGradientState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvolutionState = "convolutionState";

	private static readonly IntPtr selConvolutionStateHandle = Selector.GetHandle("convolutionState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_Weights_ = "initWithSource:weights:";

	private static readonly IntPtr selInitWithSource_Weights_Handle = Selector.GetHandle("initWithSource:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_Weights_ = "nodeWithSource:weights:";

	private static readonly IntPtr selNodeWithSource_Weights_Handle = Selector.GetHandle("nodeWithSource:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccumulatorPrecision_ = "setAccumulatorPrecision:";

	private static readonly IntPtr selSetAccumulatorPrecision_Handle = Selector.GetHandle("setAccumulatorPrecision:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNConvolutionNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual MPSNNConvolutionAccumulatorPrecisionOption AccumulatorPrecision
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("accumulatorPrecision", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSNNConvolutionAccumulatorPrecisionOption)Messaging.UInt64_objc_msgSend(base.Handle, selAccumulatorPrecisionHandle);
			}
			return (MPSNNConvolutionAccumulatorPrecisionOption)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAccumulatorPrecisionHandle);
		}
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("setAccumulatorPrecision:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAccumulatorPrecision_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAccumulatorPrecision_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual MPSCnnConvolutionGradientStateNode? ConvolutionGradientState
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("convolutionGradientState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnConvolutionGradientStateNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selConvolutionGradientStateHandle));
			}
			return Runtime.GetNSObject<MPSCnnConvolutionGradientStateNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConvolutionGradientStateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnConvolutionStateNode? ConvolutionState
	{
		[Export("convolutionState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnConvolutionStateNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selConvolutionStateHandle));
			}
			return Runtime.GetNSObject<MPSCnnConvolutionStateNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConvolutionStateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnConvolutionNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnConvolutionNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:weights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnConvolutionNode(MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSource_Weights_Handle, sourceNode.Handle, weights.Handle), "initWithSource:weights:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSource_Weights_Handle, sourceNode.Handle, weights.Handle), "initWithSource:weights:");
		}
	}

	[Export("nodeWithSource:weights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnConvolutionNode Create(MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		return Runtime.GetNSObject<MPSCnnConvolutionNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selNodeWithSource_Weights_Handle, sourceNode.Handle, weights.Handle));
	}
}
