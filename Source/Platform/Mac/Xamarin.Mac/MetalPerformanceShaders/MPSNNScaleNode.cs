using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNScaleNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSNNScaleNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_OutputSize_ = "initWithSource:outputSize:";

	private static readonly IntPtr selInitWithSource_OutputSize_Handle = Selector.GetHandle("initWithSource:outputSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_TransformProvider_OutputSize_ = "initWithSource:transformProvider:outputSize:";

	private static readonly IntPtr selInitWithSource_TransformProvider_OutputSize_Handle = Selector.GetHandle("initWithSource:transformProvider:outputSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_OutputSize_ = "nodeWithSource:outputSize:";

	private static readonly IntPtr selNodeWithSource_OutputSize_Handle = Selector.GetHandle("nodeWithSource:outputSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_TransformProvider_OutputSize_ = "nodeWithSource:transformProvider:outputSize:";

	private static readonly IntPtr selNodeWithSource_TransformProvider_OutputSize_Handle = Selector.GetHandle("nodeWithSource:transformProvider:outputSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNScaleNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNScaleNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNScaleNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:outputSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNScaleNode(MPSNNImageNode sourceNode, MTLSize size)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_MTLSize(base.Handle, selInitWithSource_OutputSize_Handle, sourceNode.Handle, size), "initWithSource:outputSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_MTLSize(base.SuperHandle, selInitWithSource_OutputSize_Handle, sourceNode.Handle, size), "initWithSource:outputSize:");
		}
	}

	[Export("initWithSource:transformProvider:outputSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNScaleNode(MPSNNImageNode sourceNode, IMPSImageTransformProvider? transformProvider, MTLSize size)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_MTLSize(base.Handle, selInitWithSource_TransformProvider_OutputSize_Handle, sourceNode.Handle, transformProvider?.Handle ?? IntPtr.Zero, size), "initWithSource:transformProvider:outputSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_MTLSize(base.SuperHandle, selInitWithSource_TransformProvider_OutputSize_Handle, sourceNode.Handle, transformProvider?.Handle ?? IntPtr.Zero, size), "initWithSource:transformProvider:outputSize:");
		}
	}

	[Export("nodeWithSource:outputSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNScaleNode Create(MPSNNImageNode sourceNode, MTLSize size)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSNNScaleNode>(Messaging.IntPtr_objc_msgSend_IntPtr_MTLSize(class_ptr, selNodeWithSource_OutputSize_Handle, sourceNode.Handle, size));
	}

	[Export("nodeWithSource:transformProvider:outputSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNScaleNode Create(MPSNNImageNode sourceNode, IMPSImageTransformProvider? transformProvider, MTLSize size)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSNNScaleNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_MTLSize(class_ptr, selNodeWithSource_TransformProvider_OutputSize_Handle, sourceNode.Handle, transformProvider?.Handle ?? IntPtr.Zero, size));
	}
}
