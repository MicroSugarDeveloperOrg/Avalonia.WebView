using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNPoolingAverageNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnPoolingAverageNode : MPSCnnPoolingNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_FilterSize_ = "initWithSource:filterSize:";

	private static readonly IntPtr selInitWithSource_FilterSize_Handle = Selector.GetHandle("initWithSource:filterSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_FilterSize_Stride_ = "initWithSource:filterSize:stride:";

	private static readonly IntPtr selInitWithSource_FilterSize_Stride_Handle = Selector.GetHandle("initWithSource:filterSize:stride:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_ = "initWithSource:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:";

	private static readonly IntPtr selInitWithSource_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_Handle = Selector.GetHandle("initWithSource:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNPoolingAverageNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnPoolingAverageNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnPoolingAverageNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnPoolingAverageNode(MPSNNImageNode sourceNode, nuint kernelWidth, nuint kernelHeight, nuint strideInPixelsX, nuint strideInPixelsY)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_nuint_nuint(base.Handle, selInitWithSource_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_Handle, sourceNode.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY), "initWithSource:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_nuint_nuint(base.SuperHandle, selInitWithSource_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_Handle, sourceNode.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY), "initWithSource:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:");
		}
	}

	[Export("initWithSource:filterSize:stride:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnPoolingAverageNode(MPSNNImageNode sourceNode, nuint size, nuint stride)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint(base.Handle, selInitWithSource_FilterSize_Stride_Handle, sourceNode.Handle, size, stride), "initWithSource:filterSize:stride:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint(base.SuperHandle, selInitWithSource_FilterSize_Stride_Handle, sourceNode.Handle, size, stride), "initWithSource:filterSize:stride:");
		}
	}

	[Export("initWithSource:filterSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnPoolingAverageNode(MPSNNImageNode sourceNode, nuint size)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selInitWithSource_FilterSize_Handle, sourceNode.Handle, size), "initWithSource:filterSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selInitWithSource_FilterSize_Handle, sourceNode.Handle, size), "initWithSource:filterSize:");
		}
	}
}
