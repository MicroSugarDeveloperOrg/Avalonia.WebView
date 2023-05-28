using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNPoolingNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnPoolingNode : MPSNNFilterNode
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
	private const string selKernelHeight = "kernelHeight";

	private static readonly IntPtr selKernelHeightHandle = Selector.GetHandle("kernelHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWidth = "kernelWidth";

	private static readonly IntPtr selKernelWidthHandle = Selector.GetHandle("kernelWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_FilterSize_ = "nodeWithSource:filterSize:";

	private static readonly IntPtr selNodeWithSource_FilterSize_Handle = Selector.GetHandle("nodeWithSource:filterSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_FilterSize_Stride_ = "nodeWithSource:filterSize:stride:";

	private static readonly IntPtr selNodeWithSource_FilterSize_Stride_Handle = Selector.GetHandle("nodeWithSource:filterSize:stride:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrideInPixelsX = "strideInPixelsX";

	private static readonly IntPtr selStrideInPixelsXHandle = Selector.GetHandle("strideInPixelsX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrideInPixelsY = "strideInPixelsY";

	private static readonly IntPtr selStrideInPixelsYHandle = Selector.GetHandle("strideInPixelsY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNPoolingNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual nuint KernelHeight
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("kernelHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selKernelHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selKernelHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual nuint KernelWidth
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("kernelWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selKernelWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selKernelWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual nuint StrideInPixelsX
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("strideInPixelsX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStrideInPixelsXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStrideInPixelsXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual nuint StrideInPixelsY
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("strideInPixelsY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStrideInPixelsYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStrideInPixelsYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnPoolingNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnPoolingNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnPoolingNode(MPSNNImageNode sourceNode, nuint kernelWidth, nuint kernelHeight, nuint strideInPixelsX, nuint strideInPixelsY)
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
	public MPSCnnPoolingNode(MPSNNImageNode sourceNode, nuint size, nuint stride)
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
	public MPSCnnPoolingNode(MPSNNImageNode sourceNode, nuint size)
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

	[Export("nodeWithSource:filterSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnPoolingNode Create(MPSNNImageNode sourceNode, nuint size)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSCnnPoolingNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selNodeWithSource_FilterSize_Handle, sourceNode.Handle, size));
	}

	[Export("nodeWithSource:filterSize:stride:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnPoolingNode Create(MPSNNImageNode sourceNode, nuint size, nuint stride)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSCnnPoolingNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint(class_ptr, selNodeWithSource_FilterSize_Stride_Handle, sourceNode.Handle, size, stride));
	}
}
