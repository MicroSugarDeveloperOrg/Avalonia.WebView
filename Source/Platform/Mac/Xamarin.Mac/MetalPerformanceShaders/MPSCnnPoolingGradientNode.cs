using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNPoolingGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnPoolingGradientNode : MPSNNGradientFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_ = "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelHeight = "kernelHeight";

	private static readonly IntPtr selKernelHeightHandle = Selector.GetHandle("kernelHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWidth = "kernelWidth";

	private static readonly IntPtr selKernelWidthHandle = Selector.GetHandle("kernelWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_ = "nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrideInPixelsX = "strideInPixelsX";

	private static readonly IntPtr selStrideInPixelsXHandle = Selector.GetHandle("strideInPixelsX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrideInPixelsY = "strideInPixelsY";

	private static readonly IntPtr selStrideInPixelsYHandle = Selector.GetHandle("strideInPixelsY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNPoolingGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint KernelHeight
	{
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
	public virtual nuint KernelWidth
	{
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
	public virtual nuint StrideInPixelsX
	{
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
	public virtual nuint StrideInPixelsY
	{
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
	protected MPSCnnPoolingGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnPoolingGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnPoolingGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelWidth, nuint kernelHeight, nuint strideInPixelsX, nuint strideInPixelsY, IMPSNNPadding? paddingPolicy)
		: base(NSObjectFlag.Empty)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_nuint_nuint_nuint_IntPtr(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY, paddingPolicy?.Handle ?? IntPtr.Zero), "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint_nuint_nuint_nuint_IntPtr(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY, paddingPolicy?.Handle ?? IntPtr.Zero), "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnPoolingGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelWidth, nuint kernelHeight, nuint strideInPixelsX, nuint strideInPixelsY, IMPSNNPadding? paddingPolicy)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		return Runtime.GetNSObject<MPSCnnPoolingGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_nuint_nuint_nuint_IntPtr(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY, paddingPolicy?.Handle ?? IntPtr.Zero));
	}
}
