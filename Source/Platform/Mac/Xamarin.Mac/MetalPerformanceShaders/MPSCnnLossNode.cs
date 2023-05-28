using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNLossNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnLossNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_LossDescriptor_ = "initWithSource:lossDescriptor:";

	private static readonly IntPtr selInitWithSource_LossDescriptor_Handle = Selector.GetHandle("initWithSource:lossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputLabels = "inputLabels";

	private static readonly IntPtr selInputLabelsHandle = Selector.GetHandle("inputLabels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_LossDescriptor_ = "nodeWithSource:lossDescriptor:";

	private static readonly IntPtr selNodeWithSource_LossDescriptor_Handle = Selector.GetHandle("nodeWithSource:lossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNLossNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNLabelsNode InputLabels
	{
		[Export("inputLabels", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSNNLabelsNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputLabelsHandle));
			}
			return Runtime.GetNSObject<MPSNNLabelsNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputLabelsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnLossNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnLossNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:lossDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnLossNode(MPSNNImageNode source, MPSCnnLossDescriptor descriptor)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSource_LossDescriptor_Handle, source.Handle, descriptor.Handle), "initWithSource:lossDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSource_LossDescriptor_Handle, source.Handle, descriptor.Handle), "initWithSource:lossDescriptor:");
		}
	}

	[Export("nodeWithSource:lossDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnLossNode Create(MPSNNImageNode source, MPSCnnLossDescriptor descriptor)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetNSObject<MPSCnnLossNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selNodeWithSource_LossDescriptor_Handle, source.Handle, descriptor.Handle));
	}
}
