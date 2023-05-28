using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNDilatedPoolingMaxNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnDilatedPoolingMaxNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateX = "dilationRateX";

	private static readonly IntPtr selDilationRateXHandle = Selector.GetHandle("dilationRateX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateY = "dilationRateY";

	private static readonly IntPtr selDilationRateYHandle = Selector.GetHandle("dilationRateY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_FilterSize_ = "initWithSource:filterSize:";

	private static readonly IntPtr selInitWithSource_FilterSize_Handle = Selector.GetHandle("initWithSource:filterSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_FilterSize_Stride_DilationRate_ = "initWithSource:filterSize:stride:dilationRate:";

	private static readonly IntPtr selInitWithSource_FilterSize_Stride_DilationRate_Handle = Selector.GetHandle("initWithSource:filterSize:stride:dilationRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_DilationRateX_DilationRateY_ = "initWithSource:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:";

	private static readonly IntPtr selInitWithSource_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_DilationRateX_DilationRateY_Handle = Selector.GetHandle("initWithSource:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_FilterSize_ = "nodeWithSource:filterSize:";

	private static readonly IntPtr selNodeWithSource_FilterSize_Handle = Selector.GetHandle("nodeWithSource:filterSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_FilterSize_Stride_DilationRate_ = "nodeWithSource:filterSize:stride:dilationRate:";

	private static readonly IntPtr selNodeWithSource_FilterSize_Stride_DilationRate_Handle = Selector.GetHandle("nodeWithSource:filterSize:stride:dilationRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNDilatedPoolingMaxNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DilationRateX
	{
		[Export("dilationRateX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDilationRateXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDilationRateXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DilationRateY
	{
		[Export("dilationRateY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDilationRateYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDilationRateYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnDilatedPoolingMaxNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnDilatedPoolingMaxNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDilatedPoolingMaxNode(MPSNNImageNode sourceNode, nuint kernelWidth, nuint kernelHeight, nuint strideInPixelsX, nuint strideInPixelsY, nuint dilationRateX, nuint dilationRateY)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_nuint_nuint_nuint_nuint(base.Handle, selInitWithSource_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_DilationRateX_DilationRateY_Handle, sourceNode.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY, dilationRateX, dilationRateY), "initWithSource:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_nuint_nuint_nuint_nuint(base.SuperHandle, selInitWithSource_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_DilationRateX_DilationRateY_Handle, sourceNode.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY, dilationRateX, dilationRateY), "initWithSource:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:");
		}
	}

	[Export("initWithSource:filterSize:stride:dilationRate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDilatedPoolingMaxNode(MPSNNImageNode sourceNode, nuint size, nuint stride, nuint dilationRate)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_nuint(base.Handle, selInitWithSource_FilterSize_Stride_DilationRate_Handle, sourceNode.Handle, size, stride, dilationRate), "initWithSource:filterSize:stride:dilationRate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_nuint(base.SuperHandle, selInitWithSource_FilterSize_Stride_DilationRate_Handle, sourceNode.Handle, size, stride, dilationRate), "initWithSource:filterSize:stride:dilationRate:");
		}
	}

	[Export("initWithSource:filterSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDilatedPoolingMaxNode(MPSNNImageNode sourceNode, nuint size)
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
	public static MPSCnnDilatedPoolingMaxNode Create(MPSNNImageNode sourceNode, nuint size)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSCnnDilatedPoolingMaxNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selNodeWithSource_FilterSize_Handle, sourceNode.Handle, size));
	}

	[Export("nodeWithSource:filterSize:stride:dilationRate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnDilatedPoolingMaxNode Create(MPSNNImageNode sourceNode, nuint size, nuint stride, nuint dilationRate)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSCnnDilatedPoolingMaxNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_nuint(class_ptr, selNodeWithSource_FilterSize_Stride_DilationRate_Handle, sourceNode.Handle, size, stride, dilationRate));
	}
}
