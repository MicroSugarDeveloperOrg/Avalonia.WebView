using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNLogSoftMaxNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnLogSoftMaxNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_ = "initWithSource:";

	private static readonly IntPtr selInitWithSource_Handle = Selector.GetHandle("initWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_ = "nodeWithSource:";

	private static readonly IntPtr selNodeWithSource_Handle = Selector.GetHandle("nodeWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNLogSoftMaxNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnLogSoftMaxNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnLogSoftMaxNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnLogSoftMaxNode(MPSNNImageNode sourceNode)
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

	[Export("nodeWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnLogSoftMaxNode Create(MPSNNImageNode sourceNode)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSCnnLogSoftMaxNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNodeWithSource_Handle, sourceNode.Handle));
	}
}
