using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNNeuronPReLUNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnNeuronPReLUNode : MPSCnnNeuronNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_AData_ = "initWithSource:aData:";

	private static readonly IntPtr selInitWithSource_AData_Handle = Selector.GetHandle("initWithSource:aData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_AData_ = "nodeWithSource:aData:";

	private static readonly IntPtr selNodeWithSource_AData_Handle = Selector.GetHandle("nodeWithSource:aData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNNeuronPReLUNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnNeuronPReLUNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnNeuronPReLUNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:aData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnNeuronPReLUNode(MPSNNImageNode sourceNode, NSData aData)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (aData == null)
		{
			throw new ArgumentNullException("aData");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSource_AData_Handle, sourceNode.Handle, aData.Handle), "initWithSource:aData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSource_AData_Handle, sourceNode.Handle, aData.Handle), "initWithSource:aData:");
		}
	}

	[Export("nodeWithSource:aData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnNeuronPReLUNode Create(MPSNNImageNode sourceNode, NSData aData)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (aData == null)
		{
			throw new ArgumentNullException("aData");
		}
		return Runtime.GetNSObject<MPSCnnNeuronPReLUNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selNodeWithSource_AData_Handle, sourceNode.Handle, aData.Handle));
	}
}
