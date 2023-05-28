using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNBilinearScaleNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSNNBilinearScaleNode : MPSNNScaleNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_OutputSize_ = "initWithSource:outputSize:";

	private static readonly IntPtr selInitWithSource_OutputSize_Handle = Selector.GetHandle("initWithSource:outputSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_TransformProvider_OutputSize_ = "initWithSource:transformProvider:outputSize:";

	private static readonly IntPtr selInitWithSource_TransformProvider_OutputSize_Handle = Selector.GetHandle("initWithSource:transformProvider:outputSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNBilinearScaleNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNBilinearScaleNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNBilinearScaleNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:outputSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNBilinearScaleNode(MPSNNImageNode sourceNode, MTLSize size)
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
	public MPSNNBilinearScaleNode(MPSNNImageNode sourceNode, IMPSImageTransformProvider? transformProvider, MTLSize size)
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
}
