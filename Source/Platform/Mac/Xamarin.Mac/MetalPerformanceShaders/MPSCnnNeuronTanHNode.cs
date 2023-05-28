using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNNeuronTanHNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnNeuronTanHNode : MPSCnnNeuronNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_ = "initWithSource:";

	private static readonly IntPtr selInitWithSource_Handle = Selector.GetHandle("initWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_A_B_ = "initWithSource:a:b:";

	private static readonly IntPtr selInitWithSource_A_B_Handle = Selector.GetHandle("initWithSource:a:b:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_ = "nodeWithSource:";

	private static readonly IntPtr selNodeWithSource_Handle = Selector.GetHandle("nodeWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_A_B_ = "nodeWithSource:a:b:";

	private static readonly IntPtr selNodeWithSource_A_B_Handle = Selector.GetHandle("nodeWithSource:a:b:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNNeuronTanHNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnNeuronTanHNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnNeuronTanHNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:a:b:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnNeuronTanHNode(MPSNNImageNode sourceNode, float a, float b)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float_float(base.Handle, selInitWithSource_A_B_Handle, sourceNode.Handle, a, b), "initWithSource:a:b:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float_float(base.SuperHandle, selInitWithSource_A_B_Handle, sourceNode.Handle, a, b), "initWithSource:a:b:");
		}
	}

	[Export("initWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnNeuronTanHNode(MPSNNImageNode sourceNode)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSource_Handle, sourceNode.Handle), "initWithSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSource_Handle, sourceNode.Handle), "initWithSource:");
		}
	}

	[Export("nodeWithSource:a:b:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnNeuronTanHNode Create(MPSNNImageNode sourceNode, float a, float b)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSCnnNeuronTanHNode>(Messaging.IntPtr_objc_msgSend_IntPtr_float_float(class_ptr, selNodeWithSource_A_B_Handle, sourceNode.Handle, a, b));
	}

	[Export("nodeWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnNeuronTanHNode Create(MPSNNImageNode sourceNode)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSCnnNeuronTanHNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNodeWithSource_Handle, sourceNode.Handle));
	}
}
