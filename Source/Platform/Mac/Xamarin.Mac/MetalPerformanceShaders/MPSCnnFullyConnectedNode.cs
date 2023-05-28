using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNFullyConnectedNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnFullyConnectedNode : MPSCnnConvolutionNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_Weights_ = "initWithSource:weights:";

	private static readonly IntPtr selInitWithSource_Weights_Handle = Selector.GetHandle("initWithSource:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_Weights_ = "nodeWithSource:weights:";

	private static readonly IntPtr selNodeWithSource_Weights_Handle = Selector.GetHandle("nodeWithSource:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNFullyConnectedNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnFullyConnectedNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnFullyConnectedNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:weights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnFullyConnectedNode(MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights)
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
	public new static MPSCnnFullyConnectedNode Create(MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		return Runtime.GetNSObject<MPSCnnFullyConnectedNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selNodeWithSource_Weights_Handle, sourceNode.Handle, weights.Handle));
	}
}
